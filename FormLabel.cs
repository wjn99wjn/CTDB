using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
namespace CTDB
{
    public partial class FormLabel : Form
    {
        public FormLabel() { InitializeComponent(); }
        private void FormLabel_Load(object sender, EventArgs e)
        {
            ucFileInfo1.ParaTable = "ctdb-label";
            ucFileInfo1.ParaFileType = 93;

            clbAuthor.Text = CTHelper.GetConfig("username");

            CTHelper.setControlTag(clbOpenStatus, 31, 30);
            CTHelper.setControlTag(clbMethod, 58, 59);
            CTHelper.setControlTag(clbStructure, 18, 23);

            refreshdata(sender, e);
        }
        private void btnOK_Click(object sender, EventArgs e) { this.Close(); }
        int sliceID = -1;
        public int SliceID
        {
            get { return sliceID; }
            set
            {
                sliceID = value;
                clbSilceID.Text = sliceID.ToString();
                CTDBEntities ct = new CTDBEntities();
                tbSlice tc = ct.tbSlice.Where<tbSlice>(c => (c.slice_id == sliceID)).First<tbSlice>();
                clbSilceID.Tag = tc;
                clbSliceInfo.Text = tc.Abstract;
            }
        }

        /// <returns></returns>
        private ArrayList LoadLabelByID()
        {
            ArrayList l = new ArrayList();
            CTDBEntities ct = new CTDBEntities();
            foreach (tbLabel t in ct.tbLabel.Where<tbLabel>(c => (c.slice_id == sliceID)))
                l.Add(t);
            return l;
        }

        /// <summary>load/ refresh </summary>
        private void refreshdata(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            mitDelete.Enabled = false;

            //if (sliceID != -1)
            //    CTHelper.setControl(clbSlice, sliceID);


            dataGridView1.DataSource = LoadLabelByID();
            //FormLogin.LoadData(dataGridView1, "tbLabel", "label_id|slice_id|label_structure|label_note|label_file_number|Abstract|UserId");
        }

        void setDBValue(tbLabel s)
        {
            s.slice_id = sliceID;
            s.scan_id = (clbSilceID.Tag as tbSlice).scan_id;
            s.sp_id = (clbSilceID.Tag as tbSlice).sp_id;

            s.label_author = clbAuthor.Text;
            s.label_file_type = "-";
            s.label_file_number = ucFileInfo1.ValueFileCount;
            s.label_structure = clbStructure.Text;
            s.label_method = clbMethod.Text;
            s.label_title = clbTitle.Text;

            s.label_note = clbNote.Text;
            s.open_status = int.Parse(clbOpenStatus.SelectedValue.ToString());
            s.date_in = DateTime.Now;
            s.UserId = Guid.Parse(CTHelper.GetConfig("userid"));

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var s = new tbLabel();
            setDBValue(s);
            CTDBEntities ct = new CTDBEntities();
            ct.tbLabel.Add(s);
            ct.SaveChanges();   //将修改保存到数据库中
            refreshdata(null, null);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(clbID.Text);
            using (var ct = new CTDBEntities())
            {
                var s = ct.tbLabel.FirstOrDefault(st => st.label_id == id);
                setDBValue(s);
                ct.SaveChanges();
                refreshdata(null, null);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(clbID.Text);
                if (MessageBox.Show("确认删除" + id.ToString(), "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    using (var db = new CTDBEntities())
                    {
                        var student = db.tbSlice.FirstOrDefault(s => s.slice_id == id);
                        db.tbSlice.Remove(student);    //删除萝莉
                        db.SaveChanges();
                        refreshdata(null, null);
                    }
            }
            catch
            {
                MessageBox.Show("记录有关联，删除失败");
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                // int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                int rid = dataGridView1.SelectedRows[0].Index;
                int id = ((dataGridView1.DataSource as ArrayList)[rid] as tbLabel).label_id;
                using (CTDBEntities ct = new CTDBEntities())
                {
                    tbLabel s = ct.tbLabel.Where<tbLabel>(c => c.label_id == id).Single();

                    clbID.Text = s.label_id.ToString();

                    // CTHelper.setControl(clbSlice, s.slice_id);

                    clbAuthor.Text = s.label_author;
                    //clbFileType.Text = s.label_file_type;
                    //clbNumberSlice.Text = s.label_file_number.ToString();
                    clbStructure.Text = s.label_structure;
                    clbMethod.Text = s.label_method;
                    clbTitle.Text = s.label_title;

                    CTHelper.setControl(clbOpenStatus, s.open_status);


                    ucFileInfo1.ParaDatasetID = s.label_id;
                    clbNote.Text = s.label_note;
                    mitDelete.Enabled = dataGridView1.Rows.Count > 0;
                }
            }
        }

        private void clbMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            clbAuthor.Enabled = true;
            if (clbMethod.SelectedItem != null)
                if ((clbMethod.SelectedItem as tbTag).tag_id == 59)
                    clbAuthor.Enabled = false;
            clbSlice_SelectedIndexChanged(sender, e);
        }
        private void clbSlice_SelectedIndexChanged(object sender, EventArgs e)
        {
            clbNote.Text = clbSliceInfo.Text + "\r\n" + clbStructure.Text + "\r\n" + clbMethod.Text;
        }


        //添加文件  //添加后的信息更新
        private void ucFileInfo1_OpenFileDialog(object sender, EventArgs e) { this.Hide(); }
        private void ucFileInfo1_UpdateFile(object sender, EventArgs e)
        {
            this.Show();
            using (CTDBEntities ct = new CTDBEntities())
            {
                //更新文件数量
                var s = ct.tbLabel.FirstOrDefault(st => st.label_id == ucFileInfo1.ParaDatasetID);
                if (s != null)
                {
                    s.label_file_number = ucFileInfo1.ValueFileCount;
                    ct.SaveChanges();
                }
            }
        }

        private void bsmAddBatch_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                string[] fds = Directory.GetDirectories(fd.SelectedPath);
                for (int i = 0; i < fds.Length; i++)
                {
                    clbNote.Text = fds[i];
                    fds[i] = fds[i].Replace(fd.SelectedPath + "\\", "");
                    clbTitle.Text = fds[i];

                    var s = new tbLabel();
                    setDBValue(s);
                    CTDBEntities ct = new CTDBEntities();
                    ct.tbLabel.Add(s);
                    ct.SaveChanges();   //将修改保存到数据库中

                }

                MessageBox.Show(fds.Length + " OK");
                refreshdata(sender, e);
            }
        }

