using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CTDB
{
    public partial class FormUpload : Form
    {
        //添加相关文件
        public static void btnScanFileAdd_Click(object sender, EventArgs e, int id, string tablename, int fileypeid = 11)
        {
            FormUpload dlg = new FormUpload();
            dlg.ParaDatasetID = id;
            dlg.ParaTable = tablename;
            dlg.ParaFileType = fileypeid;
            dlg.ShowDialog();

            //using (CTDBEntities ct = new CTDBEntities())
            //{
            //    var q = from c in ct.tbFile where c.f_pid == id && c.f_table == dlg.ParaTable select c;
            //    cscNumberFile.Text = q.Count<tbFile>().ToString();
            //    //bScanUpdate_Click(sender, e);
            //    //更新文件数量
            //    var s = ct.tbScan.FirstOrDefault(st => st.scan_id == id);
            //    s.scan_para_FilesNumber = q.Count<tbFile>();
            //    ct.SaveChanges();
            //}
            // refreshDatagridview(id.ToString());
        }


        public FormUpload() { InitializeComponent(); }
        private void btnOK_Click(object sender, EventArgs e) { this.Close(); }

        /// <summary> which table File belones to </summary>
        public string ParaTable { get; set; }
        /// <summary> record id </summary>
        public int ParaDatasetID { get; set; }
        /// <summary> which table File belones to </summary>
        public int ParaFileType { get; set; }
        string UserID = "2927A6EC-CA2B-406F-9031-F905F80AE624";

        /// <summary> which table File belones to </summary>
        public int LastUploadFileNumber { get { return lboxFile.Items.Count; } }
        public int DatabaseFileNumber { get { return lboxDB.Items.Count; } }



        private void FormUpload_Load(object sender, EventArgs e)
        {
            lbDataset.Text = ParaDatasetID.ToString();
            UserID = CTHelper.GetConfig("userid");

            CTDBEntities ct = new CTDBEntities();

            if (ParaTable == "ctdb-slice")
            {
                this.Text = "CTDB - Slice File";
                lbTableName.Text = "SliceID";
                tbSlice s = ct.tbSlice.Where(c => c.slice_id == ParaDatasetID).Single();
                lbDSName.Text = s.Abstract;
                lbSpecimenID.Text = s.tbScan.tbSpecimen.sp_id.ToString();
                mitCreatedFromSlice.Visible = true;
            }
            else if (ParaTable == "ctdb-scan")
            {
                this.Text = "CTDB - Scan Source File";
                lbTableName.Text = "ScanID";
                tbScan s = ct.tbScan.Where(c => c.scan_id == ParaDatasetID).Single();
                lbDSName.Text = s.Abstract;
                lbSpecimenID.Text = s.tbSpecimen.sp_id.ToString();
            }
            else if (ParaTable == "ctdb-label")
            {
                this.Text = "CTDB - Tissue Label File";
                lbTableName.Text = "LabelID";
                tbLabel s = ct.tbLabel.Where(c => c.label_id == ParaDatasetID).Single();
                lbDSName.Text = s.label_id.ToString();
                lbSpecimenID.Text = s.tbSlice.tbScan.tbSpecimen.sp_id.ToString();
                mitCreatedFromLabel.Visible = true;
            }
            else if (ParaTable == "ctdb-specimen")
            {
                this.Text = "CTDB - Specimen's Demo File";
                lbTableName.Text = "SpecimenID";
                tbSpecimen s = ct.tbSpecimen.Where(c => c.sp_id == ParaDatasetID).Single();
                lbSpecimenID.Text = s.sp_id.ToString();
                lbDSName.Text = s.Abstract;
            }
            else if (ParaTable == "ctdb-scanpara")
            {
                this.Text = "CTDB - scan parameter's picture file";
                lbTableName.Text = "";
                tbScan s = ct.tbScan.Where(c => c.scan_id == ParaDatasetID).Single();
                lbDSName.Text = s.Abstract;
                lbSpecimenID.Text = s.tbSpecimen.sp_id.ToString();
            }
            else
            { this.Close(); }


            CTHelper.setControlTag(cdFileType, 14, ParaFileType);   // 14 filetype, 指定的Image
            CTHelper.setControlTag(cdFileOpenStatus, 31, 30); //31 share method, 30 share in group
            CTHelper.LoadControl(cdFileRef, "tbRef", 4);   // 14 filetype, 11 image
            cdFileAuthor.Text = CTHelper.GetConfig("username");

            refreshdb();
        }
        /// <summary>更新数据库</summary>
        void refreshdb()
        {
            lbNote.Text = "更新数据库";
            CTDBEntities ct = new CTDBEntities();
            lboxDB.DataSource = ct.tbFile.Where(c =>
            c.f_pid == ParaDatasetID
            && c.f_filetype == ParaFileType
            && c.f_table == ParaTable).ToList<tbFile>();
            lboxDB.DisplayMember = "f_path";
            lbFileCount.Text = (lboxDB.DataSource as List<tbFile>).Count.ToString();
        }
        void note(int s) { pbar1.Maximum = s; pbar1.Value = 0; }
        void notep(string s = "") { if (pbar1.Value < pbar1.Maximum) pbar1.Value++; lbNote.Text = pbar1.Value + "|" + pbar1.Maximum + " " + s; Application.DoEvents(); }

        //========local file operation===========
        private void miDelAll_Click(object sender, EventArgs e) { lboxFile.SelectedItems.Clear(); }
        private void miDel_Click(object sender, EventArgs e)
        {
            int SelectItems = lboxFile.SelectedItems.Count;
            if (lboxFile.SelectedItems.Count > 0)
                for (int i = 0; i < SelectItems; i++)
                    lboxFile.Items.Remove(lboxFile.SelectedItems[0]);
        }
        private void miAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "图像文件|*.bmp;*.tiff;*.tif;*.png;*.jpg|所有文件|*.*";
            if ((cdFileType.SelectedItem as tbTag).tag_id == 12)
                openFileDialog.Filter = "3D文件|*.stl;*.obj;*.vrml|所有文件|*.*";
            else if ((cdFileType.SelectedItem as tbTag).tag_id == 99)
                openFileDialog.Filter = "ct文件|*.ctmx;*.bmp;*.tiff;*.dcm;*.tif;*.jpg;*.png|所有文件|*.*";
            else if ((cdFileType.SelectedItem as tbTag).tag_id == 14)
                openFileDialog.Filter = "视频文件|*.avi;*.mp4;*.gif;*.voc|所有文件|*.*";
            else if ((cdFileType.SelectedItem as tbTag).tag_id == 100)
                openFileDialog.Filter = "Label File|*.amr;*.bmp|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            //openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                foreach (string s in openFileDialog.FileNames)
                    lboxFile.Items.Add(s);
            lbCountFileSelect.Text = lboxFile.Items.Count.ToString();
        }
        private void lboxFile_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            for (int i = 0; i < s.Length; i++)
                lboxFile.Items.Add(s[i]);
            lbCountFileSelect.Text = lboxFile.Items.Count.ToString();
        }
        private void lboxFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Link;
            else e.Effect = DragDropEffects.None;
        }

        private void miUpload_Click(object sender, EventArgs e)
        {
            //阻止休眠
            CTHelper.PreventSleep();

            //upload files
            pbar1.Maximum = lboxFile.Items.Count;
            pbar1.Value = 0;

            lbNote.Text = "开始上传文件";
            string logl = CTHelper.CommonPath("app") + "\\upload.log";
            int countOK = 0, countError = 0;

            foreach (string fileSrc in lboxFile.Items)
            {
                pbar1.Value++;
                lbNote.Text = pbar1.Value + "，Total:" + lboxFile.Items.Count + ", " + countOK + " OK," + countError + " Fail";

                if (checkSkipSameFile.Checked) //重复检查
                {
                    string checkfilename = Path.GetFileName(fileSrc);
                    using (CTDBEntities ct = new CTDBEntities())
                    {
                        var q = from c in ct.tbFile
                                where c.f_pid == ParaDatasetID && c.f_table == ParaTable && c.f_path.Contains(checkfilename)
                                select c;
                        if (q.ToList<tbFile>().Count > 0)
                            continue;
                    }
                }

                //check names before upload上传前检测，名称检测
                string fileDes = CTHelper.CommonPath("app") + "\\" + Path.GetFileName(fileSrc).Replace(" ", "");
                if (File.Exists(fileDes)) File.Delete(fileDes);
                File.Copy(fileSrc, fileDes, true);
                string md5 = CTHelper.GetMD5Hash(fileDes);
                string fn = md5 + System.IO.Path.GetExtension(fileDes);

                //begin to upload开始上传
                if (File.Exists(fileDes))
                    addFile(fileDes, fileSrc, ParaTable, ParaDatasetID); /////核心上传函数
                File.Delete(fileDes);
                this.Enabled = true;
                Application.DoEvents();
            }

            this.Enabled = true;

            //finished 
            refreshdb();
            MessageBox.Show("Finishe upload. Error number:" + countError.ToString());
            lbNote.Text = "Finish Upload.";

            //恢复休眠
            CTHelper.RestoreSleep();
        }

        //=======remote / server=========

        ///remove from database
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Delete " + lboxDB.SelectedItems.Count.ToString() + " files", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            if (CTHelper.AlertYes("Delete " + lboxDB.SelectedItems.Count + " files"))
                using (var db = new CTDBEntities())
                    foreach (tbFile f in lboxDB.SelectedItems)
                    {
                        var student = db.tbFile.FirstOrDefault(s => s.f_id == f.f_id);
                        db.tbFile.Remove(student);    //删除
                        db.SaveChanges();
                    }
            refreshdb();
        }

        /// <summary>add a new file to database and server</summary>
        /// <param name="f">source image</param>
        /// <param name="fpath">source path</param>
        /// <param name="dsid"></param>
        /// <param name="para_table"></param>
        /// <returns></returns>
        string addFile(string f, string fpath, string para_table, int dsid)
        {
            string r = "";
            try
            {
                //upload to server
                this.Enabled = false;
                if (checkUploadFile.Checked)
                    r = CTHelper.UploadAPI(f, dsid.ToString(), "upload", para_table, "iozct", UserID);
                this.Enabled = true;
                string md5 = CTHelper.GetMD5Hash(f);

                //insert to database
                var t = new tbFile();
                t.f_path = fpath;                        //原名
                t.f_pid = dsid;                          //父表记录ID
                t.f_table = para_table;                   //对应的附表参数
                string pn = Path.GetFileNameWithoutExtension(fpath);
                if (pn.Length >= 4)
                    t.f_name = pn.Substring(pn.Length - 4, 4) + ".jpg"; //排序专用名
                else
                    t.f_name = pn + ".jpg";

                t.f_md5 = md5;                           //md5值
                t.f_author = cdFileAuthor.Text;      //版权人 copyright owner
                t.f_filetype = (cdFileType.SelectedItem as tbTag).tag_id;     // file type, default according the file extension, most Image = 11
                t.open_status = (cdFileOpenStatus.SelectedItem as tbTag).tag_id;  //share method, default 11 , most = 30

                t.f_fpid = 0;          //??
                t.sp_id = int.Parse(lbSpecimenID.Text);  //specimen id
                t.ref_id = (cdFileRef.SelectedItem as tbRef).ref_id;         //
                t.f_count = 1;

                t.date_in = DateTime.Now;
                t.date_up = DateTime.Now;
                t.UserId = Guid.Parse(UserID);

                CTDBEntities ct = new CTDBEntities();
                ct.tbFile.Add(t);
                ct.SaveChanges();   //将修改保存到数据库中
                return r;
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                r = dbEx.ToString();
                return r;
            }
        }

        //add demos from slice
        private void mitCreateExampleFromSlice_Click(object sender, EventArgs e)
        {
            if (!CTHelper.AlertYes("Selecte 10 slices as example？")) return;
            CTDBEntities ct = new CTDBEntities();
            var q = from c in ct.tbFile where c.f_pid == ParaDatasetID && c.f_table == "ctdb-slice" select c;
            List<tbFile> lll = q.ToList<tbFile>();
            int spid = ct.tbSlice.Where(c => c.slice_id == ParaDatasetID).Single().tbScan.tbSpecimen.sp_id;
            uploadSpecimenFile(spid, lll, "ctdb-slice", 10);
            refreshdb();
        }
        //add demos from labels
        private void mitCreateExampleFromLabel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Selecte 5 labels as example？", "Alert", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            CTDBEntities ct = new CTDBEntities();
            var q = from c in ct.tbFile where c.f_pid == ParaDatasetID && c.f_table == "ctdb-label" select c;
            List<tbFile> lll = q.ToList<tbFile>();
            int spid = ct.tbLabel.Where(c => c.label_id == ParaDatasetID).Single().tbSlice.tbScan.tbSpecimen.sp_id;
            uploadSpecimenFile(spid, lll, "ctdb-label", 5);
            refreshdb();
        }
        /// <summary>upload specimen file / example /demo </summary>
        /// <param name="specimenid"></param>
        /// <param name="lll"></param>
        /// <param name="filetablep"></param>
        /// <param name="choose_number"></param>
        void uploadSpecimenFile(int specimenid, List<tbFile> lll, string filetablep, int choose_number)
        {
            //从slice表中随机找出10张图
            List<string> fl = new List<string>();
            int[] fr = CTHelper.RandomIntArray(choose_number, 0, lll.Count - 1);
            for (int i = 0; i < fr.Length; i++)
            {
                string url = CTHelper.GetConfig("downloadurl") + "ct/" + filetablep + "/" + lll[fr[i]].f_pid + "/";
                string fn = Path.GetFileName(lll[fr[i]].f_path.Trim());
                fl.Add(url + fn);
            }

            Application.DoEvents();
            string ftmpd = CTHelper.CommonPath("app") + "\\" + "d.jpg";
            string ftmp = "";

            //对每张图进行上传操作  同 Add功能
            note(fl.Count);
            for (int i = 0; i < fr.Length; i++)
            {
                notep();
                if (File.Exists(ftmpd)) File.Delete(ftmpd);
                CTHelper.DownloadFile(fl[i], ftmpd); //download source image
                string fn = CTHelper.GetMD5Hash(ftmpd) + ".jpg";
                if (File.Exists(ftmpd))
                {
                    Bitmap b = CTHelper.CreateDemoImage(ftmpd, 150, 150);
                    ftmp = CTHelper.CommonPath("app") + "\\" + fn;
                    b.Save(ftmp, System.Drawing.Imaging.ImageFormat.Jpeg);

                    if (File.Exists(ftmp))
                    {
                        cdFileAuthor.Text = "selected from " + filetablep;
                        string r = addFile(ftmp, ftmp, "ctdb-specimen", specimenid);
                        if (r != "")
                            MessageBox.Show(r);
                    }
                }
                if (File.Exists(ftmpd)) File.Delete(ftmpd);
                if (File.Exists(ftmp)) File.Delete(ftmp);
            }
        }

        //从数据库里检测相关数据，看网页是否可以访问
        private void btnCheckDB_Click(object sender, EventArgs e)
        {
            CTDBEntities ct = new CTDBEntities();
            var q = from c in ct.tbFile
                    where c.f_pid == ParaDatasetID && c.f_table == ParaTable
                    orderby c.f_path
                    select c;
            List<tbFile> l = q.ToList<tbFile>();
            string flog = CTHelper.CommonPath("app") + "\\UrlTestlog.txt";
            if (File.Exists(flog)) File.Delete(flog);

            note(l.Count);
            this.Enabled = false;
            foreach (tbFile f in l)
            {
                string url = CTHelper.GetConfig("downloadurl") + f.f_table + "/" + f.f_pid.ToString() + "/" + f.f_md5 + ".jpg";
                if (CTHelper.IsUrlExist(url))
                    CTHelper.AddLog("1\t" + url, flog);
                else
                    CTHelper.AddLog("0\t" + url, flog);
                notep();
            }

            refreshdb();
            this.Enabled = true;
        }

        void AlertInTime(string text, int time = 2000)
        {
            Action act = new Action(() =>
            {
                ts = new Timer();
                ts.Tick += t_tick;
                ts.Interval = time;
                ts.Enabled = true;
                MessageBox.Show(text);
                System.Threading.Thread.Sleep(time + 500);
            });
            act.Invoke();
        }
        Timer ts = new Timer();
        void t_tick(object sender, EventArgs e)
        {
            ((Timer)sender).Enabled = false;
            SendKeys.SendWait("{Enter}");
        }

        private void lboxDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxDB.SelectedIndex > 0)
            {
                tbFile f = lboxDB.SelectedItem as tbFile;
                lbDBFile.Text = f.f_id + ":" + f.f_md5 + ":";
                CTHelper.setControl(cdFileType, (int)f.f_filetype);
                CTHelper.setControl(cdFileOpenStatus, (int)f.open_status);
                CTHelper.setControl(cdFileRef, (int)f.ref_id);
                cdFileAuthor.Text = f.f_author;
            }
        }

        private void cdFileType_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshdb();
        }


        /// <summary>查询tbFile表，确定是否有相关联的数据</summary>
        /// <param name="table">表参数</param>
        /// <param name="dsid">表记录id</param>
        /// <returns>ture 有记录，false 无记录</returns>
        static public bool HasFiles(string table, int dsid)
        {
            bool r = true;
            using (var db = new CTDBEntities())
            {
                var student = db.tbFile.FirstOrDefault(s => s.f_table == table && dsid == s.f_pid);
                if (student == null)
                    return false;
            }
            return r;
        }

    }
}
