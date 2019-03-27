using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CTDB
{
    public partial class FormEquipment : Form
    {
        public FormEquipment() { InitializeComponent(); }
        private void btnOK_Click(object sender, EventArgs e) { this.Close(); }
        private void CTDBFormAddSpecies_Load(object sender, EventArgs e) { refrashDataGridview(sender, e); }

        private void refrashDataGridview(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            CTDBEntities ct = new CTDBEntities();
            dataGridView1.DataSource = ct.tbEquipment.ToList<tbEquipment>();
            FormLogin.SetColumn(dataGridView1, "e_id|e_nameA|e_location|e_note");
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                //int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

                int rid = dataGridView1.SelectedRows[0].Index;
                int id = ((dataGridView1.DataSource as List<tbEquipment>)[rid] as tbEquipment).e_id;

                CTDBEntities ct = new CTDBEntities();
                var q = from c in ct.tbEquipment where c.e_id == id select c;
                tbEquipment s = q.ToList<tbEquipment>()[0];
                ceID.Text = s.e_id.ToString();
                ceNameA.Text = s.e_nameA;
                ceName.Text = s.e_name;
                ceNote.Text = s.e_note;
                ceLocation.Text = s.e_location;
                ceType.Text = s.e_type;
                ceContact.Text = s.e_contact;
                ceDescription.Text = s.e_description;

            }
        }


        //equipment
        private void beAdd_Click(object sender, EventArgs e)
        {
            var s = new tbEquipment();
            s.e_nameA = ceNameA.Text;
            s.e_name = ceName.Text;
            s.e_note = ceNote.Text;
            s.e_location = ceLocation.Text;
            s.e_type = ceType.Text;
            s.e_description = ceDescription.Text;
            s.date_in = DateTime.Now;
            s.e_contact = ceContact.Text;

            s.UserId = Guid.Parse(CTHelper.GetConfig("userid"));

            CTDBEntities ct = new CTDBEntities();
            ct.tbEquipment.Add(s);
            ct.SaveChanges();   //将修改保存到数据库中
            refrashDataGridview(null, null);
        }
        private void beUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(ceID.Text);
            CTDBEntities db = new CTDBEntities();
            var s = db.tbEquipment.FirstOrDefault(st => st.e_id == id);
            s.e_nameA = ceNameA.Text;
            s.e_name = ceName.Text;
            s.e_note = ceNote.Text;
            s.e_location = ceLocation.Text;
            s.e_type = ceType.Text;
            s.e_description = ceDescription.Text;
            s.e_contact = ceContact.Text;
            s.UserId = Guid.Parse(CTHelper.GetConfig("userid"));
            db.SaveChanges();
            refrashDataGridview(null, null);
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(ceID.Text);
                if (CTHelper.AlertYes("Delete " + id.ToString()))
                    using (var db = new CTDBEntities())
                    {
                        var student = db.tbEquipment.FirstOrDefault(s => s.e_id == id);
                        db.tbEquipment.Remove(student);    //删除
                        db.SaveChanges();
                        refrashDataGridview(null, null);
                    }
            }
            catch { MessageBox.Show("Fail to delete, there is related data in database!"); }
        }


    }
}
