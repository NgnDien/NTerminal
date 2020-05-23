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
using System.Xml.Serialization;
using System.Threading;

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

        private void SafeShutdown(eShutdownState state, int minuteTimeout)
        {
            Program.ShutdownState = state;
            if(minuteTimeout != 0)
            {
                tmrShutdown = new System.Windows.Forms.Timer()
                {
                    Interval = minuteTimeout * 60000,
                };
                tmrShutdown.Tick += TmrShutdown_Tick;
                tmrShutdown.Tag = 0;
                tmrShutdown.Enabled = true;
                MessageBox.Show($"Máy tính sẽ {state} sau {minuteTimeout} phút nữa");
            }
            else
            {
                TimeOut();
            }
        }

        private void TmrShutdown_Tick(object sender, EventArgs e)
        {
            if((int)tmrShutdown.Tag == 1)
            {
                tmrShutdown.Stop();
                TimeOut();
            }
            tmrShutdown.Tag = (int)tmrShutdown.Tag + 1;
        }

        private void TimeOut()
        {
            this.Close();
        }

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
            if((sender as ToolStripMenuItem)?.Tag?.ToString() != "")
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
             
        }

        private void ThoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by NgnDien with C# base .Net Framework 4.7.1\nSource code: GitHub.com/NgnDien/NTerminal", "About", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void cậpNhậtThờiGianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThoiGian = DateTime.Now;
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SafeShutdown(eShutdownState.Restart, 0);
        }

        private void shutDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SafeShutdown(eShutdownState.Shutdown, 0);
        }

        private void TxtShutdowntoolStripTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar != (char)13)
            {
                return;
            }
            try
            {
                SafeShutdown(eShutdownState.Shutdown, int.Parse(txtShutdowntoolStripTextBox.Text));
            }
            catch
            {
                SafeShutdown(eShutdownState.Shutdown, 0);
            }
        }

        private void TxtRestarttoolStripTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar != (char)13)
                return;
            try
            {
                SafeShutdown(eShutdownState.Restart, int.Parse(txtRestarttoolStripTextBox.Text));
            }
            catch
            {
                SafeShutdown(eShutdownState.Restart, 0);
            }
        }
    }
}
