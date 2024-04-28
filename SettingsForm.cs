using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BtC
{
    public partial class SettingsForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private string Btn1 = Properties.Settings.Default.ONE;
        private string Btn2 = Properties.Settings.Default.TWO;
        private string Btn3 = Properties.Settings.Default.THREE;
        private string Btn4 = Properties.Settings.Default.FOUR;
        private string Btn5 = Properties.Settings.Default.FIVE;
        private string Btn6 = Properties.Settings.Default.SIX;
        private string Btn7 = Properties.Settings.Default.SEVEN;
        private string Btn8 = Properties.Settings.Default.EIGHT;
        private int nameschanged = 0;
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            NewNameOf1.Text = Btn1;
            NewNameOf2.Text = Btn2;
            NewNameOf3.Text = Btn3;
            NewNameOf4.Text = Btn4;
            NewNameOf5.Text = Btn5;
            NewNameOf6.Text = Btn6;
            NewNameOf7.Text = Btn7;
            NewNameOf8.Text = Btn8;
            switch (Properties.Settings.Default.AutoCon)
            {
                case true:
                    AutoCon.Checked = true;
                    AutoCon.CheckState = CheckState.Checked;
                    break;
                case false:
                    AutoCon.Checked = false;
                    AutoCon.CheckState = CheckState.Unchecked;
                    break;
            }
        }

        private void ClearNamesBtn_Click(object sender, EventArgs e)
        {
            NewNameOf1.Text = "";
            NewNameOf2.Text = "";
            NewNameOf3.Text = "";
            NewNameOf4.Text = "";
            NewNameOf5.Text = "";
            NewNameOf6.Text = "";
            NewNameOf7.Text = "";
            NewNameOf8.Text = "";
            SaveAllMods();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (nameschanged > 0)
            {
                SaveAllMods();
                Properties.Settings.Default.Save();
                MessageBox.Show("All Settings have been saved successfully.", "Settings Panel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void SaveAllMods()
        {
            switch (Btn1)
            {
                case null:
                    Btn1 = "";
                    break;
                default:
                    Btn1 = NewNameOf1.Text;
                    break;
            }
            switch (Btn2)
            {
                case null:
                    Btn2 = "";
                    break;
                default:
                    Btn2= NewNameOf2.Text;
                    break;
            }
            switch (Btn3)
            {
                case null:
                    Btn3 = "";
                    break;
                default:
                    Btn3 = NewNameOf3.Text;
                    break;
            }
            switch (Btn4)
            {
                case null:
                    Btn4 = "";
                    break;
                default:
                    Btn4 = NewNameOf4.Text;
                    break;
            }
            switch (Btn5)
            {
                case null:
                    Btn5 = "";
                    break;
                default:
                    Btn5 = NewNameOf5.Text;
                    break;
            }
            switch (Btn6)
            {
                case null:
                    Btn6 = "";
                    break;
                default:
                    Btn6 = NewNameOf6.Text;
                    break;
            }
            switch (Btn7)
            {
                case null:
                    Btn7 = "";
                    break;
                default:
                    Btn7 = NewNameOf7.Text;
                    break;
            }
            switch (Btn8)
            {
                case null:
                    Btn8 = "";
                    break;
                default:
                    Btn8 = NewNameOf8.Text;
                    break;
            }
            Properties.Settings.Default.ONE   = Btn1;
            Properties.Settings.Default.TWO   = Btn2;
            Properties.Settings.Default.THREE = Btn3;
            Properties.Settings.Default.FOUR  = Btn4;
            Properties.Settings.Default.FIVE  = Btn5;
            Properties.Settings.Default.SIX   = Btn6;
            Properties.Settings.Default.SEVEN = Btn7;
            Properties.Settings.Default.EIGHT = Btn8;
        }

        private void NewNameOf1_TextChanged(object sender, EventArgs e)
        {
            if (Btn1 != NewNameOf1.Text)
            {
                nameschanged++;
            }
        }
        private void NewNameOf2_TextChanged(object sender, EventArgs e)
        {
            if (Btn2 != NewNameOf2.Text)
            {
                nameschanged++;
            }
        }
        private void NewNameOf3_TextChanged(object sender, EventArgs e)
        {
            if (Btn3 != NewNameOf3.Text)
            {
                nameschanged++;
            }
        }
        private void NewNameOf4_TextChanged(object sender, EventArgs e)
        {
            if (Btn4 != NewNameOf4.Text)
            {
                nameschanged++;
            }
        }
        private void NewNameOf5_TextChanged(object sender, EventArgs e)
        {
            if (Btn5 != NewNameOf5.Text)
            {
                nameschanged++;
            }
        }
        private void NewNameOf6_TextChanged(object sender, EventArgs e)
        {
            if (Btn6 != NewNameOf6.Text)
            {
                nameschanged++;
            }
        }
        private void NewNameOf7_TextChanged(object sender, EventArgs e)
        {
            if (Btn7 != NewNameOf7.Text)
            {
                nameschanged++;
            }
        }
        private void NewNameOf8_TextChanged(object sender, EventArgs e)
        {
            if (Btn8 != NewNameOf8.Text)
            {
                nameschanged++;
            }
        }

        private void TitlebarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveAllMods();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AutoCon_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoCon.Checked != Properties.Settings.Default.AutoCon)
            {
                nameschanged++;
            }

            switch (AutoCon.Checked)
            {
                case true:
                    AutoCon.CheckState = CheckState.Checked;
                    Properties.Settings.Default.AutoCon = true;
                    break;
                case false:
                    AutoCon.CheckState = CheckState.Unchecked;
                    Properties.Settings.Default.AutoCon = false;
                    break;
            }
        }
    }
}
