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

        // Variables to store the global variables locally
        private string globalName;
        private string globalON;
        private string globalOFF;

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

        // BackgroundWorker for loading variables.
        BackgroundWorker worker;

        // Initialiser.
        public SettingsForm(int btn)
        {
            InitializeComponent();
            btnID = btn;
            LoadValues();
            worker = new BackgroundWorker();
            worker.DoWork += LoadData;
            worker.RunWorkerAsync();
        }

        // Load values according to called integer.
        private void LoadValues()
        {
            switch (btnID)
            {
                case 1:
                    globalName = Properties.Settings.Default.ONE;
                    globalON = Properties.Settings.Default.ONE_ON;
                    globalOFF = Properties.Settings.Default.ONE_OFF;
                    break;
                case 2:
                    globalName = Properties.Settings.Default.TWO;
                    globalON = Properties.Settings.Default.TWO_ON;
                    globalOFF = Properties.Settings.Default.TWO_OFF;
                    break;
                case 3:
                    globalName = Properties.Settings.Default.THREE;
                    globalON = Properties.Settings.Default.THREE_ON;
                    globalOFF = Properties.Settings.Default.THREE_OFF;
                    break;
                case 4:
                    globalName = Properties.Settings.Default.FOUR;
                    globalON = Properties.Settings.Default.FOUR_ON;
                    globalOFF = Properties.Settings.Default.FOUR_OFF;
                    break;
                case 5:
                    globalName = Properties.Settings.Default.FIVE;
                    globalON = Properties.Settings.Default.FIVE_ON;
                    globalOFF = Properties.Settings.Default.FIVE_OFF;
                    break;
                case 6:
                    globalName = Properties.Settings.Default.SIX;
                    globalON = Properties.Settings.Default.SIX_ON;
                    globalOFF = Properties.Settings.Default.SIX_OFF;
                    break;
                case 7:
                    globalName = Properties.Settings.Default.SEVEN;
                    globalON = Properties.Settings.Default.SEVEN_ON;
                    globalOFF = Properties.Settings.Default.SEVEN_OFF;
                    break;
                case 8:
                    globalName = Properties.Settings.Default.EIGHT;
                    globalON = Properties.Settings.Default.EIGHT_ON;
                    globalOFF = Properties.Settings.Default.EIGHT_OFF;
                    break;
            }
        }

        // Setup values to other variables.
        private void LoadData(object sender, DoWorkEventArgs e)
        {
            NameTxtBox.Text = bName = globalName;
            ONTxtBox.Text = bON = globalON;
            OFFTxtBox.Text = bOFF = globalOFF;
        }

        // Basic Save Code.
        private void Save()
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


        // Save button refers to the void saveCheck().
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            saveCheck();
        }

        // Code to save changes.
        private void saveCheck()
        {
            if (nameschanged > 0 || onchanged > 0 || offchanged > 0)
            {
                Save();
                Properties.Settings.Default.Save();
                MessageBox.Show("All Settings have been saved successfully.", "Settings Panel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                this.Close();
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

        // Simple check to see if the Name values changed.
        private void NameTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (NameTxtBox.Text != globalName)
            {
                nameschanged++;
            }
        }

        // Simple check to see if the ON values changed.
        private void ONTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (ONTxtBox.Text != globalON)
            {
                onchanged++;
            }
        }

        // Simple check to see if the OFF values changed.
        private void OFFTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (OFFTxtBox.Text != globalOFF)
            {
                offchanged++;
            }
        }

        // Enter key confirms changes while Esc key closes Settings.
        private void SettingsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                saveCheck();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        // Cancel button to close the form.
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
