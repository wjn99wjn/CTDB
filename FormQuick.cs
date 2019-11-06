using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace CTDB
{
    public partial class FormQuick : Form
    {
        public FormQuick() { InitializeComponent(); }
        private void CTDBFormAddSpecies_Load(object sender, EventArgs e) { refreshdata(sender, e); }
        private void btnOK_Click(object sender, EventArgs e) { this.Close(); }

        //load
        private void refreshdata(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            //mitDelete.Enabled = false;

            CTDBEntities ct = new CTDBEntities();
            List<vQuick> l = ct.vQuick.ToList<vQuick>();
            dataGridView1.DataSource = l;

            cscanEquipment.DataSource = ct.tbEquipment.ToList<tbEquipment>();
            cscanEquipment.ValueMember = "e_id";
            cscanEquipment.DisplayMember = "e_nameA";

            cspeciesOrder.DataSource = ct.tbSpecies.ToList<tbSpecies>();
            cspeciesOrder.DisplayMember = "species_Order";

            CTHelper.setControlTag(csmSex, 43, 42);
            CTHelper.setControlTag(csmAge, 45);
            CTHelper.setControlTag(cscanTagSpecimenParty, 9);
            CTHelper.setControlTag(csmDehydrant, 63, 64);

            this.Text = "CTDB - Quick Operation From - " + l.Count;

        }

        //add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CTDBEntities ct = new CTDBEntities();

            //create species
            var s1 = new tbSpecies();
            s1.species_note = cspeciesNote.Text;
            s1.species_Order = cspeciesOrder.Text;

            s1.date_in = DateTime.Now;
            s1.UserId = Guid.Parse(CTHelper.GetConfig("userid"));
            ct.tbSpecies.Add(s1);
            ct.SaveChanges();   //将修改保存到数据库中

            //create specimen
            var s2 = new tbSpecimen();
            s2.species_id = s1.species_id;

            s2.sp_spid = csmSPID.Text; //实际标本号-不是必须字段
            s2.specimen_sex = (csmSex.SelectedItem as tbTag).tag_id;
            s2.specimen_age = csmAge.Text;
            s2.sp_note = csmNote.Text;
            s2.specimen_dry_save_path = csmSavePosition.Text;

            s2.sp_collector = csmCollector.Text;
            s2.sp_collect_place = csmCollectPlace.Text;
            s2.sp_collect_time = csmCollectTime.Text;

            s2.sp_dehydrant = csmDehydrant.Text;
            s2.sp_drycirletime = int.Parse(GetStringNumber(csmDryCycleTime.Text));
            //s2.sp_dryinstrument = "-";

            s2.Abstract = s1.species_note + "-" + s2.sp_id;
            s2.date_in = DateTime.Now;
            s2.UserId = Guid.Parse(CTHelper.GetConfig("userid"));
            s2.sp_preserve_status = "-";
            ct.tbSpecimen.Add(s2);
            ct.SaveChanges();   //将修改保存到数据库中

            //create scan record
            var s3 = new tbScan();
            s3.sp_id = s2.sp_id;
            s3.e_id = (int)cscanEquipment.SelectedValue;

            s3.scan_specimen_Body = cscanTagSpecimenParty.Text;
            s3.scan_source_save_path = cscanPath.Text;
            //s3.scan_timebegin = DateTime.Parse(cscanTimeBegin.Text);
            s3.scan_date = cscanTimeBegin.Text;

            s3.scan_para_CameraBinning = cscanCameraBinning.Text;
            s3.scan_para_SourceVoltage = double.Parse(GetStringNumber(cscanSourceVoltage.Text));
            s3.scan_para_SourceCurrent = double.Parse(GetStringNumber(cscanSourceCurrent.Text));
            s3.scan_para_Exposure = double.Parse(GetStringNumber(cscanExposure.Text));

            s3.Abstract = s2.Abstract + "-" + s3.scan_specimen_Body;
            s3.date_in = DateTime.Now;
            s3.UserId = Guid.Parse(CTHelper.GetConfig("userid"));
            ct.tbScan.Add(s3);
            ct.SaveChanges();   //将修改保存到数据库中

            //create slice record
            var s4 = new tbSlice();
            s4.scan_id = s3.scan_id;
            s4.slice_save_path = csliceSavePath.Text;

            s4.date_in = DateTime.Now;
            s4.UserId = Guid.Parse(CTHelper.GetConfig("userid"));
            s4.Abstract = s3.Abstract;
            ct.tbSlice.Add(s4);
            ct.SaveChanges();   //将修改保存到数据库中

            refreshdata(null, null);
        }

        public static decimal GetNumber(string str)
        {
            if (str.Trim() == "") return 0;
            decimal result = 0;
            if (str != null && str != string.Empty)
            {
                // 正则表达式剔除非数字字符（不包含小数点.）
                str = Regex.Replace(str, @"[^\d.\d]", "");
                // 如果是数字，则转换为decimal类型
                if (Regex.IsMatch(str, @"^[+-]?\d*[.]?\d*$"))
                {
                    result = decimal.Parse(str);
                }
            }
            return result;
        }
        public static string GetStringNumber(string str)
        {
            decimal result = GetNumber(str);
            return result.ToString();
        }

        //view/ browser
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

                CTDBEntities ct = new CTDBEntities();

                var q = from c in ct.vQuick where c.slice_id == id select c;
                vQuick s = q.ToList<vQuick>()[0];

                csliceID.Text = s.slice_id.ToString();
                //csmID.Text = s.sp_id.ToString();
                //csmDescrip.Text = s.sp_description;
                //csmCollector.Text = s.sp_collector;
                //csmCollectPlace.Text = s.sp_place;
                //csmCollectTime.Text = s.sp_time;
                //csmNote.Text = s.sp_note;
                //csmSPID.Text = s.sp_spid;
                //csmDehydrant.Text = s.sp_dehydrant;
                //csmDryInstrument.Text = s.sp_dryinstrument;
                //csmDryCycleTime.Text = s.sp_drycirletime.ToString();

                //CTHelper.setControl(csmSpecies, Convert.ToInt32(s.species_id));

                mitDelete.Enabled = dataGridView1.Rows.Count > 0;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "CSV File(*.csv)|*.csv";
            if (sd.ShowDialog() == DialogResult.OK)
            {
                CTHelper.SaveAsTxt(GetDgvToTable(dataGridView1), sd.FileName);
                MessageBox.Show("OK");
            }
        }
        static public DataTable GetDgvToTable(DataGridView dgv)
        {
            DataTable dt = new DataTable();

            // 列强制转换
            for (int count = 0; count < dgv.Columns.Count; count++)
            {
                DataColumn dc = new DataColumn(dgv.Columns[count].Name.ToString());
                dt.Columns.Add(dc);
            }

            // 循环行
            for (int count = 0; count < dgv.Rows.Count; count++)
            {
                DataRow dr = dt.NewRow();
                for (int countsub = 0; countsub < dgv.Columns.Count; countsub++)
                {
                    dr[countsub] = Convert.ToString(dgv.Rows[count].Cells[countsub].Value);
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }

        //parse the parameter
        private void tbParas_TextChanged(object sender, EventArgs e)
        {

            if (tbParas.Text.Trim() == "") return;

            string[] sl = tbParas.Text.Split('\t');

            if (sl.Length < 24) return;
            //MessageBox.Show(sl.Length.ToString());

            //初始化一些字段
            cscanCameraBinning.Text = "";
            cscanSourceVoltage.Text = "0";
            cscanSourceCurrent.Text = "0";
            cscanExposure.Text = "0";
            csmDryCycleTime.Text = "25";

            //字段对应
            //0-扫描时间
            //1-扫描地点
            //2-样本编号（年[4位]月[2位]标本号[3位]）

            //3-目             
            //4,5,6 - 种名(俗名,中文)  拉丁名 名称备注 

            //7-性别（♀♂A P L）功能型等
            //8-虫龄
            //12-采集备注
            //9,10,11 - 采集时间 采集地点 采集人 

            //16-脱水参数  
            //17-临界点干燥 
            //18-扫描部位    
            //19-扫描参数 

            //21-ct -slice数据保存位置
            //22-ct原始数据保存位置
            //23-干样本保存位置 如样本编号为201903001的样本，保存在1号箱的1号抽屉里，则命名为1 - 2019 - 1 - 3 - 01
            //24-对应数据库编号

            //================================
            cscanTimeBegin.Text = sl[0];
            try
            {
                if (sl[1].Contains("上海光源")) CTHelper.setControl(cscanEquipment, 2);
                else if (sl[1].Contains("动物所")) CTHelper.setControl(cscanEquipment, 1);
            }
            catch { }
            csmSPID.Text = sl[2];
            cspeciesOrder.Text = sl[3];
            cspeciesNote.Text = sl[4] + " " + sl[5];
            //cspeciesOrder.Text = sl[3];

            //7-性别（♀♂A P L）功能型等
            //8-虫龄
            //12-采集备注
            //9,10,11 - 采集时间 采集地点 采集人 
            try
            {
                if (sl[7].Contains("♀")) CTHelper.setControl(csmSex, 44);
                else if (sl[7].Contains("♂")) CTHelper.setControl(csmSex, 41);
            }
            catch { }
            csmAge.Text = (sl[8].Trim() == "") ? "-" : sl[7];
            csmNote.Text = (sl[12].Trim() == "") ? "-" : sl[8];

            //9,10,11-采集地点  采集时间 采集人 
            csmCollectTime.Text = (sl[9].Trim() == "") ? "-" : sl[10];
            csmCollectPlace.Text = (sl[10].Trim() == "") ? "-" : sl[11];
            csmCollector.Text = (sl[11].Trim() == "") ? "-" : sl[9];

            //16-脱水参数  
            //17-临界点干燥 
            //18-扫描部位    
            //19-扫描参数 
            try
            {
                if (sl[16].Contains("75%-100%")) CTHelper.setControl(csmDehydrant, 0);
                else if (sl[16].Contains("75-100")) CTHelper.setControl(csmDehydrant, 0);
                else if (sl[16].Contains("75%-丙酮")) CTHelper.setControl(csmDehydrant, 3);
                else if (sl[16].Contains("100")) CTHelper.setControl(csmDehydrant, 1);
            }
            catch { }

            csmDryCycleTime.Text = (sl[17].Trim() == "") ? "0" : sl[13];

            //cscanTagSpecimenParty

            try
            {
                if (sl[19].Trim() != "")
                {
                    string[] sp = sl[19].Split(new char[] { '：', '-' });
                    cscanCameraBinning.Text = sp[1].Trim();
                    cscanSourceVoltage.Text = sp[2].Trim().ToLower().Replace("kv", "");
                    cscanSourceCurrent.Text = sp[3].Trim().ToLower().Replace("w", "");
                    cscanExposure.Text = sp[4].Trim().ToLower().Replace("s", "");
                }
            }
            catch { }

            //21-ct -slice数据保存位置
            //22-ct原始数据保存位置
            //23-干样本保存位置 如样本编号为201903001的样本，保存在1号箱的1号抽屉里，则命名为1 - 2019 - 1 - 3 - 01
            //24-对应数据库编号
            cscanPath.Text = sl[21].Trim();
            csmSavePosition.Text = sl[22].Trim();
        }

        private void mitAddFile_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0) return;

            FormUpload dlg = new FormUpload();
            int id = int.Parse(csliceID.Text);
            dlg.ParaDatasetID = id;
            dlg.ParaTable = "ctdb-slice";
            dlg.ShowDialog();

            using (CTDBEntities ct = new CTDBEntities())
            {
                var q = from c in ct.tbFile where c.f_pid == id && c.f_table == dlg.ParaTable select c;
                //clNumberSlice.Text = q.Count<tbFile>().ToString();

                //更新文件数量
                var s = ct.tbSlice.FirstOrDefault(st => st.slice_id == id);
                s.slice_para_SliceNumber = q.Count<tbFile>();
                ct.SaveChanges();
            }

            //refreshDatagridview(id.ToString());
            //refreshdata();

        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            if (d.ShowDialog() == DialogResult.OK)
            {
                string[] l = CTHelper.LoadTxtByLine(d.FileName);
                if (MessageBox.Show("Add " + l.Length + " records?", "Note", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    foreach (string s in l)
                    {
                        if (s.Trim() == "") continue;
                        tbParas.Text = s;
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(2000);
                        btnAdd_Click(sender, e);
                    }
            }
        }


    }
}
