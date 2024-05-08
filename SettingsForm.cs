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
        // Code to move form.
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        // Variables to store the Button's information.
        private string bName;
        private string bON;
        private string bOFF;

        // Checker for changed values;
        private int nameschanged = 0;
        private int onchanged = 0;
        private int offchanged = 0;

        // Value for the referenced number from the MainForm.
        private int btnID = 0;

        // Initialiser
        public SettingsForm(int btn)
        {
            InitializeComponent();
            btnID = btn;
        }

        // Loading Sequence
        private void SettingsForm_Load(object sender, EventArgs e)
        {

            switch (btnID)
            {
                case 1:
                    NameTxtBox.Text = Properties.Settings.Default.ONE;
                    ONTxtBox.Text = Properties.Settings.Default.ONE_ON;
                    OFFTxtBox.Text = Properties.Settings.Default.ONE_OFF;
                    break;
                case 2:
                    NameTxtBox.Text = Properties.Settings.Default.TWO;
                    ONTxtBox.Text = Properties.Settings.Default.TWO_ON;
                    OFFTxtBox.Text = Properties.Settings.Default.TWO_OFF;
                    break;
                case 3:
                    NameTxtBox.Text = Properties.Settings.Default.THREE;
                    ONTxtBox.Text = Properties.Settings.Default.THREE_ON;
                    OFFTxtBox.Text = Properties.Settings.Default.THREE_OFF;
                    break;
                case 4:
                    NameTxtBox.Text = Properties.Settings.Default.FOUR;
                    ONTxtBox.Text = Properties.Settings.Default.FOUR_ON;
                    OFFTxtBox.Text = Properties.Settings.Default.FOUR_OFF;
                    break;
                case 5:
                    NameTxtBox.Text = Properties.Settings.Default.FIVE;
                    ONTxtBox.Text = Properties.Settings.Default.FIVE_ON;
                    OFFTxtBox.Text = Properties.Settings.Default.FIVE_OFF;
                    break;
                case 6:
                    NameTxtBox.Text = Properties.Settings.Default.SIX;
                    ONTxtBox.Text = Properties.Settings.Default.SIX_ON;
                    OFFTxtBox.Text = Properties.Settings.Default.SIX_OFF;
                    break;
                case 7:
                    NameTxtBox.Text = Properties.Settings.Default.SEVEN;
                    ONTxtBox.Text = Properties.Settings.Default.SEVEN_ON;
                    OFFTxtBox.Text = Properties.Settings.Default.SEVEN_OFF;
                    break;
                case 8:
                    NameTxtBox.Text = Properties.Settings.Default.EIGHT;
                    ONTxtBox.Text = Properties.Settings.Default.EIGHT_ON;
                    OFFTxtBox.Text = Properties.Settings.Default.EIGHT_OFF;
                    break;
            }
        }

        // Save button code to save changes.
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (nameschanged > 0 || onchanged > 0 || offchanged > 0)
            {
                SaveAllMods();
                Properties.Settings.Default.Save();
                MessageBox.Show("All Settings have been saved successfully.", "Settings Panel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        // Basic Save Code.
        private void SaveAllMods()
        {
            switch (NameTxtBox.Text)
            {
                case "":
                    bName = "";
                    break;
                default:
                    bName = NameTxtBox.Text;
                    break;
            }

            switch (ONTxtBox.Text)
            {
                case "":
                    switch (btnID)
                    {
                        case 1:
                            bON = "A";
                            break;
                        case 2:
                            bON = "B";
                            break;
                        case 3:
                            bON = "C";
                            break;
                        case 4:
                            bON = "D";
                            break;
                        case 5:
                            bON = "E";
                            break;
                        case 6:
                            bON = "F";
                            break;
                        case 7:
                            bON = "G";
                            break;
                        case 8:
                            bON = "H";
                            break;
                    }
                    break;
                default:
                    bON = ONTxtBox.Text;
                    break;
            }

            switch (OFFTxtBox.Text)
            {
                case "":
                    switch (btnID)
                    {
                        case 1:
                            bOFF = "a";
                            break;
                        case 2:
                            bOFF = "b";
                            break;
                        case 3:
                            bOFF = "c";
                            break;
                        case 4:
                            bOFF = "d";
                            break;
                        case 5:
                            bOFF = "e";
                            break;
                        case 6:
                            bOFF = "f";
                            break;
                        case 7:
                            bOFF = "g";
                            break;
                        case 8:
                            bOFF = "h";
                            break;
                    }
                    break;
                default:
                    bOFF = OFFTxtBox.Text;
                    break;
            }

            switch (btnID)
            {
                case 1:
                    Properties.Settings.Default.ONE = bName;
                    Properties.Settings.Default.ONE_ON = bON;
                    Properties.Settings.Default.ONE_OFF = bOFF;
                    break;
                case 2:
                    Properties.Settings.Default.TWO = bName;
                    Properties.Settings.Default.TWO_ON = bON;
                    Properties.Settings.Default.TWO_OFF = bOFF;
                    break;
                case 3:
                    Properties.Settings.Default.THREE = bName;
                    Properties.Settings.Default.THREE_ON = bON;
                    Properties.Settings.Default.THREE_OFF = bOFF;
                    break;
                case 4:
                    Properties.Settings.Default.FOUR = bName;
                    Properties.Settings.Default.FOUR_ON = bON;
                    Properties.Settings.Default.FOUR_OFF = bOFF;
                    break;
                case 5:
                    Properties.Settings.Default.FIVE = bName;
                    Properties.Settings.Default.FIVE_ON = bON;
                    Properties.Settings.Default.FIVE_OFF = bOFF;
                    break;
                case 6:
                    Properties.Settings.Default.SIX = bName;
                    Properties.Settings.Default.SIX_ON = bON;
                    Properties.Settings.Default.SIX_OFF = bOFF;
                    break;
                case 7:
                    Properties.Settings.Default.SEVEN = bName;
                    Properties.Settings.Default.SEVEN_ON = bON;
                    Properties.Settings.Default.SEVEN_OFF = bOFF;
                    break;
                case 8:
                    Properties.Settings.Default.EIGHT = bName;
                    Properties.Settings.Default.EIGHT_ON = bON;
                    Properties.Settings.Default.EIGHT_OFF = bOFF;
                    break;
            }
        }
        
        // The TitleBar Code.
        private void TitlebarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        // Make the label as same as The TitleBar.
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }


        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (nameschanged > 0 || onchanged > 0 || offchanged > 0)
            {
                SaveAllMods();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NameTxtBox_TextChanged(object sender, EventArgs e)
        {
            switch (btnID)
            {
                case 1:
                    if (NameTxtBox.Text != Properties.Settings.Default.ONE)
                    {
                        nameschanged++;
                    }
                    break;
                case 2:
                    if (NameTxtBox.Text != Properties.Settings.Default.TWO)
                    {
                        nameschanged++;
                    }
                    break;
                case 3:
                    if (NameTxtBox.Text != Properties.Settings.Default.THREE)
                    {
                        nameschanged++;
                    }
                    break;
                case 4:
                    if (NameTxtBox.Text != Properties.Settings.Default.FOUR)
                    {
                        nameschanged++;
                    }
                    break;
                case 5:
                    if (NameTxtBox.Text != Properties.Settings.Default.FIVE)
                    {
                        nameschanged++;
                    }
                    break;
                case 6:
                    if (NameTxtBox.Text != Properties.Settings.Default.SIX)
                    {
                        nameschanged++;
                    }
                    break;
                case 7:
                    if (NameTxtBox.Text != Properties.Settings.Default.SEVEN)
                    {
                        nameschanged++;
                    }
                    break;
                case 8:
                    if (NameTxtBox.Text != Properties.Settings.Default.EIGHT)
                    {
                        nameschanged++;
                    }
                    break;
            }
        }

        private void ONTxtBox_TextChanged(object sender, EventArgs e)
        {
            switch (btnID)
            {
                case 1:
                    if (ONTxtBox.Text != Properties.Settings.Default.ONE_ON)
                    {
                        onchanged++;
                    }
                    break;
                case 2:
                    if (ONTxtBox.Text != Properties.Settings.Default.TWO_ON)
                    {
                        onchanged++;
                    }
                    break;
                case 3:
                    if (ONTxtBox.Text != Properties.Settings.Default.THREE_ON)
                    {
                        onchanged++;
                    }
                    break;
                case 4:
                    if (ONTxtBox.Text != Properties.Settings.Default.FOUR_ON)
                    {
                        onchanged++;
                    }
                    break;
                case 5:
                    if (ONTxtBox.Text != Properties.Settings.Default.FIVE_ON)
                    {
                        onchanged++;
                    }
                    break;
                case 6:
                    if (ONTxtBox.Text != Properties.Settings.Default.SIX_ON)
                    {
                        onchanged++;
                    }
                    break;
                case 7:
                    if (ONTxtBox.Text != Properties.Settings.Default.SIX_ON)
                    {
                        onchanged++;
                    }
                    break;
                case 8:
                    if (ONTxtBox.Text != Properties.Settings.Default.EIGHT_ON)
                    {
                        onchanged++;
                    }
                    break;
            }
        }

        private void OFFTxtBox_TextChanged(object sender, EventArgs e)
        {
            switch (btnID)
            {
                case 1:
                    if (OFFTxtBox.Text != Properties.Settings.Default.ONE_OFF)
                    {
                        offchanged++;
                    }
                    break;
                case 2:
                    if (OFFTxtBox.Text != Properties.Settings.Default.TWO_OFF)
                    {
                        offchanged++;
                    }
                    break;
                case 3:
                    if (OFFTxtBox.Text != Properties.Settings.Default.THREE_OFF)
                    {
                        offchanged++;
                    }
                    break;
                case 4:
                    if (OFFTxtBox.Text != Properties.Settings.Default.FOUR_OFF)
                    {
                        offchanged++;
                    }
                    break;
                case 5:
                    if (OFFTxtBox.Text != Properties.Settings.Default.FIVE_OFF)
                    {
                        offchanged++;
                    }
                    break;
                case 6:
                    if (OFFTxtBox.Text != Properties.Settings.Default.SIX_OFF)
                    {
                        offchanged++;
                    }
                    break;
                case 7:
                    if (OFFTxtBox.Text != Properties.Settings.Default.SEVEN_OFF)
                    {
                        offchanged++;
                    }
                    break;
                case 8:
                    if (OFFTxtBox.Text != Properties.Settings.Default.EIGHT_OFF)
                    {
                        offchanged++;
                    }
                    break;
            }
        }

        private void SettingsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                
            }
        }
    }
}
