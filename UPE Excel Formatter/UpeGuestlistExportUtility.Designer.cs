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
            this.dateOfReplyLabel = new System.Windows.Forms.Label();
            this.rsvpNoteComboBox = new System.Windows.Forms.ComboBox();
            this.rsvpNoteLabel = new System.Windows.Forms.Label();
            this.dietaryRestrictionsLabel = new System.Windows.Forms.Label();
            this.dateOfReplyComboBox = new System.Windows.Forms.ComboBox();
            this.dietaryRestrictionsComboBox = new System.Windows.Forms.ComboBox();
            this.rsvpComboBox = new System.Windows.Forms.ComboBox();
            this.rsvpLabel = new System.Windows.Forms.Label();
            this.guestCountLabel = new System.Windows.Forms.Label();
            this.guestCountComboBox = new System.Windows.Forms.ComboBox();
            this.continueButton = new System.Windows.Forms.Button();
            this.upeGuestlistTitleLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.secondSortLabel = new System.Windows.Forms.Label();
            this.firstSortComboBox = new System.Windows.Forms.ComboBox();
            this.firstSortLabel = new System.Windows.Forms.Label();
            this.secondSortComboBox = new System.Windows.Forms.ComboBox();
            this.guestNameComboBox = new System.Windows.Forms.ComboBox();
            this.guestNameLabel = new System.Windows.Forms.Label();
            this.guestDietaryRestrictionsLabel = new System.Windows.Forms.Label();
            this.guestDietaryRestrictionsComboBox = new System.Windows.Forms.ComboBox();
            this.nameSuffixLabel = new System.Windows.Forms.Label();
            this.nameSuffixComboBox = new System.Windows.Forms.ComboBox();
            this.addressOneComboBox = new System.Windows.Forms.ComboBox();
            this.addressOneLabel = new System.Windows.Forms.Label();
            this.addressTwoComboBox = new System.Windows.Forms.ComboBox();
            this.addressTwoLabel = new System.Windows.Forms.Label();
            this.addressThreeComboBox = new System.Windows.Forms.ComboBox();
            this.addressThreeLabel = new System.Windows.Forms.Label();
            this.cityCombobox = new System.Windows.Forms.ComboBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.postalComboBox = new System.Windows.Forms.ComboBox();
            this.postalLabel = new System.Windows.Forms.Label();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.countryLabel = new System.Windows.Forms.Label();
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
            this.firstNameLabel.Size = new System.Drawing.Size(86, 21);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(105)))));
            this.lastNameLabel.Location = new System.Drawing.Point(14, 86);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(84, 21);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Last Name";
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
            this.uniLabel.Size = new System.Drawing.Size(37, 21);
            this.uniLabel.TabIndex = 6;
            this.uniLabel.Text = "UNI";
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
            this.emailLabel.Size = new System.Drawing.Size(48, 21);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "Email";
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
            this.namePrefixLabel.Size = new System.Drawing.Size(95, 21);
            this.namePrefixLabel.TabIndex = 10;
            this.namePrefixLabel.Text = "Name Prefix";
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
            this.fieldMatchPanel.Controls.Add(this.addressThreeLabel);
            this.fieldMatchPanel.Controls.Add(this.addressTwoLabel);
            this.fieldMatchPanel.Controls.Add(this.countryLabel);
            this.fieldMatchPanel.Controls.Add(this.postalLabel);
            this.fieldMatchPanel.Controls.Add(this.stateLabel);
            this.fieldMatchPanel.Controls.Add(this.cityLabel);
            this.fieldMatchPanel.Controls.Add(this.addressOneLabel);
            this.fieldMatchPanel.Controls.Add(this.nameSuffixLabel);
            this.fieldMatchPanel.Controls.Add(this.guestCountLabel);
            this.fieldMatchPanel.Controls.Add(this.addressThreeComboBox);
            this.fieldMatchPanel.Controls.Add(this.addressTwoComboBox);
            this.fieldMatchPanel.Controls.Add(this.countryComboBox);
            this.fieldMatchPanel.Controls.Add(this.postalComboBox);
            this.fieldMatchPanel.Controls.Add(this.stateComboBox);
            this.fieldMatchPanel.Controls.Add(this.cityCombobox);
            this.fieldMatchPanel.Controls.Add(this.addressOneComboBox);
            this.fieldMatchPanel.Controls.Add(this.nameSuffixComboBox);
            this.fieldMatchPanel.Controls.Add(this.guestDietaryRestrictionsLabel);
            this.fieldMatchPanel.Controls.Add(this.guestDietaryRestrictionsComboBox);
            this.fieldMatchPanel.Controls.Add(this.guestNameComboBox);
            this.fieldMatchPanel.Controls.Add(this.guestNameLabel);
            this.fieldMatchPanel.Controls.Add(this.guestCountComboBox);
            this.fieldMatchPanel.Controls.Add(this.continueButton);
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
            this.fieldMatchPanel.Size = new System.Drawing.Size(824, 804);
            this.fieldMatchPanel.TabIndex = 11;
            this.fieldMatchPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.fieldMatchPanel_Paint);
            // 
            // dateOfReplyLabel
            // 
            this.dateOfReplyLabel.AutoSize = true;
            this.dateOfReplyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfReplyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(105)))));
            this.dateOfReplyLabel.Location = new System.Drawing.Point(402, 162);
            this.dateOfReplyLabel.Name = "dateOfReplyLabel";
            this.dateOfReplyLabel.Size = new System.Drawing.Size(103, 21);
            this.dateOfReplyLabel.TabIndex = 14;
            this.dateOfReplyLabel.Text = "Date of Reply";
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
            this.rsvpNoteLabel.Size = new System.Drawing.Size(86, 21);
            this.rsvpNoteLabel.TabIndex = 12;
            this.rsvpNoteLabel.Text = "RSVP Note";
            // 
            // dietaryRestrictionsLabel
            // 
            this.dietaryRestrictionsLabel.AutoSize = true;
            this.dietaryRestrictionsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dietaryRestrictionsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(105)))));
            this.dietaryRestrictionsLabel.Location = new System.Drawing.Point(402, 238);
            this.dietaryRestrictionsLabel.Name = "dietaryRestrictionsLabel";
            this.dietaryRestrictionsLabel.Size = new System.Drawing.Size(145, 21);
            this.dietaryRestrictionsLabel.TabIndex = 18;
            this.dietaryRestrictionsLabel.Text = "Dietary Restrictions";
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
            this.rsvpLabel.Size = new System.Drawing.Size(48, 21);
            this.rsvpLabel.TabIndex = 16;
            this.rsvpLabel.Text = "RSVP";
            // 
            // guestCountLabel
            // 
            this.guestCountLabel.AutoSize = true;
            this.guestCountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(105)))));
            this.guestCountLabel.Location = new System.Drawing.Point(22, 737);
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
            this.guestCountComboBox.Location = new System.Drawing.Point(22, 761);
            this.guestCountComboBox.Name = "guestCountComboBox";
            this.guestCountComboBox.Size = new System.Drawing.Size(102, 29);
            this.guestCountComboBox.TabIndex = 21;
            this.guestCountComboBox.Visible = false;
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.White;
            this.continueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continueButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(105)))));
            this.continueButton.Location = new System.Drawing.Point(190, 722);
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
            this.upeGuestlistTitleLabel.Size = new System.Drawing.Size(324, 32);
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
            // secondSortLabel
            // 
            this.secondSortLabel.AutoSize = true;
            this.secondSortLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondSortLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(105)))));
            this.secondSortLabel.Location = new System.Drawing.Point(889, 241);
            this.secondSortLabel.Name = "secondSortLabel";
            this.secondSortLabel.Size = new System.Drawing.Size(176, 21);
            this.secondSortLabel.TabIndex = 24;
            this.secondSortLabel.Text = "Sort by this field second";
            // 
            // firstSortComboBox
            // 
            this.firstSortComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstSortComboBox.FormattingEnabled = true;
            this.firstSortComboBox.Location = new System.Drawing.Point(893, 189);
            this.firstSortComboBox.Name = "firstSortComboBox";
            this.firstSortComboBox.Size = new System.Drawing.Size(142, 29);
            this.firstSortComboBox.TabIndex = 21;
            // 
            // firstSortLabel
            // 
            this.firstSortLabel.AutoSize = true;
            this.firstSortLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstSortLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(105)))));
            this.firstSortLabel.Location = new System.Drawing.Point(891, 165);
            this.firstSortLabel.Name = "firstSortLabel";
            this.firstSortLabel.Size = new System.Drawing.Size(154, 21);
            this.firstSortLabel.TabIndex = 22;
            this.firstSortLabel.Text = "Sort by this field first";
            // 
            // secondSortComboBox
            // 
            this.secondSortComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondSortComboBox.FormattingEnabled = true;
            this.secondSortComboBox.Location = new System.Drawing.Point(893, 265);
            this.secondSortComboBox.Name = "secondSortComboBox";
            this.secondSortComboBox.Size = new System.Drawing.Size(142, 29);
            this.secondSortComboBox.TabIndex = 23;
            // 
            // guestNameComboBox
            // 
            this.guestNameComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestNameComboBox.FormattingEnabled = true;
            this.guestNameComboBox.Location = new System.Drawing.Point(20, 413);
            this.guestNameComboBox.Name = "guestNameComboBox";
            this.guestNameComboBox.Size = new System.Drawing.Size(351, 29);
            this.guestNameComboBox.TabIndex = 21;
            // 
            // guestNameLabel
            // 
            this.guestNameLabel.AutoSize = true;
            this.guestNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(105)))));
            this.guestNameLabel.Location = new System.Drawing.Point(18, 389);
            this.guestNameLabel.Name = "guestNameLabel";
            this.guestNameLabel.Size = new System.Drawing.Size(96, 21);
            this.guestNameLabel.TabIndex = 22;
            this.guestNameLabel.Text = "Guest Name";
            // 
            // guestDietaryRestrictionsLabel
            // 
            this.guestDietaryRestrictionsLabel.AutoSize = true;
            this.guestDietaryRestrictionsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestDietaryRestrictionsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(105)))));
            this.guestDietaryRestrictionsLabel.Location = new System.Drawing.Point(18, 464);
            this.guestDietaryRestrictionsLabel.Name = "guestDietaryRestrictionsLabel";
            this.guestDietaryRestrictionsLabel.Size = new System.Drawing.Size(189, 21);
            this.guestDietaryRestrictionsLabel.TabIndex = 24;
            this.guestDietaryRestrictionsLabel.Text = "Guest Dietary Restrictions";
            // 
            // guestDietaryRestrictionsComboBox
            // 
            this.guestDietaryRestrictionsComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestDietaryRestrictionsComboBox.FormattingEnabled = true;
            this.guestDietaryRestrictionsComboBox.Location = new System.Drawing.Point(22, 488);
            this.guestDietaryRestrictionsComboBox.Name = "guestDietaryRestrictionsComboBox";
            this.guestDietaryRestrictionsComboBox.Size = new System.Drawing.Size(351, 29);
            this.guestDietaryRestrictionsComboBox.TabIndex = 23;
            // 
            // nameSuffixLabel
            // 
            this.nameSuffixLabel.AutoSize = true;
            this.nameSuffixLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSuffixLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(105)))));
            this.nameSuffixLabel.Location = new System.Drawing.Point(404, 389);
            this.nameSuffixLabel.Name = "nameSuffixLabel";
            this.nameSuffixLabel.Size = new System.Drawing.Size(95, 21);
            this.nameSuffixLabel.TabIndex = 26;
            this.nameSuffixLabel.Text = "Name Suffix";
            // 
            // nameSuffixComboBox
            // 
            this.nameSuffixComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameSuffixComboBox.FormattingEnabled = true;
            this.nameSuffixComboBox.Location = new System.Drawing.Point(406, 413);
            this.nameSuffixComboBox.Name = "nameSuffixComboBox";
            this.nameSuffixComboBox.Size = new System.Drawing.Size(351, 29);
            this.nameSuffixComboBox.TabIndex = 25;
            // 
            // addressOneComboBox
            // 
            this.addressOneComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressOneComboBox.FormattingEnabled = true;
            this.addressOneComboBox.Location = new System.Drawing.Point(406, 488);
            this.addressOneComboBox.Name = "addressOneComboBox";
            this.addressOneComboBox.Size = new System.Drawing.Size(351, 29);
            this.addressOneComboBox.TabIndex = 25;
            // 
            // addressOneLabel
            // 
            this.addressOneLabel.AutoSize = true;
            this.addressOneLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressOneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(105)))));
            this.addressOneLabel.Location = new System.Drawing.Point(404, 464);
            this.addressOneLabel.Name = "addressOneLabel";
            this.addressOneLabel.Size = new System.Drawing.Size(99, 21);
            this.addressOneLabel.TabIndex = 26;
            this.addressOneLabel.Text = "Address One";
            // 
            // addressTwoComboBox
            // 
            this.addressTwoComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTwoComboBox.FormattingEnabled = true;
            this.addressTwoComboBox.Location = new System.Drawing.Point(406, 559);
            this.addressTwoComboBox.Name = "addressTwoComboBox";
            this.addressTwoComboBox.Size = new System.Drawing.Size(351, 29);
            this.addressTwoComboBox.TabIndex = 25;
            // 
            // addressTwoLabel
            // 
            this.addressTwoLabel.AutoSize = true;
            this.addressTwoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTwoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(105)))));
            this.addressTwoLabel.Location = new System.Drawing.Point(404, 535);
            this.addressTwoLabel.Name = "addressTwoLabel";
            this.addressTwoLabel.Size = new System.Drawing.Size(99, 21);
            this.addressTwoLabel.TabIndex = 26;
            this.addressTwoLabel.Text = "Address Two";
            // 
            // addressThreeComboBox
            // 
            this.addressThreeComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressThreeComboBox.FormattingEnabled = true;
            this.addressThreeComboBox.Location = new System.Drawing.Point(406, 636);
            this.addressThreeComboBox.Name = "addressThreeComboBox";
            this.addressThreeComboBox.Size = new System.Drawing.Size(351, 29);
            this.addressThreeComboBox.TabIndex = 25;
            // 
            // addressThreeLabel
            // 
            this.addressThreeLabel.AutoSize = true;
            this.addressThreeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressThreeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(105)))));
            this.addressThreeLabel.Location = new System.Drawing.Point(404, 612);
            this.addressThreeLabel.Name = "addressThreeLabel";
            this.addressThreeLabel.Size = new System.Drawing.Size(109, 21);
            this.addressThreeLabel.TabIndex = 26;
            this.addressThreeLabel.Text = "Address Three";
            // 
            // cityCombobox
            // 
            this.cityCombobox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityCombobox.FormattingEnabled = true;
            this.cityCombobox.Location = new System.Drawing.Point(20, 559);
            this.cityCombobox.Name = "cityCombobox";
            this.cityCombobox.Size = new System.Drawing.Size(351, 29);
            this.cityCombobox.TabIndex = 25;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(105)))));
            this.cityLabel.Location = new System.Drawing.Point(18, 535);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(37, 21);
            this.cityLabel.TabIndex = 26;
            this.cityLabel.Text = "City";
            // 
            // stateComboBox
            // 
            this.stateComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(22, 612);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(351, 29);
            this.stateComboBox.TabIndex = 25;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(105)))));
            this.stateLabel.Location = new System.Drawing.Point(20, 588);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(45, 21);
            this.stateLabel.TabIndex = 26;
            this.stateLabel.Text = "State";
            // 
            // postalComboBox
            // 
            this.postalComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postalComboBox.FormattingEnabled = true;
            this.postalComboBox.Location = new System.Drawing.Point(22, 670);
            this.postalComboBox.Name = "postalComboBox";
            this.postalComboBox.Size = new System.Drawing.Size(351, 29);
            this.postalComboBox.TabIndex = 25;
            // 
            // postalLabel
            // 
            this.postalLabel.AutoSize = true;
            this.postalLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(105)))));
            this.postalLabel.Location = new System.Drawing.Point(20, 646);
            this.postalLabel.Name = "postalLabel";
            this.postalLabel.Size = new System.Drawing.Size(52, 21);
            this.postalLabel.TabIndex = 26;
            this.postalLabel.Text = "Postal";
            // 
            // countryComboBox
            // 
            this.countryComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(408, 699);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(351, 29);
            this.countryComboBox.TabIndex = 25;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(33)))), ((int)(((byte)(105)))));
            this.countryLabel.Location = new System.Drawing.Point(406, 675);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(66, 21);
            this.countryLabel.TabIndex = 26;
            this.countryLabel.Text = "Country";
            // 
            // UpeGuestListExportUtility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1129, 981);
            this.Controls.Add(this.secondSortLabel);
            this.Controls.Add(this.firstSortComboBox);
            this.Controls.Add(this.firstSortLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.secondSortComboBox);
            this.Controls.Add(this.upeGuestlistTitleLabel);
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
        private System.Windows.Forms.Label upeGuestlistTitleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label guestCountLabel;
        private System.Windows.Forms.ComboBox guestCountComboBox;
        private System.Windows.Forms.Label secondSortLabel;
        private System.Windows.Forms.ComboBox firstSortComboBox;
        private System.Windows.Forms.Label firstSortLabel;
        private System.Windows.Forms.ComboBox secondSortComboBox;
        private System.Windows.Forms.Label addressThreeLabel;
        private System.Windows.Forms.Label addressTwoLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label postalLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label addressOneLabel;
        private System.Windows.Forms.Label nameSuffixLabel;
        private System.Windows.Forms.ComboBox addressThreeComboBox;
        private System.Windows.Forms.ComboBox addressTwoComboBox;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.ComboBox postalComboBox;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.ComboBox cityCombobox;
        private System.Windows.Forms.ComboBox addressOneComboBox;
        private System.Windows.Forms.ComboBox nameSuffixComboBox;
        private System.Windows.Forms.Label guestDietaryRestrictionsLabel;
        private System.Windows.Forms.ComboBox guestDietaryRestrictionsComboBox;
        private System.Windows.Forms.ComboBox guestNameComboBox;
        private System.Windows.Forms.Label guestNameLabel;
    }
}

