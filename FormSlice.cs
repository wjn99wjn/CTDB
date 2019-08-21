using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace CTDB
{
    public partial class FormSlice : Form
    {
        public FormSlice() { InitializeComponent(); }
        private void FormSlice_Load(object sender, EventArgs e)
        {
            ucFileInfo1.ParaTable = "ctdb-slice";
            refreshdata(sender, e);
        }
        private void btnOK_Click(object sender, EventArgs e) { this.Close(); }

        /// <summary>load/ refresh </summary>
        private void refreshdata(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            mitDelete.Enabled = false;

            CTDBEntities ct = new CTDBEntities();

            //clScan.DataSource = ct.tbScan.ToList<tbScan>();
            clScan.DataSource = FormLogin.LoadDataA("tbScan");
            clScan.DisplayMember = "Abstract";

            CTHelper.setControlTag(clOpenStatus, 31, 30);
            //CTHelper.setControlTag(clResultFileType, 51, 52);
            CTHelper.setControlTag(clCutMethod, 37, 35);

            //dataGridView1.DataSource = ct.tbSlice.ToList<tbSlice>();
            //dataGridView1.DataSource = FormLogin.LoadDataA("tbSlice");
            FormLogin.LoadData(dataGridView1, "tbSlice", "slice_id|scan_id|slice_para_PixelSize|slice_para_CutMethod|Abstract|date_in|open_status");


        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                //int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

                int rid = dataGridView1.SelectedRows[0].Index;
                int id = ((dataGridView1.DataSource as ArrayList)[rid] as tbSlice).slice_id;

                using (CTDBEntities ct = new CTDBEntities())
                {
                    tbSlice s = ct.tbSlice.Where<tbSlice>(c => c.slice_id == id).Single();
                    clID.Text = s.slice_id.ToString();

                    CTHelper.setControl(clScan, s.scan_id);

                    clReconstructionProgram.Text = s.slice_para_ReconstructionProgram;
                    // clResultFileType.Text = "";// s.slice_para_ResultFileType;
                    // clNumberSlice.Text = s.slice_para_SliceNumber.ToString();
                    clPixelSize.Text = s.slice_para_PixelSize.ToString();
                    CTHelper.setControl(clOpenStatus, s.open_status);

                    ucFileInfo1.ParaDatasetID = s.slice_id;
                    clLabelNo.Text = ct.tbLabel.Count<tbLabel>(c => c.slice_id == id).ToString();

                    mitDelete.Enabled = dataGridView1.Rows.Count > 0;
                }
            }
        }
        void setDBValue(tbSlice s)
        {
            s.scan_id = (clScan.SelectedValue as tbScan).scan_id;
            s.sp_id = (clScan.SelectedValue as tbScan).sp_id; //specimen_id

            s.slice_para_ReconstructionProgram = clReconstructionProgram.Text;
            s.slice_para_ResultFileType = "-";// clResultFileType.Text.Trim();
            s.slice_para_SliceNumber = ucFileInfo1.ValueFileCount;// int.Parse(clNumberSlice.Text);

            s.slice_para_PixelSize = double.Parse(clPixelSize.Text);



            if (clPixelSize.Text != "")
                s.slice_para_PixelSize = float.Parse(clPixelSize.Text);
            s.open_status = int.Parse(clOpenStatus.SelectedValue.ToString());
            s.slice_para_CutMethod = clCutMethod.Text;
            s.slice_save_path = "-";// clSavePath.Text;


            if (s.tbScan != null)
                s.Abstract = s.tbScan.Abstract;
            s.UserId = Guid.Parse(CTHelper.GetConfig("userid"));
            s.date_in = DateTime.Now;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var s = new tbSlice();
            setDBValue(s);
            CTDBEntities ct = new CTDBEntities();
            ct.tbSlice.Add(s);
            ct.SaveChanges();   //将修改保存到数据库中
            refreshdata(null, null);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(clID.Text);
            using (var ct = new CTDBEntities())
            {
                var s = ct.tbSlice.FirstOrDefault(st => st.slice_id == id);
                setDBValue(s);
                ct.SaveChanges();
                refreshdata(null, null);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(clID.Text);
                if (FormUpload.HasFiles("ctdb-slice", id))
                {
                    MessageBox.Show("Files related, can't delete!");
                    return;
                }
                if (CTHelper.AlertYes("Delete " + id.ToString() + "?"))
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
        private void btnSliceFileAdd_Click(object sender, EventArgs e)
        {
            FormUpload dlg = new FormUpload();
            int id = int.Parse(clID.Text);
            dlg.ParaDatasetID = id;
            dlg.ParaTable = "ctdb-slice";
            dlg.ParaFileType = 12;
            if (sender is ToolStripMenuItem)
                if ((sender as ToolStripMenuItem).Name == "cmitAddFileStack")
                    dlg.ParaFileType = 93;

            dlg.ShowDialog();

            using (CTDBEntities ct = new CTDBEntities())
            {
                var q = from c in ct.tbFile where c.f_pid == id && c.f_table == dlg.ParaTable select c;
                //  clNumberSlice.Text = q.Count<tbFile>().ToString();

                //更新文件数量
                var s = ct.tbSlice.FirstOrDefault(st => st.slice_id == id);
                s.slice_para_SliceNumber = q.Count<tbFile>();
                if (s.slice_para_SliceNumber > 0)
                {
                    tbFile t = q.ToList<tbFile>()[0];
                    // clResultFileType.Text = System.IO.Path.GetExtension(t.f_path);
                    // s.slice_para_ResultFileType = clResultFileType.Text;
                }
                ct.SaveChanges();
            }

            refreshDatagridview(id.ToString());
        }

        private void btnMDScan_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new FormScan()).ShowDialog();
            this.Show();
            CTDBEntities ct = new CTDBEntities();
            clScan.DataSource = ct.tbScan.ToList<tbScan>();
            clScan.DisplayMember = "Abstract";
        }

        private void cmitAddFileStack_Click(object sender, EventArgs e)
        {
            ucFileInfo1.ParaFileType = 93;
            ucFileInfo1.btnFileAdd_Click(sender, e);
        }

        private void cmitAddFile3D_Click(object sender, EventArgs e)
        {
            ucFileInfo1.ParaFileType = 13;
            ucFileInfo1.btnFileAdd_Click(sender, e);
        }

        private void ucFileInfo1_OpenFileDialog(object sender, EventArgs e) { this.Hide(); }
        private void ucFileInfo1_UpdateFile(object sender, EventArgs e) { this.Show(); }

        private void cmitExportMeta_Click(object sender, EventArgs e)
        {
            try
            {

                int id = int.Parse(clID.Text);
                //Hashtable ht = new Hashtable();
                List<Tuple<string, string>> ht = new List<Tuple<string, string>>();
                CTDBEntities ct = new CTDBEntities();


                tbSlice slice = ct.tbSlice.FirstOrDefault(s => s.slice_id == id);
                ht.Add(new Tuple<string, string>("Slice ID", slice.sp_id.ToString()));
                ht.Add(new Tuple<string, string>("Slice Number", slice.slice_para_SliceNumber.ToString()));
                ht.Add(new Tuple<string, string>("Slice File Type", slice.slice_para_ResultFileType.ToString()));
                ht.Add(new Tuple<string, string>("Slice Resolution", slice.slice_para_PixelSize.ToString()));

                tbScan scan = ct.tbScan.FirstOrDefault(s => s.scan_id == slice.scan_id);
                ht.Add(new Tuple<string, string>("ScanPara Volta", scan.scan_para_SourceVoltage.ToString()));
                ht.Add(new Tuple<string, string>("ScanPara Bunning", scan.scan_para_CameraBinning.ToString()));
                ht.Add(new Tuple<string, string>("ScanPara Lens Multiply", scan.scan_para_LensMultiple.ToString()));
                ht.Add(new Tuple<string, string>("ScanPara Time", scan.scan_timebegin.ToString("yyyy-MM-dd")));
                ht.Add(new Tuple<string, string>("ScanPara Operator", scan.scan_operator));
                ht.Add(new Tuple<string, string>("ScanPara Part", scan.scan_specimen_Body));

                tbEquipment equip = ct.tbEquipment.FirstOrDefault(s => s.e_id == scan.e_id);
                ht.Add(new Tuple<string, string>("ScanPara Equipment", equip.e_name));

                tbSpecimen sp = ct.tbSpecimen.FirstOrDefault(s => s.sp_id == slice.sp_id);
                ht.Add(new Tuple<string, string>("Specimen ID", sp.sp_spid));
                ht.Add(new Tuple<string, string>("Specimen Collector", sp.sp_collector));
                ht.Add(new Tuple<string, string>("Specimen Collect Time", sp.sp_collect_time));
                ht.Add(new Tuple<string, string>("Specimen Collect Place", sp.sp_collect_place));


                tbSpecies species = ct.tbSpecies.FirstOrDefault(s => s.species_id == sp.species_id);
                ht.Add(new Tuple<string, string>("Specie Name", species.species_latin));
                ht.Add(new Tuple<string, string>("Specie Genus", species.species_Genus));
                ht.Add(new Tuple<string, string>("Specie Family", species.species_Family));


                string f = Application.StartupPath + "\\meta.txt";
                if (File.Exists(f)) File.Delete(f);
                //foreach (System.Collections.DictionaryEntry item in ht)
                foreach (Tuple<string, string> item in ht)
                {
                    string s = item.Item1 + "\t:\t" + item.Item2;
                    CTHelper.AddLog(s, f);
                }

                System.Diagnostics.Process.Start(f);
            }
            catch
            {
                MessageBox.Show("记录有关联，删除失败");
            }
        }




    }
}
