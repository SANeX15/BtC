﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Timers;
using System.Windows.Forms;
using SANeX;

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
        private Color OnBack;
        private Color OnBorder;
        private Color OffBack;
        private Color OffBorder;
        private Color OnText;
        private Color OffText;
        private Color Window;

        // Protagonist of this project.
        private static SerialPort serialPort = new SerialPort();

        // For the Context Menu
        Control _sourceControl = null;

        // Boolean to check whether button is ON or OFF.
        bool is1on = false; bool is2on = false; bool is3on = false; bool is4on = false; bool is5on = false; bool is6on = false; bool is7on = false; bool is8on = false;

        // COM port string.
        static string COMport = "";

        // Refresh Timer for GetAvailablePorts()
        System.Timers.Timer sTimer = new System.Timers.Timer();

        // COM variable for button ONE
        private string ONE_ON = Properties.Settings.Default.ONE_ON;
        private string ONE_OFF = Properties.Settings.Default.ONE_OFF;

        // COM variable for button TWO
        private string TWO_ON = Properties.Settings.Default.TWO_ON;
        private string TWO_OFF = Properties.Settings.Default.TWO_OFF;

        // COM variable for button THREE
        private string THREE_ON = Properties.Settings.Default.THREE_ON;
        private string THREE_OFF = Properties.Settings.Default.THREE_OFF;

        // COM variable for button FOUR
        private string FOUR_ON = Properties.Settings.Default.FOUR_ON;
        private string FOUR_OFF = Properties.Settings.Default.FOUR_OFF;

        // COM variable for button FIVE
        private string FIVE_ON = Properties.Settings.Default.FIVE_ON;
        private string FIVE_OFF = Properties.Settings.Default.FIVE_OFF;

        // COM variable for button SIX
        private string SIX_ON = Properties.Settings.Default.SIX_ON;
        private string SIX_OFF = Properties.Settings.Default.SIX_OFF;

        // COM variable for button SEVEN
        private string SEVEN_ON = Properties.Settings.Default.SEVEN_ON;
        private string SEVEN_OFF = Properties.Settings.Default.SEVEN_OFF;

        // COM variable for button EIGHT
        private string EIGHT_ON = Properties.Settings.Default.EIGHT_ON;
        private string EIGHT_OFF = Properties.Settings.Default.EIGHT_OFF;

        // Auto Connection Enabled ? checker
        private bool AutoConBool;

        BackgroundWorker worker = new BackgroundWorker();

        public MainForm()
        {
            InitializeComponent();

            // Default Position for BtC.
            int ScrWidth = Screen.PrimaryScreen.Bounds.Size.Width;
            int ScrHeight = Screen.PrimaryScreen.Bounds.Size.Height;
            int BtCWidth = this.Width;
            int BtCHeight = this.Height;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((ScrWidth - BtCWidth) - (((ScrWidth / 2) / 2) / 2), (ScrHeight - BtCHeight) / 2);
            SetTheme();
            worker.DoWork += DoWork;

            serialPort.BaudRate = 9600;
            serialPort.Parity = Parity.None;
            serialPort.DataBits = 8;
            serialPort.StopBits = StopBits.One;
            GetAvailablePorts();

            sTimer.Elapsed += new ElapsedEventHandler(sTimer_Elapsed);
            sTimer.Interval = 2000;
            sTimer.Enabled = true;
            sTimer.Start();

            // Setting the app to DISCONnected mode.
            DisCon();
        }

        private void DoWork(object sender, DoWorkEventArgs e)
        {
            // Call Custom Names if set.
            LoadSettings();

            // Checking whether the AutoCon Boolean is true.
            switch (Properties.Settings.Default.AutoCon)
            {
                case true:
                    AutoConBool = true;
                    AutoConnector();
                    AutoConMode();
                    break;
                case false:
                    AutoConBool = false;
                    AutoConMode();
                    break;
            }
        }

        private void SetTheme()
        {
            OnBack = Properties.Settings.Default.ONColor;
            OnBorder = Properties.Settings.Default.ONBorder;
            OnText = Properties.Settings.Default.DarkText;
            OffBack = Properties.Settings.Default.DarkBackOFF;
            OffBorder = Properties.Settings.Default.DarkBackOFF;
            OffText = Properties.Settings.Default.DarkText;
            Window = Properties.Settings.Default.DarkWindow;
        }

        private void sTimer_Elapsed(object source, ElapsedEventArgs e)
        {
            GetAvailablePorts();
            sTimer.Start();
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
            SPDropDown.Items.Clear();

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

        private void IndicatorState(int state)
        {
            Progresbar.Value = 100;
            switch (state)
            {
                case 0:
                    Progresbar.ForeColor = Color.Red;
                    break;
                case 1:
                    Progresbar.ForeColor = Color.Lime;
                    break;
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
                    IndicatorState(1);
                    ReCon();
                }
            }
            // if connection fails, a possible ERROR appears. Out of which, the most common is shown below.
            catch (Exception e)
            {
                // ERROR name : Semaphore Timeout. This one will require instructions.
                if (e is TimeoutException)
                {
                    // For the recurring "Semaphore Timeout" error.
                    MessageBox.Show("Connection Timed Out\n The following instructions are to be read carefully\n 1. Restart (Turn OFF & again turn ON) your device's BlueTooth.\n 2. Click Refresh Connection (2nd Button on the Bottom Toolbar).", "Exception Get: TimeOut", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Close the serial port to avoid other possible exceptions.
                    serialPort.Close();

                    // Calls Disconnection State of UI.
                    DisCon();
                }
                else if(e is NullReferenceException)
                {
                    MessageBox.Show("Check whether you have selected a COM port in the dropdown below.", "Exception Get: NULL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Sends a Byte to the Serial Port. Required part of this app.
        private static void SendByte(string msg)
        {
            // Checks if serial port is open 
            if (serialPort.IsOpen)
            {
                //Sends a string to the serial port
                serialPort.Write(msg.ToString());
            }
            else
            {
                MessageBox.Show("Connection Lost, Press Refresh to try connecting again", "There seems to be a PROBLEM !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load customized names for buttons.
        public void LoadSettings()
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

            switch (ONE_ON)
            {
                case "":
                    ONE_ON = "A";
                    break;
                default:
                    ONE_ON = Properties.Settings.Default.ONE_ON;
                    break;
            }

            switch (ONE_OFF)
            {
                case "":
                    ONE_OFF = "a";
                    break;
                default:
                    ONE_OFF = Properties.Settings.Default.ONE_OFF;
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

            switch (TWO_ON)
            {
                case "":
                    TWO_ON = "B";
                    break;
                default:
                    TWO_ON = Properties.Settings.Default.TWO_ON;
                    break;
            }

            switch (TWO_OFF)
            {
                case "":
                    TWO_OFF = "b";
                    break;
                default:
                    TWO_OFF = Properties.Settings.Default.TWO_OFF;
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

            switch (THREE_ON)
            {
                case "":
                    THREE_ON = "C";
                    break;
                default:
                    THREE_ON = Properties.Settings.Default.THREE_ON;
                    break;
            }

            switch (THREE_OFF)
            {
                case "":
                    THREE_OFF = "c";
                    break;
                default:
                    THREE_OFF = Properties.Settings.Default.THREE_OFF;
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

            switch (FOUR_ON)
            {
                case "":
                    FOUR_ON = "D";
                    break;
                default:
                    FOUR_ON = Properties.Settings.Default.FOUR_ON;
                    break;
            }

            switch (FOUR_OFF)
            {
                case "":
                    FOUR_OFF = "d";
                    break;
                default:
                    FOUR_OFF = Properties.Settings.Default.FOUR_OFF;
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

            switch (FIVE_ON)
            {
                case "":
                    FIVE_ON = "E";
                    break;
                default:
                    FIVE_ON = Properties.Settings.Default.FIVE_ON;
                    break;
            }

            switch (FIVE_OFF)
            {
                case "":
                    FIVE_OFF = "e";
                    break;
                default:
                    FIVE_OFF = Properties.Settings.Default.FIVE_OFF;
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

            switch (SIX_ON)
            {
                case "":
                    SIX_ON = "F";
                    break;
                default:
                    SIX_ON = Properties.Settings.Default.SIX_ON;
                    break;
            }

            switch (SIX_OFF)
            {
                case "":
                    SIX_OFF = "f";
                    break;
                default:
                    SIX_OFF = Properties.Settings.Default.SIX_OFF;
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

            switch (SEVEN_ON)
            {
                case "":
                    SEVEN_ON = "G";
                    break;
                default:
                    SEVEN_ON = Properties.Settings.Default.SEVEN_ON;
                    break;
            }

            switch (SEVEN_OFF)
            {
                case "":
                    SEVEN_OFF = "g";
                    break;
                default:
                    SEVEN_OFF = Properties.Settings.Default.SEVEN_OFF;
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

            switch (EIGHT_ON)
            {
                case "":
                    EIGHT_ON = "H";
                    break;
                default:
                    EIGHT_ON = Properties.Settings.Default.EIGHT_ON;
                    break;
            }

            switch (EIGHT_OFF)
            {
                case "":
                    EIGHT_OFF = "h";
                    break;
                default:
                    EIGHT_OFF = Properties.Settings.Default.EIGHT_OFF;
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

        // To enable the buttons if connected.
        private void ReCon()
        {
            ONE.Enabled = true;
            TWO.Enabled = true;
            THREE.Enabled = true;
            FOUR.Enabled = true;
            FIVE.Enabled = true;
            SIX.Enabled = true;
            SEVEN.Enabled = true;
            EIGHT.Enabled = true;
            IndicatorState(1);
        }

        // To disable the buttons if not connected.
        private void DisCon()
        {
            OffBtn(ONE);
            OffBtn(TWO);
            OffBtn(THREE);
            OffBtn(FOUR);
            OffBtn(FIVE);
            OffBtn(SIX);
            OffBtn(SEVEN);
            OffBtn(EIGHT);
            ONE.Enabled = false;
            TWO.Enabled = false;
            THREE.Enabled = false;
            FOUR.Enabled = false;
            FIVE.Enabled = false;
            SIX.Enabled = false;
            SEVEN.Enabled = false;
            EIGHT.Enabled = false;
            IndicatorState(0);
            SPDropDown.Texts = "Choose COM port";
        }

        // Tells what to do if button is ON.
        private void OnBtn(CC_ModernButton btn)
        {
            btn.ForeColor = OnText;
            btn.BackColor = OnBack;
            btn.BorderColor = OnBorder;
        }

        // Tells what to do if button is OFF.
        private void OffBtn(CC_ModernButton btn)
        {
            btn.ForeColor = OffText;
            btn.BackColor = OffBack;
            btn.BorderColor = OffBorder;
        }
        // Turns a button into a toggle.
        private void ONE_Click(object sender, EventArgs e)
        {
            SignalCall(1);
        }

        // Turns a button into a toggle.
        private void TWO_Click(object sender, EventArgs e)
        {
            SignalCall(2);
        }

        // Turns a button into a toggle.
        private void THREE_Click(object sender, EventArgs e)
        {
            SignalCall(3);
        }

        // Turns a button into a toggle.
        private void FOUR_Click(object sender, EventArgs e)
        {
            SignalCall(4);
        }

        // Turns a button into a toggle.
        private void FIVE_Click(object sender, EventArgs e)
        {
            SignalCall(5);
        }

        // Turns a button into a toggle.
        private void SIX_Click(object sender, EventArgs e)
        {
            SignalCall(6);
        }

        // Turns a button into a toggle.
        private void SEVEN_Click(object sender, EventArgs e)
        {
            SignalCall(7);
        }

        // Turns a button into a toggle.
        private void EIGHT_Click(object sender, EventArgs e)
        {
            SignalCall(8);
        }
        
        // Calls the Settings form.
        private void CallSettings(int id)
        {
            Form settings = new SettingsForm(id);
            settings.FormClosed += delegate
            {
                LoadSettings();
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
            if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                SignalCall(1);
            }
            else if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                SignalCall(2);
            }
            else if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                SignalCall(3);
            }
            else if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                SignalCall(4);
            }
            else if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                SignalCall(5);
            }
            else if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                SignalCall(6);
            }
            else if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                SignalCall(7);
            }
            else if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                SignalCall(8);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                Connect();
            }
        }

        //Refreshes the connection if Clicked.
        private void Refresh_Click(object sender, EventArgs e)
        {
            SPDropDown.SelectedItem = COMport;
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

        private void EditButtonMenu_Opened(object sender, EventArgs e)
        {
            _sourceControl = EditButtonMenu.SourceControl;
        }
        
        private void Settings_Click(object sender, EventArgs e)
        {
            switch (_sourceControl.Name)
            {
                case "ONE":
                    CallSettings(1);
                    break;
                case "TWO":
                    CallSettings(2);
                    break;
                case "THREE":
                    CallSettings(3);
                    break;
                case "FOUR":
                    CallSettings(4);
                    break;
                case "FIVE":
                    CallSettings(5);
                    break;
                case "SIX":
                    CallSettings(6);
                    break;
                case "SEVEN":
                    CallSettings(7);
                    break;
                case "EIGHT":
                    CallSettings(8);
                    break;
            }
        }

        private void SignalCall(int ID)
        {
            switch (ID)
            {
                case 1:
                    switch (is1on)
                    {
                        case true:
                            is1on = false;
                            SendByte(ONE_OFF);
                            OffBtn(ONE);
                            break;
                        case false:
                            is1on = true;
                            SendByte(ONE_ON);
                            OnBtn(ONE);
                            break;
                    }
                    break;
                case 2:
                    switch (is2on)
                    {
                        case true:
                            is2on = false;
                            SendByte(TWO_OFF);
                            OffBtn(TWO);
                            break;
                        case false:
                            is2on = true;
                            SendByte(TWO_ON);
                            OnBtn(TWO);
                            break;
                    }
                    break;
                case 3:
                    switch (is3on)
                    {
                        case true:
                            is3on = false;
                            SendByte(THREE_OFF);
                            OffBtn(THREE);
                            break;
                        case false:
                            is3on = true;
                            SendByte(THREE_ON);
                            OnBtn(THREE);
                            break;
                    }
                    break;
                case 4:
                    switch (is4on)
                    {
                        case true:
                            is4on = false;
                            SendByte(FOUR_OFF);
                            OffBtn(FOUR);
                            break;
                        case false:
                            is4on = true;
                            SendByte(FOUR_ON);
                            OnBtn(FOUR);
                            break;
                    }
                    break;
                case 5:
                    switch (is5on)
                    {
                        case true:
                            is5on = false;
                            SendByte(FIVE_OFF);
                            OffBtn(FIVE);
                            break;
                        case false:
                            is5on = true;
                            SendByte(FIVE_ON);
                            OnBtn(FIVE);
                            break;
                    }
                    break;
                case 6:
                    switch (is6on)
                    {
                        case true:
                            is6on = false;
                            SendByte(SIX_OFF);
                            OffBtn(SIX);
                            break;
                        case false:
                            is6on = true;
                            SendByte(SIX_ON);
                            OnBtn(SIX);
                            break;
                    }
                    break;
                case 7:
                    switch (is7on)
                    {
                        case true:
                            is7on = false;
                            SendByte(SEVEN_OFF);
                            OffBtn(SEVEN);
                            break;
                        case false:
                            is7on = true;
                            SendByte(SEVEN_ON);
                            OnBtn(SEVEN);
                            break;
                    }
                    break;
                case 8:
                    switch (is8on)
                    {
                        case true:
                            is8on = false;
                            SendByte(EIGHT_OFF);
                            OffBtn(EIGHT);
                            break;
                        case false:
                            is8on = true;
                            SendByte(EIGHT_ON);
                            OnBtn(EIGHT);
                            break;
                    }
                    break;
            }
        }

        private void AutoConMode()
        {
            switch (AutoConBool)
            {
                case false:
                    AutoCon.BackColor = OffBack;
                    Properties.Settings.Default.AutoCon = false;
                    break;
                case true:
                    AutoCon.BackColor = OnBack;
                    Properties.Settings.Default.AutoCon = true;
                    break;
            }
            Properties.Settings.Default.Save();
        }

        private void AutoCon_Click(object sender, EventArgs e)
        {
            AutoConBool = !AutoConBool;
            AutoConMode();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Confirm your Exit ?", "??", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}