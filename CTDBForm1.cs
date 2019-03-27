using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace CTDB
{
    /// <summary> CT 数据库管理客户端 </summary>
    public partial class CTDBForm1 : Form
    {
        string conName = "CTDBEntities";
        string providerName = "System.Data.EntityClient";
        string connectionString = "";

        //更新视图，并选定某行
        void refreshDatagridview(string id)
        {
            tabControl2_SelectedIndexChanged(null, null);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == id)
                {
                    dataGridView1.Rows[i].Selected = true;
                    break;
                }
        }
        //clear parameters when closing
        private void CTDBForm1_FormClosing(object sender, FormClosingEventArgs e) { CTHelper.UpdateConnectionString(Application.ProductName, conName, "", ""); }

        //load===============
        public CTDBForm1() { InitializeComponent(); }
        private void CTDBForm1_Load(object sender, EventArgs e)
        {
            connectionString = CTHelper.LoadTxt("efp.txt");
            connectionString = CTHelper.Decrypt(connectionString, CTHelper.GetConfig("appkey2"));

            CTHelper.UpdateConnectionString(Application.ProductName, conName, connectionString, providerName);
            lbHelp.Text = Properties.Resources.help_ct;
            tabControl2.SelectedIndex = 3;//help
            updateUserInfo();


        }
        /// <summary>record user information if the user first login, else update </summary>
        void updateUserInfo()
        {
            Guid uid = Guid.Parse(CTHelper.GetConfig("userid"));
            string username = CTHelper.GetConfig("username");
            string mail = CTHelper.GetConfig("mail");
            CTDBEntities ct = new CTDBEntities();
            tbUser tu = null;
            try { tu = ct.tbUser.Where(c => c.UserId == uid).Single(); }
            catch (Exception ex) { Console.Write(ex.ToString()); }
            if (tu == null)
            {
                tu = ct.tbUser.Create();
                tu.UserId = uid;
                tu.date_in = DateTime.Now;
                ct.tbUser.Add(tu);
            }
            tu.UserName = username;
            tu.mail = mail;
            tu.date_up = DateTime.Now;
            ct.SaveChanges();
            this.Text = "Insect 3D Database Clicent -- " + username;
            btnMDTag.Enabled = FormLogin.HasAuthorty("");
        }

        //gridview=====load when select Table
        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            CTDBEntities ct = new CTDBEntities();
            if (tabControl2.SelectedIndex == 0) //scan
            {
                dataGridView1.DataSource = ct.tbScan.ToList<tbScan>();

                cscEquipment.DataSource = ct.tbEquipment.ToList<tbEquipment>();
                cscEquipment.ValueMember = "e_id";
                cscEquipment.DisplayMember = "e_nameA";

                cscSpecimen.DataSource = ct.tbSpecimen.ToList<tbSpecimen>();
                cscSpecimen.DisplayMember = "Abstract";

                CTHelper.setControlTag(cscTagSpecimenAlive, 10);
                CTHelper.setControlTag(cscTagSpecimenParty, 9);
                CTHelper.setControlTag(cscOpenStatus, 31, 30);
            }
            else if (tabControl2.SelectedIndex == 1) //slice
            {
                dataGridView1.DataSource = ct.tbSlice.ToList<tbSlice>();
            }
            else if (tabControl2.SelectedIndex == 2) //tag
            {
                dataGridView1.DataSource = ct.tbTag.ToList<tbTag>();
            }
            else if (tabControl2.SelectedIndex == 3) //help
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Table Name");
                dt.Columns.Add("Records");
                dt.Rows.Add(new object[] { "Equipment", ct.tbEquipment.Count<tbEquipment>().ToString() });
                dt.Rows.Add(new object[] { "Tag", ct.tbTag.Count<tbTag>().ToString() });
                dt.Rows.Add(new object[] { "Species", ct.tbSpecies.Count<tbSpecies>().ToString() });
                dt.Rows.Add(new object[] { "Specimen", ct.tbSpecimen.Count<tbSpecimen>().ToString() });
                dt.Rows.Add(new object[] { "Scan", ct.tbScan.Count<tbScan>().ToString() });
                dt.Rows.Add(new object[] { "Slice", ct.tbSlice.Count<tbSlice>().ToString() });
                dt.Rows.Add(new object[] { "Label", ct.tbLabel.Count<tbLabel>().ToString() });
                dt.Rows.Add(new object[] { "Files", ct.tbFile.Count<tbFile>().ToString() });

                dataGridView1.DataSource = dt;
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (tabControl2.SelectedIndex == 0) //scan
                {
                    int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                    lbNote.Text = id.ToString();

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

                    cscNumberFile.Text = s.scan_para_FilesNumber.ToString();
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
                    cscRotationStep.Text = s.scan_para_RotationStep.ToString();
                    cscExposure.Text = s.scan_para_Exposure.ToString();

                    CTHelper.setControl(cscOpenStatus, s.open_status);

                }
                else if (tabControl2.SelectedIndex == 1) //slice
                {
                }
                else if (tabControl2.SelectedIndex == 2) //tag
                {
                    //CTDBEntities ct = new CTDBEntities();
                    //var q = from c in ct.tbSpecimen where c.sp_id == id select c;
                }
            }
        }

        //scan========
        private void bScanDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(cscID.Text);
            //if (MessageBox.Show("确认删除" + id.ToString(), "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            if (CTHelper.AlertYes("确认删除" + id.ToString()))
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
            tabControl2_SelectedIndexChanged(null, null);
        }
        private void btnAddEuipment_Click(object sender, EventArgs e)
        {
            FormEquipment dlg = new FormEquipment();
            dlg.ShowDialog();
            CTDBEntities ct = new CTDBEntities();
            cscEquipment.DataSource = ct.tbEquipment.ToList<tbEquipment>();
            cscEquipment.DisplayMember = "e_nameA";
            cscEquipment.SelectedIndex = cscEquipment.Items.Count - 1;
        }
        private void btnAddSpecimen_Click(object sender, EventArgs e)
        {
            FormSpecimen dlg = new FormSpecimen();
            dlg.ShowDialog();
            CTDBEntities ct = new CTDBEntities();

            cscSpecimen.DataSource = ct.tbSpecimen.ToList<tbSpecimen>();
            cscSpecimen.DisplayMember = "Abstract";
            cscSpecimen.SelectedIndex = cscSpecimen.Items.Count - 1;
        }

        //help=====
        private void label62_DoubleClick(object sender, EventArgs e) { new About((string)((sender as Label).Tag)).ShowDialog(); }


        private void btnOCR_Click(object sender, EventArgs e)
        {

        }

        private void btnMDEquipment_Click(object sender, EventArgs e) { showFormD(new FormEquipment()); }
        private void btnSpecimen_Click(object sender, EventArgs e) { showFormD(new FormSpecimen()); }
        private void btnMDTag_Click(object sender, EventArgs e) { showFormD(new FormTag()); }
        private void btnQuick1_Click(object sender, EventArgs e) { showFormD(new FormQuick()); }
        private void btnMDSpecies_Click(object sender, EventArgs e) { showFormD(new FormSpecies()); }
        private void btnMDScan_Click(object sender, EventArgs e) { showFormD(new FormScan()); }
        private void btnMDSlice_Click(object sender, EventArgs e) { showFormD(new FormSlice()); }
        private void btnMDLabel_Click(object sender, EventArgs e) { showFormD(new FormLabel()); }
        private void btnMDRef_Click(object sender, EventArgs e) { showFormD(new FormRef()); }
        void showFormD(Form f)
        {
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

    }
}
