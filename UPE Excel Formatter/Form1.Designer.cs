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
            this.dateCreatedLabel = new System.Windows.Forms.Label();
            this.dateCreatedComboBox = new System.Windows.Forms.ComboBox();
            this.dateOfReplyLabel = new System.Windows.Forms.Label();
            this.rsvpNoteComboBox = new System.Windows.Forms.ComboBox();
            this.rsvpNoteLabel = new System.Windows.Forms.Label();
            this.dietaryRestrictionsLabel = new System.Windows.Forms.Label();
            this.dateOfReplyComboBox = new System.Windows.Forms.ComboBox();
            this.dietaryRestrictionsComboBox = new System.Windows.Forms.ComboBox();
            this.rsvpComboBox = new System.Windows.Forms.ComboBox();
            this.rsvpLabel = new System.Windows.Forms.Label();
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
            this.firstNameLabel.Location = new System.Drawing.Point(13, 8);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(82, 13);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name Field";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(12, 59);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(83, 13);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Last Name Field";
            // 
            // lastNameComboBox
            // 
            this.lastNameComboBox.FormattingEnabled = true;
            this.lastNameComboBox.Location = new System.Drawing.Point(15, 75);
            this.lastNameComboBox.Name = "lastNameComboBox";
            this.lastNameComboBox.Size = new System.Drawing.Size(292, 21);
            this.lastNameComboBox.TabIndex = 3;
            // 
            // uniLabel
            // 
            this.uniLabel.AutoSize = true;
            this.uniLabel.Location = new System.Drawing.Point(12, 161);
            this.uniLabel.Name = "uniLabel";
            this.uniLabel.Size = new System.Drawing.Size(51, 13);
            this.uniLabel.TabIndex = 6;
            this.uniLabel.Text = "UNI Field";
            // 
            // uniComboBox
            // 
            this.uniComboBox.FormattingEnabled = true;
            this.uniComboBox.Location = new System.Drawing.Point(15, 177);
            this.uniComboBox.Name = "uniComboBox";
            this.uniComboBox.Size = new System.Drawing.Size(292, 21);
            this.uniComboBox.TabIndex = 5;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(12, 110);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(57, 13);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "Email Field";
            // 
            // emailComboBox
            // 
            this.emailComboBox.FormattingEnabled = true;
            this.emailComboBox.Location = new System.Drawing.Point(15, 126);
            this.emailComboBox.Name = "emailComboBox";
            this.emailComboBox.Size = new System.Drawing.Size(292, 21);
            this.emailComboBox.TabIndex = 7;
            // 
            // namePrefixLabel
            // 
            this.namePrefixLabel.AutoSize = true;
            this.namePrefixLabel.Location = new System.Drawing.Point(12, 212);
            this.namePrefixLabel.Name = "namePrefixLabel";
            this.namePrefixLabel.Size = new System.Drawing.Size(89, 13);
            this.namePrefixLabel.TabIndex = 10;
            this.namePrefixLabel.Text = "Name Prefix Field";
            // 
            // namePrefixComboBox
            // 
            this.namePrefixComboBox.FormattingEnabled = true;
            this.namePrefixComboBox.Location = new System.Drawing.Point(15, 228);
            this.namePrefixComboBox.Name = "namePrefixComboBox";
            this.namePrefixComboBox.Size = new System.Drawing.Size(292, 21);
            this.namePrefixComboBox.TabIndex = 9;
            // 
            // fieldMatchPanel
            // 
            this.fieldMatchPanel.Controls.Add(this.dateCreatedLabel);
            this.fieldMatchPanel.Controls.Add(this.dateCreatedComboBox);
            this.fieldMatchPanel.Controls.Add(this.dateOfReplyLabel);
            this.fieldMatchPanel.Controls.Add(this.rsvpNoteComboBox);
            this.fieldMatchPanel.Controls.Add(this.rsvpNoteLabel);
            this.fieldMatchPanel.Controls.Add(this.dietaryRestrictionsLabel);
            this.fieldMatchPanel.Controls.Add(this.dateOfReplyComboBox);
            this.fieldMatchPanel.Controls.Add(this.dietaryRestrictionsComboBox);
            this.fieldMatchPanel.Controls.Add(this.rsvpComboBox);
            this.fieldMatchPanel.Controls.Add(this.rsvpLabel);
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
            this.fieldMatchPanel.Size = new System.Drawing.Size(752, 300);
            this.fieldMatchPanel.TabIndex = 11;
            // 
            // dateCreatedLabel
            // 
            this.dateCreatedLabel.AutoSize = true;
            this.dateCreatedLabel.Location = new System.Drawing.Point(400, 212);
            this.dateCreatedLabel.Name = "dateCreatedLabel";
            this.dateCreatedLabel.Size = new System.Drawing.Size(95, 13);
            this.dateCreatedLabel.TabIndex = 20;
            this.dateCreatedLabel.Text = "Date Created Field";
            // 
            // dateCreatedComboBox
            // 
            this.dateCreatedComboBox.FormattingEnabled = true;
            this.dateCreatedComboBox.Location = new System.Drawing.Point(403, 228);
            this.dateCreatedComboBox.Name = "dateCreatedComboBox";
            this.dateCreatedComboBox.Size = new System.Drawing.Size(292, 21);
            this.dateCreatedComboBox.TabIndex = 19;
            // 
            // dateOfReplyLabel
            // 
            this.dateOfReplyLabel.AutoSize = true;
            this.dateOfReplyLabel.Location = new System.Drawing.Point(400, 110);
            this.dateOfReplyLabel.Name = "dateOfReplyLabel";
            this.dateOfReplyLabel.Size = new System.Drawing.Size(97, 13);
            this.dateOfReplyLabel.TabIndex = 14;
            this.dateOfReplyLabel.Text = "Date of Reply Field";
            // 
            // rsvpNoteComboBox
            // 
            this.rsvpNoteComboBox.FormattingEnabled = true;
            this.rsvpNoteComboBox.Location = new System.Drawing.Point(403, 75);
            this.rsvpNoteComboBox.Name = "rsvpNoteComboBox";
            this.rsvpNoteComboBox.Size = new System.Drawing.Size(292, 21);
            this.rsvpNoteComboBox.TabIndex = 11;
            // 
            // rsvpNoteLabel
            // 
            this.rsvpNoteLabel.AutoSize = true;
            this.rsvpNoteLabel.Location = new System.Drawing.Point(401, 59);
            this.rsvpNoteLabel.Name = "rsvpNoteLabel";
            this.rsvpNoteLabel.Size = new System.Drawing.Size(87, 13);
            this.rsvpNoteLabel.TabIndex = 12;
            this.rsvpNoteLabel.Text = "RSVP Note Field";
            // 
            // dietaryRestrictionsLabel
            // 
            this.dietaryRestrictionsLabel.AutoSize = true;
            this.dietaryRestrictionsLabel.Location = new System.Drawing.Point(400, 161);
            this.dietaryRestrictionsLabel.Name = "dietaryRestrictionsLabel";
            this.dietaryRestrictionsLabel.Size = new System.Drawing.Size(123, 13);
            this.dietaryRestrictionsLabel.TabIndex = 18;
            this.dietaryRestrictionsLabel.Text = "Dietary Restrictions Field";
            // 
            // dateOfReplyComboBox
            // 
            this.dateOfReplyComboBox.FormattingEnabled = true;
            this.dateOfReplyComboBox.Location = new System.Drawing.Point(403, 126);
            this.dateOfReplyComboBox.Name = "dateOfReplyComboBox";
            this.dateOfReplyComboBox.Size = new System.Drawing.Size(292, 21);
            this.dateOfReplyComboBox.TabIndex = 13;
            // 
            // dietaryRestrictionsComboBox
            // 
            this.dietaryRestrictionsComboBox.FormattingEnabled = true;
            this.dietaryRestrictionsComboBox.Location = new System.Drawing.Point(403, 177);
            this.dietaryRestrictionsComboBox.Name = "dietaryRestrictionsComboBox";
            this.dietaryRestrictionsComboBox.Size = new System.Drawing.Size(292, 21);
            this.dietaryRestrictionsComboBox.TabIndex = 17;
            // 
            // rsvpComboBox
            // 
            this.rsvpComboBox.FormattingEnabled = true;
            this.rsvpComboBox.Location = new System.Drawing.Point(403, 24);
            this.rsvpComboBox.Name = "rsvpComboBox";
            this.rsvpComboBox.Size = new System.Drawing.Size(292, 21);
            this.rsvpComboBox.TabIndex = 15;
            // 
            // rsvpLabel
            // 
            this.rsvpLabel.AutoSize = true;
            this.rsvpLabel.Location = new System.Drawing.Point(400, 8);
            this.rsvpLabel.Name = "rsvpLabel";
            this.rsvpLabel.Size = new System.Drawing.Size(61, 13);
            this.rsvpLabel.TabIndex = 16;
            this.rsvpLabel.Text = "RSVP Field";
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(310, 392);
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
        private System.Windows.Forms.Label dateOfReplyLabel;
        private System.Windows.Forms.ComboBox rsvpNoteComboBox;
        private System.Windows.Forms.Label rsvpNoteLabel;
        private System.Windows.Forms.Label dietaryRestrictionsLabel;
        private System.Windows.Forms.ComboBox dateOfReplyComboBox;
        private System.Windows.Forms.ComboBox dietaryRestrictionsComboBox;
        private System.Windows.Forms.ComboBox rsvpComboBox;
        private System.Windows.Forms.Label rsvpLabel;
        private System.Windows.Forms.Label dateCreatedLabel;
        private System.Windows.Forms.ComboBox dateCreatedComboBox;
    }
}

