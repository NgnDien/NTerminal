namespace NTerminal
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblGio = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnOpen = new System.Windows.Forms.ToolStripSplitButton();
            this.btnChucNang = new System.Windows.Forms.ToolStripSplitButton();
            this.cậpNhậtThờiGianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tùyChỉnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.safeShutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtShutdowntoolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtRestarttoolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.tmrThoiGian = new System.Windows.Forms.Timer(this.components);
            this.tmrUpdateTime = new System.Windows.Forms.Timer(this.components);
            //this.tmrShutdown = new System.Windows.Forms.Timer(this.components);
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGio
            // 
            this.lblGio.Font = new System.Drawing.Font("Anderson Four Feather Falls", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGio.Location = new System.Drawing.Point(0, 0);
            this.lblGio.Name = "lblGio";
            this.lblGio.Size = new System.Drawing.Size(100, 21);
            this.lblGio.TabIndex = 0;
            this.lblGio.Text = "21:50:59";
            this.lblGio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblGio.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.lblGio.MouseEnter += new System.EventHandler(this.FrmMain_MouseEnter);
            this.lblGio.MouseLeave += new System.EventHandler(this.FrmMain_MouseLeave);
            this.lblGio.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            this.lblGio.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseUp);
            // 
            // lblNgay
            // 
            this.lblNgay.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgay.Location = new System.Drawing.Point(0, 17);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(100, 22);
            this.lblNgay.TabIndex = 1;
            this.lblNgay.Text = "11/5/1998";
            this.lblNgay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblNgay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.lblNgay.MouseEnter += new System.EventHandler(this.FrmMain_MouseEnter);
            this.lblNgay.MouseLeave += new System.EventHandler(this.FrmMain_MouseLeave);
            this.lblNgay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            this.lblNgay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseUp);
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip.CanOverflow = false;
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.btnChucNang});
            this.toolStrip.Location = new System.Drawing.Point(100, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(36, 39);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            this.toolStrip.MouseEnter += new System.EventHandler(this.FrmMain_MouseEnter);
            this.toolStrip.MouseLeave += new System.EventHandler(this.FrmMain_MouseLeave);
            // 
            // btnOpen
            // 
            this.btnOpen.AutoSize = false;
            this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpen.Image = global::NTerminal.Properties.Resources.btnOpen;
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnOpen.Size = new System.Drawing.Size(34, 19);
            this.btnOpen.Text = "Lối tắt";
            this.btnOpen.MouseEnter += new System.EventHandler(this.FrmMain_MouseEnter);
            this.btnOpen.MouseLeave += new System.EventHandler(this.FrmMain_MouseLeave);
            // 
            // btnChucNang
            // 
            this.btnChucNang.AutoSize = false;
            this.btnChucNang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cậpNhậtThờiGianToolStripMenuItem,
            this.tùyChỉnhToolStripMenuItem,
            this.thôngTinToolStripMenuItem,
            this.toolStripSeparator2,
            this.thoátToolStripMenuItem,
            this.safeShutdownToolStripMenuItem});
            this.btnChucNang.Image = global::NTerminal.Properties.Resources.btnMenu;
            this.btnChucNang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChucNang.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.btnChucNang.Name = "btnChucNang";
            this.btnChucNang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnChucNang.Size = new System.Drawing.Size(34, 19);
            this.btnChucNang.Text = "Chức năng";
            this.btnChucNang.MouseEnter += new System.EventHandler(this.FrmMain_MouseEnter);
            this.btnChucNang.MouseLeave += new System.EventHandler(this.FrmMain_MouseLeave);
            // 
            // cậpNhậtThờiGianToolStripMenuItem
            // 
            this.cậpNhậtThờiGianToolStripMenuItem.Name = "cậpNhậtThờiGianToolStripMenuItem";
            this.cậpNhậtThờiGianToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.cậpNhậtThờiGianToolStripMenuItem.Text = "Cậ&p nhật thời gian";
            this.cậpNhậtThờiGianToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtThờiGianToolStripMenuItem_Click);
            // 
            // tùyChỉnhToolStripMenuItem
            // 
            this.tùyChỉnhToolStripMenuItem.Name = "tùyChỉnhToolStripMenuItem";
            this.tùyChỉnhToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.tùyChỉnhToolStripMenuItem.Text = "Tùy &chỉnh";
            this.tùyChỉnhToolStripMenuItem.Click += new System.EventHandler(this.TùyChỉnhToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.thôngTinToolStripMenuItem.Text = "Thông t&in";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(169, 6);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.thoátToolStripMenuItem.Text = "&Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.ThoátToolStripMenuItem_Click);
            // 
            // safeShutdownToolStripMenuItem
            // 
            this.safeShutdownToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shutDownToolStripMenuItem,
            this.restartToolStripMenuItem});
            this.safeShutdownToolStripMenuItem.Name = "safeShutdownToolStripMenuItem";
            this.safeShutdownToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.safeShutdownToolStripMenuItem.Text = "&Safe Shutdown";
            // 
            // shutDownToolStripMenuItem
            // 
            this.shutDownToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtShutdowntoolStripTextBox});
            this.shutDownToolStripMenuItem.Name = "shutDownToolStripMenuItem";
            this.shutDownToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.shutDownToolStripMenuItem.Text = "&Shut down";
            this.shutDownToolStripMenuItem.Click += new System.EventHandler(this.shutDownToolStripMenuItem_Click);
            // 
            // txtShutdowntoolStripTextBox
            // 
            this.txtShutdowntoolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtShutdowntoolStripTextBox.Name = "txtShutdowntoolStripTextBox";
            this.txtShutdowntoolStripTextBox.Size = new System.Drawing.Size(100, 23);
            this.txtShutdowntoolStripTextBox.KeyPress += this.TxtShutdowntoolStripTextBox_KeyPress;
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtRestarttoolStripTextBox});
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.restartToolStripMenuItem.Text = "&Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // txtRestarttoolStripTextBox
            // 
            this.txtRestarttoolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRestarttoolStripTextBox.Name = "txtRestarttoolStripTextBox";
            this.txtRestarttoolStripTextBox.Size = new System.Drawing.Size(100, 23);
            this.txtRestarttoolStripTextBox.KeyPress += this.TxtRestarttoolStripTextBox_KeyPress;
            // 
            // tmrThoiGian
            // 
            this.tmrThoiGian.Interval = 999;
            this.tmrThoiGian.Tick += new System.EventHandler(this.TmrThoiGian_Tick);
            // 
            // tmrUpdateTime
            // 
            this.tmrUpdateTime.Interval = 900000;
            this.tmrUpdateTime.Tick += new System.EventHandler(this.TmrUpdateTime_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(136, 39);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.lblNgay);
            this.Controls.Add(this.lblGio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Opacity = 0.2D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NTerminal";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.MouseEnter += new System.EventHandler(this.FrmMain_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.FrmMain_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseUp);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGio;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripSplitButton btnChucNang;
        private System.Windows.Forms.ToolStripMenuItem tùyChỉnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Timer tmrThoiGian;
        private System.Windows.Forms.Timer tmrUpdateTime;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSplitButton btnOpen;
        private System.Windows.Forms.ToolStripMenuItem safeShutdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shutDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtRestarttoolStripTextBox;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtShutdowntoolStripTextBox;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtThờiGianToolStripMenuItem;
        private System.Windows.Forms.Timer tmrShutdown;
    }
}

