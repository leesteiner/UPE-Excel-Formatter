namespace UPE_Excel_Formatter
{
    partial class Form1
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
            this.loadFileButton = new System.Windows.Forms.Button();
            this.firstNameComboBox = new System.Windows.Forms.ComboBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameComboBox = new System.Windows.Forms.ComboBox();
            this.uniLabel = new System.Windows.Forms.Label();
            this.uniComboBox = new System.Windows.Forms.ComboBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailComboBox = new System.Windows.Forms.ComboBox();
            this.namePrefixLabel = new System.Windows.Forms.Label();
            this.namePrefixComboBox = new System.Windows.Forms.ComboBox();
            this.fieldMatchPanel = new System.Windows.Forms.Panel();
            this.continueButton = new System.Windows.Forms.Button();
            this.fieldMatchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadFileButton
            // 
            this.loadFileButton.Location = new System.Drawing.Point(36, 43);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(171, 23);
            this.loadFileButton.TabIndex = 0;
            this.loadFileButton.Text = "Choose an Excel or CSV File...";
            this.loadFileButton.UseVisualStyleBackColor = true;
            this.loadFileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // firstNameComboBox
            // 
            this.firstNameComboBox.FormattingEnabled = true;
            this.firstNameComboBox.Location = new System.Drawing.Point(15, 24);
            this.firstNameComboBox.Name = "firstNameComboBox";
            this.firstNameComboBox.Size = new System.Drawing.Size(292, 21);
            this.firstNameComboBox.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(12, 8);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(82, 13);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name Field";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(12, 62);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(83, 13);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Last Name Field";
            // 
            // lastNameComboBox
            // 
            this.lastNameComboBox.FormattingEnabled = true;
            this.lastNameComboBox.Location = new System.Drawing.Point(15, 78);
            this.lastNameComboBox.Name = "lastNameComboBox";
            this.lastNameComboBox.Size = new System.Drawing.Size(292, 21);
            this.lastNameComboBox.TabIndex = 3;
            // 
            // uniLabel
            // 
            this.uniLabel.AutoSize = true;
            this.uniLabel.Location = new System.Drawing.Point(12, 115);
            this.uniLabel.Name = "uniLabel";
            this.uniLabel.Size = new System.Drawing.Size(51, 13);
            this.uniLabel.TabIndex = 6;
            this.uniLabel.Text = "UNI Field";
            // 
            // uniComboBox
            // 
            this.uniComboBox.FormattingEnabled = true;
            this.uniComboBox.Location = new System.Drawing.Point(15, 131);
            this.uniComboBox.Name = "uniComboBox";
            this.uniComboBox.Size = new System.Drawing.Size(292, 21);
            this.uniComboBox.TabIndex = 5;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(12, 166);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(57, 13);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "Email Field";
            // 
            // emailComboBox
            // 
            this.emailComboBox.FormattingEnabled = true;
            this.emailComboBox.Location = new System.Drawing.Point(15, 182);
            this.emailComboBox.Name = "emailComboBox";
            this.emailComboBox.Size = new System.Drawing.Size(292, 21);
            this.emailComboBox.TabIndex = 7;
            // 
            // namePrefixLabel
            // 
            this.namePrefixLabel.AutoSize = true;
            this.namePrefixLabel.Location = new System.Drawing.Point(12, 215);
            this.namePrefixLabel.Name = "namePrefixLabel";
            this.namePrefixLabel.Size = new System.Drawing.Size(89, 13);
            this.namePrefixLabel.TabIndex = 10;
            this.namePrefixLabel.Text = "Name Prefix Field";
            // 
            // namePrefixComboBox
            // 
            this.namePrefixComboBox.FormattingEnabled = true;
            this.namePrefixComboBox.Location = new System.Drawing.Point(15, 231);
            this.namePrefixComboBox.Name = "namePrefixComboBox";
            this.namePrefixComboBox.Size = new System.Drawing.Size(292, 21);
            this.namePrefixComboBox.TabIndex = 9;
            // 
            // fieldMatchPanel
            // 
            this.fieldMatchPanel.Controls.Add(this.lastNameLabel);
            this.fieldMatchPanel.Controls.Add(this.namePrefixLabel);
            this.fieldMatchPanel.Controls.Add(this.firstNameComboBox);
            this.fieldMatchPanel.Controls.Add(this.namePrefixComboBox);
            this.fieldMatchPanel.Controls.Add(this.firstNameLabel);
            this.fieldMatchPanel.Controls.Add(this.emailLabel);
            this.fieldMatchPanel.Controls.Add(this.lastNameComboBox);
            this.fieldMatchPanel.Controls.Add(this.emailComboBox);
            this.fieldMatchPanel.Controls.Add(this.uniComboBox);
            this.fieldMatchPanel.Controls.Add(this.uniLabel);
            this.fieldMatchPanel.Location = new System.Drawing.Point(36, 86);
            this.fieldMatchPanel.Name = "fieldMatchPanel";
            this.fieldMatchPanel.Size = new System.Drawing.Size(401, 300);
            this.fieldMatchPanel.TabIndex = 11;
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(536, 279);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(192, 49);
            this.continueButton.TabIndex = 11;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.fieldMatchPanel);
            this.Controls.Add(this.loadFileButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.fieldMatchPanel.ResumeLayout(false);
            this.fieldMatchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadFileButton;
        private System.Windows.Forms.ComboBox firstNameComboBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.ComboBox lastNameComboBox;
        private System.Windows.Forms.Label uniLabel;
        private System.Windows.Forms.ComboBox uniComboBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.ComboBox emailComboBox;
        private System.Windows.Forms.Label namePrefixLabel;
        private System.Windows.Forms.ComboBox namePrefixComboBox;
        private System.Windows.Forms.Panel fieldMatchPanel;
        private System.Windows.Forms.Button continueButton;
    }
}

