using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

//using System.Web.Script.Serialization;

namespace CTDB
{
    public partial class FormSpecies : Form
    {
        public FormSpecies() { InitializeComponent(); }
        private void FormSpecies_Activated(object sender, EventArgs e) { cspeciesNote.Focus(); }
        private void btnOK_Click(object sender, EventArgs e) { this.Close(); }

        private void CTDBFormAddSpecies_Load(object sender, EventArgs e)
        {
            CTHelper.setControlTag(cspeciesOrder, 108); //load order list
            cspeciesOrder.DisplayMember = "tag_tag";

            refreshdata(sender, e);
        }

        //operations
        /// <summary> set values </summary>
        /// <param name="s"></param>
        void setDBValue(tbSpecies s)
        {
            s.species_note = cspeciesNote.Text.Trim();
            s.species_CHN = cspeciesCHN.Text.Trim();
            s.species_latin = cspeciesLatin.Text.Trim();

            s.species_Order = cspeciesOrder.Text.Trim();
            s.species_Family = cspeciesFamily.Text.Trim();
            s.species_Genus = cspeciesGenus.Text.Trim();
            s.species_Species = cspeciesSpecies.Text.Trim();

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
            int rowid = CTHelper.GetRowIndex(dataGridView1);

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

        /// <summary>load/browser</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="rowIndex">要显示的选中的rowid， -1 </param>
        private void refreshdata(object sender, EventArgs e, int rowIndex = -1)
        {
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = FormLogin.LoadDataF("tbSpecies");
            FormLogin.SetColumn(dataGridView1, "species_id|species_latin|species_Order|species_Family|species_CHN|species_note");

            CTHelper.SetRowIndex(dataGridView1, rowIndex);
            cspeciesNote.Focus();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int rid = dataGridView1.SelectedRows[0].Index;
                int id = ((dataGridView1.DataSource as ArrayList)[rid] as tbSpecies).species_id;

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
        void autoParse(string s)
        {
            List<FormItemModel> formDatas = new List<FormItemModel>();
            formDatas.Add(new FormItemModel() { Key = "src", Value = s });
            formDatas.Add(new FormItemModel() { Key = "para", Value = "trans" });
            formDatas.Add(new FormItemModel() { Key = "vcode", Value = "iozName" });
            string r = CTHelper.PostForm(CTHelper.GetConfig("nameParseUrl"), formDatas);


            Console.Write(r);
            //MessageBox.Show(r);
            //cspeciesLatin.Text = cspeciesGenus.Text.Trim() + " " + cspeciesSpecies.Text.Trim();

            //解析
            JObject jo = JObject.Parse(r);
            if (jo.GetValue("la") != null)
            {
                string[] sl = jo.GetValue("la").ToString().Split(' ');
                cspeciesGenus.Text = sl[0];
                if (sl.Length > 1)
                    cspeciesSpecies.Text = sl[1];
            }
        }

        private void cspeciesNote_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                autoMatch(cspeciesNote.Text.Trim());
            }
        }

        private void cspeciesLatin_TextChanged(object sender, EventArgs e)
        {
            autoParse(cspeciesLatin.Text);
        }


    }
}
