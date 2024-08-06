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
            this.NameTxtboxContainer = new System.Windows.Forms.GroupBox();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ONTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.OFFTxtBox = new System.Windows.Forms.TextBox();
            this.SaveBtn = new SANeX.CC_ModernButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelBtn = new SANeX.CC_ModernButton();
            this.TitlebarPanel.SuspendLayout();
            this.NameTxtboxContainer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitlebarPanel
            // 
            this.TitlebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TitlebarPanel.Controls.Add(this.label1);
            this.TitlebarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlebarPanel.Location = new System.Drawing.Point(0, 0);
            this.TitlebarPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TitlebarPanel.Name = "TitlebarPanel";
            this.TitlebarPanel.Size = new System.Drawing.Size(203, 25);
            this.TitlebarPanel.TabIndex = 2;
            this.TitlebarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlebarPanel_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Settings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // NameTxtboxContainer
            // 
            this.NameTxtboxContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.NameTxtboxContainer.Controls.Add(this.NameTxtBox);
            this.NameTxtboxContainer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxtboxContainer.ForeColor = System.Drawing.Color.White;
            this.NameTxtboxContainer.Location = new System.Drawing.Point(12, 30);
            this.NameTxtboxContainer.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.NameTxtboxContainer.Name = "NameTxtboxContainer";
            this.NameTxtboxContainer.Padding = new System.Windows.Forms.Padding(10, 0, 10, 3);
            this.NameTxtboxContainer.Size = new System.Drawing.Size(181, 50);
            this.NameTxtboxContainer.TabIndex = 4;
            this.NameTxtboxContainer.TabStop = false;
            this.NameTxtboxContainer.Text = "Name of the Button";
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.NameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTxtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameTxtBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxtBox.ForeColor = System.Drawing.Color.White;
            this.NameTxtBox.Location = new System.Drawing.Point(10, 20);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(161, 26);
            this.NameTxtBox.TabIndex = 0;
            this.NameTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameTxtBox.TextChanged += new System.EventHandler(this.NameTxtBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.groupBox2.Controls.Add(this.ONTxtBox);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 87);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 3);
            this.groupBox2.Size = new System.Drawing.Size(82, 50);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ON CMD";
            // 
            // ONTxtBox
            // 
            this.ONTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ONTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ONTxtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ONTxtBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ONTxtBox.ForeColor = System.Drawing.Color.White;
            this.ONTxtBox.Location = new System.Drawing.Point(10, 20);
            this.ONTxtBox.MaxLength = 10;
            this.ONTxtBox.Name = "ONTxtBox";
            this.ONTxtBox.Size = new System.Drawing.Size(62, 26);
            this.ONTxtBox.TabIndex = 0;
            this.ONTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ONTxtBox.TextChanged += new System.EventHandler(this.ONTxtBox_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.groupBox3.Controls.Add(this.OFFTxtBox);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(108, 87);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 3);
            this.groupBox3.Size = new System.Drawing.Size(85, 50);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "OFF CMD";
            // 
            // OFFTxtBox
            // 
            this.OFFTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.OFFTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OFFTxtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OFFTxtBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OFFTxtBox.ForeColor = System.Drawing.Color.White;
            this.OFFTxtBox.Location = new System.Drawing.Point(10, 20);
            this.OFFTxtBox.MaxLength = 10;
            this.OFFTxtBox.Name = "OFFTxtBox";
            this.OFFTxtBox.Size = new System.Drawing.Size(65, 26);
            this.OFFTxtBox.TabIndex = 0;
            this.OFFTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OFFTxtBox.TextChanged += new System.EventHandler(this.OFFTxtBox_TextChanged);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SaveBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SaveBtn.BorderColor = System.Drawing.Color.Gray;
            this.SaveBtn.BorderRadius = 5;
            this.SaveBtn.BorderSize = 1;
            this.SaveBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.SaveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(0, 0);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(101, 42);
            this.SaveBtn.TabIndex = 4;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.TextColor = System.Drawing.Color.White;
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CancelBtn);
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 42);
            this.panel1.TabIndex = 7;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CancelBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CancelBtn.BorderColor = System.Drawing.Color.Gray;
            this.CancelBtn.BorderRadius = 5;
            this.CancelBtn.BorderSize = 1;
            this.CancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(101, 0);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(102, 42);
            this.CancelBtn.TabIndex = 5;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.TextColor = System.Drawing.Color.White;
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(203, 185);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.NameTxtboxContainer);
            this.Controls.Add(this.TitlebarPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsForm_KeyDown);
            this.TitlebarPanel.ResumeLayout(false);
            this.TitlebarPanel.PerformLayout();
            this.NameTxtboxContainer.ResumeLayout(false);
            this.NameTxtboxContainer.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitlebarPanel;
        private System.Windows.Forms.Label label1;
        private SANeX.CC_ModernButton SaveBtn;
        private System.Windows.Forms.GroupBox NameTxtboxContainer;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ONTxtBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox OFFTxtBox;
        private System.Windows.Forms.Panel panel1;
        private SANeX.CC_ModernButton CancelBtn;
    }
}