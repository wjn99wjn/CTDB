using System;
using System.Data;
using System.Linq;

using System.Windows.Forms;
using System.Collections;

namespace CTDB
{
    public partial class FormSpecimen : Form
    {
        public FormSpecimen() { InitializeComponent(); }
        private void btnOK_Click(object sender, EventArgs e) { this.Close(); }

        private void CTDBFormSpecimen_Load(object sender, EventArgs e)
        {
            //load controls
            ucFileInfo1.ParaTable = "ctdb-specimen";
            CTHelper.setControlTag(csmSex, 43, 42);
            CTHelper.setControlTag(csmAge, 45, 46);
            CTHelper.setControlTag(csmDehydrant, 63, 64);
            CTHelper.setControlTag(csmPS, 95, 96);
            //load gridview-specimen information


            //this.dataGridView1.AutoGenerateColumns = false;

            CTDBEntities ct = new CTDBEntities();
            csmSpecies.DataSource = FormLogin.LoadDataA("tbSpecies");
            csmSpecies.DisplayMember = "species_note";

            refreshdata();
        }


        /// <summary>load/ refresh </summary>
        private void refreshdata(int rowIndex = -1)
        {
            dataGridView1.DataSource = null;
            mitDelete.Enabled = false;
            CTDBEntities ct = new CTDBEntities();
            //dataGridView1.DataSource = ct.tbSpecimen.ToList<tbSpecimen>();
            //dataGridView1.DataSource = FormLogin.LoadDataA("tbSpecimen");
            //SetColumn(dataGridView1, "sp_id|species_id");
            FormLogin.LoadData(dataGridView1, "tbSpecimen", "sp_id|species_id|sp_collector|Abstract|UserId");
            //dg.DataSource = FormLogin.LoadDataA(table);
            //SetColumn(dg, showcol);

            if (dataGridView1.DataSource != null)
                if (rowIndex > 0)
                    dataGridView1.Rows[rowIndex].Selected = true;
        }

        //load selected information
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int rid = dataGridView1.SelectedRows[0].Index;
                int id = ((dataGridView1.DataSource as ArrayList)[rid] as tbSpecimen).sp_id;

                // (int)(dataGridView1.SelectedRows[0].Cells[0].Value as tbSpecimen);
                //tbSpecimen ss = dataGridView1.SelectedRows[0].Cells[0].Value as tbSpecimen;
                //Console.WriteLine(ss.sp_spid.ToString());
                CTDBEntities ct = new CTDBEntities();
                var q = from c in ct.tbSpecimen where c.sp_id == id select c;
                tbSpecimen s = q.ToList<tbSpecimen>()[0];

                csmID.Text = s.sp_id.ToString();

                csmSPID.Text = s.sp_spid;

                csmCollector.Text = s.sp_collector;
                csmCollectPlace.Text = s.sp_place;
                csmCollectTime.Text = s.sp_time;

                csmDehydrant.Text = s.sp_dehydrant;
                csmDryInstrument.Text = s.sp_dryinstrument;
                csmDryCycleTime.Text = s.sp_drycirletime.ToString();

                CTHelper.setControl(csmSpecies, (int)s.species_id);
                CTHelper.setControl(csmSex, (int)s.specimen_sex);
                csmAge.Text = s.specimen_age;
                csmDriedSpecimenSavePosition.Text = s.specimen_dry_save_path;

                csmPS.Text = s.sp_preserve_status;
                csmNote.Text = s.sp_note;
                //lbFilecount.Text = ct.tbFile.Where<tbFile>(c => c.f_pid == s.sp_id && c.f_table == "ctdb-specimen").Count<tbFile>().ToString();

