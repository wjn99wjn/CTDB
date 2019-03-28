using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
namespace CTDB
{
    public partial class FormScan : Form
    {
        public FormScan() { InitializeComponent(); }
        private void CTDBFormScan_Load(object sender, EventArgs e) { refreshdata(sender, e); }
        private void btnOK_Click(object sender, EventArgs e) { this.Close(); }

        /// <summary>load/ refresh </summary>
        private void refreshdata(object sender, EventArgs e)
        {
            CTDBEntities ct = new CTDBEntities();

            cscEquipment.DataSource = ct.tbEquipment.ToList<tbEquipment>();
            cscEquipment.DisplayMember = "e_nameA";

            //cscSpecimen.DataSource = ct.tbSpecimen.ToList<tbSpecimen>();
            cscSpecimen.DataSource = FormLogin.LoadDataA("tbSpecimen");
            cscSpecimen.DisplayMember = "Abstract";

            cscRef.DataSource = FormLogin.LoadDataF("tbRef");
            cscRef.DisplayMember = "cite";
            cscRef.SelectedIndex = 3;


            ucFileInfo1.ParaTable = "ctdb-scan";

            //var q = from c in ct.tbTag where c.tag_pid == 10 select c;
            //cscTagSpecimenAlive.DataSource = q.ToList<tbTag>();
            //cscTagSpecimenAlive.ValueMember = "tag_id";
            //cscTagSpecimenAlive.DisplayMember = "tag_tag";
            CTHelper.setControlTag(cscTagSpecimenAlive, 10);
            CTHelper.setControlTag(cscTagSpecimenParty, 9);
            CTHelper.setControlTag(cscOpenStatus, 31, 30);
            CTHelper.setControlTag(cscFileType, 51, 52);
            CTHelper.setControlTag(cscSourceType, 76, 75);
            CTHelper.setControlTag(cscCamera, 77, 78);
            CTHelper.setControlTag(cscCameraBinning, 101, 107);//2x2
            CTHelper.setControlTag(cscLensMultiple, 105, 102);//0.4

            cscTimeBegin.Text = DateTime.Now.ToShortDateString();

            //ucFileInfo1.Enabled = false;

            //dataGridView1.DataSource = ct.tbScan.OrderByDescending(s => s.scan_id).ToList<tbScan>();
            //  dataGridView1.DataSource = FormLogin.LoadDataA("tbScan");
            FormLogin.LoadData(dataGridView1, "tbScan", "scan_id|e_id|sp_id|Abstract|scan_para_FilesNumber|UserId");
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                //int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                //lbNote.Text = id.ToString();
                int rid = dataGridView1.SelectedRows[0].Index;
                int id = ((dataGridView1.DataSource as ArrayList)[rid] as tbScan).scan_id;

                CTDBEntities ct = new CTDBEntities();
                var q = from c in ct.tbScan where c.scan_id == id select c;
                tbScan s = q.ToList<tbScan>()[0];
                cscID.Text = s.scan_id.ToString();

                cscOperator.Text = s.scan_operator;
                cscTimeBegin.Text = s.scan_timebegin.ToShortDateString();
                cscTimeEnd.Text = s.scan_timeend.ToString();
                CTHelper.setControl(cscSpecimen, s.sp_id);
                CTHelper.setControl(cscTagSpecimenAlive, s.scan_tag_SpecimenAlive);
                cscTagSpecimenParty.Text = s.scan_specimen_Body;
                s.scan_specimen_Body = cscTagSpecimenParty.Text;

                //cscNumberFile.Text = s.scan_para_FilesNumber.ToString();
                cscFileType.Text = s.scan_para_ImageFomat;
                //cscLensMultiple.Text = s.scan_para_ImagePixelSize.ToString();
                cscLensMultiple.Text = s.scan_para_LensMultiple.ToString();
                cscCameraBinning.Text = s.scan_para_CameraBinning;

                CTHelper.setControl(cscEquipment, s.e_id);
                cscSourceType.Text = s.scan_para_SourceType;
                cscCamera.Text = s.scan_para_Camera;
                cscSourceVoltage.Text = s.scan_para_SourceVoltage.ToString();
                cscSourceCurrent.Text = s.scan_para_SourceCurrent.ToString();

                cscCamera2Source.Text = s.scan_para_Camera2Source.ToString();
                cscObejct2Souce.Text = s.scan_para_Object2Source.ToString();
                cscVerticalObjectPosition.Text = s.scan_para_VerticalObjectPosition.ToString();
                cscPixelSize.Text = s.scan_para_PixelSize.ToString();
                cscRotationStep.Text = s.scan_para_RotationStep.ToString();
                cscExposure.Text = s.scan_para_Exposure.ToString();

                //cscScanSourceSavePath.Text = s.scan_source_save_path;
                cscSliceNo.Text = ct.tbSlice.Count<tbSlice>(c => c.scan_id == id).ToString();

                CTHelper.setControl(cscOpenStatus, s.open_status);
                ucFileInfo1.ParaDatasetID = s.scan_id;

                CTHelper.setControl(cscRef, s.ref_id);

                mitDelete.Enabled = dataGridView1.Rows.Count > 0;
            }
        }

