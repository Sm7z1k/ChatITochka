namespace ChatITochka
{
    partial class UserMessage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbText = new System.Windows.Forms.Label();
            this.pbAva = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAva)).BeginInit();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbText.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbText.Location = new System.Drawing.Point(70, 10);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(277, 28);
            this.lbText.TabIndex = 1;
            this.lbText.Text = "label1";
            // 
            // pbAva
            // 
            this.pbAva.Location = new System.Drawing.Point(15, 0);
            this.pbAva.Name = "pbAva";
            this.pbAva.Size = new System.Drawing.Size(50, 50);
            this.pbAva.TabIndex = 2;
            this.pbAva.TabStop = false;
            // 
            // UserMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.pbAva);
            this.Controls.Add(this.lbText);
            this.Name = "UserMessage";
            this.Size = new System.Drawing.Size(350, 53);
            this.Load += new System.EventHandler(this.UserMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.PictureBox pbAva;
    }
}
