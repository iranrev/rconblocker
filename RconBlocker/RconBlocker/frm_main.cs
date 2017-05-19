using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace RconBlocker
{
    public partial class frm_main : Form
    {
        Thread CheckThread;
        int speed = 30;
        RadioButton Checked_Button;
        SendRcon BadRcon;
        bool spamming;
        bool used_app = false;
        public frm_main()
        {
            InitializeComponent();
            //InitFont();
            LoadFont();
            lbl_count.Font = new Font(private_fonts.Families[0], 72);
            lbl_count.UseCompatibleTextRendering = true;
        }
        PrivateFontCollection private_fonts = new PrivateFontCollection();
        private void LoadFont()
        {
            // specify embedded resource name
            string resource = "RconBlocker.digital.ttf";
            // receive resource stream
            Stream fontStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource);
            // create an unsafe memory block for the font data
            IntPtr data = Marshal.AllocCoTaskMem((int)fontStream.Length);
            // create a buffer to read in to
            byte[] fontdata = new byte[fontStream.Length];
            // read the font data from the resource
            fontStream.Read(fontdata, 0, (int)fontStream.Length);
            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, (int)fontStream.Length);
            // pass the font to the font collection
            private_fonts.AddMemoryFont(data, (int)fontStream.Length);
            // close the resource stream
            fontStream.Close();
            // free the unsafe memory
            Marshal.FreeCoTaskMem(data);
        }
        /*
        private void addfontfrommemory()
        {
            Stream fontStream = this.GetType().Assembly.GetManifestResourceStream("yourfont.ttf");

            byte[] fontdata = new byte[fontStream.Length];
            fontStream.Read(fontdata, 0, (int)fontStream.Length);
            fontStream.Close();
            unsafe
            {
                fixed (byte* pFontData = fontdata)
                {
                    pfc.AddMemoryFont((System.IntPtr)pFontData, fontdata.Length);
                }
            }
        }
        public void InitFont()
        {
            var pfc = new PrivateFontCollection();
            var fontLength = Properties.Resources.digital.Length;
            var fontData = Properties.Resources.digital;
            var data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontData, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);
            Marshal.FreeCoTaskMem(data);
            //textBox1.Font = new Font(pfc.Families[0], textBox1.Font.Size);
            lbl_count.Font = new Font(pfc.Families[0], lbl_count.Font.Size);
            //button1.Font = new Font(pfc.Families[0], button1.Font.Size);
        }
        */
        private void btn_spam_Click(object sender, EventArgs e)
        {
            if (used_app == false) used_app = true;
            if (!spamming)
            {
                if (this.txt_command.Text.Length == 0)
                    this.txt_command.Text = "x";
                if (this.txt_ip.Text.Length == 0 || this.txt_port.Text.Length == 0)
                {
                    notifyIcon.ShowBalloonTip(3, "Rcon Blocker", "IP or Port Must be not Empty", ToolTipIcon.Error);
                    MessageBox.Show("IP or Port Must be not Empty", "Error");
                }
                else
                {
                    if (Validate_IP(this.txt_ip.Text))
                    {
                        if (Validate_Port(this.txt_port.Text))
                        {
                            BadRcon = new SendRcon();
                            spamming = true;
                            this.btn_spam.Text = "Stop Spam";
                            this.rbtn_fullspeed.Enabled = false;
                            this.rbtn_medspeed.Enabled = false;
                            this.rbtn_lowspeed.Enabled = false;
                            BadRcon.SendThis(this, this.txt_command.Text, this.txt_ip.Text, int.Parse(this.txt_port.Text),speed);
                            Thread firsThread = new Thread(new ThreadStart(BadRcon.spamRcon));
                            firsThread.Start();
                            this.btn_check.Enabled = false;
                            notifyIcon.ShowBalloonTip(3, "Rcon Blocker", "Started to Attacking Target Server :)", ToolTipIcon.Info);
                            //BadRcon.spamRcon(this, this.txt_command.Text, this.txt_ip.Text, "x", int.Parse(this.txt_port.Text))
                        }
                        else
                        {
                            notifyIcon.ShowBalloonTip(3, "Rcon Blocker Error", "Port is not Valid :(\n Domain is any integer from 0 to 65535", ToolTipIcon.Error);
                            MessageBox.Show("Port is not Valid :(\n Domain is any integer from 0 to 65535", "Error");
                        }
                            
                    }
                    else
                    {
                        notifyIcon.ShowBalloonTip(3, "Rcon Blocker Error", "IP Address is not Valid :(", ToolTipIcon.Error);
                        MessageBox.Show("IP Address is not Valid :(", "Error");
                    }
                }
            }
            else
            {
                this.rbtn_fullspeed.Enabled = true;
                this.rbtn_medspeed.Enabled = true;
                this.rbtn_lowspeed.Enabled = true;
                this.btn_check.Enabled = true;
                this.btn_spam.Text = "Start Spam";
                spamming = false;
                BadRcon.StopSpam();
                notifyIcon.ShowBalloonTip(3, "Rcon Blocker", "Stopped Spamming :|", ToolTipIcon.Info);

            }
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            if (File.Exists("RconBlocker.ini"))
            {
                try
                {
                    StreamReader reader = new StreamReader("RconBlocker.ini");
                    this.txt_ip.Text = reader.ReadLine();
                    this.txt_port.Text = reader.ReadLine();
                    this.txt_command.Text = reader.ReadLine();
                    reader.Close();
                }
                catch (Exception)
                {
                    //throw;
                }
            }
        }

        private void lbl_Site_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://ircod4.ir/");
        }

        public void SetCounterValue(int value)
        {
            try
            {
                this.Invoke(new MethodInvoker(delegate () { this.lbl_count.Text = value.ToString(); }));
                //Invoke((Action)(() => { this.lbl_count.Text = value.ToString(); }));
            }
            catch (Exception)
            {
                // throw;
            }
        }
        public void SetbtnAction(string text)
        {
            try
            {
                this.Invoke(new MethodInvoker(delegate () { this.btn_spam.Text = text; }));
                //Invoke((Action)(() => { this.btn_spam.Text = text; }));
            }
            catch (Exception)
            {
                // throw;
            }

        }

        public void ShowMessage(string text, string caption)
        {
            MessageBox.Show(text, caption);
            this.Invoke(new MethodInvoker(delegate () { notifyIcon.ShowBalloonTip(3, caption, text, ToolTipIcon.Info); }));
            // Invoke((Action)(() => { notifyIcon.ShowBalloonTip(3, caption, text, ToolTipIcon.Info); }));
        }
        public static bool Validate_Port(string StrPort)
        {
            int port;
            bool InRange = Int32.TryParse(StrPort, out port) && port >= 0 && port <= 65535;
            return InRange;
        }
        public static bool Validate_IP(string ipStr)
        {
            string pattern = @"^(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)(\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}$";
            Regex check = new Regex(pattern);
            bool valid = false;
            if (ipStr == "")
            {
                valid = false;
            }
            else
            {
                valid = check.IsMatch(ipStr, 0);
            }
            return valid;
        }

        private void lbl_help_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Rcom Blocker is a Rcon Spammer for Disabling Server Controller Bots Like B3,AdminMod for a Temporary Time \n Programmer Doesnt Have Responsibility for abusing from this App. \n Contact with me : \n Telegram ID: @hosseinpourziyaie\n Gmail: hosseinpourziyaie@gmail.com\n our Website: www.ircod4.ir", "About");
        }

        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(used_app) BadRcon.StopSpam();
            using (StreamWriter writer = new StreamWriter("RconBlocker.ini"))
            {
                writer.WriteLine(this.txt_ip.Text);
                writer.WriteLine(this.txt_port.Text);
                writer.WriteLine(this.txt_command.Text);
                writer.Close();
            }
            //CheckThread.Abort();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            if (spamming) return;
            if (this.txt_ip.Text.Length == 0 || this.txt_port.Text.Length == 0)
            {
                notifyIcon.ShowBalloonTip(3, "Rcon Blocker", "IP or Port Must be not Empty", ToolTipIcon.Error);
                MessageBox.Show("IP or Port Must be not Empty", "Error");
            }
            else
            {
                if (Validate_IP(this.txt_ip.Text))
                {
                    if (Validate_Port(this.txt_port.Text))
                    {
                        //Thread firsThread = new Thread(new ThreadStart(BadRcon.spamRcon));
                        //firsThread.Start();
                        BadRcon = new SendRcon();
                        BadRcon.SendThis(this, this.txt_command.Text, this.txt_ip.Text, int.Parse(this.txt_port.Text), speed);
                        CheckThread = new Thread(new ThreadStart(BadRcon.checkRCON));
                        CheckThread.Start();
                        /*bool x = BadRcon.checkRCON(this.txt_ip.Text, int.Parse(this.txt_port.Text));
                        if (x == true)
                        {
                            notifyIcon.ShowBalloonTip(3, "Rcon Blocker", "Server Responsed & its Exsits :) !", ToolTipIcon.Info);
                            MessageBox.Show("Server Responsed & its Exsits :) !");
                        }
                        else
                        {
                            notifyIcon.ShowBalloonTip(3, "Rcon Blocker Error", "No Response from Server :( maybe Ip or Port is wrong? or Check Your Network Connection.", ToolTipIcon.Error);
                            MessageBox.Show("No Response from Server :( maybe Ip or Port is wrong? or Check Your Network Connection.");
                        }*/
                    }
                    else
                    {
                        notifyIcon.ShowBalloonTip(3, "Rcon Blocker Error", "Port is not Valid :(\n Domain is any integer from 0 to 65535", ToolTipIcon.Error);
                        MessageBox.Show("Port is not Valid :(\n Domain is any integer from 0 to 65535", "Error");
                    }
                }
                else
                {
                    notifyIcon.ShowBalloonTip(3, "Rcon Blocker Error", "IP Address is not Valid :(", ToolTipIcon.Error);
                    MessageBox.Show("IP Address is not Valid :(", "Error");
                }
            }

        }
        private void AllCheckBoxes_CheckedChanged(Object sender, EventArgs e)
        {
            // Check of the raiser of the event is a checked Checkbox.
            // Of course we also need to to cast it first.
            if (((RadioButton)sender).Checked)
            {
                // This is the correct control.
                Checked_Button = (RadioButton)sender;
                    
                if (Checked_Button.Name == "rbtn_fullspeed")
                    speed = 0;
                else if (Checked_Button.Name == "rbtn_medspeed")
                    speed = 30;
                else if (Checked_Button.Name == "rbtn_lowspeed")
                    speed = 200;
            }
        }
        /////////////////////////////////////////////////////////////////////////
    }
}