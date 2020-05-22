using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTerminal
{
    public partial class FrmCustoms : Form
    {
        public FrmCustoms()
        {
            InitializeComponent();
        }

        private void FrmCustoms_Shown(object sender, EventArgs e)
        {
            //treeView1.Nodes.Clear();
            ReadData(DataWorkings.Config.Items, treeView1.Nodes[0].Nodes);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node == treeView1.Nodes[0])
            {
                txtDiaChi.Text = txtHienThi.Text = txtMoTa.Text = "";
                return;
            }
            ShowNode(e.Node);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(treeView1.SelectedNode!=null)
            {
                treeView1.SelectedNode.Nodes.Add(new TreeNode()
                {
                    Text = txtHienThi.Text,
                    ToolTipText = txtMoTa.Text,
                    Tag = txtDiaChi.Text,
                });
            }
            else
            {
                treeView1.Nodes.Add(new TreeNode()
                {
                    Text = txtHienThi.Text,
                    ToolTipText = txtMoTa.Text,
                    Tag = txtDiaChi.Text,
                });
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.Text = txtHienThi.Text;
                treeView1.SelectedNode.ToolTipText = txtMoTa.Text;
                treeView1.SelectedNode.Tag = txtDiaChi.Text;
            }
            else
            {
                MessageBox.Show("Chưa chọn Node nào để sửa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode?.Remove();
        }

        private void btnXong_Click(object sender, EventArgs e)
        {
            DataWorkings.Config.Items.Clear();
            WriteData(DataWorkings.Config.Items, treeView1.Nodes[0].Nodes) ;
            DataWorkings.WriteConfig();
        }

        private void ReadData(List<CItems> lstItems, TreeNodeCollection nodes)
        {
            if(lstItems == null)
            {
                return;
            }    
            if(lstItems.Count == 0)
            {
                return;
            }    

            foreach(CItems item in lstItems)
            {
                TreeNode node = new TreeNode()
                {
                    Text = item.HT,
                    Tag = item.DC,
                    ToolTipText = item.MT,
                };
                ReadData(item.SubItems, node.Nodes);
                nodes.Add(node);
            }    
        }

        private void WriteData(List<CItems> lstItem, TreeNodeCollection nodes)
        {
            if(nodes == null)
            {
                return;
            }
            if(nodes.Count == 0)
            {
                return;
            }    
            foreach(TreeNode node in nodes)
            {
                CItems item = new CItems()
                {
                    HT = node.Text,
                    DC = node.Tag.ToString(),
                    MT = node.ToolTipText,
                };
                WriteData(item.SubItems, node.Nodes);
                lstItem.Add(item);
            }    
        }

        private void ShowNode(TreeNode node)
        {
            txtHienThi.Text = node.Text;
            txtDiaChi.Text = node.Tag.ToString();
            txtMoTa.Text = node.ToolTipText;
        }

        private void treeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            txtHienThi.Text = e.Label;
        }

        private void treeView1_BeforeLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if(e.Node == treeView1.Nodes[0])
                e.CancelEdit = true;
        }
    }
}
