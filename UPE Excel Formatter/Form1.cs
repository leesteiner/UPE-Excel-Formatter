using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;

namespace UPE_Excel_Formatter
{
    public partial class Form1 : Form
    {
        private List<CellObject> headerTitleList = new List<CellObject>();
        private List<RowObject> spreadsheetData = new List<RowObject>();
        private List<Tuple<int,string>> neededColumns = new List<Tuple<int,string>>();
        private List<LabelAndBoxObject> comboBoxAndLabelList = new List<LabelAndBoxObject>();
        private String filename;
        

        public Form1()
        {
            InitializeComponent();
            RenameThisMethod();
        }

        private void RenameThisMethod()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Excel.Application oXL;
            Excel._Workbook oWB;
            Excel._Worksheet oSheet;
            Excel.Range oRng;
            int totalColumns = 0;
            int totalRows = 0;

            #region Open Excel and Get Headers
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel or CSV Files|*.xls;*.xlsx;*.xlsm;*.csv";
            openFileDialog1.Title = "Select an Excel file";

            //If Open File Dialog succeeds, store result in string filename
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;

                //Start Excel and get Application object.
                oXL = new Excel.Application();

                //Set this to false when on work computer, works fine in background unless there is a dialog popup
                oXL.Visible = true;
                oWB = oXL.Workbooks.Open(filename);
                oSheet = (Excel._Worksheet)oWB.ActiveSheet;

                //Get total used range and set total columns and rows
                oRng = (Excel.Range)oSheet.UsedRange;
                totalColumns = oRng.Columns.Count;
                totalRows = oRng.Rows.Count;

                //For each column in Header (row 1), create cell object, pass in row 1, column num and value
                //Add cell to headerTitleList
                for (int c = 1; c < totalColumns + 1; c++)
                {
                    string value = oSheet.Cells[1, c].Value.ToString();
                    CellObject cell = new CellObject(1, c, value);
                    headerTitleList.Add(cell);
                }

                //Add last cell to headerTitleList for user option in case match can't be made later
                headerTitleList.Add(new CellObject(1, totalColumns + 2, "Add this row to sheet."));

                //Release ComObjects and Close Excel
                Marshal.ReleaseComObject(oRng);
                Marshal.ReleaseComObject(oSheet);
                oWB.Close();
                Marshal.ReleaseComObject(oWB);
                oXL.Quit();
                Marshal.ReleaseComObject(oXL);

                #endregion

                #region Bind Form Elements
                //Bind comboboxes to list of header values, combine with label, search string, and corresponding header for final export, add to list
                firstNameComboBox.DataSource = headerTitleList;
                firstNameComboBox.DisplayMember = "Value";
                comboBoxAndLabelList.Add(new LabelAndBoxObject(firstNameComboBox, firstNameLabel, new List<string>() {"first"}, "First Name" ));

                lastNameComboBox.BindingContext = new BindingContext();
                lastNameComboBox.DataSource = headerTitleList;
                lastNameComboBox.DisplayMember = "Value";
                comboBoxAndLabelList.Add(new LabelAndBoxObject(lastNameComboBox, lastNameLabel, new List<string>() { "last" }, "Last Name" ));

                uniComboBox.BindingContext = new BindingContext();
                uniComboBox.DataSource = headerTitleList;
                uniComboBox.DisplayMember = "Value";
                comboBoxAndLabelList.Add(new LabelAndBoxObject(uniComboBox, uniLabel, new List<string>() { "uni" }, "UNI" ));

                emailComboBox.BindingContext = new BindingContext();
                emailComboBox.DataSource = headerTitleList;
                emailComboBox.DisplayMember = "Value";
                comboBoxAndLabelList.Add(new LabelAndBoxObject(emailComboBox, emailLabel, new List<string>() { "email" }, "Email Address" ));

                namePrefixComboBox.BindingContext = new BindingContext();
                namePrefixComboBox.DataSource = headerTitleList;
                namePrefixComboBox.DisplayMember = "Value";
                comboBoxAndLabelList.Add(new LabelAndBoxObject(namePrefixComboBox, namePrefixLabel, new List<string>() { "prefix" }, "Name Prefix" ));

                rsvpComboBox.BindingContext = new BindingContext();
                rsvpComboBox.DataSource = headerTitleList;
                rsvpComboBox.DisplayMember = "Value";
                comboBoxAndLabelList.Add(new LabelAndBoxObject(rsvpComboBox, rsvpLabel, new List<string>() { "rsvp" }, "RSVP" ));

                rsvpNoteComboBox.BindingContext = new BindingContext();
                rsvpNoteComboBox.DataSource = headerTitleList;
                rsvpNoteComboBox.DisplayMember = "Value";
                comboBoxAndLabelList.Add(new LabelAndBoxObject(rsvpNoteComboBox, rsvpNoteLabel, new List<string>() { "rsvp","note" }, "RSVP Note" ));

                dateOfReplyComboBox.BindingContext = new BindingContext();
                dateOfReplyComboBox.DataSource = headerTitleList;
                dateOfReplyComboBox.DisplayMember = "Value";
                comboBoxAndLabelList.Add(new LabelAndBoxObject(dateOfReplyComboBox, dateOfReplyLabel, new List<string>() { "date","reply" }, "Date of Reply" ));


