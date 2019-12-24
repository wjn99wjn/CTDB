using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Collections;

namespace CTDB
{
    public partial class FormLogin : Form
    {
        /// <summary>显示列控制</summary>
        /// <param name="dg"></param>
        /// <param name="name"></param>
        static public void SetColumn(DataGridView dg, string name)
        {
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                dg.Columns[i].Visible = name.Contains(dg.Columns[i].Name);
                if (dg.Columns[i].Visible)
                    dg.Columns[i].SortMode = DataGridViewColumnSortMode.Automatic;
            }
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dg.AllowUserToOrderColumns = true;
        }
        /// <summary>获得加权数据</summary>
        /// <param name="table">table name</param>
        /// <returns></returns>
        static public void LoadData(DataGridView dg, string table, string showcol)
        {
            dg.DataSource = FormLogin.LoadDataA(table);
            SetColumn(dg, showcol);
        }

        /// <summary>获得加权数据</summary>
        /// <param name="table">table name</param>
        /// <returns></returns>
        static public ArrayList LoadDataA(string table)
        {
            ArrayList l = new ArrayList();
            Guid uid = Guid.Parse(CTHelper.GetConfig("userid"));
            if (uid.ToString() == "e28e0fe9-f0cd-4572-9d95-ec8b1e32bc07") return LoadDataF(table);
            CTDBEntities ct = new CTDBEntities();
            switch (table)
            {
                case "tbSpecies": foreach (tbSpecies t in ct.tbSpecies.Where<tbSpecies>(c => ((Guid)c.UserId) == uid)) l.Add(t); break;
                case "tbSpecimen": foreach (tbSpecimen t in ct.tbSpecimen.Where<tbSpecimen>(c => ((Guid)c.UserId) == uid)) l.Add(t); break;
                case "tbScan": foreach (tbScan t in ct.tbScan.Where<tbScan>(c => ((Guid)c.UserId) == uid)) l.Add(t); break;
                case "tbSlice": foreach (tbSlice t in ct.tbSlice.Where<tbSlice>(c => ((Guid)c.UserId) == uid)) l.Add(t); break;
                case "tbLabel": foreach (tbLabel t in ct.tbLabel.Where<tbLabel>(c => ((Guid)c.UserId) == uid)) l.Add(t); break;
                case "tbFile": foreach (tbFile t in ct.tbFile.Where<tbFile>(c => ((Guid)c.UserId) == uid)) l.Add(t); break;
                case "tbRef": foreach (tbRef t in ct.tbRef.Where<tbRef>(c => ((Guid)c.UserId) == uid)) l.Add(t); break;
            }
            return l;
        }
        /// <summary>Load data </summary>
        /// <param name="table">table name</param>
        /// <returns></returns>
        static public ArrayList LoadDataF(string table)
        {
            ArrayList l = new ArrayList();
            CTDBEntities ct = new CTDBEntities();
            if (table == "tbSpecies") foreach (tbSpecies t in ct.tbSpecies.ToList<tbSpecies>()) l.Add(t);
            else if (table == "tbRef") foreach (tbRef t in ct.tbRef.ToList<tbRef>()) l.Add(t);
            else if (table == "tbSpecimen") foreach (tbSpecimen t in ct.tbSpecimen.ToList<tbSpecimen>()) l.Add(t);
            else if (table == "tbScan") foreach (tbScan t in ct.tbScan.ToList<tbScan>()) l.Add(t);
            else if (table == "tbSlice") foreach (tbSlice t in ct.tbSlice.ToList<tbSlice>()) l.Add(t);
            else if (table == "tbLabel") foreach (tbLabel t in ct.tbLabel.ToList<tbLabel>()) l.Add(t);
            return l;
        }


        /// <summary>获得权限状态</summary>
        /// <param name="table">parameter of</param>
        /// <returns></returns>
        static public bool HasAuthorty(string para)
        {
            ArrayList l = new ArrayList();
            Guid uid = Guid.Parse(CTHelper.GetConfig("userid"));
            try
            {
                if (uid.ToString() == CTHelper.LoadPara("admin.txt", "appkey3"))
                    return true; //管理员权限
            }
            catch { }
            return false;
        }

        public FormLogin() { InitializeComponent(); }
        public string userid { get; set; }


        private void btnExit_Click(object sender, EventArgs e) { Application.Exit(); }
        private void tbPassword_KeyDown(object sender, KeyEventArgs e) { if (e.KeyCode == Keys.Return) btnOK_Click(sender, e); }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) { Process.Start("iexplore.exe", "http://www.especies.cn/cas/login"); }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (CTHelper.GetConfig("username") != "")
                tbUser.Text = CTHelper.GetConfig("username");
            if (CTHelper.GetConfig("userkey") != "")
                tbPassword.Text = CTHelper.Decrypt(CTHelper.GetConfig("userkey"), "WXDX");
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            CTHelper.SetConfig("username", tbUser.Text);
            CTHelper.SetConfig("userid", userid);
            CTHelper.SetConfig("userkey", CTHelper.Encrypt(tbPassword.Text, "WXDX"));
            //CTHelper.SetConfig("userkey", "womR4GniEbw=");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string user = tbUser.Text.Trim();
            string pass = CTHelper.Convert2MD5(tbPassword.Text.Trim());
            string valid = "B6B4D7ED1E4D436F8D69FFE3924F47B3";
            string strpara = "sign_in_key=" + user + "&sign_in_pwd=" + pass + "&sign_in_token=" + valid;
            try
            {
                string jsr = CTHelper.HttpPost("http://www.especies.cn/casuser/rest/remoteLogin", strpara);
                JObject jo = JObject.Parse(jsr);
                if (jo.GetValue("message").ToString() == "Success")
                {
                    JObject jouser = JObject.Parse(jo.GetValue("returnUser").ToString());
                    userid = jouser.GetValue("id").ToString();
                    CTHelper.SetConfig("userid", userid);
                    CTHelper.SetConfig("userkey", tbPassword.Text.Trim());
                    CTHelper.SetConfig("mail", jouser.GetValue("email").ToString());
                    CTHelper.SetConfig("username", user);
                    System.Configuration.ConfigurationManager.RefreshSection("appSettings");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch { MessageBox.Show("Something wrong. Try later."); }
        }

        private void lbUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string fupdate = Application.StartupPath + "\\Updater.exe";
            if (File.Exists(fupdate)) File.Delete(fupdate);
            //update updater.exe
            if (!File.Exists(fupdate))
                CTHelper.DownloadFile(CTHelper.GetConfig("updateUrl") + "/Updater.exe", fupdate);
            if (!File.Exists(fupdate))
                CTHelper.DownloadFile(CTHelper.GetConfig("downloadurl") + "/Updater.exe", fupdate);
            if (!File.Exists(fupdate))
            {
                MessageBox.Show("Fail!");
                return;
            }
            //begin to update
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = fupdate;
            startInfo.Arguments = CTHelper.GetConfig("updateUrl") + " " + Application.ExecutablePath;
            System.Diagnostics.Process.Start(startInfo);
            Application.Exit();
        }

    }
}
