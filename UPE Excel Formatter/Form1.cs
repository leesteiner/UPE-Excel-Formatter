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
        List<CellObject> headerTitleList = new List<CellObject>();
        List<RowObject> spreadsheetData = new List<RowObject>();
        List<int> neededColumns = new List<int>();
        List<LabelAndBoxObject> comboBoxAndLabelList = new List<LabelAndBoxObject>();
        String filename;

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


            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel or CSV Files|*.xls;*.xlsx;*.xlsm;*.csv";
            openFileDialog1.Title = "Select an Excel file";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;

                //em.Open(filename);
                //Start Excel and get Application object.

                oXL = new Excel.Application();
                oXL.Visible = false;
                oWB = oXL.Workbooks.Open(filename);
                oSheet = (Excel._Worksheet)oWB.ActiveSheet;
                oRng = (Excel.Range)oSheet.UsedRange;
                totalColumns = oRng.Columns.Count;
                totalRows = oRng.Rows.Count;
                //string[] headerTitles = new string[totalColumns+1];
                
                //string[,] spreadsheetData = new string[totalRows,totalColumns];
                for (int c = 1; c < totalColumns + 1; c++)
                {
                    string value = oSheet.Cells[1, c].Value.ToString();
                    CellObject cell = new CellObject(1, c, value);
                    //headerTitles[i] = oSheet.Cells[1, i].Value.ToString();
                    headerTitleList.Add(cell);
                }

                //TODO: Reload below data after selectors are set. Access xl sheet twice
                /*
                 * //THIS CODE BELOW WORKS, USE AFTER ABOVE IS SET
                for (int r = 2 ; r < totalRows ; r++)
                {
                    RowObject currentRow = new RowObject();
                    currentRow.RowNumber = r;
                    for (int c = 1; c < totalColumns; c++)
                    {
                        CellObject cellData = new CellObject();
                        string value = "";
                        if (oSheet.Cells[r, c].Value != null)
                        {
                            value = oSheet.Cells[r, c].Value.ToString();
                        }
                        else if (oSheet.Cells[r, c].Value == null)
                        {
                            value = "null";
                        }
                        else value = "null";
                        
                        CellObject cell = new CellObject(r, c, value);

                        currentRow.Cells.Add(cell);
                        
                    }
                    spreadsheetData.Add(currentRow);
                    
                }
                */
                //for (int i = 1; i < totalRows; i++)
                //{
                //    for (int p = 1; p < totalColumns; p++)
                //    {

                //        spreadsheetData[i, p] = oSheet.Cells[i, p].Value.ToString();
                //    }
                //}
                Marshal.ReleaseComObject(oRng);
                Marshal.ReleaseComObject(oSheet);
                oWB.Close();
                Marshal.ReleaseComObject(oWB);
                oXL.Quit();
                Marshal.ReleaseComObject(oXL);



                firstNameComboBox.DataSource = headerTitleList;
                firstNameComboBox.DisplayMember = "Value";
                comboBoxAndLabelList.Add(new LabelAndBoxObject(firstNameComboBox, firstNameLabel, new List<string>() {"first"}));

                lastNameComboBox.BindingContext = new BindingContext();
                lastNameComboBox.DataSource = headerTitleList;
                lastNameComboBox.DisplayMember = "Value";
                comboBoxAndLabelList.Add(new LabelAndBoxObject(lastNameComboBox, lastNameLabel, new List<string>() { "last" }));

                uniComboBox.BindingContext = new BindingContext();
                uniComboBox.DataSource = headerTitleList;
                uniComboBox.DisplayMember = "Value";
                comboBoxAndLabelList.Add(new LabelAndBoxObject(uniComboBox, uniLabel, new List<string>() { "uni" }));

                emailComboBox.BindingContext = new BindingContext();
                emailComboBox.DataSource = headerTitleList;
                emailComboBox.DisplayMember = "Value";
                comboBoxAndLabelList.Add(new LabelAndBoxObject(emailComboBox, emailLabel, new List<string>() { "email" }));

                namePrefixComboBox.BindingContext = new BindingContext();
                namePrefixComboBox.DataSource = headerTitleList;
                namePrefixComboBox.DisplayMember = "Value";
                comboBoxAndLabelList.Add(new LabelAndBoxObject(namePrefixComboBox, namePrefixLabel, new List<string>() { "prefix" }));

                rsvpComboBox.BindingContext = new BindingContext();
                rsvpComboBox.DataSource = headerTitleList;
                rsvpComboBox.DisplayMember = "Value";
                comboBoxAndLabelList.Add(new LabelAndBoxObject(rsvpComboBox, rsvpLabel, new List<string>() { "rsvp" }));

                rsvpNoteComboBox.BindingContext = new BindingContext();
                rsvpNoteComboBox.DataSource = headerTitleList;
                rsvpNoteComboBox.DisplayMember = "Value";
                comboBoxAndLabelList.Add(new LabelAndBoxObject(rsvpNoteComboBox, rsvpNoteLabel, new List<string>() { "rsvp","note" }));

                dateOfReplyComboBox.BindingContext = new BindingContext();
                dateOfReplyComboBox.DataSource = headerTitleList;
                dateOfReplyComboBox.DisplayMember = "Value";
                comboBoxAndLabelList.Add(new LabelAndBoxObject(dateOfReplyComboBox, dateOfReplyLabel, new List<string>() { "date","reply" }));


                dietaryRestrictionsComboBox.BindingContext = new BindingContext();
                dietaryRestrictionsComboBox.DataSource = headerTitleList;
                dietaryRestrictionsComboBox.DisplayMember = "Value";
                comboBoxAndLabelList.Add(new LabelAndBoxObject(dietaryRestrictionsComboBox, dietaryRestrictionsLabel, new List<string>() { "dietary", "restrictions" }));

                dateCreatedComboBox.BindingContext = new BindingContext();
                dateCreatedComboBox.DataSource = headerTitleList;
                dateCreatedComboBox.DisplayMember = "Value";
                comboBoxAndLabelList.Add(new LabelAndBoxObject(dateCreatedComboBox, dateCreatedLabel, new List<string>() { "created" }));




                //TODO: Automatch comboboxes: As Below
                //TODO: Last column getting cut off on import of column headers

                StringComparison comp = StringComparison.OrdinalIgnoreCase;



                foreach (LabelAndBoxObject l in comboBoxAndLabelList)
                {
                    bool stringMatched = false;
                    while (stringMatched == false)
                    {
                        foreach (CellObject cell in headerTitleList)
                        {
                            /*if (cell.Value.ToString() == l.label.Text)
                            if (cell.Value.Contains(l.label.Text,comp))
                            {
                                l.comboBox.SelectedItem = l.comboBox.Items.IndexOf(cell);
                                //??l.comboBox.SelectedItem = cell;
                            }

                            */


                            //compare label text to list of strings;

                            if (l.searchStrings.Count > 1)
                            {
                                if (cell.Value.ToString().Contains(l.searchStrings[0],comp) && cell.Value.ToString().Contains(l.searchStrings[1],comp) && stringMatched == false)
                                {
                                    l.comboBox.SelectedItem = cell;
                                    stringMatched = true;
                                }
                            }
                            else if (l.searchStrings.Count == 1)
                            {
                                if (cell.Value.ToString().Contains(l.searchStrings[0], comp) && stringMatched == false)
                                {
                                    l.comboBox.SelectedItem = cell;
                                    stringMatched = true;
                                }
                            }




                        }
                        stringMatched = true;

                    }



                }



                //oRng.Font.FontStyle = "Garamond";
                //oRng = oSheet.UsedRange;


                ////Start Excel and get Application object.
                //using (ExcelManager em = new ExcelManager())
                //{

                //    //List<RowObject> allRows = new List<RowObject>();
                //    //Change column count!
                //    //int columnCount = 20;
                //    //int rowCount = 40;
                //    //for (int i=0;i<rowCount;i++)
                //    //{
                //    //    RowObject currentRow = new RowObject();
                //    //    ArrayList rowArray = new ArrayList();
                //    //    rowArray = em.GetRangeFormattedValues($"A{i}", $"AZ{i}");
                //    //}
                //}



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
                neededColumns.Add(l.comboBox.SelectedIndex+1);

                //TODO: Add label text to a separate list? Display list of headers that way?
            }


            Excel.Application oXL;
            Excel._Workbook oWB;
            Excel._Worksheet oSheet;
            Excel.Range oRng;


            oXL = new Excel.Application();
            oXL.Visible = false;
            oWB = oXL.Workbooks.Open(filename);
            oSheet = (Excel._Worksheet)oWB.ActiveSheet;
            oRng = (Excel.Range)oSheet.UsedRange;
            int totalColumns = oRng.Columns.Count;
            int totalRows = oRng.Rows.Count;



            //TODO: Add working box so the user knows it's working
            //TODO: Sort data by: Type, 
            //THIS CODE BELOW WORKS, USE AFTER ABOVE IS SET
            for (int r = 2; r < totalRows; r++)
            {
                RowObject currentRow = new RowObject();
                currentRow.RowNumber = r;

                foreach (int c in neededColumns)
                {
                    CellObject cellData = new CellObject();
                    //string value = "";
                    var cellValue = (string)(oSheet.Cells[r, c] as Range).Text;
                    //value = (string)oSheet.Cells[r, c].Value;
                    //if (oSheet.Cells[r,c].Value != null)
                    //{
                    //    value = oSheet.Cells[r, c].Value.ToString();
                    //}
                    //else if (oSheet.Cells[r, c].Value == null)
                    //{
                    //    value = "null";
                    //}
                    //else value = "null";

                    //CellObject cell = new CellObject(r, c, value);
                    CellObject cell = new CellObject(r, c, cellValue);

                    currentRow.Cells.Add(cell);
                }


                //for (int c = 1; c < totalColumns; c++)
                //{
                //    if (neededColumns.Contains(c))
                //    {
                //        CellObject cellData = new CellObject();
                //        string value = "";
                //        if (oSheet.Cells[r, c].Value != null)
                //        {
                //            value = oSheet.Cells[r, c].Value.ToString();
                //        }
                //        else if (oSheet.Cells[r, c].Value == null)
                //        {
                //            value = "null";
                //        }
                //        else value = "null";

                //        CellObject cell = new CellObject(r, c, value);

                //        currentRow.Cells.Add(cell);
                //    }


                //}
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
            foreach (int i in neededColumns)
            {
                oSheet.Cells[1, column++].Value = headerTitleList[i-1].Value;
            }
            //foreach (CellObject c in headerTitleList)
            //{
            //    if (neededColumns.Contains(c.Column))
            //    {
            //        oSheet.Cells[1, column++].Value = c.Value;
            //    }
                
            //}



            







            foreach (RowObject r in spreadsheetData)
            {
                int currentColumn = 1;
                foreach (CellObject c in r)
                {

                    oSheet.Cells[c.Row, currentColumn].Value = c.Value;
                    currentColumn++;
                    
                }
                
            }
        }


    }
}
