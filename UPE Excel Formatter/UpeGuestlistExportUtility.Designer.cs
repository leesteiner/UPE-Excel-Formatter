namespace UPE_Excel_Formatter
{
    partial class UpeGuestListExportUtility
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
            this.upeGuestlistTitleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guestCountLabel = new System.Windows.Forms.Label();
            this.guestCountComboBox = new System.Windows.Forms.ComboBox();
            this.fieldMatchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadFileButton
            // 
            this.loadFileButton.BackColor = System.Drawing.Color.White;
            this.loadFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadFileButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(105)))));
            this.loadFileButton.Location = new System.Drawing.Point(47, 97);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(291, 41);
            this.loadFileButton.TabIndex = 0;
            this.loadFileButton.Text = "Choose an Excel or CSV File...";
            this.loadFileButton.UseVisualStyleBackColor = false;
            this.loadFileButton.Click += new System.EventHandler(this.loadExcelSheetButton_Click);
            // 
            // firstNameComboBox
            // 
            this.firstNameComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameComboBox.FormattingEnabled = true;
            this.firstNameComboBox.Location = new System.Drawing.Point(18, 34);
            this.firstNameComboBox.Name = "firstNameComboBox";
            this.firstNameComboBox.Size = new System.Drawing.Size(351, 29);
            this.firstNameComboBox.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(105)))));
            this.firstNameLabel.Location = new System.Drawing.Point(16, 10);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(123, 21);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name Field";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(105)))));
            this.lastNameLabel.Location = new System.Drawing.Point(14, 86);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(121, 21);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Last Name Field";
            // 
            // lastNameComboBox
            // 
            this.lastNameComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameComboBox.FormattingEnabled = true;
            this.lastNameComboBox.Location = new System.Drawing.Point(18, 110);
            this.lastNameComboBox.Name = "lastNameComboBox";
            this.lastNameComboBox.Size = new System.Drawing.Size(351, 29);
            this.lastNameComboBox.TabIndex = 3;
            // 
            // uniLabel
            // 
            this.uniLabel.AutoSize = true;
            this.uniLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uniLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(105)))));
            this.uniLabel.Location = new System.Drawing.Point(16, 238);
            this.uniLabel.Name = "uniLabel";
            this.uniLabel.Size = new System.Drawing.Size(74, 21);
            this.uniLabel.TabIndex = 6;
            this.uniLabel.Text = "UNI Field";
            // 
            // uniComboBox
            // 
            this.uniComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uniComboBox.FormattingEnabled = true;
            this.uniComboBox.Location = new System.Drawing.Point(18, 262);
            this.uniComboBox.Name = "uniComboBox";
            this.uniComboBox.Size = new System.Drawing.Size(351, 29);
            this.uniComboBox.TabIndex = 5;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(105)))));
            this.emailLabel.Location = new System.Drawing.Point(14, 162);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(85, 21);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "Email Field";
            // 
            // emailComboBox
            // 
            this.emailComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailComboBox.FormattingEnabled = true;
            this.emailComboBox.Location = new System.Drawing.Point(18, 186);
            this.emailComboBox.Name = "emailComboBox";
            this.emailComboBox.Size = new System.Drawing.Size(351, 29);
            this.emailComboBox.TabIndex = 7;
            // 
            // namePrefixLabel
            // 
            this.namePrefixLabel.AutoSize = true;
            this.namePrefixLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namePrefixLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(105)))));
            this.namePrefixLabel.Location = new System.Drawing.Point(16, 314);
            this.namePrefixLabel.Name = "namePrefixLabel";
            this.namePrefixLabel.Size = new System.Drawing.Size(132, 21);
            this.namePrefixLabel.TabIndex = 10;
            this.namePrefixLabel.Text = "Name Prefix Field";
            // 
            // namePrefixComboBox
            // 
            this.namePrefixComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namePrefixComboBox.FormattingEnabled = true;
            this.namePrefixComboBox.Location = new System.Drawing.Point(18, 338);
            this.namePrefixComboBox.Name = "namePrefixComboBox";
            this.namePrefixComboBox.Size = new System.Drawing.Size(351, 29);
            this.namePrefixComboBox.TabIndex = 9;
            // 
            // fieldMatchPanel
            // 
            this.fieldMatchPanel.Controls.Add(this.guestCountLabel);
            this.fieldMatchPanel.Controls.Add(this.guestCountComboBox);
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
            this.fieldMatchPanel.Location = new System.Drawing.Point(47, 155);
            this.fieldMatchPanel.Name = "fieldMatchPanel";
            this.fieldMatchPanel.Size = new System.Drawing.Size(824, 391);
            this.fieldMatchPanel.TabIndex = 11;
            // 
            // dateCreatedLabel
            // 
            this.dateCreatedLabel.AutoSize = true;
            this.dateCreatedLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCreatedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(105)))));
            this.dateCreatedLabel.Location = new System.Drawing.Point(406, 314);
            this.dateCreatedLabel.Name = "dateCreatedLabel";
            this.dateCreatedLabel.Size = new System.Drawing.Size(137, 21);
            this.dateCreatedLabel.TabIndex = 20;
            this.dateCreatedLabel.Text = "Date Created Field";
            // 
            // dateCreatedComboBox
            // 
            this.dateCreatedComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateCreatedComboBox.FormattingEnabled = true;
            this.dateCreatedComboBox.Location = new System.Drawing.Point(406, 338);
            this.dateCreatedComboBox.Name = "dateCreatedComboBox";
            this.dateCreatedComboBox.Size = new System.Drawing.Size(351, 29);
            this.dateCreatedComboBox.TabIndex = 19;
            // 
            // dateOfReplyLabel
            // 
            this.dateOfReplyLabel.AutoSize = true;
            this.dateOfReplyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfReplyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(105)))));
            this.dateOfReplyLabel.Location = new System.Drawing.Point(402, 162);
            this.dateOfReplyLabel.Name = "dateOfReplyLabel";
            this.dateOfReplyLabel.Size = new System.Drawing.Size(140, 21);
            this.dateOfReplyLabel.TabIndex = 14;
            this.dateOfReplyLabel.Text = "Date of Reply Field";
            // 
            // rsvpNoteComboBox
            // 
            this.rsvpNoteComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rsvpNoteComboBox.FormattingEnabled = true;
            this.rsvpNoteComboBox.Location = new System.Drawing.Point(410, 110);
            this.rsvpNoteComboBox.Name = "rsvpNoteComboBox";
            this.rsvpNoteComboBox.Size = new System.Drawing.Size(351, 29);
            this.rsvpNoteComboBox.TabIndex = 11;
            // 
            // rsvpNoteLabel
            // 
            this.rsvpNoteLabel.AutoSize = true;
            this.rsvpNoteLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rsvpNoteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(105)))));
            this.rsvpNoteLabel.Location = new System.Drawing.Point(406, 86);
            this.rsvpNoteLabel.Name = "rsvpNoteLabel";
            this.rsvpNoteLabel.Size = new System.Drawing.Size(123, 21);
            this.rsvpNoteLabel.TabIndex = 12;
            this.rsvpNoteLabel.Text = "RSVP Note Field";
            // 
            // dietaryRestrictionsLabel
            // 
            this.dietaryRestrictionsLabel.AutoSize = true;
            this.dietaryRestrictionsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dietaryRestrictionsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(105)))));
            this.dietaryRestrictionsLabel.Location = new System.Drawing.Point(402, 238);
            this.dietaryRestrictionsLabel.Name = "dietaryRestrictionsLabel";
            this.dietaryRestrictionsLabel.Size = new System.Drawing.Size(182, 21);
            this.dietaryRestrictionsLabel.TabIndex = 18;
            this.dietaryRestrictionsLabel.Text = "Dietary Restrictions Field";
            // 
            // dateOfReplyComboBox
            // 
            this.dateOfReplyComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfReplyComboBox.FormattingEnabled = true;
            this.dateOfReplyComboBox.Location = new System.Drawing.Point(406, 186);
            this.dateOfReplyComboBox.Name = "dateOfReplyComboBox";
            this.dateOfReplyComboBox.Size = new System.Drawing.Size(351, 29);
            this.dateOfReplyComboBox.TabIndex = 13;
            // 
            // dietaryRestrictionsComboBox
            // 
            this.dietaryRestrictionsComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dietaryRestrictionsComboBox.FormattingEnabled = true;
            this.dietaryRestrictionsComboBox.Location = new System.Drawing.Point(406, 262);
            this.dietaryRestrictionsComboBox.Name = "dietaryRestrictionsComboBox";
            this.dietaryRestrictionsComboBox.Size = new System.Drawing.Size(351, 29);
            this.dietaryRestrictionsComboBox.TabIndex = 17;
            // 
            // rsvpComboBox
            // 
            this.rsvpComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rsvpComboBox.FormattingEnabled = true;
            this.rsvpComboBox.Location = new System.Drawing.Point(410, 34);
            this.rsvpComboBox.Name = "rsvpComboBox";
            this.rsvpComboBox.Size = new System.Drawing.Size(351, 29);
            this.rsvpComboBox.TabIndex = 15;
            // 
            // rsvpLabel
            // 
            this.rsvpLabel.AutoSize = true;
            this.rsvpLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rsvpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(105)))));
            this.rsvpLabel.Location = new System.Drawing.Point(406, 10);
            this.rsvpLabel.Name = "rsvpLabel";
            this.rsvpLabel.Size = new System.Drawing.Size(85, 21);
            this.rsvpLabel.TabIndex = 16;
            this.rsvpLabel.Text = "RSVP Field";
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.White;
            this.continueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continueButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(105)))));
            this.continueButton.Location = new System.Drawing.Point(353, 564);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(192, 49);
            this.continueButton.TabIndex = 11;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // upeGuestlistTitleLabel
            // 
            this.upeGuestlistTitleLabel.AutoSize = true;
            this.upeGuestlistTitleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upeGuestlistTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(105)))));
            this.upeGuestlistTitleLabel.Location = new System.Drawing.Point(433, 12);
            this.upeGuestlistTitleLabel.Name = "upeGuestlistTitleLabel";
            this.upeGuestlistTitleLabel.Size = new System.Drawing.Size(325, 32);
            this.upeGuestlistTitleLabel.TabIndex = 12;
            this.upeGuestlistTitleLabel.Text = "UPE Guestlist Export Utility";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::UPE_Excel_Formatter.Properties.Resources.Columbia_Crown_simple_svg;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(764, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 96);
            this.panel1.TabIndex = 13;
            // 
            // guestCountLabel
            // 
            this.guestCountLabel.AutoSize = true;
            this.guestCountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(105)))));
            this.guestCountLabel.Location = new System.Drawing.Point(277, 203);
            this.guestCountLabel.Name = "guestCountLabel";
            this.guestCountLabel.Size = new System.Drawing.Size(96, 21);
            this.guestCountLabel.TabIndex = 22;
            this.guestCountLabel.Text = "Guest Count";
            this.guestCountLabel.Visible = false;
            // 
            // guestCountComboBox
            // 
            this.guestCountComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestCountComboBox.FormattingEnabled = true;
            this.guestCountComboBox.Location = new System.Drawing.Point(277, 227);
            this.guestCountComboBox.Name = "guestCountComboBox";
            this.guestCountComboBox.Size = new System.Drawing.Size(351, 29);
            this.guestCountComboBox.TabIndex = 21;
            this.guestCountComboBox.Visible = false;
            // 
            // UpeGuestListExportUtility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(898, 629);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.upeGuestlistTitleLabel);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.fieldMatchPanel);
            this.Controls.Add(this.loadFileButton);
            this.Name = "UpeGuestListExportUtility";
            this.Text = "UPE Guestlist Export Utility";
            this.fieldMatchPanel.ResumeLayout(false);
            this.fieldMatchPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label upeGuestlistTitleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label guestCountLabel;
        private System.Windows.Forms.ComboBox guestCountComboBox;
    }
}

