namespace ChatITochka
{
    partial class Massege
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbText.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbText.Location = new System.Drawing.Point(3, 0);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(346, 27);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "label1";
            // 
            // Massege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.lbText);
            this.Name = "Massege";
            this.Size = new System.Drawing.Size(352, 29);
            this.Load += new System.EventHandler(this.Massege_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbText;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
