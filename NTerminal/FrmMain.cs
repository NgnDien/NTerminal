using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace NTerminal
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
                                                           

        private DateTime _thoigian;
        private DateTime ThoiGian
        {
            set
            {
                if(InvokeRequired)
                {
                    Invoke((MethodInvoker)delegate
                    {
                        lblNgay.Text = value.ToString("dd/MM/yyyy");
                        lblGio.Text = value.ToString("HH:mm:ss");
                    });
                }
                else
                {
                    lblNgay.Text = value.ToString("dd/MM/yyyy");
                    lblGio.Text = value.ToString("HH:mm:ss");
                }
                _thoigian = value;
            }
            get
            {
                return _thoigian;
            }
        }

        private void LoadCfg()
        {
            //hiển thị ngày giờ hiện tại
            ThoiGian = DateTime.Now;
            tmrThoiGian.Enabled = true ;
            tmrUpdateTime.Enabled = true;

            //đọc cấu hình từ file cfg
            DataWorkings.Config = CJsonWorkings.Read(typeof(CConfigs), DataWorkings.FileConfig) as CConfigs;
            if(DataWorkings.Config != null)
            {
                AddItem(btnOpen.DropDownItems, DataWorkings.Config.Items);
                this.Location = DataWorkings.Config.FML;
            }
            else
            {
                DataWorkings.Config = new CConfigs();
            }

        }

        private void AddItem(ToolStripItemCollection menu, List<CItems> items)
        {
            if(items == null)
            {
                return;
            }
            if(items.Count == 0)
            {
                return;
            }
            foreach(CItems item in items)
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem()
                {
                    Text = item.HT,
                    Tag = item.DC,
                    ToolTipText = item.MT,
                };
                menuItem.MouseDown += Item_Click;
                AddItem(menuItem.DropDownItems, item.SubItems);
                menu.Add(menuItem);
            }
        }

        private string DirPathOf(string path)
        {
            if(path.Length>3)
            {
                return path.Substring(0, path.LastIndexOf('\\'));
            }
            else
            {
                return path;
            }
        }

        #region Move form
        int x0, y0;

        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button != MouseButtons.Left)
                return;
            x0 = e.X;
            y0 = e.Y;
        }
        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button != MouseButtons.Left)
                return;
            Left += (e.X - x0);
            Top += (e.Y - y0);
        }

        private void FrmMain_MouseUp(object sender, MouseEventArgs e)
        {
            DataWorkings.Config.FML = this.Location;
            DataWorkings.WriteConfig();
        }
        #endregion Move form

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            LoadCfg(); 
        }

        private void TmrThoiGian_Tick(object sender, EventArgs e)
        {
            ThoiGian = ThoiGian.AddSeconds(1);
        }

        private void TmrUpdateTime_Tick(object sender, EventArgs e)
        {
            if(tmrThoiGian.Enabled)
            {
                ThoiGian = DateTime.Now;
            }
        }

        private void FrmMain_MouseEnter(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void FrmMain_MouseLeave(object sender, EventArgs e)
        {
            this.Opacity = 0.2;
        }

        private void TùyChỉnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(FrmCustoms frmCustoms = new FrmCustoms())
            {
                if(frmCustoms.ShowDialog() == DialogResult.OK)
                {
                    //đọc dữ liệu của config.Items rồi chèn vào btnOpen.Items
                    AddItem(btnOpen.DropDownItems, DataWorkings.Config.Items);
                }    
            }    
        }

        private void Item_Click(object sender, MouseEventArgs e)
        {
            switch(e.Button)
            {
                case MouseButtons.Left:
                    {
                        try
                        {
                            if(Directory.Exists((sender as ToolStripMenuItem)?.Tag.ToString()))
                            {
                                Process.Start("explorer", $"\"{(sender as ToolStripMenuItem)?.Tag.ToString()}\"");
                                return;
                            }
                            if(File.Exists((sender as ToolStripMenuItem)?.Tag.ToString()))
                            {
                                Process.Start("explorer", $"\"{(sender as ToolStripMenuItem)?.Tag.ToString()}\"");
                                return;
                            }
                            MessageBox.Show($"Thư mục hoặc tệp tin không tồn tại\n{(sender as ToolStripMenuItem)?.Tag.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                        catch
                        {
                            MessageBox.Show("Không thể mở {(sender as ToolStripMenuItem)?.Tag.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }  
                        break;
                    }
                case MouseButtons.Right:
                    {
                        try
                        {
                            if(Directory.Exists((sender as ToolStripMenuItem)?.Tag.ToString()))
                            {
                                Process.Start("explorer", $"\"{DirPathOf((sender as ToolStripMenuItem)?.Tag.ToString())}\"");
                                return;
                            }
                            if(File.Exists((sender as ToolStripMenuItem)?.Tag.ToString()))
                            {
                                Process.Start("explorer", $"\"{DirPathOf((sender as ToolStripMenuItem)?.Tag.ToString())}\"");
                                return;
                            }
                            MessageBox.Show($"Thư mục hoặc tập tin không tồn tại\n{(sender as ToolStripMenuItem)?.Tag.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                        catch
                        {
                            MessageBox.Show("Không thể mở thư mục chứa {(sender as ToolStripMenuItem)?.Tag.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                        break;
                    }
                default:
                    {
                        return;
                    }
            }    
            
             
        }

        private void ThoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by NgnDien with C# base .Net Framework 4.7.1\nSource code: GitHub.com/NgnDien/NTerminal", "About", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        

    }
}
