using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;

using System.Xml;

namespace CTDB
{
    public partial class FormSlice : Form
    {
        /// <summary>导出元数据方法</summary>
        /// <param name="id">slice表的 slice_id </param>
        static public void ExportMeta(int id)
        {
            try
            {
                List<Tuple<string, string>> ht = new List<Tuple<string, string>>();
                CTDBEntities ct = new CTDBEntities();

                tbSlice slice = ct.tbSlice.FirstOrDefault(s => s.slice_id == id);
                ht.Add(new Tuple<string, string>("URL", "http://ct.especies.cn/slice/info/" + slice.slice_id.ToString()));
                ht.Add(new Tuple<string, string>("Slice ID", slice.slice_id.ToString()));
                ht.Add(new Tuple<string, string>("Slice Number", slice.slice_para_SliceNumber.ToString()));
                ht.Add(new Tuple<string, string>("Slice File Type", slice.slice_para_ResultFileType.ToString()));
                ht.Add(new Tuple<string, string>("Slice Resolution", slice.slice_para_PixelSize.ToString()));


                tbScan scan = ct.tbScan.FirstOrDefault(s => s.scan_id == slice.scan_id);
                //ht.Add(new Tuple<string, string>("Scan ID", scan.scan_id.ToString()));
                ht.Add(new Tuple<string, string>("Scan Voltage", scan.scan_para_SourceVoltage.ToString()));
                ht.Add(new Tuple<string, string>("Scan Power", scan.scan_para_SourcePower.ToString()));
                ht.Add(new Tuple<string, string>("Scan Binning", scan.scan_para_CameraBinning.ToString()));
                ht.Add(new Tuple<string, string>("Scan Lens", scan.scan_para_LensMultiple.ToString()));
                ht.Add(new Tuple<string, string>("Scan Exposure", scan.scan_para_Exposure.ToString()));
                ht.Add(new Tuple<string, string>("Scan Time", scan.scan_date));
                ht.Add(new Tuple<string, string>("Scan Operator", scan.scan_operator));
                ht.Add(new Tuple<string, string>("Scan Part", scan.scan_specimen_Body));

                //tbTag ttag = ct.tbTag.FirstOrDefault(s => s.tag_id == scan.scan_tag_SpecimenAlive);
                //ht.Add(new Tuple<string, string>("Specimen Status", ttag.tag_tag));
                ht.Add(new Tuple<string, string>("Specimen Status", FormTag.GetTagTag(scan.scan_tag_SpecimenAlive)));

                tbEquipment equip = ct.tbEquipment.FirstOrDefault(s => s.e_id == scan.e_id);
                ht.Add(new Tuple<string, string>("Equipment", equip.e_name));

                tbSpecimen sp = ct.tbSpecimen.FirstOrDefault(s => s.sp_id == slice.sp_id);
                ht.Add(new Tuple<string, string>("Specimen ID", sp.sp_spid));
                ht.Add(new Tuple<string, string>("Specimen Collector", sp.sp_collector));
                ht.Add(new Tuple<string, string>("Specimen Time", sp.sp_collect_time));
                ht.Add(new Tuple<string, string>("Specimen Place", sp.sp_collect_place));
                ht.Add(new Tuple<string, string>("Specimen Identifier", sp.sp_identifier));

                ht.Add(new Tuple<string, string>("Preprocess", sp.sp_dehydrant));


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
            catch (Exception ee)
            {
                MessageBox.Show("记录有问题，导出失败\r\n" + ee.ToString());
            }
        }
        static XmlElement addnode(XmlDocument xmldoc, string name, string vv)
        {
            XmlNode xn = xmldoc.CreateNode(XmlNodeType.Text, name, "");
            xn.InnerText = vv;
            XmlElement xe = xmldoc.CreateElement(name);
            xe.AppendChild(xn);
            return xe;
        }
        static public string ExportPIDXML(int id)
        {
            string r = "";
            try
            {
                //https://blog.csdn.net/xjj51296646/article/details/4241548
                XmlDocument xmldoc = new XmlDocument();
                //加入XML的声明段落,<?xml version="1.0" encoding="gb2312"?>
                XmlDeclaration xmldecl = xmldoc.CreateXmlDeclaration("1.0", "UTF-8", null);
                xmldoc.AppendChild(xmldecl);
                //加入一个根元素
                XmlElement xmlroot = xmldoc.CreateElement("", "pid", "");
                xmlroot.SetAttribute("type", "DATASET");
                xmldoc.AppendChild(xmlroot);

                XmlElement xmlroot2 = xmldoc.CreateElement("", "metadatas", "");
                xmlroot.AppendChild(xmlroot2);

                XmlElement xmlmeta = xmldoc.CreateElement("", "metadata", "");
                xmlmeta.SetAttribute("type", "Metadata");
                xmlroot2.AppendChild(xmlmeta);

                List<Tuple<string, string>> ht = new List<Tuple<string, string>>();
                CTDBEntities ct = new CTDBEntities();
                tbSlice slice = ct.tbSlice.FirstOrDefault(s => s.slice_id == id);
                tbScan scan = ct.tbScan.FirstOrDefault(s => s.scan_id == slice.scan_id);
                string part = scan.scan_specimen_Body;
                tbSpecimen sp = ct.tbSpecimen.FirstOrDefault(s => s.sp_id == slice.sp_id);
                tbSpecies species = ct.tbSpecies.FirstOrDefault(s => s.species_id == sp.species_id);
                string spname = species.species_latin;


                string pid = "21.86116.3/CT.slice." + slice.slice_id.ToString();
                xmlmeta.AppendChild(addnode(xmldoc, "pid", pid));
                string url = "http://ct.especies.cn/slice/info/" + slice.slice_id.ToString();
                xmlmeta.AppendChild(addnode(xmldoc, "url", url));

                string funding = "the Strategic Priority Research Program of the Chinese Academy of Sciences(Grant No. XDA19050203)";
                xmlmeta.AppendChild(addnode(xmldoc, "funding", funding));
                xmlmeta.AppendChild(addnode(xmldoc, "copyright", "CC BY 4.0"));

                string title_zh = spname + " " + part + " 显微CT扫描和标注数据";
                xmlmeta.AppendChild(addnode(xmldoc, "title_zh", title_zh));
                string title_en = "Micro-CT Slice and Label Data of " + spname + " " + part;
                xmlmeta.AppendChild(addnode(xmldoc, "title_en", title_en));

                string description_zh = title_zh;
                xmlmeta.AppendChild(addnode(xmldoc, "description_zh", description_zh));
                string description_en = title_en;
                xmlmeta.AppendChild(addnode(xmldoc, "description_en", description_en));

                string keyword_zh = spname + ";显微CT;结构标注";
                xmlmeta.AppendChild(addnode(xmldoc, "keyword_zh", keyword_zh));
                string keyword_en = spname + ";Micro CT;structural label";
                xmlmeta.AppendChild(addnode(xmldoc, "keyword_en", keyword_en));

                xmlmeta.AppendChild(addnode(xmldoc, "resource_type", "采集数据"));
                xmlmeta.AppendChild(addnode(xmldoc, "publisher_zh", "动物科学数据中心"));
                xmlmeta.AppendChild(addnode(xmldoc, "publisher_en", "Scientific Data Center of Zoology"));

                string f = Application.StartupPath + "\\meta.xml";
                if (File.Exists(f)) File.Delete(f);
                xmldoc.Save(f);
                System.Diagnostics.Process.Start(f);
            }
            catch (Exception ee)
            {
                MessageBox.Show("记录有问题，导出失败\r\n" + ee.ToString());
            }
            return r;
        }

        /// <summary>浏览器看slice资源信息</summary>
        /// <param name="slice_id"></param>
        static public void OpenSliceInBrowser(int slice_id)
        {
            try
            {
                int id = slice_id;
                //Hashtable ht = new Hashtable();
                List<Tuple<string, string>> ht = new List<Tuple<string, string>>();
                CTDBEntities ct = new CTDBEntities();
                tbSlice slice = ct.tbSlice.FirstOrDefault(s => s.slice_id == id);
                string url = "http://ct.especies.cn/slice/info/" + slice.slice_id.ToString();

                System.Diagnostics.Process.Start(url);
            }
            catch { }
        }

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
            CTHelper.setControlTag(clFileType, 51, 55);
            CTHelper.setControlTag(clCutMethod, 37, 35);

            cscRef.DataSource = FormLogin.LoadDataF("tbRef");
            cscRef.DisplayMember = "cite";
            cscRef.SelectedIndex = 3;

            //dataGridView1.DataSource = ct.tbSlice.ToList<tbSlice>();
            //dataGridView1.DataSource = FormLogin.LoadDataA("tbSlice");
            FormLogin.LoadData(dataGridView1, "tbSlice", "slice_id|scan_id|slice_para_PixelSize|slice_para_CutMethod|Abstract|date_in|open_status|slice_para_SliceNumber");

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
                    clFileType.Text = s.slice_para_ResultFileType;
                    // clNumberSlice.Text = s.slice_para_SliceNumber.ToString();
                    clPixelSize.Text = s.slice_para_PixelSize.ToString();
                    CTHelper.setControl(clOpenStatus, s.open_status);

                    ucFileInfo1.ParaDatasetID = s.slice_id;
                    clLabelNo.Text = ct.tbLabel.Count<tbLabel>(c => c.slice_id == id).ToString();

                    CTHelper.setControl(cscRef, s.ref_id);

                    mitDelete.Enabled = dataGridView1.Rows.Count > 0;
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = ((dataGridView1.DataSource as ArrayList)[e.RowIndex] as tbSlice).slice_id;
                this.clID.Text = id.ToString();
                bsmAddLabel_Click(sender, null);
            }

        }
        void setDBValue(tbSlice s)
        {
            s.scan_id = (clScan.SelectedValue as tbScan).scan_id;
            s.sp_id = (clScan.SelectedValue as tbScan).sp_id; //specimen_id

            s.slice_para_ReconstructionProgram = clReconstructionProgram.Text;
            s.slice_para_ResultFileType = clResultFileType.Text.Trim();
            s.slice_para_SliceNumber = ucFileInfo1.ValueFileCount;// int.Parse(clNumberSlice.Text);

            double psize = -1.0;
            double.TryParse(clPixelSize.Text, out psize);
            s.slice_para_PixelSize = psize;



            if (clPixelSize.Text != "")
                s.slice_para_PixelSize = float.Parse(clPixelSize.Text);
            s.open_status = int.Parse(clOpenStatus.SelectedValue.ToString());
            s.slice_para_CutMethod = clCutMethod.Text;
            s.slice_save_path = "-";// clSavePath.Text;


            if (s.tbScan != null)
                s.Abstract = s.tbScan.Abstract;
            s.UserId = Guid.Parse(CTHelper.GetConfig("userid"));
            s.date_in = DateTime.Now;
            s.ref_id = (cscRef.SelectedItem as tbRef).ref_id;

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
        private void ucFileInfo1_UpdateFile(object sender, EventArgs e)
        {
            this.Show();
            int id = int.Parse(clID.Text);
            using (CTDBEntities ct = new CTDBEntities())
            {
                //更新文件数量
                var s = ct.tbSlice.FirstOrDefault(st => st.slice_id == id);
                //s.scan_para_FilesNumber = ucFileInfo1.ValueFileCount;// q.Count<tbFile>();
                s.slice_para_SliceNumber = ucFileInfo1.ValueFileCount;
                //s.slice_para_PixelSize  = ucFileI
                ct.SaveChanges();
            }
            refreshDatagridview(id.ToString());
        }


        private void lbComputeResolution_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            if (od.ShowDialog() == DialogResult.OK)
            {

            }

        }

