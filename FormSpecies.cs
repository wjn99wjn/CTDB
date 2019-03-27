using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

//using System.Web.Script.Serialization;

namespace CTDB
{
    public partial class FormSpecies : Form
    {
        public FormSpecies() { InitializeComponent(); }
        private void FormSpecies_Activated(object sender, EventArgs e) { cspeciesNote.Focus(); }
        private void CTDBFormAddSpecies_Load(object sender, EventArgs e) { refreshdata(sender, e); }
        private void btnOK_Click(object sender, EventArgs e) { this.Close(); }

        //operations
        /// <summary> set values </summary>
        /// <param name="s"></param>
        void setDBValue(tbSpecies s)
        {
            s.species_note = cspeciesNote.Text;
            s.species_CHN = cspeciesCHN.Text;
            s.species_latin = cspeciesLatin.Text;

            s.species_Order = cspeciesOrder.Text;
            s.species_Family = cspeciesFamily.Text;
            s.species_Genus = cspeciesGenus.Text;
            s.species_Species = cspeciesSpecies.Text;

            s.species_LSID = "-";
            s.date_in = DateTime.Now;
            s.UserId = Guid.Parse(CTHelper.GetConfig("userid"));
        }
        private void bSpeciesAdd_Click(object sender, EventArgs e)
        {
            tbSpecies s = new tbSpecies();
            setDBValue(s);
            CTDBEntities ct = new CTDBEntities();
            ct.tbSpecies.Add(s);
            ct.SaveChanges();   //将修改保存到数据库中
            refreshdata(null, null, (dataGridView1.DataSource as List<tbSpecies>).Count);
        }
        private void bSpeciesUpdate_Click(object sender, EventArgs e)
        {
            int rowid = -1;
            if (dataGridView1.SelectedRows.Count == 1)
                rowid = dataGridView1.SelectedRows[0].Index;

            int id = int.Parse(cspeciesID.Text);
            using (var db = new CTDBEntities())
            {
                var s = db.tbSpecies.FirstOrDefault(st => st.species_id == id);
                setDBValue(s);
                db.SaveChanges();
                MessageBox.Show(id + " Updated!");
                refreshdata(null, null, rowid);
            }
        }
        private void bSpeciesDel_Click(object sender, EventArgs e)
        {
            int id = int.Parse(cspeciesID.Text);
            if (MessageBox.Show("Delete " + id.ToString(), "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
                using (var db = new CTDBEntities())
                {
                    var student = db.tbSpecies.FirstOrDefault(s => s.species_id == id);
                    db.tbSpecies.Remove(student);    //删除萝莉
                    db.SaveChanges();
                    refreshdata(null, null);
                }
        }

        //load/browser
        private void refreshdata(object sender, EventArgs e, int rowIndex = -1)
        {
            dataGridView1.DataSource = null;
            CTDBEntities ct = new CTDBEntities();
            dataGridView1.DataSource = ct.tbSpecies.ToList<tbSpecies>();
            if (dataGridView1.DataSource != null)
                if (rowIndex > 0)
                {
                    dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
                    dataGridView1.Rows[rowIndex].Selected = true;
                }
            cspeciesNote.Focus();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                CTDBEntities ct = new CTDBEntities();
                var q = from c in ct.tbSpecies
                        where c.species_id == id
                        select c;
                List<tbSpecies> sl = q.ToList<tbSpecies>();
                tbSpecies s = sl[0];
                {
                    cspeciesID.Text = s.species_id.ToString();
                    cspeciesNote.Text = s.species_note;
                    cspeciesLatin.Text = s.species_latin;
                    cspeciesCHN.Text = s.species_CHN;
                    cspeciesOrder.Text = s.species_Order;
                    cspeciesFamily.Text = s.species_Family;
                    cspeciesGenus.Text = s.species_Genus;
                    cspeciesSpecies.Text = s.species_Species;
                }

                string str = "";
                //str += ct.tbSpecimen.Where(c => c.species_id == s.species_id).Count<tbSpecimen>() ;
                lbSPcount.Text = ct.tbSpecimen.Where(c => c.species_id == s.species_id).Count<tbSpecimen>().ToString();
            }
        }


        private void cspeciesNote_TextChanged(object sender, EventArgs e)
        {
            //cspeciesLatin.Text = cspeciesGenus.Text.Trim() + " " + cspeciesSpecies.Text.Trim();
        }

        void autoMatch(string s)
        {
            List<FormItemModel> formDatas = new List<FormItemModel>();
            formDatas.Add(new FormItemModel() { Key = "sstring", Value = s });
            formDatas.Add(new FormItemModel() { Key = "para", Value = "ct" });
            formDatas.Add(new FormItemModel() { Key = "vcode", Value = "cts" });
            string r = CTHelper.PostForm(CTHelper.GetConfig("namesearchurl"), formDatas);
            Console.Write(r);
            //MessageBox.Show(r);
            //cspeciesLatin.Text = cspeciesGenus.Text.Trim() + " " + cspeciesSpecies.Text.Trim();

            //解析
            JObject jo = JObject.Parse(r);
            if (jo.GetValue("error_code").ToString() == "0")
                if (jo.GetValue("data_count").ToString() != "0")
                {
                    string datastr = jo.GetValue("data").ToString();
                    DataTable dt = Newtonsoft.Json.JsonConvert.DeserializeObject<DataTable>(datastr);

                    //MessageBox.Show(dt.Rows[0][0].ToString());
                    cspeciesCHN.Text = dt.Rows[0]["tag_tag"].ToString();
                    cspeciesLatin.Text = dt.Rows[0]["tag_En"].ToString();

                }
        }

        private void cspeciesNote_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                autoMatch(cspeciesNote.Text.Trim());
            }
        }

    }
}
