namespace UPE_Excel_Formatter
{
    partial class LoadingScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.upeGuestlistTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::UPE_Excel_Formatter.Properties.Resources.Columbia_Crown_simple_svg;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(24, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 198);
            this.panel1.TabIndex = 0;
            // 
            // upeGuestlistTitleLabel
            // 
            this.upeGuestlistTitleLabel.AutoSize = true;
            this.upeGuestlistTitleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upeGuestlistTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(105)))));
            this.upeGuestlistTitleLabel.Location = new System.Drawing.Point(82, 25);
            this.upeGuestlistTitleLabel.Name = "upeGuestlistTitleLabel";
            this.upeGuestlistTitleLabel.Size = new System.Drawing.Size(128, 32);
            this.upeGuestlistTitleLabel.TabIndex = 13;
            this.upeGuestlistTitleLabel.Text = "Loading...";
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(292, 307);
            this.Controls.Add(this.upeGuestlistTitleLabel);
            this.Controls.Add(this.panel1);
            this.Name = "LoadingScreen";
            this.Text = "Loading Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label upeGuestlistTitleLabel;
    }
}