                dietaryRestrictionsComboBox.BindingContext = new BindingContext();
                dietaryRestrictionsComboBox.DataSource = headerTitleList;
                dietaryRestrictionsComboBox.DisplayMember = "Value";
                comboBoxAndLabelList.Add(new LabelAndBoxObject(dietaryRestrictionsComboBox, dietaryRestrictionsLabel, new List<string>() { "dietary", "restrictions" }, "Dietary Restrictions" ));


                //TODO: Is this duplication of date of reply??

                dateCreatedComboBox.BindingContext = new BindingContext();
                dateCreatedComboBox.DataSource = headerTitleList;
                dateCreatedComboBox.DisplayMember = "Value";
                comboBoxAndLabelList.Add(new LabelAndBoxObject(dateCreatedComboBox, dateCreatedLabel, new List<string>() { "created" }, "Date Created" ));

                #endregion

                #region Match Headers to Form Element Selections

                //Set compare criteria here with any StringComparison enum
                StringComparison comp = StringComparison.OrdinalIgnoreCase;

                //Iterate through ComboBoxes in Form
                foreach (LabelAndBoxObject l in comboBoxAndLabelList)
                {
                    //Set initial selected item to last in header list, which should be "Add this to spreadsheet"
                    l.comboBox.SelectedItem = headerTitleList[headerTitleList.Count - 1];

                    bool stringMatched = false;
                    while (stringMatched == false)
                    {
                           
                        //Iterate through cells in HeaderTitle List
                        foreach (CellObject cell in headerTitleList)
                        {

                            //Compare values of cell to list of strings defined in #Bind Form Elements using Contains() string extension, if match is found, set selected;
                            
                            //If there is more than one string (not scalable, only two currently)
                            if (l.searchStrings.Count > 1)
                            {
                                if (cell.Value.ToString().Contains(l.searchStrings[0],comp) && cell.Value.ToString().Contains(l.searchStrings[1],comp) && stringMatched == false)
                                {
                                    l.comboBox.SelectedItem = cell;
                                    stringMatched = true;
                                }
                            }

                            //If there is only one string
                            else if (l.searchStrings.Count == 1)
                            {
                                if (cell.Value.ToString().Contains(l.searchStrings[0], comp) && stringMatched == false)
                                {
                                    l.comboBox.SelectedItem = cell;
                                    stringMatched = true;
                                }
                            }

                        }
                        
                        //TODO: can this be a break?
                        //If no match found, exit loop
                        stringMatched = true;

                    }
                }


                #endregion
                //oRng.Font.FontStyle = "Garamond";
                //oRng = oSheet.UsedRange;
                //oXL = new Excel.Application();
                //oXL.Visible = true;
                //oWB = oXL.Workbooks.Open(filename);
                //oSheet = (Excel._Worksheet)oWB.ActiveSheet;
                //oRng = (Excel.Range)oSheet.UsedRange;
                //oRng.Font.FontStyle = "Garamond";
                //oRng = oSheet.UsedRange;
            }
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            foreach (LabelAndBoxObject l in comboBoxAndLabelList)
            {
                neededColumns.Add(new Tuple<int,string>(l.comboBox.SelectedIndex+1,l.name));
            }


            Excel.Application oXL;
            Excel._Workbook oWB;
            Excel._Worksheet oSheet;
            Excel.Range oRng;


            oXL = new Excel.Application();
            oXL.Visible = true;
            oWB = oXL.Workbooks.Open(filename);
            oSheet = (Excel._Worksheet)oWB.ActiveSheet;
            oRng = (Excel.Range)oSheet.UsedRange;
            int totalColumns = oRng.Columns.Count;
            int totalRows = oRng.Rows.Count;



            //TODO: Add working box so the user knows it's working
            //TODO: Sort data by: Type, 

            for (int r = 2; r < totalRows; r++)
            {
                RowObject currentRow = new RowObject();
                currentRow.RowNumber = r;

                foreach (Tuple<int,string> c in neededColumns)
                {
                    var cellValue = (string)(oSheet.Cells[r, c.Item1] as Range).Text;
                    CellObject cell = new CellObject(r, c.Item1, cellValue);             
                    currentRow.Cells.Add(cell);
                }

                spreadsheetData.Add(currentRow);

            }



            Marshal.ReleaseComObject(oRng);
            Marshal.ReleaseComObject(oSheet);
            oWB.Close();
            Marshal.ReleaseComObject(oWB);
            oXL.Quit();
            Marshal.ReleaseComObject(oXL);


            oXL = new Excel.Application();
            oXL.Visible = true;
            oWB = oXL.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            oSheet = (Worksheet)oWB.Worksheets[1];


            int column = 1;

            foreach (Tuple<int,string> i in neededColumns)
            {
                oSheet.Cells[1, column++].Value = i.Item2;
            }


            foreach (RowObject r in spreadsheetData)
            {
                int currentColumn = 1;
                foreach (CellObject c in r)
                {

                    oSheet.Cells[c.Row, currentColumn].Value = c.Value;
                    currentColumn++;
                    
                }
                
            }


            Marshal.ReleaseComObject(oRng);
            Marshal.ReleaseComObject(oSheet);
            Marshal.ReleaseComObject(oWB);
            Marshal.ReleaseComObject(oXL);
        }

        private void loadExcelSheetButton_Click(object sender, EventArgs e)
        {

        }
    }
}
