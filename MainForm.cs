using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace BtC
{
    public partial class MainForm : Form
    {
        // Code to give user ability to move the Form.
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        
        // Color variables for buttons (ON & OFF).
        private readonly Color OnBack = Color.FromArgb(0, 192, 0);
        private readonly Color OffBack = Color.FromArgb(30, 30, 30);

        private static SerialPort serialPort = new SerialPort();

        // Boolean to check whether button is ON or OFF.
        bool is1on = false; bool is2on = false; bool is3on = false; bool is4on = false; bool is5on = false; bool is6on = false; bool is7on = false; bool is8on = false;

        // COM port string.
        static string COMport = "";

        public MainForm()
        {
            InitializeComponent();

            // Default Position for BtC.
            int ScrWidth = Screen.PrimaryScreen.Bounds.Size.Width;
            int ScrHeight = Screen.PrimaryScreen.Bounds.Size.Height;
            int BtCWidth = this.Width;
            int BtCHeight = this.Height;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((ScrWidth - BtCWidth) - (((ScrWidth / 2)/2)/2), (ScrHeight - BtCHeight) / 2);
            serialPort.BaudRate = 9600;
            serialPort.Parity = Parity.None;
            serialPort.DataBits = 8;
            serialPort.StopBits = StopBits.One;
            GetAvailablePorts();

            // Setting the app to DISCONnected mode.
            DisCon();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            // Call Custom Names if set.
            LoadNames();

            // Checking whether the AutoCon Boolean is true.
            switch (Properties.Settings.Default.AutoCon)
            {
                case true:
                    AutoConnector();
                    break;
                case false:
                    break;
            } 
        }

        private void AutoConnector()
        {
            switch (Properties.Settings.Default.AutoCon)
            {
                case true:
                    COMport = Properties.Settings.Default.LastConCOM;
                    SPDropDown.SelectedItem = Properties.Settings.Default.LastConCOM;
                    while (serialPort.IsOpen)
                    {
                        serialPort.Close();
                    }
                    Selection();
                    break;
                case false:
                    MessageBox.Show("Auto Connection is turned OFF.", "Turn ON AutoCon in Settings to continue !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }

        }

        public void GetAvailablePorts()
        {
            // Checking and fetching all Serial Ports from system and arranging in an array.
            string[] ports = SerialPort.GetPortNames();

            // Setting values of the dropdown to the serial port values fetched before.
            SPDropDown.Items.AddRange(ports);
        }

        private void SPDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            // The string value COMport will be the selected serial port from the dropdown.
            COMport = this.SPDropDown.SelectedItem.ToString();
            Properties.Settings.Default.LastConCOM = COMport;
            Properties.Settings.Default.Save();

            // Checks whether the serial port is active before connecting.
            while (serialPort.IsOpen)
            {
                serialPort.Close();
            }
            Selection();
        }

        private void Selection()
        {
            // Check if selection is not empty.
            if (SPDropDown != null)
            {
                // Checks again if selection is not empty or text is not empty
                if (SPDropDown.SelectedIndex > -1 || SPDropDown.SelectedItem.ToString() != null)
                {
                    // Tries to connect to the serial port.
                    Progresbar.SliderColor = Color.Yellow;
                    Progresbar.Value = 100;
                    Connect();
                }
                else
                {
                    // Calls disconnection.
                    Progresbar.SliderColor = Color.Red;
                    Progresbar.Value = 100;
                    DisCon();
                }
            }

            // Rare case : warns the user to not put empty values
            else
            {
                MessageBox.Show("Select HC05 COM port to Continue.", "Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Connector for serial port
        private void Connect()
        {
            // Puts Focus on Form
            this.Focus();
            try
            {
                // Checks if the port is NOT open.
                if (!serialPort.IsOpen)
                {
                    serialPort.PortName = COMport;
                    serialPort.Open();
                    Progresbar.Value = 100;
                    ReCon();
                }
            }
            // if connection fails, a possible ERROR appears. Out of which, the most common is shown below.
            catch (Exception e)
            {
                // ERROR name : Semaphore Timeout. This one will require instructions.
                if (e.ToString().Contains("timeout"))
                {
                    // For the recurring "Semaphore Timeout" error.
                    MessageBox.Show("Listen carefully, Restart (Turn OFF & again turn ON) your desktop's BlueTooth. Then click the refresh.", "Timed out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                    // Close the serial port to avoid other possible exceptions.
                    serialPort.Close();

                    // Calls Disconnection State of UI.
                    DisCon();
                }

                // Else just show what the error is.
                else
                {
                    // For any other unknown error.
                    MessageBox.Show(e.Message, "There seems to be a PROBLEM !!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Close the serial port to avoid other possible exceptions.
                    serialPort.Close();

                    // Calls Disconnection State of UI.
                    DisCon();
                }
            }
        }

        // Sends a Byte to the Serial Port. Required part of this app.
        private static void SendByte(string message)
        {
            // Checks if serial port is open 
            if (serialPort.IsOpen)
            {
               //Sends a string to the serial port
                serialPort.Write(message.ToString());
            }
            else
            {
                MessageBox.Show("Connection Lost, Press Refresh to try connecting again", "There seems to be a PROBLEM !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         
        // Load customized names for buttons.
        public void LoadNames()
        {
            // Variables for temporary reference.
            string ONEtext = Properties.Settings.Default.ONE;
            string TWOtext = Properties.Settings.Default.TWO;
            string THREEtext = Properties.Settings.Default.THREE;
            string FOURtext = Properties.Settings.Default.FOUR;
            string FIVEtext = Properties.Settings.Default.FIVE;
            string SIXtext = Properties.Settings.Default.SIX;
            string SEVENtext = Properties.Settings.Default.SEVEN;
            string EIGHTtext = Properties.Settings.Default.EIGHT;
         ;

            //checks for empty values to replace with numbers,
            //else, puts names from settings.
            switch (ONEtext)
            {
                case "":
                    ONE.Text = "1";
                    break;
                default:
                    ONE.Text = Properties.Settings.Default.ONE;
                    break;
            }

            switch (TWOtext)
            {
                case "":
                    TWO.Text = "2";
                    break;
                default:
                    TWO.Text = Properties.Settings.Default.TWO;
                    break;
            }

            switch (THREEtext)
            {
                case "":
                    THREE.Text = "3";
                    break;
                default:
                    THREE.Text = Properties.Settings.Default.THREE;
                    break;
            }

            switch (FOURtext)
            {
                case "":
                    FOUR.Text = "4";
                    break;
                default:
                    FOUR.Text = Properties.Settings.Default.FOUR;
                    break;
            }

            switch (FIVEtext)
            {
                case "":
                    FIVE.Text = "5";
                    break;
                default:
                    FIVE.Text = Properties.Settings.Default.FIVE;
                    break;
            }

            switch (SIXtext)
            {
                case "":
                    SIX.Text = "6";
                    break;
                default:
                    SIX.Text = Properties.Settings.Default.SIX;
                    break;
            }

            switch (SEVENtext)
            {
                case "":
                    SEVEN.Text = "7";
                    break;
                default:
                    SEVEN.Text = Properties.Settings.Default.SEVEN;
                    break;
            }

            switch (EIGHTtext)
            {
                case "":
                    EIGHT.Text = "8";
                    break;
                default:
                    EIGHT.Text = Properties.Settings.Default.EIGHT;
                    break;
            }
        }

        //Form moving code applies here
        private void TitlebarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        // And also here.
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        // DA BIG RED BUTTON to close the form.
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // DA BIG YELLOW BUTTON to minimise the form.
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // To enable the buttons if connected.
        private void ReCon()
        {
            label2.Text = "⦿ Connected";
            label2.ForeColor = Color.FromArgb(0, 192, 0);
            ONE.Enabled = true;
            TWO.Enabled = true;
            THREE.Enabled = true;
            FOUR.Enabled = true;
            FIVE.Enabled = true;
            SIX.Enabled = true;
            SEVEN.Enabled = true;
            EIGHT.Enabled = true;
            Progresbar.SliderColor = Color.Lime;
            Progresbar.Value = 100;
        }

        // To disable the buttons if not connected.
        private void DisCon()
        {
            label2.Text = "⦿ Disconnected";
            label2.ForeColor = Color.Red;
            ONE.Enabled = false;
            TWO.Enabled = false;
            THREE.Enabled = false;
            FOUR.Enabled = false;
            FIVE.Enabled = false;
            SIX.Enabled = false;
            SEVEN.Enabled = false;
            EIGHT.Enabled = false;
            Progresbar.SliderColor = Color.Red;
            Progresbar.Value = 100;
        }

        // Tells what to do if button is ON.
        private void OnBtn(int btn)
        {
            switch (btn)
            {
                case 1:
                    ONE.ForeColor = Color.WhiteSmoke;
                    ONE.BackColor = OnBack;
                    ONE.FlatAppearance.BorderColor = OnBack;
                    break;
                case 2:
                    TWO.ForeColor = Color.WhiteSmoke;
                    TWO.BackColor = OnBack;
                    TWO.FlatAppearance.BorderColor = OnBack;
                    break;
                case 3:
                    THREE.ForeColor = Color.WhiteSmoke;
                    THREE.BackColor = OnBack;
                    THREE.FlatAppearance.BorderColor = OnBack;
                    break;
                case 4:
                    FOUR.ForeColor = Color.WhiteSmoke;
                    FOUR.BackColor = OnBack;
                    FOUR.FlatAppearance.BorderColor = OnBack;
                    break;
                case 5:
                    FIVE.ForeColor = Color.WhiteSmoke;
                    FIVE.BackColor = OnBack;
                    FIVE.FlatAppearance.BorderColor = OnBack;
                    break;
                case 6:
                    SIX.ForeColor = Color.WhiteSmoke;
                    SIX.BackColor = OnBack;
                    SIX.FlatAppearance.BorderColor = OnBack;
                    break;
                case 7:
                    SEVEN.ForeColor = Color.WhiteSmoke;
                    SEVEN.BackColor = OnBack;
                    SEVEN.FlatAppearance.BorderColor = OnBack;
                    break;
                case 8:
                    EIGHT.ForeColor = Color.WhiteSmoke;
                    EIGHT.BackColor = OnBack;
                    EIGHT.FlatAppearance.BorderColor = OnBack;
                    break;
            }
        }

        // Tells what to do if button is OFF.
        private void OffBtn(int btn)
        {
            switch (btn)
            {
                case 1:
                    ONE.ForeColor = Color.WhiteSmoke;
                    ONE.BackColor = OffBack;
                    ONE.FlatAppearance.BorderColor = Color.Gray;
                    break;
                case 2:
                    TWO.ForeColor = Color.WhiteSmoke;
                    TWO.BackColor = OffBack;
                    TWO.FlatAppearance.BorderColor = Color.Gray;
                    break;
                case 3:
                    THREE.ForeColor = Color.WhiteSmoke;
                    THREE.BackColor = OffBack;
                    THREE.FlatAppearance.BorderColor = Color.Gray;
                    break;
                case 4:
                    FOUR.ForeColor = Color.WhiteSmoke;
                    FOUR.BackColor = OffBack;
                    FOUR.FlatAppearance.BorderColor = Color.Gray;
                    break;
                case 5:
                    FIVE.ForeColor = Color.WhiteSmoke;
                    FIVE.BackColor = OffBack;
                    FIVE.FlatAppearance.BorderColor = Color.Gray;
                    break;
                case 6:
                    SIX.ForeColor = Color.WhiteSmoke;
                    SIX.BackColor = OffBack;
                    SIX.FlatAppearance.BorderColor = Color.Gray;
                    break;
                case 7:
                    SEVEN.ForeColor = Color.WhiteSmoke;
                    SEVEN.BackColor = OffBack;
                    SEVEN.FlatAppearance.BorderColor = Color.Gray;
                    break;
                case 8:
                    EIGHT.ForeColor = Color.WhiteSmoke;
                    EIGHT.BackColor = OffBack;
                    EIGHT.FlatAppearance.BorderColor = Color.Gray;
                    break;
            }
        }
        // Turns a button into a toggle.
        private void ONE_Click(object sender, EventArgs e)
        {
            switch (is1on)
            {
                case true:
                    is1on = false;
                    SendByte("a");
                    OffBtn(1);
                    break;
                case false:
                    is1on = true;
                    SendByte("A");
                    OnBtn(1);
                    break;
            }
        }

        // Turns a button into a toggle.
        private void TWO_Click(object sender, EventArgs e)
        {
            switch (is2on)
            {
                case true:
                    is2on = false;
                    SendByte("b");
                    OffBtn(2);
                    break;
                case false:
                    is2on = true;
                    SendByte("B");
                    OnBtn(2);
                    break;
            }
        }

        // Turns a button into a toggle.
        private void THREE_Click(object sender, EventArgs e)
        {
            switch (is3on)
            {
                case true:
                    is3on = false;
                    SendByte("c");
                    OffBtn(3);
                    break;
                case false:
                    is3on = true;
                    SendByte("C");
                    OnBtn(3);
                    break;
            }
        }

        // Turns a button into a toggle.
        private void FOUR_Click(object sender, EventArgs e)
        {
            switch (is4on)
            {
                case true:
                    is4on = false;
                    SendByte("d");
                    OffBtn(4);
                    break;
                case false:
                    is4on = true;
                    SendByte("D");
                    OnBtn(4);
                    break;
            }
        }

        // Turns a button into a toggle.
        private void FIVE_Click(object sender, EventArgs e)
        {
            switch (is5on)
            {
                case true:
                    is5on = false;
                    SendByte("e");
                    OffBtn(5);
                    break;
                case false:
                    is5on = true;
                    SendByte("E");
                    OnBtn(5);
                    break;
            }
        }

        // Turns a button into a toggle.
        private void SIX_Click(object sender, EventArgs e)
        {
            switch (is6on)
            {
                case true:
                    is6on = false;
                    SendByte("f");
                    OffBtn(6);
                    break;
                case false:
                    is6on = true;
                    SendByte("F");
                    OnBtn(6);
                    break;
            }
        }

        // Turns a button into a toggle.
        private void SEVEN_Click(object sender, EventArgs e)
        {
            switch (is7on)
            {
                case true:
                    is7on = false;
                    SendByte("g");
                    OffBtn(7);
                    break;
                case false:
                    is7on = true;
                    SendByte("G");
                    OnBtn(7);
                    break;
            }
        }

        // Turns a button into a toggle.
        private void EIGHT_Click(object sender, EventArgs e)
        {
            switch (is8on)
            {
                case true:
                    is8on = false;
                    SendByte("h");
                    OffBtn(8);
                    break;
                case false:
                    is8on = true;
                    SendByte("H");
                    OnBtn(8);
                    break;
            }
        }

        // Calls the Settings form.
        private void Settings_Btn_Click(object sender, EventArgs e)
        {
            Form settings = new SettingsForm();
            settings.FormClosed += delegate
            {
                LoadNames();
            };
            settings.ShowDialog();
        }

        // Closes the port when the app is closing.
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort.Close();
            DisCon();
        }

        // Allows the user to toggle buttons by pressing the number/numpad keys
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                switch (is1on)
                {
                    case true:
                        is1on = false;
                        SendByte("a");
                        OffBtn(1);
                        break;
                    case false:
                        is1on = true;
                        SendByte("A");
                        OnBtn(1);
                        break;
                }
            }
            else if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                switch (is2on)
                {
                    case true:
                        is2on = false;
                        SendByte("b");
                        OffBtn(2);
                        break;
                    case false:
                        is2on = true;
                        SendByte("B");
                        OnBtn(2);
                        break;
                }
            }
            else if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                switch (is3on)
                {
                    case true:
                        is3on = false;
                        SendByte("c");
                        OffBtn(3);
                        break;
                    case false:
                        is3on = true;
                        SendByte("C");
                        OnBtn(3);
                        break;
                }
            }
            else if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                switch (is4on)
                {
                    case true:
                        is4on = false;
                        SendByte("d");
                        OffBtn(4);
                        break;
                    case false:
                        is4on = true;
                        SendByte("D");
                        OnBtn(4);
                        break;
                }
            }
            else if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                switch (is5on)
                {
                    case true:
                        is5on = false;
                        SendByte("e");
                        OffBtn(5);
                        break;
                    case false:
                        is5on = true;
                        SendByte("E");
                        OnBtn(5);
                        break;
                }
            }
            else if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                switch (is6on)
                {
                    case true:
                        is6on = false;
                        SendByte("f");
                        OffBtn(6);
                        break;
                    case false:
                        is6on = true;
                        SendByte("F");
                        OnBtn(6);
                        break;
                }
            }
            else if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                switch (is7on)
                {
                    case true:
                        is7on = false;
                        SendByte("g");
                        OffBtn(7);
                        break;
                    case false:
                        is7on = true;
                        SendByte("G");
                        OnBtn(7);
                        break;
                }
            }
            else if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                switch (is8on)
                {
                    case true:
                        is8on = false;
                        SendByte("h");
                        OffBtn(8);
                        break;
                    case false:
                        is8on = true;
                        SendByte("H");
                        OnBtn(8);
                        break;
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                Connect();
            }
        }

        //Refreshes the connection if Clicked.
        private void Refresh_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void DisconBtn_Click(object sender, EventArgs e)
        {
            switch (serialPort.IsOpen)
            {
                case true:
                    serialPort.Close();
                    DisCon();
                    break;
                case false:
                    break;
            }
        }
    }
}