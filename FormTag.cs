using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CTDB
{
    public partial class FormTag : Form
    {
        public FormTag() { InitializeComponent(); }

        CTDBEntities ct = new CTDBEntities();
        private void btnOK_Click(object sender, EventArgs e) { this.Close(); }
        private void CTDBFormAddSpecies_Load(object sender, EventArgs e) { refreshdata(); }



        private void bTagAdd_Click(object sender, EventArgs e)
        {
            var s = new tbTag();

            s.tag_tag = ctagTag.Text;
            s.tag_tagCN = ctagCHN.Text;
            s.tag_note = ctagNote.Text;
            s.tag_type = 0;
            s.tag_pid = 8;
            s.date_in = DateTime.Now;

            ct.tbTag.Add(s);
            ct.SaveChanges();   //将修改保存到数据库中
            refreshdata();
        }
        private void bTagDel_Click(object sender, EventArgs e)
        {
            int id = int.Parse(ctagID.Text);
            if (MessageBox.Show("确认删除" + id.ToString(), "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    using (var db = new CTDBEntities())
                    {
                        var student = db.tbTag.FirstOrDefault(s => s.tag_id == id);
                        db.tbTag.Remove(student);    //删除
                        db.SaveChanges();
                        refreshdata();
                    }
                }
                catch (Exception eeee)
                { MessageBox.Show("Error." + eeee.ToString()); }
        }
        private void bTagUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(ctagID.Text);
            //try
            {
                var s = ct.tbTag.FirstOrDefault(st => st.tag_id == id);
                s.tag_tagCN = ctagCHN.Text;
                s.tag_note = ctagNote.Text;
                s.tag_tag = ctagTag.Text;
                ct.SaveChanges();
                refreshdata();
            }

        }


        //browser
        private void refreshdata()
        {
            dataGridView1.DataSource = ct.tbTag.ToList<tbTag>();
            loadTreeview();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                var q = from c in ct.tbTag
                        where c.tag_id == id
                        select c;
                List<tbTag> sl = q.ToList<tbTag>();
                tbTag s = sl[0];
                //foreach (tbSpecies s in q)
                {
                    ctagID.Text = s.tag_id.ToString();
                    ctagCHN.Text = s.tag_tagCN;
                    ctagNote.Text = s.tag_note;
                    ctagTag.Text = s.tag_tag;
                    ctagPID.Text = s.tag_pid.ToString();
                }
            }
        }



        private void loadTreeview()
        {
            var list = from c in ct.tbTag where c.tag_pid == 0 select c;
            //var list = from c in ct.tbTag where c.tag_pid == 0 select c;
            treeView1.Nodes.Clear();
            foreach (tbTag tag in list)
            {
                TreeNode tn = new TreeNode();
                addNote(tn, tag);
                treeView1.Nodes.Add(tn);
            }
            treeView1.HideSelection = false;
        }

        public string UserId { get; set; }
        public int SourceID { get; set; }

        private void addNote(TreeNode tn, tbTag tag)
        {
            tn.Name = tag.tag_id.ToString();
            tn.Text = tag.tag_tag;

            //if (tag.TagType.ID == "1")
            //    tn.ForeColor = Color.Red;
            //if (tag.TagType.ID == "9")
            //    tn.ForeColor = Color.Green;

            var list = from c in ct.tbTag where c.tag_pid == tag.tag_id select c;
            foreach (tbTag tagc in list)
            {
                TreeNode node = new TreeNode();
                addNote(node, tagc);
                tn.Nodes.Add(node);
            }
        }
        //private void loadGridview()
        //{
        //    var list = from c in ct.tbTag where c.tag_pid == tag.tag_id select c;
        //    dataGridView1.DataSource = ct.getTagsBySourceID(SourceID);
        //    dataGridView1.Columns[0].Width = 30;
        //}

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //tTag vtag = bmdb.getTagByID(e.Node.Name);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                if (dataGridView1.Rows[i].Cells["tag_id"].Value.ToString() == e.Node.Name)
                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)this.dataGridView1.SelectedRows[0].Cells["tag_id"].Value;
            //tbTag vtag = ct.getTagByID(id);

            tbTag vtag = ct.tbTag.Where(c => c.tag_id == id).Single();
            TreeNode[] tns = treeView1.Nodes.Find(vtag.tag_id.ToString(), true);
            treeView1.CollapseAll();
            treeView1.SelectedNode = tns[0];
        }


        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {
            //return;
            //为TreeView 控件 DragDrop事件定义处理方法
            //获得用户拖拽的 TreeNode节点 
            TreeNode OriginationNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");
            //使用 PointToClient方法将屏幕鼠标的坐标换成在TreeView工作区的坐标 
            Point pt = ((TreeView)sender).PointToClient(new Point(e.X, e.Y));
            TreeNode DestinationNode = ((TreeView)sender).GetNodeAt(pt);     //确定将 TreeNode节点拖拽到哪一个节点下 
            //确定此实例中存储的数据是否与 System.Windows.Forms.TreeNode关联 
            if (OriginationNode.Name == DestinationNode.Name) return;

            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode", false))
            {
                TreeNode TestNode = DestinationNode;
                //父节点不能拖拽至其子孙类节点下,并且用户拖拽的节点 跟目标节点不能是同一个,否则给出警告信息并直接返回
                while (TestNode != TestNode.TreeView.TopNode)
                {
                    if (TestNode == OriginationNode)
                    {
                        MessageBox.Show("Node can't become its child's child!");
                        return;
                    }
                    TestNode = TestNode.Parent;
                    if (TestNode == null)
                        break;
                }

                //动作
                if (e.Effect == DragDropEffects.Copy)
                {
                }
                else
                {
                    label1.Text = "Moved!";
                    OriginationNode.Remove();
                    //if (tagp != null)
                    //    tTag.DeleteTagRelationship(tag.ID, tagp.ID, this.UserId);
                    DestinationNode.Nodes.Add(OriginationNode);
                    //tbTag t = ct.getTagByID(OriginationNode.Name);
                    int tid = int.Parse(OriginationNode.Name);
                    tbTag t = ct.tbTag.Where(c => c.tag_id == tid).Single();

                    t.tag_pid = int.Parse(DestinationNode.Name);
                    t.tag_type = t.tag_pid;// = int.Parse(DestinationNode.Name);

                    ct.SaveChanges();
                }
            }
        }
        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {
            //为两个 TreeView控件定义 DragEnter事件的处理方法 确定此实例中存储的数据是否与 System.Windows.Forms.TreeNode关联 
            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode"))
            {
                //如在拖拽过程中 ctrl键一直按下，则表示拷贝操作，否则为移动操作 
                if (Control.ModifierKeys == Keys.Control)
                    e.Effect = DragDropEffects.Copy;
                else
                    e.Effect = DragDropEffects.Move;
            }
            else
                e.Effect = DragDropEffects.None;
            label1.Text = e.Effect.ToString();
        }
        private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (((TreeView)sender).SelectedNode != ((TreeView)sender).TopNode)
                if (e.Button == MouseButtons.Left)
                {
                    //if ( IsPicNode(((TreeView)sender).SelectedNode))
                    DoDragDrop(e.Item, DragDropEffects.Move | DragDropEffects.Copy);
                    //DoDragDrop(e.Item, DragDropEffects.Move | DragDropEffects.Copy);
                }
        }

    }
}
