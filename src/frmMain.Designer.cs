namespace WindowsFormsApplication1
{
    partial class frmMain
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
            if (disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ntfIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openCloseEmulatorConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpControllerListener = new System.Windows.Forms.GroupBox();
            this.chkController4 = new System.Windows.Forms.CheckBox();
            this.chkController3 = new System.Windows.Forms.CheckBox();
            this.chkController2 = new System.Windows.Forms.CheckBox();
            this.chkController1 = new System.Windows.Forms.CheckBox();
            this.imgGuide = new System.Windows.Forms.PictureBox();
            this.grpKodi = new System.Windows.Forms.GroupBox();
            this.Kodi_Controller_Config = new br.com.pgnSoft.Games.XBOX360_Controller();
            this.chkKodiStart = new System.Windows.Forms.CheckBox();
            this.imgKodiLogo = new System.Windows.Forms.PictureBox();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.grpCloseEmulators = new System.Windows.Forms.GroupBox();
            this.Emulator_Controller_Config = new br.com.pgnSoft.Games.XBOX360_Controller();
            this.chkCloseEmulators = new System.Windows.Forms.CheckBox();
            this.imgEmulator = new System.Windows.Forms.PictureBox();
            this.pnlTopDock = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTopDock_Left = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ctxMenu.SuspendLayout();
            this.grpControllerListener.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgGuide)).BeginInit();
            this.grpKodi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgKodiLogo)).BeginInit();
            this.pnlContainer.SuspendLayout();
            this.grpCloseEmulators.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgEmulator)).BeginInit();
            this.pnlTopDock.SuspendLayout();
            this.pnlTopDock_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // ntfIcon
            // 
            this.ntfIcon.ContextMenuStrip = this.ctxMenu;
            this.ntfIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfIcon.Icon")));
            this.ntfIcon.Text = "Close Emulator";
            this.ntfIcon.Visible = true;
            this.ntfIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ntfIcon_MouseDoubleClick);
            // 
            // ctxMenu
            // 
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCloseEmulatorConfigToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(229, 54);
            // 
            // openCloseEmulatorConfigToolStripMenuItem
            // 
            this.openCloseEmulatorConfigToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.openCloseEmulatorConfigToolStripMenuItem.Name = "openCloseEmulatorConfigToolStripMenuItem";
            this.openCloseEmulatorConfigToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.openCloseEmulatorConfigToolStripMenuItem.Text = "Open Close Emulator Config";
            this.openCloseEmulatorConfigToolStripMenuItem.Click += new System.EventHandler(this.openCloseEmulatorConfigToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(225, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // grpControllerListener
            // 
            this.grpControllerListener.Controls.Add(this.chkController4);
            this.grpControllerListener.Controls.Add(this.chkController3);
            this.grpControllerListener.Controls.Add(this.chkController2);
            this.grpControllerListener.Controls.Add(this.chkController1);
            this.grpControllerListener.Controls.Add(this.imgGuide);
            this.grpControllerListener.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpControllerListener.Location = new System.Drawing.Point(8, 8);
            this.grpControllerListener.Margin = new System.Windows.Forms.Padding(8);
            this.grpControllerListener.Name = "grpControllerListener";
            this.grpControllerListener.Size = new System.Drawing.Size(640, 128);
            this.grpControllerListener.TabIndex = 4;
            this.grpControllerListener.TabStop = false;
            this.grpControllerListener.Text = "Listen to these XBox Controllers : ";
            // 
            // chkController4
            // 
            this.chkController4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkController4.AutoSize = true;
            this.chkController4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkController4.Location = new System.Drawing.Point(360, 93);
            this.chkController4.Name = "chkController4";
            this.chkController4.Size = new System.Drawing.Size(77, 17);
            this.chkController4.TabIndex = 4;
            this.chkController4.Text = "Controller 4";
            this.chkController4.UseVisualStyleBackColor = true;
            this.chkController4.CheckedChanged += new System.EventHandler(this.chkController4_CheckedChanged);
            // 
            // chkController3
            // 
            this.chkController3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkController3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkController3.Location = new System.Drawing.Point(137, 93);
            this.chkController3.Name = "chkController3";
            this.chkController3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkController3.Size = new System.Drawing.Size(130, 17);
            this.chkController3.TabIndex = 3;
            this.chkController3.Text = "Controller 3";
            this.chkController3.UseVisualStyleBackColor = true;
            this.chkController3.CheckedChanged += new System.EventHandler(this.chkController3_CheckedChanged);
            // 
            // chkController2
            // 
            this.chkController2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkController2.AutoSize = true;
            this.chkController2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkController2.Location = new System.Drawing.Point(360, 33);
            this.chkController2.Name = "chkController2";
            this.chkController2.Size = new System.Drawing.Size(77, 17);
            this.chkController2.TabIndex = 2;
            this.chkController2.Text = "Controller 2";
            this.chkController2.UseVisualStyleBackColor = true;
            this.chkController2.CheckedChanged += new System.EventHandler(this.chkController2_CheckedChanged);
            // 
            // chkController1
            // 
            this.chkController1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkController1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkController1.Location = new System.Drawing.Point(137, 33);
            this.chkController1.Name = "chkController1";
            this.chkController1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkController1.Size = new System.Drawing.Size(130, 17);
            this.chkController1.TabIndex = 1;
            this.chkController1.Text = "Controller 1";
            this.chkController1.UseVisualStyleBackColor = true;
            this.chkController1.CheckedChanged += new System.EventHandler(this.chkController1_CheckedChanged);
            // 
            // imgGuide
            // 
            this.imgGuide.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imgGuide.Image = global::br.com.pgnSoft.Games.Properties.Resources.GBNNNN;
            this.imgGuide.Location = new System.Drawing.Point(290, 48);
            this.imgGuide.Name = "imgGuide";
            this.imgGuide.Size = new System.Drawing.Size(43, 43);
            this.imgGuide.TabIndex = 0;
            this.imgGuide.TabStop = false;
            // 
            // grpKodi
            // 
            this.grpKodi.Controls.Add(this.Kodi_Controller_Config);
            this.grpKodi.Controls.Add(this.chkKodiStart);
            this.grpKodi.Controls.Add(this.imgKodiLogo);
            this.grpKodi.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpKodi.Location = new System.Drawing.Point(8, 136);
            this.grpKodi.Margin = new System.Windows.Forms.Padding(8);
            this.grpKodi.Name = "grpKodi";
            this.grpKodi.Size = new System.Drawing.Size(640, 385);
            this.grpKodi.TabIndex = 5;
            this.grpKodi.TabStop = false;
            this.grpKodi.Text = "Kodi Open";
            // 
            // Kodi_Controller_Config
            // 
            this.Kodi_Controller_Config.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Kodi_Controller_Config.Location = new System.Drawing.Point(122, 23);
            this.Kodi_Controller_Config.Name = "Kodi_Controller_Config";
            this.Kodi_Controller_Config.Size = new System.Drawing.Size(500, 352);
            this.Kodi_Controller_Config.TabIndex = 6;
            // 
            // chkKodiStart
            // 
            this.chkKodiStart.AutoSize = true;
            this.chkKodiStart.Checked = true;
            this.chkKodiStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkKodiStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkKodiStart.Location = new System.Drawing.Point(9, 0);
            this.chkKodiStart.Name = "chkKodiStart";
            this.chkKodiStart.Size = new System.Drawing.Size(171, 17);
            this.chkKodiStart.TabIndex = 5;
            this.chkKodiStart.Text = "Start Kodi with XBOX Controller";
            this.chkKodiStart.UseVisualStyleBackColor = true;
            this.chkKodiStart.CheckedChanged += new System.EventHandler(this.chkKodiStart_CheckedChanged);
            // 
            // imgKodiLogo
            // 
            this.imgKodiLogo.BackgroundImage = global::br.com.pgnSoft.Games.Properties.Resources.kodi;
            this.imgKodiLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgKodiLogo.Location = new System.Drawing.Point(12, 23);
            this.imgKodiLogo.Name = "imgKodiLogo";
            this.imgKodiLogo.Size = new System.Drawing.Size(100, 75);
            this.imgKodiLogo.TabIndex = 0;
            this.imgKodiLogo.TabStop = false;
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.Controls.Add(this.grpCloseEmulators);
            this.pnlContainer.Controls.Add(this.grpKodi);
            this.pnlContainer.Controls.Add(this.grpControllerListener);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 100);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Padding = new System.Windows.Forms.Padding(8);
            this.pnlContainer.Size = new System.Drawing.Size(673, 298);
            this.pnlContainer.TabIndex = 6;
            // 
            // grpCloseEmulators
            // 
            this.grpCloseEmulators.Controls.Add(this.Emulator_Controller_Config);
            this.grpCloseEmulators.Controls.Add(this.chkCloseEmulators);
            this.grpCloseEmulators.Controls.Add(this.imgEmulator);
            this.grpCloseEmulators.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCloseEmulators.Location = new System.Drawing.Point(8, 521);
            this.grpCloseEmulators.Margin = new System.Windows.Forms.Padding(8);
            this.grpCloseEmulators.Name = "grpCloseEmulators";
            this.grpCloseEmulators.Size = new System.Drawing.Size(640, 385);
            this.grpCloseEmulators.TabIndex = 6;
            this.grpCloseEmulators.TabStop = false;
            this.grpCloseEmulators.Text = "Kodi Open";
            // 
            // Emulator_Controller_Config
            // 
            this.Emulator_Controller_Config.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Emulator_Controller_Config.Location = new System.Drawing.Point(122, 23);
            this.Emulator_Controller_Config.Name = "Emulator_Controller_Config";
            this.Emulator_Controller_Config.Size = new System.Drawing.Size(500, 352);
            this.Emulator_Controller_Config.TabIndex = 6;
            // 
            // chkCloseEmulators
            // 
            this.chkCloseEmulators.AutoSize = true;
            this.chkCloseEmulators.Checked = true;
            this.chkCloseEmulators.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCloseEmulators.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chkCloseEmulators.Location = new System.Drawing.Point(9, 0);
            this.chkCloseEmulators.Name = "chkCloseEmulators";
            this.chkCloseEmulators.Size = new System.Drawing.Size(241, 17);
            this.chkCloseEmulators.TabIndex = 5;
            this.chkCloseEmulators.Text = "Close openned emullator with XBOX Controller";
            this.chkCloseEmulators.UseVisualStyleBackColor = true;
            this.chkCloseEmulators.CheckedChanged += new System.EventHandler(this.chkCloseEmulators_CheckedChanged);
            // 
            // imgEmulator
            // 
            this.imgEmulator.BackgroundImage = global::br.com.pgnSoft.Games.Properties.Resources.ControllerIcon;
            this.imgEmulator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgEmulator.Location = new System.Drawing.Point(24, 24);
            this.imgEmulator.Name = "imgEmulator";
            this.imgEmulator.Size = new System.Drawing.Size(75, 75);
            this.imgEmulator.TabIndex = 0;
            this.imgEmulator.TabStop = false;
            // 
            // pnlTopDock
            // 
            this.pnlTopDock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.pnlTopDock.BackgroundImage = global::br.com.pgnSoft.Games.Properties.Resources.baner_full;
            this.pnlTopDock.Controls.Add(this.lblTitle);
            this.pnlTopDock.Controls.Add(this.pnlTopDock_Left);
            this.pnlTopDock.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopDock.Location = new System.Drawing.Point(0, 0);
            this.pnlTopDock.Name = "pnlTopDock";
            this.pnlTopDock.Size = new System.Drawing.Size(673, 100);
            this.pnlTopDock.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(213, 31);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Close Emulator";
            // 
            // pnlTopDock_Left
            // 
            this.pnlTopDock_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(115)))), ((int)(((byte)(28)))), ((int)(((byte)(19)))));
            this.pnlTopDock_Left.Controls.Add(this.imgLogo);
            this.pnlTopDock_Left.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTopDock_Left.Location = new System.Drawing.Point(526, 0);
            this.pnlTopDock_Left.Name = "pnlTopDock_Left";
            this.pnlTopDock_Left.Padding = new System.Windows.Forms.Padding(8);
            this.pnlTopDock_Left.Size = new System.Drawing.Size(147, 100);
            this.pnlTopDock_Left.TabIndex = 0;
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.Transparent;
            this.imgLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgLogo.Image = global::br.com.pgnSoft.Games.Properties.Resources.logo_128X37;
            this.imgLogo.Location = new System.Drawing.Point(8, 8);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(131, 37);
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackgroundImage = global::br.com.pgnSoft.Games.Properties.Resources.baner_full;
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 398);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(673, 59);
            this.pnlButtons.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(30)))), ((int)(((byte)(16)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(26)))), ((int)(((byte)(14)))));
            this.btnCancel.FlatAppearance.BorderSize = 3;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(69)))), ((int)(((byte)(61)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(44)))), ((int)(((byte)(29)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Location = new System.Drawing.Point(380, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 50);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(30)))), ((int)(((byte)(16)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(26)))), ((int)(((byte)(14)))));
            this.btnSave.FlatAppearance.BorderSize = 3;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(69)))), ((int)(((byte)(61)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(44)))), ((int)(((byte)(29)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Location = new System.Drawing.Point(526, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 50);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save Changes";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 457);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlTopDock);
            this.Controls.Add(this.pnlButtons);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(689, 495);
            this.Name = "frmMain";
            this.Text = "Close Emulator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.ctxMenu.ResumeLayout(false);
            this.grpControllerListener.ResumeLayout(false);
            this.grpControllerListener.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgGuide)).EndInit();
            this.grpKodi.ResumeLayout(false);
            this.grpKodi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgKodiLogo)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.grpCloseEmulators.ResumeLayout(false);
            this.grpCloseEmulators.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgEmulator)).EndInit();
            this.pnlTopDock.ResumeLayout(false);
            this.pnlTopDock.PerformLayout();
            this.pnlTopDock_Left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon ntfIcon;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.Panel pnlTopDock;
        private System.Windows.Forms.Panel pnlTopDock_Left;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpControllerListener;
        private System.Windows.Forms.PictureBox imgGuide;
        private System.Windows.Forms.CheckBox chkController4;
        private System.Windows.Forms.CheckBox chkController3;
        private System.Windows.Forms.CheckBox chkController2;
        private System.Windows.Forms.CheckBox chkController1;
        private System.Windows.Forms.GroupBox grpKodi;
        private System.Windows.Forms.PictureBox imgKodiLogo;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.CheckBox chkKodiStart;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private br.com.pgnSoft.Games.XBOX360_Controller Kodi_Controller_Config;
        private System.Windows.Forms.GroupBox grpCloseEmulators;
        private br.com.pgnSoft.Games.XBOX360_Controller Emulator_Controller_Config;
        private System.Windows.Forms.CheckBox chkCloseEmulators;
        private System.Windows.Forms.PictureBox imgEmulator;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCloseEmulatorConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    }
}

