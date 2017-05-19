namespace RconBlocker
{
    partial class frm_main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.txt_command = new System.Windows.Forms.TextBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.btn_spam = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_command = new System.Windows.Forms.Label();
            this.lbl_ip = new System.Windows.Forms.Label();
            this.lbl_port = new System.Windows.Forms.Label();
            this.lbl_count = new System.Windows.Forms.Label();
            this.lbl_Programmer = new System.Windows.Forms.Label();
            this.lbl_Site = new System.Windows.Forms.LinkLabel();
            this.lbl_help = new System.Windows.Forms.LinkLabel();
            this.btn_check = new System.Windows.Forms.Button();
            this.rbtn_fullspeed = new System.Windows.Forms.RadioButton();
            this.rbtn_lowspeed = new System.Windows.Forms.RadioButton();
            this.rbtn_medspeed = new System.Windows.Forms.RadioButton();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // txt_command
            // 
            this.txt_command.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_command.Location = new System.Drawing.Point(101, 194);
            this.txt_command.Name = "txt_command";
            this.txt_command.Size = new System.Drawing.Size(289, 30);
            this.txt_command.TabIndex = 2;
            this.mainToolTip.SetToolTip(this.txt_command, "Fake Request Data");
            // 
            // txt_port
            // 
            this.txt_port.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_port.Location = new System.Drawing.Point(101, 158);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(289, 30);
            this.txt_port.TabIndex = 1;
            this.mainToolTip.SetToolTip(this.txt_port, "Port of Target Server");
            // 
            // txt_ip
            // 
            this.txt_ip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ip.Location = new System.Drawing.Point(101, 119);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(289, 30);
            this.txt_ip.TabIndex = 0;
            this.mainToolTip.SetToolTip(this.txt_ip, "IP Address of Target Server");
            // 
            // btn_spam
            // 
            this.btn_spam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_spam.Location = new System.Drawing.Point(222, 263);
            this.btn_spam.Name = "btn_spam";
            this.btn_spam.Size = new System.Drawing.Size(168, 34);
            this.btn_spam.TabIndex = 7;
            this.btn_spam.Text = "Start Spam";
            this.mainToolTip.SetToolTip(this.btn_spam, "Start Attacking to Target");
            this.btn_spam.UseVisualStyleBackColor = true;
            this.btn_spam.Click += new System.EventHandler(this.btn_spam_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Tahoma", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Title.Location = new System.Drawing.Point(64, 7);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(227, 39);
            this.lbl_Title.TabIndex = 4;
            this.lbl_Title.Text = "Rcon Blocker";
            this.mainToolTip.SetToolTip(this.lbl_Title, "Rcon Blocker Program Usefull for Shuting Down Servers Contoroller System Like B3 " +
        "& AdminMod");
            // 
            // lbl_command
            // 
            this.lbl_command.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_command.AutoSize = true;
            this.lbl_command.Location = new System.Drawing.Point(42, 197);
            this.lbl_command.Name = "lbl_command";
            this.lbl_command.Size = new System.Drawing.Size(53, 23);
            this.lbl_command.TabIndex = 5;
            this.lbl_command.Text = "Text:";
            this.mainToolTip.SetToolTip(this.lbl_command, "Fake Request Data");
            // 
            // lbl_ip
            // 
            this.lbl_ip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ip.AutoSize = true;
            this.lbl_ip.Location = new System.Drawing.Point(44, 122);
            this.lbl_ip.Name = "lbl_ip";
            this.lbl_ip.Size = new System.Drawing.Size(34, 23);
            this.lbl_ip.TabIndex = 6;
            this.lbl_ip.Text = "IP:";
            this.mainToolTip.SetToolTip(this.lbl_ip, "IP Address of Target Server");
            // 
            // lbl_port
            // 
            this.lbl_port.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_port.AutoSize = true;
            this.lbl_port.Location = new System.Drawing.Point(42, 158);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(50, 23);
            this.lbl_port.TabIndex = 7;
            this.lbl_port.Text = "Port:";
            this.mainToolTip.SetToolTip(this.lbl_port, "Port of Target Server");
            // 
            // lbl_count
            // 
            this.lbl_count.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_count.AutoSize = true;
            this.lbl_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 71.99999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_count.Location = new System.Drawing.Point(410, 132);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(98, 108);
            this.lbl_count.TabIndex = 8;
            this.lbl_count.Text = "0";
            this.mainToolTip.SetToolTip(this.lbl_count, "Count of Attacked Threads");
            // 
            // lbl_Programmer
            // 
            this.lbl_Programmer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Programmer.AutoSize = true;
            this.lbl_Programmer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Programmer.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Programmer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Programmer.Location = new System.Drawing.Point(186, 52);
            this.lbl_Programmer.Name = "lbl_Programmer";
            this.lbl_Programmer.Size = new System.Drawing.Size(382, 25);
            this.lbl_Programmer.TabIndex = 9;
            this.lbl_Programmer.Text = "Programmed by Hossein Pourziyaie";
            this.mainToolTip.SetToolTip(this.lbl_Programmer, "You Can Talk with Me Using Telegram or Gmail\r\nTelegram ID : @hosseinpourziyaie\r\nG" +
        "mail : hosseinpourziyaie@gmail.com");
            // 
            // lbl_Site
            // 
            this.lbl_Site.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Site.AutoSize = true;
            this.lbl_Site.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Site.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Site.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Site.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Site.Location = new System.Drawing.Point(421, 84);
            this.lbl_Site.Name = "lbl_Site";
            this.lbl_Site.Size = new System.Drawing.Size(184, 29);
            this.lbl_Site.TabIndex = 25;
            this.lbl_Site.TabStop = true;
            this.lbl_Site.Text = "www.ircod4.ir";
            this.mainToolTip.SetToolTip(this.lbl_Site, "Visit our WebSite mate :)");
            this.lbl_Site.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_Site_LinkClicked);
            // 
            // lbl_help
            // 
            this.lbl_help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_help.AutoSize = true;
            this.lbl_help.BackColor = System.Drawing.Color.Transparent;
            this.lbl_help.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_help.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_help.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_help.Location = new System.Drawing.Point(639, 280);
            this.lbl_help.Name = "lbl_help";
            this.lbl_help.Size = new System.Drawing.Size(27, 29);
            this.lbl_help.TabIndex = 26;
            this.lbl_help.TabStop = true;
            this.lbl_help.Text = "?";
            this.mainToolTip.SetToolTip(this.lbl_help, "About Me");
            this.lbl_help.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_help_LinkClicked);
            // 
            // btn_check
            // 
            this.btn_check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_check.Location = new System.Drawing.Point(46, 263);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(170, 34);
            this.btn_check.TabIndex = 6;
            this.btn_check.Text = "Check Server";
            this.mainToolTip.SetToolTip(this.btn_check, "Send heartbeat & Recive Response for Checcking Servers Status \r\nUse to Sure about" +
        " Server IP & Port Correction ");
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // rbtn_fullspeed
            // 
            this.rbtn_fullspeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_fullspeed.AutoSize = true;
            this.rbtn_fullspeed.Location = new System.Drawing.Point(166, 230);
            this.rbtn_fullspeed.Name = "rbtn_fullspeed";
            this.rbtn_fullspeed.Size = new System.Drawing.Size(116, 27);
            this.rbtn_fullspeed.TabIndex = 3;
            this.rbtn_fullspeed.Text = "Full Speed";
            this.mainToolTip.SetToolTip(this.rbtn_fullspeed, "No MiliSeconds Timeout Between Every Attacks \r\nGood for Attack using Vps or Attac" +
        "k without Playing");
            this.rbtn_fullspeed.UseVisualStyleBackColor = true;
            this.rbtn_fullspeed.CheckedChanged += new System.EventHandler(this.AllCheckBoxes_CheckedChanged);
            // 
            // rbtn_lowspeed
            // 
            this.rbtn_lowspeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_lowspeed.AutoSize = true;
            this.rbtn_lowspeed.Location = new System.Drawing.Point(280, 230);
            this.rbtn_lowspeed.Name = "rbtn_lowspeed";
            this.rbtn_lowspeed.Size = new System.Drawing.Size(120, 27);
            this.rbtn_lowspeed.TabIndex = 5;
            this.rbtn_lowspeed.Text = "Low Speed";
            this.mainToolTip.SetToolTip(this.rbtn_lowspeed, "200 MiliSeconds Timeout Between Every Attacks \r\nGood for Weak Systems ");
            this.rbtn_lowspeed.UseVisualStyleBackColor = true;
            this.rbtn_lowspeed.CheckedChanged += new System.EventHandler(this.AllCheckBoxes_CheckedChanged);
            // 
            // rbtn_medspeed
            // 
            this.rbtn_medspeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_medspeed.AutoSize = true;
            this.rbtn_medspeed.Checked = true;
            this.rbtn_medspeed.Location = new System.Drawing.Point(46, 230);
            this.rbtn_medspeed.Name = "rbtn_medspeed";
            this.rbtn_medspeed.Size = new System.Drawing.Size(123, 27);
            this.rbtn_medspeed.TabIndex = 4;
            this.rbtn_medspeed.TabStop = true;
            this.rbtn_medspeed.Text = "Med Speed";
            this.mainToolTip.SetToolTip(this.rbtn_medspeed, "30 MiliSeconds Timeout Between Every Attacks\r\nGood for Attacking while Playing ");
            this.rbtn_medspeed.UseVisualStyleBackColor = true;
            this.rbtn_medspeed.CheckedChanged += new System.EventHandler(this.AllCheckBoxes_CheckedChanged);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            // 
            // frm_main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(667, 309);
            this.Controls.Add(this.rbtn_lowspeed);
            this.Controls.Add(this.rbtn_fullspeed);
            this.Controls.Add(this.rbtn_medspeed);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.lbl_help);
            this.Controls.Add(this.lbl_Site);
            this.Controls.Add(this.lbl_Programmer);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.lbl_port);
            this.Controls.Add(this.lbl_ip);
            this.Controls.Add(this.lbl_command);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.btn_spam);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.txt_command);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(812, 421);
            this.MinimumSize = new System.Drawing.Size(683, 348);
            this.Name = "frm_main";
            this.Text = "Rcon Blocker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_main_FormClosing);
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_command;
        private System.Windows.Forms.Label lbl_ip;
        private System.Windows.Forms.Label lbl_port;
        public System.Windows.Forms.Button btn_spam;
        public System.Windows.Forms.Label lbl_count;
        public System.Windows.Forms.TextBox txt_command;
        public System.Windows.Forms.TextBox txt_port;
        public System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Label lbl_Programmer;
        private System.Windows.Forms.LinkLabel lbl_Site;
        private System.Windows.Forms.LinkLabel lbl_help;
        public System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.RadioButton rbtn_fullspeed;
        private System.Windows.Forms.RadioButton rbtn_lowspeed;
        private System.Windows.Forms.RadioButton rbtn_medspeed;
        private System.Windows.Forms.ToolTip mainToolTip;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}