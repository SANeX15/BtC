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
            this.SPDropDown = new System.Windows.Forms.ComboBox();
            this.TitlebarPanel = new System.Windows.Forms.Panel();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Settings_Btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.AutoCon = new System.Windows.Forms.CheckBox();
            this.ONE = new System.Windows.Forms.Button();
            this.TWO = new System.Windows.Forms.Button();
            this.THREE = new System.Windows.Forms.Button();
            this.FOUR = new System.Windows.Forms.Button();
            this.FIVE = new System.Windows.Forms.Button();
            this.SIX = new System.Windows.Forms.Button();
            this.SEVEN = new System.Windows.Forms.Button();
            this.EIGHT = new System.Windows.Forms.Button();
            this.TitlebarPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SPDropDown
            // 
            this.SPDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.SPDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SPDropDown.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SPDropDown.FormattingEnabled = true;
            this.SPDropDown.Location = new System.Drawing.Point(0, 10);
            this.SPDropDown.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.SPDropDown.Name = "SPDropDown";
            this.SPDropDown.Size = new System.Drawing.Size(247, 33);
            this.SPDropDown.TabIndex = 0;
            this.SPDropDown.SelectedIndexChanged += new System.EventHandler(this.SPDropDown_SelectedIndexChanged);
            // 
            // TitlebarPanel
            // 
            this.TitlebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TitlebarPanel.Controls.Add(this.RefreshBtn);
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
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.RefreshBtn.BackgroundImage = global::BtC.Properties.Resources.Refresh;
            this.RefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.RefreshBtn.FlatAppearance.BorderSize = 0;
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBtn.Location = new System.Drawing.Point(139, 0);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(17, 15);
            this.RefreshBtn.TabIndex = 4;
            this.RefreshBtn.Text = "button3";
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "BtC";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // Settings_Btn
            // 
            this.Settings_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Settings_Btn.BackgroundImage = global::BtC.Properties.Resources.settings;
            this.Settings_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Settings_Btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.Settings_Btn.FlatAppearance.BorderSize = 0;
            this.Settings_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_Btn.Location = new System.Drawing.Point(0, 0);
            this.Settings_Btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Settings_Btn.Name = "Settings_Btn";
            this.Settings_Btn.Size = new System.Drawing.Size(17, 15);
            this.Settings_Btn.TabIndex = 2;
            this.Settings_Btn.Text = "button3";
            this.Settings_Btn.UseVisualStyleBackColor = false;
            this.Settings_Btn.Click += new System.EventHandler(this.Settings_Btn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(156, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 15);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(201, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 15);
            this.button1.TabIndex = 0;
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
            this.panel1.Size = new System.Drawing.Size(246, 69);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.AutoCon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 21);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "⦿ Disconnected";
            // 
            // AutoCon
            // 
            this.AutoCon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoCon.AutoSize = true;
            this.AutoCon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoCon.ForeColor = System.Drawing.Color.White;
            this.AutoCon.Location = new System.Drawing.Point(145, 0);
            this.AutoCon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AutoCon.Name = "AutoCon";
            this.AutoCon.Size = new System.Drawing.Size(102, 20);
            this.AutoCon.TabIndex = 1;
            this.AutoCon.Text = "Auto Connect";
            this.AutoCon.UseVisualStyleBackColor = true;
            this.AutoCon.CheckedChanged += new System.EventHandler(this.AutoCon_CheckedChanged);
            // 
            // ONE
            // 
            this.ONE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ONE.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.ONE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ONE.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ONE.Location = new System.Drawing.Point(0, 91);
            this.ONE.Name = "ONE";
            this.ONE.Size = new System.Drawing.Size(120, 64);
            this.ONE.TabIndex = 3;
            this.ONE.Text = "1";
            this.ONE.UseVisualStyleBackColor = false;
            this.ONE.Click += new System.EventHandler(this.ONE_Click);
            // 
            // TWO
            // 
            this.TWO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TWO.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.TWO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TWO.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TWO.Location = new System.Drawing.Point(126, 91);
            this.TWO.Name = "TWO";
            this.TWO.Size = new System.Drawing.Size(120, 64);
            this.TWO.TabIndex = 4;
            this.TWO.Text = "2";
            this.TWO.UseVisualStyleBackColor = false;
            this.TWO.Click += new System.EventHandler(this.TWO_Click);
            // 
            // THREE
            // 
            this.THREE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.THREE.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.THREE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.THREE.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.THREE.Location = new System.Drawing.Point(0, 161);
            this.THREE.Name = "THREE";
            this.THREE.Size = new System.Drawing.Size(120, 64);
            this.THREE.TabIndex = 5;
            this.THREE.Text = "3";
            this.THREE.UseVisualStyleBackColor = false;
            this.THREE.Click += new System.EventHandler(this.THREE_Click);
            // 
            // FOUR
            // 
            this.FOUR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.FOUR.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.FOUR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FOUR.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FOUR.Location = new System.Drawing.Point(126, 161);
            this.FOUR.Name = "FOUR";
            this.FOUR.Size = new System.Drawing.Size(120, 64);
            this.FOUR.TabIndex = 6;
            this.FOUR.Text = "4";
            this.FOUR.UseVisualStyleBackColor = false;
            this.FOUR.Click += new System.EventHandler(this.FOUR_Click);
            // 
            // FIVE
            // 
            this.FIVE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.FIVE.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.FIVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FIVE.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FIVE.Location = new System.Drawing.Point(0, 231);
            this.FIVE.Name = "FIVE";
            this.FIVE.Size = new System.Drawing.Size(120, 64);
            this.FIVE.TabIndex = 7;
            this.FIVE.Text = "5";
            this.FIVE.UseVisualStyleBackColor = false;
            this.FIVE.Click += new System.EventHandler(this.FIVE_Click);
            // 
            // SIX
            // 
            this.SIX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SIX.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.SIX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SIX.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SIX.Location = new System.Drawing.Point(126, 231);
            this.SIX.Name = "SIX";
            this.SIX.Size = new System.Drawing.Size(120, 64);
            this.SIX.TabIndex = 8;
            this.SIX.Text = "6";
            this.SIX.UseVisualStyleBackColor = false;
            this.SIX.Click += new System.EventHandler(this.SIX_Click);
            // 
            // SEVEN
            // 
            this.SEVEN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SEVEN.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.SEVEN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SEVEN.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SEVEN.Location = new System.Drawing.Point(0, 301);
            this.SEVEN.Name = "SEVEN";
            this.SEVEN.Size = new System.Drawing.Size(120, 64);
            this.SEVEN.TabIndex = 9;
            this.SEVEN.Text = "7";
            this.SEVEN.UseVisualStyleBackColor = false;
            this.SEVEN.Click += new System.EventHandler(this.SEVEN_Click);
            // 
            // EIGHT
            // 
            this.EIGHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.EIGHT.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.EIGHT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EIGHT.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.EIGHT.Location = new System.Drawing.Point(126, 301);
            this.EIGHT.Name = "EIGHT";
            this.EIGHT.Size = new System.Drawing.Size(120, 64);
            this.EIGHT.TabIndex = 10;
            this.EIGHT.Text = "8";
            this.EIGHT.UseVisualStyleBackColor = false;
            this.EIGHT.Click += new System.EventHandler(this.EIGHT_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(246, 373);
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
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.TitlebarPanel.ResumeLayout(false);
            this.TitlebarPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox SPDropDown;
        private System.Windows.Forms.Panel TitlebarPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Settings_Btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox AutoCon;
        private System.Windows.Forms.Button ONE;
        private System.Windows.Forms.Button TWO;
        private System.Windows.Forms.Button THREE;
        private System.Windows.Forms.Button FOUR;
        private System.Windows.Forms.Button FIVE;
        private System.Windows.Forms.Button SIX;
        private System.Windows.Forms.Button SEVEN;
        private System.Windows.Forms.Button EIGHT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RefreshBtn;
    }
}

