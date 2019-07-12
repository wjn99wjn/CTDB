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

        //clear parameters when closing
        private void CTDBForm1_FormClosing(object sender, FormClosingEventArgs e) { CTHelper.UpdateConnectionString(Application.ProductName, conName, "", ""); }

        //load===============
        public CTDBForm1() { InitializeComponent(); }
        private void CTDBForm1_Load(object sender, EventArgs e)
        {
            connectionString = CTHelper.LoadTxt("efp.txt");
            connectionString = CTHelper.Decrypt(connectionString, CTHelper.GetConfig("appkey2"));

            CTHelper.UpdateConnectionString(Application.ProductName, conName, connectionString, providerName);
            lbHelpSpecimen.Text = Properties.Resources.help_ct_Specimen;
            lbHelpScan.Text = Properties.Resources.help_ct_Scan;
            lbHelpTag.Text = Properties.Resources.help_ct_Tag;
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
            Guid uid = Guid.Parse(CTHelper.GetConfig("userid"));
            dataGridView1.DataSource = null;
            CTDBEntities ct = new CTDBEntities();
            if (tabControl2.SelectedIndex == 0) //specimen
            {
                dataGridView1.DataSource = ct.tbSpecimen.Where<tbSpecimen>(c => c.UserId == uid).ToList<tbSpecimen>();
            }
            else if (tabControl2.SelectedIndex == 1) //scan
            {
                dataGridView1.DataSource = ct.tbScan.Where<tbScan>(c => c.UserId == uid).ToList<tbScan>();
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
                dt.Rows.Add(new object[] { "Equipment", ct.tbEquipment.Count<tbEquipment>(c => c.UserId == uid).ToString() });
                dt.Rows.Add(new object[] { "Tag", ct.tbTag.Count<tbTag>().ToString() });
                dt.Rows.Add(new object[] { "Species", ct.tbSpecies.Count<tbSpecies>(c => c.UserId == uid).ToString() });
                dt.Rows.Add(new object[] { "Specimen", ct.tbSpecimen.Count<tbSpecimen>(c => c.UserId == uid).ToString() });
                dt.Rows.Add(new object[] { "Scan", ct.tbScan.Count<tbScan>(c => c.UserId == uid).ToString() });
                dt.Rows.Add(new object[] { "Slice", ct.tbSlice.Count<tbSlice>(c => c.UserId == uid).ToString() });
                dt.Rows.Add(new object[] { "Label", ct.tbLabel.Count<tbLabel>(c => c.UserId == uid).ToString() });
                dt.Rows.Add(new object[] { "Files", ct.tbFile.Count<tbFile>(c => c.UserId == uid).ToString() });

                dataGridView1.DataSource = dt;
            }
        }

        private void btnMDEquipment_Click(object sender, EventArgs e) { showFormD(new FormEquipment()); }
        private void btnSpecimen_Click(object sender, EventArgs e) { showFormD(new FormSpecimen()); }
        private void btnMDTag_Click(object sender, EventArgs e) { showFormD(new FormTag()); }
        private void btnQuick1_Click(object sender, EventArgs e) { showFormD(new FormQuick()); }
        private void btnMDSpecies_Click(object sender, EventArgs e) { showFormD(new FormSpecies()); }
        private void btnMDSlice_Click(object sender, EventArgs e) { showFormD(new FormSlice()); }
        private void btnMDLabel_Click(object sender, EventArgs e) { showFormD(new FormLabel()); }
        private void btnMDRef_Click(object sender, EventArgs e) { showFormD(new FormRef()); }
        private void btnMDScan_Click(object sender, EventArgs e)
        {
            FormScan f = new FormScan();
            showFormD(f);
            if (f.AddSlice)
                btnMDSlice_Click(sender, e);
        }
        void showFormD(Form f)
        {
            this.Hide();
            f.ShowDialog();
            this.Show();
        }


    }
}