        private void mitClearAll_Click(object sender, EventArgs e)
        {
            //int id = int.Parse(clbID.Text);
            ArrayList sl = dataGridView1.DataSource as ArrayList;
            if (sl.Count > 0)
                if (MessageBox.Show("确认删除" + sl.Count + " records?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    using (var db = new CTDBEntities())
                    {
                        foreach (tbLabel ts in sl)
                        {
                            try
                            {
                                //MessageBox.Show(ts.label_id.ToString());
                                var student = db.tbLabel.FirstOrDefault(s => s.label_id == ts.label_id);
                                db.tbLabel.Remove(student);    //删除萝莉
                                db.SaveChanges();
                            }
                            catch
                            {
                                MessageBox.Show("记录有关联，删除失败");
                            }
                        }
                        refreshdata(null, null);
                    }
        }




        //author: walker
        //date: 2014-01-06
        //function: 
        /// <summary>将dataGridView导出到csv </summary>
        /// <param name="dataGridView"></param>
        /// <returns></returns>
        public static bool dataGridViewToCSV(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("没有数据可导出!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.FileName = null;
            saveFileDialog.Title = "保存";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream stream = saveFileDialog.OpenFile();
                StreamWriter sw = new StreamWriter(stream, System.Text.Encoding.GetEncoding(-0));
                string strLine = "";
                try
                {
                    //表头
                    for (int i = 0; i < dataGridView.ColumnCount; i++)
                    {
                        if (i > 0)
                            strLine += ",";
                        strLine += dataGridView.Columns[i].HeaderText;
                    }
                    strLine.Remove(strLine.Length - 1);
                    sw.WriteLine(strLine);
                    strLine = "";
                    //表的内容
                    for (int j = 0; j < dataGridView.Rows.Count; j++)
                    {
                        strLine = "";
                        int colCount = dataGridView.Columns.Count;
                        for (int k = 0; k < colCount; k++)
                        {
                            if (k > 0 && k < colCount)
                                strLine += ",";
                            if (dataGridView.Rows[j].Cells[k].Value == null)
                                strLine += "";
                            else
                            {
                                string cell = dataGridView.Rows[j].Cells[k].Value.ToString().Trim();
                                //防止里面含有特殊符号
                                cell = cell.Replace("\"", "\"\"");
                                cell = "\"" + cell + "\"";
                                strLine += cell;
                            }
                        }
                        sw.WriteLine(strLine);
                    }
                    sw.Close();
                    stream.Close();
                    MessageBox.Show("数据被导出到：" + saveFileDialog.FileName.ToString(), "导出完毕", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "导出错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            return true;
        }

        private void exportTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewToCSV(dataGridView1);
        }
    }
}
