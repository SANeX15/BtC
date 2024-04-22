namespace BtC
{
    partial class SettingsForm
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
            this.TitlebarPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new BtC.CustomControls_ModernButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NewNameOf8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NewNameOf7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NewNameOf6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NewNameOf5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NewNameOf4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NewNameOf3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NewNameOf2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveBtn = new BtC.CustomControls_ModernButton();
            this.ClearNamesBtn = new BtC.CustomControls_ModernButton();
            this.NewNameOf1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AutoCon = new System.Windows.Forms.CheckBox();
            this.TitlebarPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitlebarPanel
            // 
            this.TitlebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TitlebarPanel.Controls.Add(this.label1);
            this.TitlebarPanel.Controls.Add(this.button1);
            this.TitlebarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlebarPanel.Location = new System.Drawing.Point(0, 0);
            this.TitlebarPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TitlebarPanel.Name = "TitlebarPanel";
            this.TitlebarPanel.Size = new System.Drawing.Size(254, 15);
            this.TitlebarPanel.TabIndex = 2;
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
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Settings";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.BorderColor = System.Drawing.Color.Red;
            this.button1.BorderRadius = 3;
            this.button1.BorderSize = 1;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(209, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 15);
            this.button1.TabIndex = 0;
            this.button1.TextColor = System.Drawing.Color.White;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AutoCon);
            this.groupBox1.Controls.Add(this.NewNameOf8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.NewNameOf7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.NewNameOf6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.NewNameOf5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.NewNameOf4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.NewNameOf3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.NewNameOf2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SaveBtn);
            this.groupBox1.Controls.Add(this.ClearNamesBtn);
            this.groupBox1.Controls.Add(this.NewNameOf1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 359);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // NewNameOf8
            // 
            this.NewNameOf8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.NewNameOf8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewNameOf8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewNameOf8.ForeColor = System.Drawing.Color.White;
            this.NewNameOf8.Location = new System.Drawing.Point(83, 251);
            this.NewNameOf8.Name = "NewNameOf8";
            this.NewNameOf8.Size = new System.Drawing.Size(164, 26);
            this.NewNameOf8.TabIndex = 18;
            this.NewNameOf8.TextChanged += new System.EventHandler(this.NewNameOf8_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Name Of 8";
            // 
            // NewNameOf7
            // 
            this.NewNameOf7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.NewNameOf7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewNameOf7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewNameOf7.ForeColor = System.Drawing.Color.White;
            this.NewNameOf7.Location = new System.Drawing.Point(83, 219);
            this.NewNameOf7.Name = "NewNameOf7";
            this.NewNameOf7.Size = new System.Drawing.Size(164, 26);
            this.NewNameOf7.TabIndex = 16;
            this.NewNameOf7.TextChanged += new System.EventHandler(this.NewNameOf7_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Name Of 7";
            // 
            // NewNameOf6
            // 
            this.NewNameOf6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.NewNameOf6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewNameOf6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewNameOf6.ForeColor = System.Drawing.Color.White;
            this.NewNameOf6.Location = new System.Drawing.Point(83, 187);
            this.NewNameOf6.Name = "NewNameOf6";
            this.NewNameOf6.Size = new System.Drawing.Size(164, 26);
            this.NewNameOf6.TabIndex = 14;
            this.NewNameOf6.TextChanged += new System.EventHandler(this.NewNameOf6_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Name Of 6";
            // 
            // NewNameOf5
            // 
            this.NewNameOf5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.NewNameOf5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewNameOf5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewNameOf5.ForeColor = System.Drawing.Color.White;
            this.NewNameOf5.Location = new System.Drawing.Point(83, 155);
            this.NewNameOf5.Name = "NewNameOf5";
            this.NewNameOf5.Size = new System.Drawing.Size(164, 26);
            this.NewNameOf5.TabIndex = 12;
            this.NewNameOf5.TextChanged += new System.EventHandler(this.NewNameOf5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Name Of 5";
            // 
            // NewNameOf4
            // 
            this.NewNameOf4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.NewNameOf4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewNameOf4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewNameOf4.ForeColor = System.Drawing.Color.White;
            this.NewNameOf4.Location = new System.Drawing.Point(83, 123);
            this.NewNameOf4.Name = "NewNameOf4";
            this.NewNameOf4.Size = new System.Drawing.Size(164, 26);
            this.NewNameOf4.TabIndex = 10;
            this.NewNameOf4.TextChanged += new System.EventHandler(this.NewNameOf4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Name Of 4";
            // 
            // NewNameOf3
            // 
            this.NewNameOf3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.NewNameOf3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewNameOf3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewNameOf3.ForeColor = System.Drawing.Color.White;
            this.NewNameOf3.Location = new System.Drawing.Point(83, 91);
            this.NewNameOf3.Name = "NewNameOf3";
            this.NewNameOf3.Size = new System.Drawing.Size(164, 26);
            this.NewNameOf3.TabIndex = 8;
            this.NewNameOf3.TextChanged += new System.EventHandler(this.NewNameOf3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name Of 3";
            // 
            // NewNameOf2
            // 
            this.NewNameOf2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.NewNameOf2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewNameOf2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewNameOf2.ForeColor = System.Drawing.Color.White;
            this.NewNameOf2.Location = new System.Drawing.Point(83, 58);
            this.NewNameOf2.Name = "NewNameOf2";
            this.NewNameOf2.Size = new System.Drawing.Size(164, 26);
            this.NewNameOf2.TabIndex = 6;
            this.NewNameOf2.TextChanged += new System.EventHandler(this.NewNameOf2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name Of 2";
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SaveBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SaveBtn.BorderColor = System.Drawing.Color.Gray;
            this.SaveBtn.BorderRadius = 5;
            this.SaveBtn.BorderSize = 1;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(129, 311);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(120, 40);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.TextColor = System.Drawing.Color.White;
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ClearNamesBtn
            // 
            this.ClearNamesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClearNamesBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClearNamesBtn.BorderColor = System.Drawing.Color.Gray;
            this.ClearNamesBtn.BorderRadius = 5;
            this.ClearNamesBtn.BorderSize = 1;
            this.ClearNamesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearNamesBtn.ForeColor = System.Drawing.Color.White;
            this.ClearNamesBtn.Location = new System.Drawing.Point(3, 311);
            this.ClearNamesBtn.Name = "ClearNamesBtn";
            this.ClearNamesBtn.Size = new System.Drawing.Size(120, 40);
            this.ClearNamesBtn.TabIndex = 3;
            this.ClearNamesBtn.Text = "Clear All";
            this.ClearNamesBtn.TextColor = System.Drawing.Color.White;
            this.ClearNamesBtn.UseVisualStyleBackColor = false;
            this.ClearNamesBtn.Click += new System.EventHandler(this.ClearNamesBtn_Click);
            // 
            // NewNameOf1
            // 
            this.NewNameOf1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.NewNameOf1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewNameOf1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewNameOf1.ForeColor = System.Drawing.Color.White;
            this.NewNameOf1.Location = new System.Drawing.Point(83, 26);
            this.NewNameOf1.Name = "NewNameOf1";
            this.NewNameOf1.Size = new System.Drawing.Size(164, 26);
            this.NewNameOf1.TabIndex = 2;
            this.NewNameOf1.TextChanged += new System.EventHandler(this.NewNameOf1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name Of 1";
            // 
            // AutoCon
            // 
            this.AutoCon.AutoSize = true;
            this.AutoCon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoCon.ForeColor = System.Drawing.Color.White;
            this.AutoCon.Location = new System.Drawing.Point(9, 284);
            this.AutoCon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AutoCon.Name = "AutoCon";
            this.AutoCon.Size = new System.Drawing.Size(216, 20);
            this.AutoCon.TabIndex = 19;
            this.AutoCon.Text = "Auto Connect to previous device";
            this.AutoCon.UseVisualStyleBackColor = true;
            this.AutoCon.CheckedChanged += new System.EventHandler(this.AutoCon_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(254, 374);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TitlebarPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.TitlebarPanel.ResumeLayout(false);
            this.TitlebarPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitlebarPanel;
        private System.Windows.Forms.Label label1;
        private CustomControls_ModernButton button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NewNameOf3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NewNameOf2;
        private System.Windows.Forms.Label label3;
        private CustomControls_ModernButton SaveBtn;
        private CustomControls_ModernButton ClearNamesBtn;
        private System.Windows.Forms.TextBox NewNameOf1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewNameOf8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NewNameOf7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NewNameOf6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NewNameOf5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NewNameOf4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox AutoCon;
    }
}