        /// <summary>set values </summary>
        /// <param name="s"></param>
        void setDBValue(tbScan s)
        {
            s.scan_operator = cscOperator.Text;
            s.scan_timebegin = DateTime.Parse(cscTimeBegin.Text);
            s.scan_timeend = DateTime.Parse(cscTimeEnd.Text);
            s.sp_id = (cscSpecimen.SelectedItem as tbSpecimen).sp_id;

            s.scan_tag_SpecimenAlive = int.Parse(cscTagSpecimenAlive.SelectedValue.ToString());
            s.scan_specimen_Body = cscTagSpecimenParty.Text;

            s.scan_para_FilesNumber = ucFileInfo1.ValueFileCount;// int.Parse(cscNumberFile.Text);
            s.scan_para_ImageFomat = cscFileType.Text;
            s.scan_para_ImagePixelSize = 0.0;
            s.scan_para_LensMultiple = double.Parse(cscLensMultiple.Text);
            s.scan_para_CameraBinning = cscCameraBinning.Text;

            s.e_id = (cscEquipment.SelectedItem as tbEquipment).e_id;
            s.scan_para_SourceType = cscSourceType.Text;
            s.scan_para_Camera = cscCamera.Text;
            s.scan_para_SourceVoltage = double.Parse(cscSourceVoltage.Text);
            s.scan_para_SourceCurrent = double.Parse(cscSourceCurrent.Text);

            s.scan_para_Camera2Source = double.Parse(cscCamera2Source.Text);
            s.scan_para_Object2Source = double.Parse(cscObejct2Souce.Text);
            s.scan_para_VerticalObjectPosition = double.Parse(cscVerticalObjectPosition.Text);
            s.scan_para_PixelSize = double.Parse(cscPixelSize.Text);
            s.scan_para_RotationStep = double.Parse(cscRotationStep.Text);
            s.scan_para_Exposure = double.Parse(cscExposure.Text);

            s.Abstract = cscSpecimen.Text + "-" + cscTagSpecimenParty.Text;
            s.scan_source_save_path = "-";
            s.open_status = (cscOpenStatus.SelectedItem as tbTag).tag_id;
            s.date_in = DateTime.Now;
            s.ref_id = (cscRef.SelectedItem as tbRef).ref_id;

            s.UserId = Guid.Parse(CTHelper.GetConfig("userid"));

        }

        //scan
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var s = new tbScan();
            setDBValue(s);
            using (CTDBEntities ct = new CTDBEntities())
            {
                ct.tbScan.Add(s);
                ct.SaveChanges();   //将修改保存到数据库中
            }

            //refreshDatagridview(dataGridView1.Rows.Count.ToString());
            int rowid = dataGridView1.Rows.Count;
            refreshdata(null, null);
            dataGridView1.Rows[rowid].Selected = true;
            //return;


