namespace BtC
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TitlebarPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.controlbox = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EditButtonMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.Progresbar = new SANeX.CC_ModernProgressBar();
            this.EIGHT = new SANeX.CC_ModernButton();
            this.SEVEN = new SANeX.CC_ModernButton();
            this.SIX = new SANeX.CC_ModernButton();
            this.FIVE = new SANeX.CC_ModernButton();
            this.FOUR = new SANeX.CC_ModernButton();
            this.THREE = new SANeX.CC_ModernButton();
            this.TWO = new SANeX.CC_ModernButton();
            this.ONE = new SANeX.CC_ModernButton();
            this.AutoCon = new SANeX.CC_ModernButton();
            this.RefreshBtn = new SANeX.CC_ModernButton();
            this.DisconBtn = new SANeX.CC_ModernButton();
            this.SPDropDown = new BtC.CustomControls_ModernDropDown();
            this.MinBtn = new SANeX.CC_ModernButton();
            this.CloseBtn = new SANeX.CC_ModernButton();
            this.TitlebarPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.EditButtonMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitlebarPanel
            // 
            this.TitlebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TitlebarPanel.Controls.Add(this.label1);
            this.TitlebarPanel.Controls.Add(this.MinBtn);
            this.TitlebarPanel.Controls.Add(this.CloseBtn);
            this.TitlebarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlebarPanel.Location = new System.Drawing.Point(0, 0);
            this.TitlebarPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TitlebarPanel.Name = "TitlebarPanel";
            this.TitlebarPanel.Size = new System.Drawing.Size(246, 35);
            this.TitlebarPanel.TabIndex = 1;
            this.TitlebarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlebarPanel_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "BtC";
            // 
            // controlbox
            // 
            this.controlbox.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("controlbox.ImageStream")));
            this.controlbox.TransparentColor = System.Drawing.Color.Transparent;
            this.controlbox.Images.SetKeyName(0, "minimise.png");
            this.controlbox.Images.SetKeyName(1, "Close.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SPDropDown);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 325);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 29);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RefreshBtn);
            this.panel2.Controls.Add(this.DisconBtn);
            this.panel2.Controls.Add(this.AutoCon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(156, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(90, 29);
            this.panel2.TabIndex = 2;
            // 
            // EditButtonMenu
            // 
            this.EditButtonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.EditButtonMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Settings});
            this.EditButtonMenu.Name = "EditButtonMenu";
            this.EditButtonMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.EditButtonMenu.Size = new System.Drawing.Size(156, 26);
            this.EditButtonMenu.Opened += new System.EventHandler(this.EditButtonMenu_Opened);
            // 
            // Settings
            // 
            this.Settings.ForeColor = System.Drawing.Color.White;
            this.Settings.Image = global::BtC.Properties.Resources.settings;
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(155, 22);
            this.Settings.Text = "Button Settings";
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // ToolTips
            // 
            this.ToolTips.AutoPopDelay = 5000;
            this.ToolTips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ToolTips.ForeColor = System.Drawing.Color.White;
            this.ToolTips.InitialDelay = 300;
            this.ToolTips.ReshowDelay = 100;
            this.ToolTips.UseFading = false;
            // 
            // Progresbar
            // 
            this.Progresbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Progresbar.ChannelColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Progresbar.ChannelHeight = 6;
            this.Progresbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Progresbar.ForeBackColor = System.Drawing.Color.Lime;
            this.Progresbar.ForeColor = System.Drawing.Color.White;
            this.Progresbar.Location = new System.Drawing.Point(0, 321);
            this.Progresbar.Name = "Progresbar";
            this.Progresbar.ShowMaximun = false;
            this.Progresbar.ShowValue = SANeX.TextPosition.None;
            this.Progresbar.Size = new System.Drawing.Size(246, 4);
            this.Progresbar.SliderColor = System.Drawing.Color.Lime;
            this.Progresbar.SliderHeight = 6;
            this.Progresbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Progresbar.SymbolAfter = "";
            this.Progresbar.SymbolBefore = "";
            this.Progresbar.TabIndex = 11;
            // 
            // EIGHT
            // 
            this.EIGHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.EIGHT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.EIGHT.BorderColor = System.Drawing.Color.Gray;
            this.EIGHT.BorderRadius = 7;
            this.EIGHT.BorderSize = 1;
            this.EIGHT.ContextMenuStrip = this.EditButtonMenu;
            this.EIGHT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EIGHT.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.EIGHT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EIGHT.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EIGHT.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.EIGHT.Location = new System.Drawing.Point(125, 252);
            this.EIGHT.Name = "EIGHT";
            this.EIGHT.Size = new System.Drawing.Size(120, 64);
            this.EIGHT.TabIndex = 10;
            this.EIGHT.Text = "8";
            this.EIGHT.TextColor = System.Drawing.Color.WhiteSmoke;
            this.ToolTips.SetToolTip(this.EIGHT, "Eighth Device");
            this.EIGHT.UseVisualStyleBackColor = false;
            this.EIGHT.Click += new System.EventHandler(this.EIGHT_Click);
            // 
            // SEVEN
            // 
            this.SEVEN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SEVEN.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SEVEN.BorderColor = System.Drawing.Color.Gray;
            this.SEVEN.BorderRadius = 7;
            this.SEVEN.BorderSize = 1;
            this.SEVEN.ContextMenuStrip = this.EditButtonMenu;
            this.SEVEN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SEVEN.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.SEVEN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SEVEN.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEVEN.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SEVEN.Location = new System.Drawing.Point(1, 252);
            this.SEVEN.Name = "SEVEN";
            this.SEVEN.Size = new System.Drawing.Size(120, 64);
            this.SEVEN.TabIndex = 9;
            this.SEVEN.Text = "7";
            this.SEVEN.TextColor = System.Drawing.Color.WhiteSmoke;
            this.ToolTips.SetToolTip(this.SEVEN, "Seventh Device");
            this.SEVEN.UseVisualStyleBackColor = false;
            this.SEVEN.Click += new System.EventHandler(this.SEVEN_Click);
            // 
            // SIX
            // 
            this.SIX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SIX.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SIX.BorderColor = System.Drawing.Color.Gray;
            this.SIX.BorderRadius = 7;
            this.SIX.BorderSize = 1;
            this.SIX.ContextMenuStrip = this.EditButtonMenu;
            this.SIX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SIX.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.SIX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SIX.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SIX.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SIX.Location = new System.Drawing.Point(125, 182);
            this.SIX.Name = "SIX";
            this.SIX.Size = new System.Drawing.Size(120, 64);
            this.SIX.TabIndex = 8;
            this.SIX.Text = "6";
            this.SIX.TextColor = System.Drawing.Color.WhiteSmoke;
            this.ToolTips.SetToolTip(this.SIX, "Sixth Device");
            this.SIX.UseVisualStyleBackColor = false;
            this.SIX.Click += new System.EventHandler(this.SIX_Click);
            // 
            // FIVE
            // 
            this.FIVE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.FIVE.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.FIVE.BorderColor = System.Drawing.Color.Gray;
            this.FIVE.BorderRadius = 7;
            this.FIVE.BorderSize = 1;
            this.FIVE.ContextMenuStrip = this.EditButtonMenu;
            this.FIVE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FIVE.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.FIVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FIVE.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FIVE.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FIVE.Location = new System.Drawing.Point(1, 182);
            this.FIVE.Name = "FIVE";
            this.FIVE.Size = new System.Drawing.Size(120, 64);
            this.FIVE.TabIndex = 7;
            this.FIVE.Text = "5";
            this.FIVE.TextColor = System.Drawing.Color.WhiteSmoke;
            this.ToolTips.SetToolTip(this.FIVE, "Fifth Device");
            this.FIVE.UseVisualStyleBackColor = false;
            this.FIVE.Click += new System.EventHandler(this.FIVE_Click);
            // 
            // FOUR
            // 
            this.FOUR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.FOUR.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.FOUR.BorderColor = System.Drawing.Color.Gray;
            this.FOUR.BorderRadius = 7;
            this.FOUR.BorderSize = 1;
            this.FOUR.ContextMenuStrip = this.EditButtonMenu;
            this.FOUR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FOUR.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.FOUR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FOUR.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FOUR.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FOUR.Location = new System.Drawing.Point(125, 112);
            this.FOUR.Name = "FOUR";
            this.FOUR.Size = new System.Drawing.Size(120, 64);
            this.FOUR.TabIndex = 6;
            this.FOUR.Text = "4";
            this.FOUR.TextColor = System.Drawing.Color.WhiteSmoke;
            this.ToolTips.SetToolTip(this.FOUR, "Fourth Device");
            this.FOUR.UseVisualStyleBackColor = false;
            this.FOUR.Click += new System.EventHandler(this.FOUR_Click);
            // 
            // THREE
            // 
            this.THREE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.THREE.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.THREE.BorderColor = System.Drawing.Color.Gray;
            this.THREE.BorderRadius = 7;
            this.THREE.BorderSize = 1;
            this.THREE.ContextMenuStrip = this.EditButtonMenu;
            this.THREE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.THREE.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.THREE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.THREE.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.THREE.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.THREE.Location = new System.Drawing.Point(1, 112);
            this.THREE.Name = "THREE";
            this.THREE.Size = new System.Drawing.Size(120, 64);
            this.THREE.TabIndex = 5;
            this.THREE.Text = "3";
            this.THREE.TextColor = System.Drawing.Color.WhiteSmoke;
            this.ToolTips.SetToolTip(this.THREE, "Third Device");
            this.THREE.UseVisualStyleBackColor = false;
            this.THREE.Click += new System.EventHandler(this.THREE_Click);
            // 
            // TWO
            // 
            this.TWO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TWO.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TWO.BorderColor = System.Drawing.Color.Gray;
            this.TWO.BorderRadius = 7;
            this.TWO.BorderSize = 1;
            this.TWO.ContextMenuStrip = this.EditButtonMenu;
            this.TWO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TWO.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.TWO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TWO.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TWO.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TWO.Location = new System.Drawing.Point(125, 42);
            this.TWO.Name = "TWO";
            this.TWO.Size = new System.Drawing.Size(120, 64);
            this.TWO.TabIndex = 4;
            this.TWO.Text = "2";
            this.TWO.TextColor = System.Drawing.Color.WhiteSmoke;
            this.ToolTips.SetToolTip(this.TWO, "Second Device");
            this.TWO.UseVisualStyleBackColor = false;
            this.TWO.Click += new System.EventHandler(this.TWO_Click);
            // 
            // ONE
            // 
            this.ONE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ONE.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ONE.BorderColor = System.Drawing.Color.Gray;
            this.ONE.BorderRadius = 7;
            this.ONE.BorderSize = 1;
            this.ONE.ContextMenuStrip = this.EditButtonMenu;
            this.ONE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ONE.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ONE.FlatAppearance.BorderSize = 0;
            this.ONE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ONE.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ONE.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ONE.Location = new System.Drawing.Point(1, 42);
            this.ONE.Name = "ONE";
            this.ONE.Size = new System.Drawing.Size(120, 64);
            this.ONE.TabIndex = 3;
            this.ONE.Text = "1";
            this.ONE.TextColor = System.Drawing.Color.WhiteSmoke;
            this.ToolTips.SetToolTip(this.ONE, "First Device");
            this.ONE.UseVisualStyleBackColor = false;
            this.ONE.Click += new System.EventHandler(this.ONE_Click);
            // 
            // AutoCon
            // 
            this.AutoCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.AutoCon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.AutoCon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AutoCon.BorderColor = System.Drawing.Color.Gray;
            this.AutoCon.BorderRadius = 15;
            this.AutoCon.BorderSize = 1;
            this.AutoCon.Dock = System.Windows.Forms.DockStyle.Left;
            this.AutoCon.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.AutoCon.FlatAppearance.BorderSize = 0;
            this.AutoCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoCon.ForeColor = System.Drawing.Color.White;
            this.AutoCon.Image = global::BtC.Properties.Resources.link;
            this.AutoCon.Location = new System.Drawing.Point(3, 0);
            this.AutoCon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AutoCon.Name = "AutoCon";
            this.AutoCon.Size = new System.Drawing.Size(29, 29);
            this.AutoCon.TabIndex = 6;
            this.AutoCon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AutoCon.TextColor = System.Drawing.Color.White;
            this.ToolTips.SetToolTip(this.AutoCon, "Auto Connect");
            this.AutoCon.UseVisualStyleBackColor = false;
            this.AutoCon.Click += new System.EventHandler(this.AutoCon_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.RefreshBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.RefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RefreshBtn.BorderColor = System.Drawing.Color.Gray;
            this.RefreshBtn.BorderRadius = 15;
            this.RefreshBtn.BorderSize = 1;
            this.RefreshBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RefreshBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.RefreshBtn.FlatAppearance.BorderSize = 0;
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.ForeColor = System.Drawing.Color.White;
            this.RefreshBtn.Image = global::BtC.Properties.Resources.Refresh;
            this.RefreshBtn.Location = new System.Drawing.Point(32, 0);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(29, 29);
            this.RefreshBtn.TabIndex = 5;
            this.RefreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RefreshBtn.TextColor = System.Drawing.Color.White;
            this.ToolTips.SetToolTip(this.RefreshBtn, "ReConnect");
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // DisconBtn
            // 
            this.DisconBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.DisconBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.DisconBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DisconBtn.BorderColor = System.Drawing.Color.Gray;
            this.DisconBtn.BorderRadius = 15;
            this.DisconBtn.BorderSize = 1;
            this.DisconBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.DisconBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.DisconBtn.FlatAppearance.BorderSize = 0;
            this.DisconBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisconBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisconBtn.ForeColor = System.Drawing.Color.White;
            this.DisconBtn.Image = global::BtC.Properties.Resources.discon;
            this.DisconBtn.Location = new System.Drawing.Point(61, 0);
            this.DisconBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DisconBtn.Name = "DisconBtn";
            this.DisconBtn.Size = new System.Drawing.Size(29, 29);
            this.DisconBtn.TabIndex = 4;
            this.DisconBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DisconBtn.TextColor = System.Drawing.Color.White;
            this.ToolTips.SetToolTip(this.DisconBtn, "DisConnect");
            this.DisconBtn.UseVisualStyleBackColor = false;
            this.DisconBtn.Click += new System.EventHandler(this.DisconBtn_Click);
            // 
            // SPDropDown
            // 
            this.SPDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SPDropDown.BorderColor = System.Drawing.Color.Gray;
            this.SPDropDown.BorderSize = 1;
            this.SPDropDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SPDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.SPDropDown.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPDropDown.ForeColor = System.Drawing.Color.White;
            this.SPDropDown.IconColor = System.Drawing.Color.White;
            this.SPDropDown.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SPDropDown.ListTextColor = System.Drawing.Color.White;
            this.SPDropDown.Location = new System.Drawing.Point(0, 0);
            this.SPDropDown.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.SPDropDown.MinimumSize = new System.Drawing.Size(50, 15);
            this.SPDropDown.Name = "SPDropDown";
            this.SPDropDown.Padding = new System.Windows.Forms.Padding(1);
            this.SPDropDown.Size = new System.Drawing.Size(156, 29);
            this.SPDropDown.TabIndex = 0;
            this.SPDropDown.Texts = "Choose COM port";
            this.SPDropDown.OnSelectedIndexChanged += new System.EventHandler(this.SPDropDown_SelectedIndexChanged);
            // 
            // MinBtn
            // 
            this.MinBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MinBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MinBtn.BorderColor = System.Drawing.Color.Red;
            this.MinBtn.BorderRadius = 0;
            this.MinBtn.BorderSize = 0;
            this.MinBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinBtn.FlatAppearance.BorderSize = 0;
            this.MinBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod;
            this.MinBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.ForeColor = System.Drawing.Color.White;
            this.MinBtn.ImageIndex = 0;
            this.MinBtn.ImageList = this.controlbox;
            this.MinBtn.Location = new System.Drawing.Point(136, 0);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(55, 35);
            this.MinBtn.TabIndex = 4;
            this.MinBtn.TextColor = System.Drawing.Color.White;
            this.MinBtn.UseVisualStyleBackColor = false;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CloseBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CloseBtn.BorderColor = System.Drawing.Color.Red;
            this.CloseBtn.BorderRadius = 0;
            this.CloseBtn.BorderSize = 0;
            this.CloseBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(20)))), ((int)(((byte)(5)))));
            this.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(20)))), ((int)(((byte)(10)))));
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.ImageIndex = 1;
            this.CloseBtn.ImageList = this.controlbox;
            this.CloseBtn.Location = new System.Drawing.Point(191, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(55, 35);
            this.CloseBtn.TabIndex = 3;
            this.CloseBtn.TextColor = System.Drawing.Color.White;
            this.CloseBtn.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(246, 354);
            this.Controls.Add(this.Progresbar);
            this.Controls.Add(this.EIGHT);
            this.Controls.Add(this.SEVEN);
            this.Controls.Add(this.SIX);
            this.Controls.Add(this.FIVE);
            this.Controls.Add(this.FOUR);
            this.Controls.Add(this.THREE);
            this.Controls.Add(this.TWO);
            this.Controls.Add(this.ONE);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitlebarPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "MainForm";
            this.Text = "BtC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.TitlebarPanel.ResumeLayout(false);
            this.TitlebarPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.EditButtonMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls_ModernDropDown SPDropDown;
        private System.Windows.Forms.Panel TitlebarPanel;
        private System.Windows.Forms.Panel panel1;
        private SANeX.CC_ModernButton ONE;
        private SANeX.CC_ModernButton TWO;
        private SANeX.CC_ModernButton THREE;
        private SANeX.CC_ModernButton FOUR;
        private SANeX.CC_ModernButton FIVE;
        private SANeX.CC_ModernButton SIX;
        private SANeX.CC_ModernButton SEVEN;
        private SANeX.CC_ModernButton EIGHT;
        private System.Windows.Forms.Panel panel2;
        private SANeX.CC_ModernButton RefreshBtn;
        private SANeX.CC_ModernButton DisconBtn;
        private SANeX.CC_ModernProgressBar Progresbar;
        private System.Windows.Forms.ContextMenuStrip EditButtonMenu;
        private System.Windows.Forms.ToolStripMenuItem Settings;
        private System.Windows.Forms.ToolTip ToolTips;
        private SANeX.CC_ModernButton AutoCon;
        private SANeX.CC_ModernButton MinBtn;
        private SANeX.CC_ModernButton CloseBtn;
        private System.Windows.Forms.ImageList controlbox;
        private System.Windows.Forms.Label label1;
    }
}

