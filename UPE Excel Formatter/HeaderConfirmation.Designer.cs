namespace UPE_Excel_Formatter
{
    partial class HeaderConfirmation
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
            this.button1 = new System.Windows.Forms.Button();
            this.secondSortLabel = new System.Windows.Forms.Label();
            this.firstSortComboBox = new System.Windows.Forms.ComboBox();
            this.firstSortLabel = new System.Windows.Forms.Label();
            this.secondSortComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 626);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 89);
            this.button1.TabIndex = 45;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // secondSortLabel
            // 
            this.secondSortLabel.AutoSize = true;
            this.secondSortLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondSortLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(105)))));
            this.secondSortLabel.Location = new System.Drawing.Point(930, 344);
            this.secondSortLabel.Name = "secondSortLabel";
            this.secondSortLabel.Size = new System.Drawing.Size(176, 21);
            this.secondSortLabel.TabIndex = 49;
            this.secondSortLabel.Text = "Sort by this field second";
            // 
            // firstSortComboBox
            // 
            this.firstSortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.firstSortComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.firstSortComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstSortComboBox.FormattingEnabled = true;
            this.firstSortComboBox.Location = new System.Drawing.Point(934, 292);
            this.firstSortComboBox.Name = "firstSortComboBox";
            this.firstSortComboBox.Size = new System.Drawing.Size(254, 29);
            this.firstSortComboBox.TabIndex = 46;
            // 
            // firstSortLabel
            // 
            this.firstSortLabel.AutoSize = true;
            this.firstSortLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstSortLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(105)))));
            this.firstSortLabel.Location = new System.Drawing.Point(932, 268);
            this.firstSortLabel.Name = "firstSortLabel";
            this.firstSortLabel.Size = new System.Drawing.Size(154, 21);
            this.firstSortLabel.TabIndex = 47;
            this.firstSortLabel.Text = "Sort by this field first";
            // 
            // secondSortComboBox
            // 
            this.secondSortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.secondSortComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.secondSortComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondSortComboBox.FormattingEnabled = true;
            this.secondSortComboBox.Location = new System.Drawing.Point(934, 368);
            this.secondSortComboBox.Name = "secondSortComboBox";
            this.secondSortComboBox.Size = new System.Drawing.Size(254, 29);
            this.secondSortComboBox.TabIndex = 48;
            // 
            // HeaderConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 727);
            this.Controls.Add(this.secondSortLabel);
            this.Controls.Add(this.firstSortComboBox);
            this.Controls.Add(this.firstSortLabel);
            this.Controls.Add(this.secondSortComboBox);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(105)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HeaderConfirmation";
            this.Text = "HeaderConfirmation";
            this.Load += new System.EventHandler(this.HeaderConfirmation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label secondSortLabel;
        private System.Windows.Forms.ComboBox firstSortComboBox;
        private System.Windows.Forms.Label firstSortLabel;
        private System.Windows.Forms.ComboBox secondSortComboBox;
    }
}