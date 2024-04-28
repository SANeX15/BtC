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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TitlebarPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Settings_Btn = new BtC.CustomControls_ModernButton();
            this.button2 = new BtC.CustomControls_ModernButton();
            this.button1 = new BtC.CustomControls_ModernButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RefreshBtn = new BtC.CustomControls_ModernButton();
            this.DisconBtn = new BtC.CustomControls_ModernButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SPDropDown = new BtC.CustomControls_ModernDropDown();
            this.Progresbar = new BtC.CustomControls_ModernProgressBar();
            this.EIGHT = new BtC.CustomControls_ModernButton();
            this.SEVEN = new BtC.CustomControls_ModernButton();
            this.SIX = new BtC.CustomControls_ModernButton();
            this.FIVE = new BtC.CustomControls_ModernButton();
            this.FOUR = new BtC.CustomControls_ModernButton();
            this.THREE = new BtC.CustomControls_ModernButton();
            this.TWO = new BtC.CustomControls_ModernButton();
            this.ONE = new BtC.CustomControls_ModernButton();
            this.TitlebarPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitlebarPanel
            // 
            this.TitlebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TitlebarPanel.Controls.Add(this.label1);
            this.TitlebarPanel.Controls.Add(this.Settings_Btn);
            this.TitlebarPanel.Controls.Add(this.button2);
            this.TitlebarPanel.Controls.Add(this.button1);
            this.TitlebarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlebarPanel.Location = new System.Drawing.Point(0, 0);
            this.TitlebarPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TitlebarPanel.Name = "TitlebarPanel";
            this.TitlebarPanel.Size = new System.Drawing.Size(246, 15);
            this.TitlebarPanel.TabIndex = 1;
            this.TitlebarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlebarPanel_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "BtC";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // Settings_Btn
            // 
            this.Settings_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Settings_Btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Settings_Btn.BackgroundImage = global::BtC.Properties.Resources.settings;
            this.Settings_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Settings_Btn.BorderColor = System.Drawing.Color.White;
            this.Settings_Btn.BorderRadius = 5;
            this.Settings_Btn.BorderSize = 1;
            this.Settings_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Settings_Btn.FlatAppearance.BorderSize = 0;
            this.Settings_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_Btn.ForeColor = System.Drawing.Color.Transparent;
            this.Settings_Btn.Location = new System.Drawing.Point(139, 0);
            this.Settings_Btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Settings_Btn.Name = "Settings_Btn";
            this.Settings_Btn.Size = new System.Drawing.Size(17, 15);
            this.Settings_Btn.TabIndex = 2;
            this.Settings_Btn.TextColor = System.Drawing.Color.Transparent;
            this.Settings_Btn.UseVisualStyleBackColor = false;
            this.Settings_Btn.Click += new System.EventHandler(this.Settings_Btn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.BackgroundColor = System.Drawing.Color.Gold;
            this.button2.BorderColor = System.Drawing.Color.Gold;
            this.button2.BorderRadius = 5;
            this.button2.BorderSize = 1;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(156, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 15);
            this.button2.TabIndex = 1;
            this.button2.TextColor = System.Drawing.Color.White;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.BorderRadius = 5;
            this.button1.BorderSize = 1;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(201, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 15);
            this.button1.TabIndex = 0;
            this.button1.TextColor = System.Drawing.Color.White;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.SPDropDown);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 73);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RefreshBtn);
            this.panel2.Controls.Add(this.DisconBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 27);
            this.panel2.TabIndex = 2;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.RefreshBtn.BackgroundColor = System.Drawing.Color.Transparent;
            this.RefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RefreshBtn.BorderColor = System.Drawing.Color.Gray;
            this.RefreshBtn.BorderRadius = 7;
            this.RefreshBtn.BorderSize = 1;
            this.RefreshBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.RefreshBtn.FlatAppearance.BorderSize = 0;
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.ForeColor = System.Drawing.Color.White;
            this.RefreshBtn.Image = global::BtC.Properties.Resources.Refresh;
            this.RefreshBtn.Location = new System.Drawing.Point(192, 0);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(27, 27);
            this.RefreshBtn.TabIndex = 5;
            this.RefreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RefreshBtn.TextColor = System.Drawing.Color.White;
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // DisconBtn
            // 
            this.DisconBtn.BackColor = System.Drawing.Color.Transparent;
            this.DisconBtn.BackgroundColor = System.Drawing.Color.Transparent;
            this.DisconBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DisconBtn.BorderColor = System.Drawing.Color.Gray;
            this.DisconBtn.BorderRadius = 7;
            this.DisconBtn.BorderSize = 1;
            this.DisconBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.DisconBtn.FlatAppearance.BorderSize = 0;
            this.DisconBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisconBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisconBtn.ForeColor = System.Drawing.Color.White;
            this.DisconBtn.Image = global::BtC.Properties.Resources.discon;
            this.DisconBtn.Location = new System.Drawing.Point(219, 0);
            this.DisconBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DisconBtn.Name = "DisconBtn";
            this.DisconBtn.Size = new System.Drawing.Size(27, 27);
            this.DisconBtn.TabIndex = 4;
            this.DisconBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DisconBtn.TextColor = System.Drawing.Color.White;
            this.DisconBtn.UseVisualStyleBackColor = false;
            this.DisconBtn.Click += new System.EventHandler(this.DisconBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "⦿ Disconnected";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SPDropDown
            // 
            this.SPDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SPDropDown.BorderColor = System.Drawing.Color.Gray;
            this.SPDropDown.BorderSize = 1;
            this.SPDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.SPDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SPDropDown.ForeColor = System.Drawing.Color.White;
            this.SPDropDown.IconColor = System.Drawing.Color.White;
            this.SPDropDown.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SPDropDown.ListTextColor = System.Drawing.Color.White;
            this.SPDropDown.Location = new System.Drawing.Point(0, 10);
            this.SPDropDown.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.SPDropDown.MinimumSize = new System.Drawing.Size(200, 30);
            this.SPDropDown.Name = "SPDropDown";
            this.SPDropDown.Padding = new System.Windows.Forms.Padding(1);
            this.SPDropDown.Size = new System.Drawing.Size(246, 33);
            this.SPDropDown.TabIndex = 0;
            this.SPDropDown.Texts = "Choose COM port";
            this.SPDropDown.OnSelectedIndexChanged += new System.EventHandler(this.SPDropDown_SelectedIndexChanged);
            // 
            // Progresbar
            // 
            this.Progresbar.ChannelColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Progresbar.ChannelHeight = 6;
            this.Progresbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Progresbar.ForeBackColor = System.Drawing.Color.Lime;
            this.Progresbar.ForeColor = System.Drawing.Color.White;
            this.Progresbar.Location = new System.Drawing.Point(0, 377);
            this.Progresbar.Name = "Progresbar";
            this.Progresbar.ShowMaximun = false;
            this.Progresbar.ShowValue = BtC.TextPosition.None;
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
            this.EIGHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.EIGHT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.EIGHT.BorderColor = System.Drawing.Color.Gray;
            this.EIGHT.BorderRadius = 7;
            this.EIGHT.BorderSize = 1;
            this.EIGHT.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.EIGHT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EIGHT.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.EIGHT.Location = new System.Drawing.Point(126, 305);
            this.EIGHT.Name = "EIGHT";
            this.EIGHT.Size = new System.Drawing.Size(120, 64);
            this.EIGHT.TabIndex = 10;
            this.EIGHT.Text = "8";
            this.EIGHT.TextColor = System.Drawing.Color.WhiteSmoke;
            this.EIGHT.UseVisualStyleBackColor = false;
            this.EIGHT.Click += new System.EventHandler(this.EIGHT_Click);
            // 
            // SEVEN
            // 
            this.SEVEN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SEVEN.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SEVEN.BorderColor = System.Drawing.Color.Gray;
            this.SEVEN.BorderRadius = 7;
            this.SEVEN.BorderSize = 1;
            this.SEVEN.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.SEVEN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SEVEN.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SEVEN.Location = new System.Drawing.Point(0, 305);
            this.SEVEN.Name = "SEVEN";
            this.SEVEN.Size = new System.Drawing.Size(120, 64);
            this.SEVEN.TabIndex = 9;
            this.SEVEN.Text = "7";
            this.SEVEN.TextColor = System.Drawing.Color.WhiteSmoke;
            this.SEVEN.UseVisualStyleBackColor = false;
            this.SEVEN.Click += new System.EventHandler(this.SEVEN_Click);
            // 
            // SIX
            // 
            this.SIX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SIX.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SIX.BorderColor = System.Drawing.Color.Gray;
            this.SIX.BorderRadius = 7;
            this.SIX.BorderSize = 1;
            this.SIX.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.SIX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SIX.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SIX.Location = new System.Drawing.Point(126, 235);
            this.SIX.Name = "SIX";
            this.SIX.Size = new System.Drawing.Size(120, 64);
            this.SIX.TabIndex = 8;
            this.SIX.Text = "6";
            this.SIX.TextColor = System.Drawing.Color.WhiteSmoke;
            this.SIX.UseVisualStyleBackColor = false;
            this.SIX.Click += new System.EventHandler(this.SIX_Click);
            // 
            // FIVE
            // 
            this.FIVE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.FIVE.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.FIVE.BorderColor = System.Drawing.Color.Gray;
            this.FIVE.BorderRadius = 7;
            this.FIVE.BorderSize = 1;
            this.FIVE.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.FIVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FIVE.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FIVE.Location = new System.Drawing.Point(0, 235);
            this.FIVE.Name = "FIVE";
            this.FIVE.Size = new System.Drawing.Size(120, 64);
            this.FIVE.TabIndex = 7;
            this.FIVE.Text = "5";
            this.FIVE.TextColor = System.Drawing.Color.WhiteSmoke;
            this.FIVE.UseVisualStyleBackColor = false;
            this.FIVE.Click += new System.EventHandler(this.FIVE_Click);
            // 
            // FOUR
            // 
            this.FOUR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.FOUR.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.FOUR.BorderColor = System.Drawing.Color.Gray;
            this.FOUR.BorderRadius = 7;
            this.FOUR.BorderSize = 1;
            this.FOUR.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.FOUR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FOUR.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FOUR.Location = new System.Drawing.Point(126, 165);
            this.FOUR.Name = "FOUR";
            this.FOUR.Size = new System.Drawing.Size(120, 64);
            this.FOUR.TabIndex = 6;
            this.FOUR.Text = "4";
            this.FOUR.TextColor = System.Drawing.Color.WhiteSmoke;
            this.FOUR.UseVisualStyleBackColor = false;
            this.FOUR.Click += new System.EventHandler(this.FOUR_Click);
            // 
            // THREE
            // 
            this.THREE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.THREE.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.THREE.BorderColor = System.Drawing.Color.Gray;
            this.THREE.BorderRadius = 7;
            this.THREE.BorderSize = 1;
            this.THREE.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.THREE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.THREE.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.THREE.Location = new System.Drawing.Point(0, 165);
            this.THREE.Name = "THREE";
            this.THREE.Size = new System.Drawing.Size(120, 64);
            this.THREE.TabIndex = 5;
            this.THREE.Text = "3";
            this.THREE.TextColor = System.Drawing.Color.WhiteSmoke;
            this.THREE.UseVisualStyleBackColor = false;
            this.THREE.Click += new System.EventHandler(this.THREE_Click);
            // 
            // TWO
            // 
            this.TWO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TWO.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TWO.BorderColor = System.Drawing.Color.Gray;
            this.TWO.BorderRadius = 7;
            this.TWO.BorderSize = 1;
            this.TWO.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.TWO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TWO.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TWO.Location = new System.Drawing.Point(126, 95);
            this.TWO.Name = "TWO";
            this.TWO.Size = new System.Drawing.Size(120, 64);
            this.TWO.TabIndex = 4;
            this.TWO.Text = "2";
            this.TWO.TextColor = System.Drawing.Color.WhiteSmoke;
            this.TWO.UseVisualStyleBackColor = false;
            this.TWO.Click += new System.EventHandler(this.TWO_Click);
            // 
            // ONE
            // 
            this.ONE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ONE.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ONE.BorderColor = System.Drawing.Color.Gray;
            this.ONE.BorderRadius = 7;
            this.ONE.BorderSize = 1;
            this.ONE.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.ONE.FlatAppearance.BorderSize = 0;
            this.ONE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ONE.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ONE.Location = new System.Drawing.Point(0, 95);
            this.ONE.Name = "ONE";
            this.ONE.Size = new System.Drawing.Size(120, 64);
            this.ONE.TabIndex = 3;
            this.ONE.Text = "1";
            this.ONE.TextColor = System.Drawing.Color.WhiteSmoke;
            this.ONE.UseVisualStyleBackColor = false;
            this.ONE.Click += new System.EventHandler(this.ONE_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(246, 381);
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
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.TitlebarPanel.ResumeLayout(false);
            this.TitlebarPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls_ModernDropDown SPDropDown;
        private System.Windows.Forms.Panel TitlebarPanel;
        private CustomControls_ModernButton button1;
        private CustomControls_ModernButton button2;
        private System.Windows.Forms.Label label1;
        private CustomControls_ModernButton Settings_Btn;
        private System.Windows.Forms.Panel panel1;
        private CustomControls_ModernButton ONE;
        private CustomControls_ModernButton TWO;
        private CustomControls_ModernButton THREE;
        private CustomControls_ModernButton FOUR;
        private CustomControls_ModernButton FIVE;
        private CustomControls_ModernButton SIX;
        private CustomControls_ModernButton SEVEN;
        private CustomControls_ModernButton EIGHT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private CustomControls_ModernButton DisconBtn;
        private CustomControls_ModernButton RefreshBtn;
        private CustomControls_ModernProgressBar Progresbar;
    }
}

