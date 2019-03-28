using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CTDB
{
    public partial class ucFileInfo : UserControl
    {

        public ucFileInfo() { InitializeComponent(); }

        public int ValueFileCount { get { return int.Parse(lbCount.Text); } }
        private int dsid = 0;
        public int ParaDatasetID
        {
            get { return dsid; }
            set
            {
                dsid = value;
                if (dsid != 0)
                    refrash();
            }
        }
        private string ptable = "";
        public string ParaTable
        {
            get { return ptable; }
            set
            {
                ptable = value;
                if (ptable != "")
                    loadTable();
            }
        }
        public int ParaFileType
        {
            get { return (cbFileType.SelectedItem as tbTag).tag_id; }
            set { CTHelper.setControlTag(cbFileType, 14, value); }
        }

        public event EventHandler UpdateFile;
        public event EventHandler OpenFileDialog;
        public event EventHandler CloseFileDialog;
        //public event EventHandler AddFile;

        void refrash()
        {
            using (CTDBEntities ct = new CTDBEntities())
            {
                lbCount.Text = ct.tbFile.Where(c =>
                c.f_filetype == ParaFileType
                && c.f_pid == this.ParaDatasetID
                && c.f_table == this.ParaTable).Count<tbFile>().ToString();

                lbCountAll.Text = ct.tbFile.Where(c =>
                c.f_table == this.ParaTable
                && c.f_pid == this.ParaDatasetID
                ).Count<tbFile>().ToString();
            }
        }
        void loadTable()
        {
            if (ptable == "ctdb-specimen")
                CTHelper.setControlTag(cbFileType, 14, 11);   // 14 filetype, 11 image
            else if (ptable == "ctdb-scan")
                CTHelper.setControlTag(cbFileType, 14, 93);   // 14 filetype, 11 image
            else if (ptable == "ctdb-slice")
                CTHelper.setControlTag(cbFileType, 14, 93);   // 14 filetype, 11 image
            else if (ptable == "ctdb-scanpara")
                CTHelper.setControlTag(cbFileType, 14, 11);   // 14 filetype, 11 image
            else if (ptable == "ctdb-label")
                CTHelper.setControlTag(cbFileType, 14, 100);   // 14 filetype, 11 image
        }

        private void ucFileInfo_Load(object sender, EventArgs e)
        {

        }

        public void btnFileAdd_Click(object sender, EventArgs e)
        {
            if (ParaDatasetID == 0) return;
            if (ParaTable == "") return;


            FormUpload dlg = new FormUpload();
            dlg.ParaDatasetID = ParaDatasetID;
            dlg.ParaTable = ParaTable;
            dlg.ParaFileType = (cbFileType.SelectedItem as tbTag).tag_id;


            if (OpenFileDialog != null) OpenFileDialog(sender, e);
            dlg.ShowDialog();


            //关闭后的处理
            refrash();
            //send up the message
            if (UpdateFile != null) UpdateFile(sender, e);

        }

        private void cbFileType_SelectedIndexChanged(object sender, EventArgs e)
        {
            refrash();
        }


    }
}
