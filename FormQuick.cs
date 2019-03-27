﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

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
            s2.sp_place = csmCollectPlace.Text;
            s2.sp_time = csmCollectTime.Text;

            s2.sp_dehydrant = csmDehydrant.Text;
            s2.sp_drycirletime = int.Parse(csmDryCycleTime.Text);
            //s2.sp_dryinstrument = "-";

            s2.Abstract = s1.species_note + "-" + s2.sp_id;
            s2.date_in = DateTime.Now;
            s2.UserId = Guid.Parse(CTHelper.GetConfig("userid"));
            ct.tbSpecimen.Add(s2);
            ct.SaveChanges();   //将修改保存到数据库中

            //create scan record
            var s3 = new tbScan();
            s3.sp_id = s2.sp_id;
            s3.e_id = (int)cscanEquipment.SelectedValue;

            s3.scan_specimen_Body = cscanTagSpecimenParty.Text;
            s3.scan_source_save_path = cscanPath.Text;
            s3.scan_timebegin = DateTime.Parse(cscanTimeBegin.Text);

            s3.scan_para_CameraBinning = cscanCameraBinning.Text;
            s3.scan_para_SourceVoltage = double.Parse(cscanSourceVoltage.Text);
            s3.scan_para_SourceCurrent = double.Parse(cscanSourceCurrent.Text);
            s3.scan_para_Exposure = double.Parse(cscanExposure.Text);

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

            if (sl.Length < 18) return;
            //MessageBox.Show(sl.Length.ToString());

            //初始化一些字段
            cscanCameraBinning.Text = "";
            cscanSourceVoltage.Text = "0";
            cscanSourceCurrent.Text = "0";
            cscanExposure.Text = "0";
            csmDryCycleTime.Text = "25";


            cscanTimeBegin.Text = sl[0];
            try
            {
                if (sl[1].Contains("上海光源")) CTHelper.setControl(cscanEquipment, 2);
                else if (sl[1].Contains("动物所")) CTHelper.setControl(cscanEquipment, 1);
            }
            catch { }

            csmSPID.Text = sl[2];
            cspeciesNote.Text = sl[3];
            cspeciesOrder.Text = sl[4];

            try
            {
                if (sl[6].Contains("♀")) CTHelper.setControl(csmSex, 44);
                else if (sl[6].Contains("♂")) CTHelper.setControl(csmSex, 41);
            }
            catch { }

            csmAge.Text = (sl[7].Trim() == "") ? "-" : sl[7];
            csmNote.Text = (sl[8].Trim() == "") ? "-" : sl[8];

            csmCollector.Text = (sl[9].Trim() == "") ? "-" : sl[9];
            csmCollectTime.Text = (sl[10].Trim() == "") ? "-" : sl[10];
            csmCollectPlace.Text = (sl[11].Trim() == "") ? "-" : sl[11];

            try
            {
                if (sl[12].Contains("75%-100%")) CTHelper.setControl(csmDehydrant, 0);
                else if (sl[12].Contains("75-100")) CTHelper.setControl(csmDehydrant, 0);
                else if (sl[12].Contains("75%-丙酮")) CTHelper.setControl(csmDehydrant, 3);
                else if (sl[12].Contains("100")) CTHelper.setControl(csmDehydrant, 1);
            }
            catch { }

            csmDryCycleTime.Text = (sl[13].Trim() == "") ? "0" : sl[13];

            try
            {
                if (sl[15].Trim() != "")
                {
                    string[] sp = sl[15].Split(new char[] { '：', '-' });
                    cscanCameraBinning.Text = sp[1].Trim();
                    cscanSourceVoltage.Text = sp[2].Trim().ToLower().Replace("kv", "");
                    cscanSourceCurrent.Text = sp[3].Trim().ToLower().Replace("w", "");
                    cscanExposure.Text = sp[4].Trim().ToLower().Replace("s", "");
                }
            }
            catch { }

            cscanPath.Text = sl[17].Trim();
            csmSavePosition.Text = sl[18].Trim();
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
    }
}