            //级联添加一个slice
            using (CTDBEntities ct = new CTDBEntities())
            {
                tbSlice sl = new tbSlice();
                sl.scan_id = int.Parse(cscID.Text);
                sl.slice_para_ReconstructionProgram = "NRecon";
                sl.slice_para_ResultFileType = "BMP";
                sl.slice_para_SliceNumber = 0;
                sl.slice_para_PixelSize = 1.04;
                sl.open_status = 30;
                sl.UserId = Guid.Parse(CTHelper.GetConfig("userid"));
                sl.Abstract = cscSpecimen.Text + "-" + cscTagSpecimenParty.Text;
                ct.tbSlice.Add(sl);
                ct.SaveChanges();   //将修改保存到数据库中
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(cscID.Text);
            using (var ct = new CTDBEntities())
            {
                var s = ct.tbScan.FirstOrDefault(st => st.scan_id == id);
                setDBValue(s);
                ct.SaveChanges();
                refreshdata(null, null);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(cscID.Text);
            if (MessageBox.Show("确认删除" + id.ToString(), "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    using (var db = new CTDBEntities())
                    {
                        var student = db.tbScan.FirstOrDefault(s => s.scan_id == id);
                        db.tbScan.Remove(student);    //删除萝莉
                        db.SaveChanges();
                    }
                }
                catch { MessageBox.Show("删除失败，可能有关联数据"); }
            refreshdata(null, null);
        }

        //update view 更新视图，并选定某行
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
        //添加设备
        private void btnAddEuipment_Click(object sender, EventArgs e)
        {
            FormEquipment dlg = new FormEquipment();
            dlg.ShowDialog();
            CTDBEntities ct = new CTDBEntities();
            cscEquipment.DataSource = ct.tbEquipment.ToList<tbEquipment>();
            cscEquipment.DisplayMember = "e_nameA";
            cscEquipment.SelectedIndex = cscEquipment.Items.Count - 1;
        }
        //添加标本
        private void btnAddSpecimen_Click(object sender, EventArgs e)
        {
            FormSpecimen dlg = new FormSpecimen();
            dlg.ShowDialog();
            CTDBEntities ct = new CTDBEntities();

            cscSpecimen.DataSource = ct.tbSpecimen.ToList<tbSpecimen>();
            cscSpecimen.DisplayMember = "Abstract";
            cscSpecimen.SelectedIndex = cscSpecimen.Items.Count - 1;
        }

        //添加相关文件
        private void addFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0) return;
            // btnScanFileAdd_Click(sender, e);
            ucFileInfo1.btnFileAdd_Click(sender, e);
        }

        private void ucFileInfo1_UpdateFile(object sender, EventArgs e)
        {
            this.Show();
            int id = int.Parse(cscID.Text);
            using (CTDBEntities ct = new CTDBEntities())
            {
                //更新文件数量
                var s = ct.tbScan.FirstOrDefault(st => st.scan_id == id);
                s.scan_para_FilesNumber = ucFileInfo1.ValueFileCount;// q.Count<tbFile>();
                ct.SaveChanges();
            }
            refreshDatagridview(id.ToString());
        }
        private void ucFileInfo1_OpenFileDialog(object sender, EventArgs e) { this.Hide(); }

        private void btnOCR_Click(object sender, EventArgs e)
        {
            return;
            if (!int.TryParse(cscID.Text, out int id)) return;
            OpenFileDialog d = new OpenFileDialog();
            d.Title = "挑选参数图";
            d.Filter = "Photos (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp";
            if (d.ShowDialog() == DialogResult.OK)
            {
                string md5 = CTHelper.GetMD5Hash(d.FileName);
                string f = CTHelper.CommonPath("app") + "\\" + md5 + ".pdf";
                File.Copy(d.FileName, f);
                string r = CTHelper.UploadAPI(f, id.ToString(), "upload", "ctdb-scanpara", "iozct", CTHelper.GetConfig("userid"));
                Console.Write(r);
                if (File.Exists(f)) File.Delete(f);

                if (r == "")
                {
                    //update tFile 表

                }
            }
        }




    }
}
