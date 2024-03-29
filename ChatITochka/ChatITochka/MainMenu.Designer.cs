namespace ChatITochka
{
    partial class MainMenu
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
            this.cbChats = new System.Windows.Forms.ComboBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.rtbFind = new System.Windows.Forms.RichTextBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHidePanel = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lbLogin = new System.Windows.Forms.Label();
            this.pbAva = new System.Windows.Forms.PictureBox();
            this.panelChat = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtbMessageText = new System.Windows.Forms.RichTextBox();
            this.panelChatInfoUser = new System.Windows.Forms.Panel();
            this.btnLeaveFromChat = new System.Windows.Forms.Button();
            this.pbAvaPanelChat = new System.Windows.Forms.PictureBox();
            this.lbLoginPanelChat = new System.Windows.Forms.Label();
            this.flpPanelChatMessage = new System.Windows.Forms.FlowLayoutPanel();
            this.massege1 = new ChatITochka.Massege();
            this.userMessage1 = new ChatITochka.UserMessage();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAva)).BeginInit();
            this.panelChat.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelChatInfoUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvaPanelChat)).BeginInit();
            this.flpPanelChatMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbChats
            // 
            this.cbChats.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbChats.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbChats.ForeColor = System.Drawing.SystemColors.Window;
            this.cbChats.FormattingEnabled = true;
            this.cbChats.Location = new System.Drawing.Point(1, 50);
            this.cbChats.Name = "cbChats";
            this.cbChats.Size = new System.Drawing.Size(211, 21);
            this.cbChats.TabIndex = 0;
            this.cbChats.SelectedIndexChanged += new System.EventHandler(this.cbChats_SelectedIndexChanged);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenu.Location = new System.Drawing.Point(1, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(28, 24);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "=";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // rtbFind
            // 
            this.rtbFind.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rtbFind.ForeColor = System.Drawing.SystemColors.Window;
            this.rtbFind.Location = new System.Drawing.Point(36, 13);
            this.rtbFind.Name = "rtbFind";
            this.rtbFind.Size = new System.Drawing.Size(176, 23);
            this.rtbFind.TabIndex = 2;
            this.rtbFind.Text = "";
            this.rtbFind.TextChanged += new System.EventHandler(this.rtbFind_TextChanged);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.btnHidePanel);
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.lbLogin);
            this.panelMenu.Controls.Add(this.pbAva);
            this.panelMenu.Location = new System.Drawing.Point(1, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(211, 449);
            this.panelMenu.TabIndex = 3;
            this.panelMenu.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(214, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 449);
            this.panel1.TabIndex = 4;
            // 
            // btnHidePanel
            // 
            this.btnHidePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHidePanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHidePanel.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHidePanel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHidePanel.Location = new System.Drawing.Point(180, 3);
            this.btnHidePanel.Name = "btnHidePanel";
            this.btnHidePanel.Size = new System.Drawing.Size(28, 24);
            this.btnHidePanel.TabIndex = 3;
            this.btnHidePanel.Text = "=";
            this.btnHidePanel.UseVisualStyleBackColor = false;
            this.btnHidePanel.Click += new System.EventHandler(this.btnHidePanel_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(59, 353);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 64);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbLogin.Location = new System.Drawing.Point(55, 72);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(87, 36);
            this.lbLogin.TabIndex = 1;
            this.lbLogin.Text = "Login";
            // 
            // pbAva
            // 
            this.pbAva.Location = new System.Drawing.Point(74, 19);
            this.pbAva.Name = "pbAva";
            this.pbAva.Size = new System.Drawing.Size(50, 50);
            this.pbAva.TabIndex = 0;
            this.pbAva.TabStop = false;
            // 
            // panelChat
            // 
            this.panelChat.Controls.Add(this.flpPanelChatMessage);
            this.panelChat.Controls.Add(this.panel2);
            this.panelChat.Controls.Add(this.panelChatInfoUser);
            this.panelChat.Location = new System.Drawing.Point(215, 3);
            this.panelChat.Name = "panelChat";
            this.panelChat.Size = new System.Drawing.Size(587, 446);
            this.panelChat.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rtbMessageText);
            this.panel2.Location = new System.Drawing.Point(0, 408);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 38);
            this.panel2.TabIndex = 7;
            // 
            // rtbMessageText
            // 
            this.rtbMessageText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rtbMessageText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMessageText.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMessageText.ForeColor = System.Drawing.SystemColors.Window;
            this.rtbMessageText.Location = new System.Drawing.Point(3, 3);
            this.rtbMessageText.Name = "rtbMessageText";
            this.rtbMessageText.Size = new System.Drawing.Size(581, 32);
            this.rtbMessageText.TabIndex = 0;
            this.rtbMessageText.Text = "";
            this.rtbMessageText.TextChanged += new System.EventHandler(this.rtbMessageText_TextChanged);
            // 
            // panelChatInfoUser
            // 
            this.panelChatInfoUser.Controls.Add(this.btnLeaveFromChat);
            this.panelChatInfoUser.Controls.Add(this.pbAvaPanelChat);
            this.panelChatInfoUser.Controls.Add(this.lbLoginPanelChat);
            this.panelChatInfoUser.Location = new System.Drawing.Point(0, -3);
            this.panelChatInfoUser.Name = "panelChatInfoUser";
            this.panelChatInfoUser.Size = new System.Drawing.Size(584, 56);
            this.panelChatInfoUser.TabIndex = 6;
            // 
            // btnLeaveFromChat
            // 
            this.btnLeaveFromChat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLeaveFromChat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLeaveFromChat.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaveFromChat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLeaveFromChat.Location = new System.Drawing.Point(549, 19);
            this.btnLeaveFromChat.Name = "btnLeaveFromChat";
            this.btnLeaveFromChat.Size = new System.Drawing.Size(24, 26);
            this.btnLeaveFromChat.TabIndex = 7;
            this.btnLeaveFromChat.Text = "-";
            this.btnLeaveFromChat.UseVisualStyleBackColor = false;
            this.btnLeaveFromChat.Click += new System.EventHandler(this.btnLeaveFromChat_Click);
            // 
            // pbAvaPanelChat
            // 
            this.pbAvaPanelChat.Location = new System.Drawing.Point(7, 3);
            this.pbAvaPanelChat.Name = "pbAvaPanelChat";
            this.pbAvaPanelChat.Size = new System.Drawing.Size(50, 50);
            this.pbAvaPanelChat.TabIndex = 6;
            this.pbAvaPanelChat.TabStop = false;
            // 
            // lbLoginPanelChat
            // 
            this.lbLoginPanelChat.AutoSize = true;
            this.lbLoginPanelChat.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginPanelChat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbLoginPanelChat.Location = new System.Drawing.Point(64, 9);
            this.lbLoginPanelChat.Name = "lbLoginPanelChat";
            this.lbLoginPanelChat.Size = new System.Drawing.Size(87, 36);
            this.lbLoginPanelChat.TabIndex = 5;
            this.lbLoginPanelChat.Text = "Login";
            // 
            // flpPanelChatMessage
            // 
            this.flpPanelChatMessage.AutoScroll = true;
            this.flpPanelChatMessage.Controls.Add(this.massege1);
            this.flpPanelChatMessage.Controls.Add(this.userMessage1);
            this.flpPanelChatMessage.Location = new System.Drawing.Point(31, 56);
            this.flpPanelChatMessage.Name = "flpPanelChatMessage";
            this.flpPanelChatMessage.Size = new System.Drawing.Size(542, 349);
            this.flpPanelChatMessage.TabIndex = 8;
            // 
            // massege1
            // 
            this.massege1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.massege1.Location = new System.Drawing.Point(3, 3);
            this.massege1.Name = "massege1";
            this.massege1.Size = new System.Drawing.Size(539, 29);
            this.massege1.TabIndex = 0;
            this.massege1.Title = null;
            this.massege1.Visible = false;
            // 
            // userMessage1
            // 
            this.userMessage1.AutoScroll = true;
            this.userMessage1.Ava = null;
            this.userMessage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.userMessage1.Location = new System.Drawing.Point(3, 38);
            this.userMessage1.Name = "userMessage1";
            this.userMessage1.Size = new System.Drawing.Size(350, 53);
            this.userMessage1.TabIndex = 1;
            this.userMessage1.Title = null;
            this.userMessage1.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelChat);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.rtbFind);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.cbChats);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load_1);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAva)).EndInit();
            this.panelChat.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelChatInfoUser.ResumeLayout(false);
            this.panelChatInfoUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvaPanelChat)).EndInit();
            this.flpPanelChatMessage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbChats;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.RichTextBox rtbFind;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.PictureBox pbAva;
        private System.Windows.Forms.Button btnHidePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelChat;
        private System.Windows.Forms.Panel panelChatInfoUser;
        private System.Windows.Forms.Label lbLoginPanelChat;
        private System.Windows.Forms.Button btnLeaveFromChat;
        private System.Windows.Forms.PictureBox pbAvaPanelChat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox rtbMessageText;
        private System.Windows.Forms.FlowLayoutPanel flpPanelChatMessage;
        private Massege massege1;
        private UserMessage userMessage1;
    }
}