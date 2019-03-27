using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CTDB
{
    public partial class FormLabel : Form
    {
        public FormLabel() { InitializeComponent(); }
        private void FormLabel_Load(object sender, EventArgs e)
        {
            ucFileInfo1.ParaTable = "ctdb-label";
            ucFileInfo1.ParaFileType = 93;

            refreshdata(sender, e);
            clbAuthor.Text = CTHelper.GetConfig("username");
        }
        private void btnOK_Click(object sender, EventArgs e) { this.Close(); }

        /// <summary>load/ refresh </summary>
        private void refreshdata(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            mitDelete.Enabled = false;


            CTDBEntities ct = new CTDBEntities();
            // dataGridView1.DataSource = ct.tbLabel.ToList<tbLabel>();

            //clbSlice.DataSource = ct.tbSlice.ToList<tbSlice>();
            //clbSlice.DisplayMember = "Abstract";
            clbSlice.DataSource = FormLogin.LoadDataA("tbSlice");
            clbSlice.DisplayMember = "Abstract";

            CTHelper.setControlTag(clbOpenStatus, 31, 30);
            CTHelper.setControlTag(clbMethod, 58, 59);
            CTHelper.setControlTag(clbStructure, 18, 23);


            FormLogin.LoadData(dataGridView1, "tbLabel", "label_id|slice_id|label_structure|label_note|label_file_number|Abstract|UserId");
        }
        void refreshDatagridview(string id)
        {
            refreshdata(null, null);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == id)
                {
                    dataGridView1.Rows[i].Selected = true;
                    break;
                }
        }

        void setDBValue(tbLabel s)
        {
            s.slice_id = (clbSlice.SelectedItem as tbSlice).slice_id;
            s.scan_id = (clbSlice.SelectedItem as tbSlice).scan_id;
            s.sp_id = (clbSlice.SelectedItem as tbSlice).sp_id;

            s.label_author = clbAuthor.Text;
            s.label_file_type = "-";
            s.label_file_number = ucFileInfo1.ValueFileCount;
            s.label_structure = clbStructure.Text;
            s.label_method = clbMethod.Text;

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

                    CTHelper.setControl(clbSlice, s.slice_id);

                    clbAuthor.Text = s.label_author;
                    //clbFileType.Text = s.label_file_type;
                    //clbNumberSlice.Text = s.label_file_number.ToString();
                    clbStructure.Text = s.label_structure;
                    clbMethod.Text = s.label_method;

                    CTHelper.setControl(clbOpenStatus, s.open_status);


                    ucFileInfo1.ParaDatasetID = s.label_id;
                    clbNote.Text = s.label_note;
                    mitDelete.Enabled = dataGridView1.Rows.Count > 0;
                }
            }
        }


        private void clbSlice_SelectedIndexChanged(object sender, EventArgs e)
        {
            clbNote.Text = clbSlice.Text + ":" + clbStructure.Text + ":" + clbMethod.Text;
        }

        private void ucFileInfo1_UpdateFile(object sender, EventArgs e)
        {
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


    }
}
