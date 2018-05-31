using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UPE_Excel_Formatter;

namespace UPE_Excel_Formatter
{
    public partial class HeaderConfirmation : Form
    {

        public List<LabelAndBoxObject> returnComboBoxAndLabelList = new List<LabelAndBoxObject>();
        public List<string> sortList2 = new List<string>();

        public HeaderConfirmation(List<LabelAndBoxObject> l)
        {
            InitializeComponent();
            returnComboBoxAndLabelList = l;
            
        }

        //IN HERE: Generate sort list from comboboxes passed in, on Omit radio change, reload combobox list, reset to 0 if thisindex moves.

        private void HeaderConfirmation_Load(object sender, EventArgs e)
        {

            //TODO - graphical: Combo boxes are too short on long header names (bedework)

            int i = 0;
            int x = 20;
            bool halved = false;
            
            Label labelI = new Label();
            labelI.Text = "Include / Add";
            this.Controls.Add(labelI);
            labelI.Location = new Point(x + 330, 30 * i + 10);
            labelI.BringToFront();

            Label labelO = new Label();
            labelO.Text = "Omit";
            this.Controls.Add(labelO);
            labelO.Location = new Point(x + 400, 30 * i + 10);
            labelO.BringToFront();

            Label labelIright = new Label();
            labelIright.Text = "Include / Add";
            this.Controls.Add(labelIright);
            labelIright.Location = new Point(x + 330 + 450, 30 * i + 10);
            labelIright.BringToFront();

            Label labelOright = new Label();
            labelOright.Text = "Omit";
            this.Controls.Add(labelOright);
            labelOright.Location = new Point(x + 400 + 450, 30 * i + 10);
            labelOright.BringToFront();

            foreach (LabelAndBoxObject l in returnComboBoxAndLabelList)
            {
                if (l.name != "Guest Count")
                {
                    Label label = new Label();
                    label = l.label;
                    label.Location = new Point(x, 30 * i + 10);
                    this.Controls.Add(label);
                    sortList2.Add(label.Text);


                    ComboBox combo = new ComboBox();
                    combo = l.comboBox;
                    combo.Location = new Point(x, 30 * i + 40);
                    combo.Enabled = false;
                    combo.Width = 300;
                    combo.BackColor = l.comboBox.BackColor;
                    this.Controls.Add(combo);



                    RadioButton radioI = new RadioButton();
                    radioI.Name = "radioI";
                    radioI = l.radioInclude;
                    radioI.AutoSize = true;
                    radioI.Location = new System.Drawing.Point(9, 22);
                    radioI.Margin = new System.Windows.Forms.Padding(0);
                    radioI.Size = new System.Drawing.Size(14, 13);
                    radioI.TabIndex = 0;
                    radioI.TabStop = true;
                    radioI.UseVisualStyleBackColor = true;
                    
                    radioI.Checked = true;




                    RadioButton radioO = new RadioButton();
                    radioO.Name = "radioO";
                    radioO = l.radioOmit;
                    radioO.AutoSize = true;
                    radioO.Location = new System.Drawing.Point(63, 22);
                    radioO.Margin = new System.Windows.Forms.Padding(0);
                    radioO.Size = new System.Drawing.Size(14, 13);
                    radioO.TabIndex = 0;
                    radioO.TabStop = true;
                    radioO.UseVisualStyleBackColor = true;
                    //TODO: Add event arg here for this.Name, repeat for radioI? link in bookmark bar for instructions
                    radioO.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);

                    GroupBox radioGroup = new GroupBox();

                    radioGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                    radioGroup.Controls.Add(radioI);
                    radioGroup.Controls.Add(radioO);
                    radioGroup.Location = new Point(x + 330, 30 * i + 10);
                    radioGroup.Margin = new System.Windows.Forms.Padding(0);
                    radioGroup.Name = l.name;
                    radioGroup.Padding = new System.Windows.Forms.Padding(0);
                    radioGroup.Size = new System.Drawing.Size(86, 45);
                    this.Controls.Add(radioGroup);


                    i = i + 2;

                    if (!halved)
                    {
                        int q = returnComboBoxAndLabelList.IndexOf(l);
                        if (q >= (returnComboBoxAndLabelList.Count - 1) / 2)
                        {
                            x = 450;
                            i = 0;
                            halved = true;
                        }
                    }
                }


            }



            firstSortComboBox.BindingContext = new BindingContext();
            firstSortComboBox.ValueMember = "Key";
            firstSortComboBox.DisplayMember = "Value";
            firstSortComboBox.DataSource = new BindingSource(sortList2, null);
            firstSortComboBox.SelectedIndex = 10;

            secondSortComboBox.BindingContext = new BindingContext();
            secondSortComboBox.ValueMember = "Key";
            secondSortComboBox.DisplayMember = "Value";
            secondSortComboBox.DataSource = new BindingSource(sortList2, null);
            secondSortComboBox.SelectedIndex = 6;
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton thisRadio = sender as RadioButton;
            GroupBox thisgroupBox = thisRadio.Parent as GroupBox;

            if (thisRadio.Name == "RadioO")
            {
                sortList2.Remove(thisgroupBox.Name);
            }
            else if (thisRadio.Name == "RadioI")
            {
                //TODO Populate this, add @ indexof?
            }

            firstSortComboBox.DataSource = new BindingSource(sortList2, null);
            secondSortComboBox.DataSource = new BindingSource(sortList2, null);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Change list to include new data here
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
