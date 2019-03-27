using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CTDB
{
    public partial class FormRef : Form
    {
        public FormRef() { InitializeComponent(); }
        private void CTDBFormAddSpecies_Load(object sender, EventArgs e) { refreshdata(sender, e); }
        private void btnOK_Click(object sender, EventArgs e) { this.Close(); }

        //operations
        /// <summary> set values </summary>
        /// <param name="s"></param>
        void setDBValue(tbRef s)
        {
            s.title = refTitle.Text;
            s.url = refURL.Text;
            s.cite = refCite.Text;

            s.author = refAuthor.Text;
            s.year = int.Parse(refYear.Text);
            s.doc = refDoc.Text;

            s.UserId = Guid.Parse(CTHelper.GetConfig("userid"));
        }
        private void bSpeciesAdd_Click(object sender, EventArgs e)
        {
            tbRef s = new tbRef();
            setDBValue(s);
            CTDBEntities ct = new CTDBEntities();
            ct.tbRef.Add(s);
            ct.SaveChanges();   //将修改保存到数据库中
            refreshdata(null, null);
        }
        private void bSpeciesUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(refID.Text);
            using (var db = new CTDBEntities())
            {
                var s = db.tbRef.FirstOrDefault(st => st.ref_id == id);
                setDBValue(s);
                db.SaveChanges();
                refreshdata(null, null);
            }
        }
        private void bSpeciesDel_Click(object sender, EventArgs e)
        {
            int id = int.Parse(refID.Text);
            if (MessageBox.Show("Delete " + id.ToString(), "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
                using (var db = new CTDBEntities())
                {
                    var student = db.tbRef.FirstOrDefault(s => s.ref_id == id);
                    db.tbRef.Remove(student);    //删除萝莉
                    db.SaveChanges();
                    refreshdata(null, null);
                }
        }

        //load/browser
        private void refreshdata(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            //CTDBEntities ct = new CTDBEntities();
            //dataGridView1.DataSource = ct.tbRef.ToList<tbRef>();
            dataGridView1.DataSource = FormLogin.LoadDataA("tbRef");
            FormLogin.SetColumn(dataGridView1, "ref_id|year|cite|url");

            if (dataGridView1.Rows.Count > 0)
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                CTDBEntities ct = new CTDBEntities();
                var q = from c in ct.tbRef
                        where c.ref_id == id
                        select c;
                List<tbRef> sl = q.ToList<tbRef>();
                tbRef s = sl[0];
                {
                    refID.Text = s.ref_id.ToString();
                    refCite.Text = s.cite;
                    refTitle.Text = s.title;
                    refURL.Text = s.url;
                    refAuthor.Text = s.author;
                    refYear.Text = s.year.ToString();
                    refDoc.Text = s.doc;
                }

                string str = "";
            }
        }

        //parse names
        private void btnParse_Click(object sender, EventArgs e)
        {
            Match m = Regex.Match(refCite.Text, "(19|20)[0-9][0-9]");
            refYear.Text = m.Value.ToString();
            string[] t = refCite.Text.Split(new char[] { ',', '，', '.' });
            string title = t[0];
            foreach (string s in t)
                if (s.Length > title.Length)
                    title = s.Trim();
            refTitle.Text = title;

            refAuthor.Text = refCite.Text.Replace(title, "#").Split('#')[0].ToString().Trim();
        }


    }
}