        private void viewScanInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = int.Parse(clID.Text);
            using (CTDBEntities ct = new CTDBEntities())
            {
                //更新文件数量
                var slice = ct.tbSlice.FirstOrDefault(st => st.slice_id == id);
                var scan = ct.tbScan.FirstOrDefault(st => st.scan_id == slice.scan_id);
                var sp = ct.tbSpecimen.FirstOrDefault(st => st.sp_id == scan.sp_id);

                string r = "ScanID: " + scan.sp_id + "\r\n";
                r += "Scan Operator: " + scan.scan_operator + "\r\n";
                r += "SecimenSPID: " + sp.sp_spid + "\r\n";
                MessageBox.Show(r);
            }
        }

        private void bsmAddLabel_Click(object sender, EventArgs e)
        {
            FormLabel fl = new FormLabel();
            fl.SliceID = int.Parse(this.clID.Text);
            this.Hide();
            fl.ShowDialog();
            this.Show();
        }

        private void cmitExportPIDXML_Click(object sender, EventArgs e)
        {
            int id = int.Parse(clID.Text);
            ExportPIDXML(id);
        }
        private void cmitExportMeta_Click(object sender, EventArgs e)
        {
            int id = int.Parse(clID.Text);
            ExportMeta(id);
        }
        private void cmitOpenInBrowser_Click(object sender, EventArgs e)
        {
            int id = int.Parse(clID.Text);
            OpenSliceInBrowser(id);
        }




    }
}