                ucFileInfo1.ParaDatasetID = s.sp_id;
                mitDelete.Enabled = dataGridView1.Rows.Count > 0;
            }
        }



        //tbSpecimen operations
        /// <summary> set values </summary>
        /// <param name="s"></param>
        void setDBValue(tbSpecimen s)
        {
            s.species_id = (csmSpecies.SelectedItem as tbSpecies).species_id;
            s.sp_note = csmNote.Text;

            s.sp_spid = csmSPID.Text;//实际标本号-不是必须字段
            s.specimen_age = csmAge.Text;
            s.specimen_sex = (csmSex.SelectedItem as tbTag).tag_id;
            s.specimen_dry_save_path = csmDriedSpecimenSavePosition.Text;
            //s.sp_description = csmDescrip.Text;

            s.sp_collector = csmCollector.Text;
            s.sp_place = csmCollectPlace.Text;
            s.sp_time = csmCollectTime.Text;

            s.sp_dehydrant = csmDehydrant.Text;
            s.sp_drycirletime = int.Parse(csmDryCycleTime.Text);
            s.sp_dryinstrument = csmDryInstrument.Text;

            s.sp_preserve_status = csmPS.Text;

            s.Abstract = csmSpecies.Text.Trim() + "-" + csmSPID.Text;
            s.UserId = Guid.Parse(CTHelper.GetConfig("userid"));
            s.date_in = DateTime.Now;
        }
        private void bsmAdd_Click(object sender, EventArgs e)
        {
            var s = new tbSpecimen();
            setDBValue(s);
            CTDBEntities ct = new CTDBEntities();
            ct.tbSpecimen.Add(s);
            ct.SaveChanges();   //将修改保存到数据库中
            refreshdata(dataGridView1.RowCount);
        }
        private void bsmUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(csmID.Text);
            using (var ct = new CTDBEntities())
            {
                var s = ct.tbSpecimen.FirstOrDefault(st => st.sp_id == id);
                setDBValue(s);
                ct.SaveChanges();
                refreshdata(dataGridView1.SelectedRows[0].Index);
            }
        }
        private void bsmDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(csmID.Text);
                if (MessageBox.Show("确认删除" + id.ToString(), "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (var db = new CTDBEntities())
                    {
                        var student = db.tbSpecimen.FirstOrDefault(s => s.sp_id == id);
                        db.tbSpecimen.Remove(student);
                        db.SaveChanges();
                    }
                    refreshdata(0);
                }
            }
            catch
            {
                MessageBox.Show("记录有关联，删除失败");
            }
        }


        private void btnAddSpecies_Click(object sender, EventArgs e)
        {
            FormSpecies dlg = new FormSpecies();
            dlg.ShowDialog();
            CTDBEntities ct = new CTDBEntities();
            csmSpecies.DataSource = ct.tbSpecies.ToList<tbSpecies>();
            csmSpecies.ValueMember = "species_id";
            csmSpecies.DisplayMember = "species_latin";
            csmSpecies.SelectedIndex = csmSpecies.Items.Count - 1;
        }
        private void csmSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSpecies ts = (csmSpecies.SelectedItem as tbSpecies);
            lbSpeciesCHN.Text = ts.species_CHN + " " + ts.species_latin;
            csmNote.Text = csmSpecies.Text.Trim();
        }
        private void btnAddExample_Click(object sender, EventArgs e)
        {
            FormUpload dlg = new FormUpload();
            int id = int.Parse(csmID.Text);
            dlg.ParaDatasetID = id;
            dlg.ParaTable = "ctdb-specimen";
            dlg.ParaFileType = 11;
            if (sender is ToolStripMenuItem)
                if ((sender as ToolStripMenuItem).Name == "mitAddExample3D")
                    dlg.ParaFileType = 12;
            dlg.ShowDialog();
        }
        private void mitAddScan_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormScan dlg = new FormScan();
            int id = int.Parse(csmID.Text);
            dlg.ShowDialog();
            this.Show();
        }
        //help=====
        private void label62_DoubleClick(object sender, EventArgs e) { new About((string)((sender as Label).Tag)).ShowDialog(); }

        private void ucFileInfo1_OpenFileDialog(object sender, EventArgs e) { this.Hide(); }
        private void ucFileInfo1_UpdateFile(object sender, EventArgs e) { this.Show(); }

    }
}
