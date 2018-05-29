using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
using System.Threading;
using System.Linq;

namespace UPE_Excel_Formatter
{
    public partial class UpeGuestListExportUtility : Form
    {
        private List<CellObject> headerTitleList = new List<CellObject>();
        private List<RowObject> spreadsheetData = new List<RowObject>();
        private List<Tuple<int,string>> neededColumns = new List<Tuple<int,string>>();
        private List<LabelAndBoxObject> comboBoxAndLabelList = new List<LabelAndBoxObject>();
        private String filename;
        

        public UpeGuestListExportUtility()
        {
            InitializeComponent();
            RenameThisMethod();
        }

        private void RenameThisMethod()
        {

        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            //new Thread(() => new LoadingScreen().ShowDialog()).Start();


            foreach (LabelAndBoxObject l in comboBoxAndLabelList)
            {
                neededColumns.Add(new Tuple<int,string>(l.comboBox.SelectedIndex+1,l.name));
            }


            //TODO: Use vars?
            StringComparison comp = StringComparison.OrdinalIgnoreCase;
            Excel.Application oXL;
            Excel._Workbook oWB;
            Excel._Worksheet oSheet;
            Excel.Range oRng;
            Excel.Range titleRange;


            oXL = new Microsoft.Office.Interop.Excel.Application();
            oXL.Visible = false;
            var oWBS = oXL.Workbooks;
            oWB = oWBS.Open(filename);
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
                    
                    //DateTime cellDate;
                    if (c.Item2.Contains("date",comp))
                    {
                        //TODO: Handle Null Exception

                        //TimeSpan dateFromExcel = new TimeSpan(Convert.ToInt32((oSheet.cells[r, c.Item1] as Range)));
                        string cellString = (oSheet.Cells[r,c.Item1] as Range).Value2.ToString();
                        double date = double.Parse(cellString);
                        cellString = DateTime.FromOADate(date).ToString("MM/dd/yyyy");
                        //cellDate = DateTime.FromOADate(d);
                        CellObject cell = new CellObject(r, c.Item1, cellString);
                        currentRow.Cells.Add(cell);

                    }
                    else
                    {
                        string cellString = (string)(oSheet.Cells[r, c.Item1] as Range).Text;
                        CellObject cell = new CellObject(r, c.Item1, cellString);
                        currentRow.Cells.Add(cell);
                    }
                    
                    
                }

                spreadsheetData.Add(currentRow);

            }







            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            GC.WaitForPendingFinalizers();

        
            Marshal.FinalReleaseComObject(oRng);
            
            Marshal.FinalReleaseComObject(oSheet);
            oWB.Close(Type.Missing, Type.Missing, Type.Missing);
            oWBS.Close();
            
            Marshal.FinalReleaseComObject(oWB);
            Marshal.FinalReleaseComObject(oWBS);
            oXL.Quit();
            Marshal.FinalReleaseComObject(oXL);


            //TODO: SORT DATA HERE



            oXL = new Excel.Application();
            oXL.Visible = true;
            oWBS = oXL.Workbooks;
            oWB = oWBS.Add(XlWBATemplate.xlWBATWorksheet);
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


            oRng = (Excel.Range)oSheet.UsedRange;
            totalColumns = oRng.Columns.Count;
            totalRows = oRng.Rows.Count;
            Excel.Range titleRangeStart = oSheet.Cells[1, 1];
            Excel.Range titleRangeEnd = oSheet.Cells[1, totalColumns];
            Excel.Range bodyRangeStart = oSheet.Cells[2, totalColumns];
            Excel.Range bodyRangeEnd = oSheet.Cells[totalRows, totalColumns];
            //titleRange = (Excel.Range)oSheet.Range(oSheet.Cells[1, 1], oSheet.Cells[1, totalColumns]);
            titleRange = (Excel.Range)oSheet.get_Range(titleRangeStart, titleRangeEnd);
            //TODO: Format data here

            oRng.Font.Name = "Garamond";
            oRng.Font.Size = 11;
            titleRange.Interior.Color = Excel.XlRgbColor.rgbLightBlue;
            titleRange.Font.Bold = true;
            titleRange.Font.Size = 12;
            oRng.Columns.AutoFit();
            
            for (int i=1; i< totalColumns;i++)
            {
                oRng.Columns[i].AutoFit();

                if (oRng.Columns[i].ColumnWidth > 25 )
                {
                    oRng.Columns[1].ColumnWidth = 25;
                }
                
            }

            dynamic bodyRange = oSheet.get_Range(bodyRangeStart, bodyRangeEnd);

            //TODO: Layout landscape, print area, borders


            //SORT COLUMNS ARE NOT DYNAMIC - first sort is by Last Name (9), second by RSVP(5)
            oRng.Sort(oRng.Columns[9]);
            oRng.Sort(oRng.Columns[5]);
            oRng.Activate();
            oRng.Application.ActiveWindow.SplitRow = 1;
            oRng.Application.ActiveWindow.FreezePanes = true;
            titleRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            titleRange.Borders.Color = Excel.XlRgbColor.rgbBlack;
            titleRange.Borders.Weight = Excel.XlBorderWeight.xlThick;

            //titleRange.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
            //titleRange.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
            //titleRange.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
            //titleRange.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
            titleRange.AutoFilter(1, Type.Missing, Excel.XlAutoFilterOperator.xlAnd, Type.Missing, true);



            //titleRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            //titleRange.Borders.Weight = Excel.XlBorderWeight.xlThin;
            //titleRange.Borders. = Excel.XlBordersIndex.xlEdgeBottom;
            //titleRange.Borders = Excel.XlBordersIndex.xlEdgeRight;
            //titleRange.Borders = Excel.XlBordersIndex.xlEdgeLeft;
            //titleRange.Borders = Excel.XlBordersIndex.xlEdgeTop;
            var printSettings = oSheet.PageSetup;
            printSettings.Orientation = Excel.XlPageOrientation.xlLandscape;
            printSettings.PrintArea = "A1:" + oRng.SpecialCells(XlCellType.xlCellTypeLastCell);
            printSettings.FitToPagesWide = 1;
            printSettings.BottomMargin = 0.5;
            printSettings.TopMargin = 0.5;
            printSettings.LeftMargin = 0.5;
            printSettings.RightMargin = 0.5;
            printSettings.HeaderMargin = 0.5;
            printSettings.FooterMargin = 0.5;





            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //TODO: Close Workbooks here, then reopen as just file?
            Marshal.FinalReleaseComObject(oRng);
            Marshal.FinalReleaseComObject(titleRange);
            Marshal.FinalReleaseComObject(titleRangeStart);
            Marshal.FinalReleaseComObject(titleRangeEnd);
            Marshal.FinalReleaseComObject(bodyRangeStart);
            Marshal.FinalReleaseComObject(bodyRangeEnd);
            Marshal.FinalReleaseComObject(oSheet);
            Marshal.FinalReleaseComObject(oWB);
            Marshal.FinalReleaseComObject(oWBS);
            Marshal.FinalReleaseComObject(oXL);
            //TODO: Fix Loading Screen
            //LoadingScreen load = new LoadingScreen();
            //load = (LoadingScreen)System.Windows.Forms.Application.OpenForms["LoadingScreen"];
            //load.Close();
            
        }

        private void loadExcelSheetButton_Click(object sender, EventArgs e)
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
                oXL.Visible = false;
                var oWBS = oXL.Workbooks;
                oWB = oWBS.Open(filename);
                oSheet = (Excel._Worksheet)oWB.ActiveSheet;

                //Get total used range and set total columns and rows
                oRng = (Excel.Range)oSheet.UsedRange;
                totalColumns = oRng.Columns.Count;
                totalRows = oRng.Rows.Count;

                LoadingScreen.ShowLoadingScreen();
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

                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers();

                Marshal.FinalReleaseComObject(oRng);
                Marshal.FinalReleaseComObject(oSheet);
                oWB.Close(Type.Missing, Type.Missing, Type.Missing);
                oWBS.Close();
                Marshal.FinalReleaseComObject(oWB);
                Marshal.FinalReleaseComObject(oWBS);
                oWB = null;
                
                oXL.Quit();
                Marshal.FinalReleaseComObject(oXL);

                #endregion

                #region Bind Form Elements

                //TODO: Sort Comboboxes in panel so columns sort this way
                //Bind comboboxes to list of header values, combine with label, search string, and corresponding header for final export, add to list

                uniComboBox.BindingContext = new BindingContext();
                uniComboBox.DataSource = headerTitleList;
                uniComboBox.DisplayMember = "Value";
                comboBoxAndLabelList.Add(new LabelAndBoxObject(uniComboBox, uniLabel, new List<string>() { "uni" }, "UNI"));

                rsvpNoteComboBox.BindingContext = new BindingContext();
                rsvpNoteComboBox.DataSource = headerTitleList;
                rsvpNoteComboBox.DisplayMember = "Value";
                comboBoxAndLabelList.Add(new LabelAndBoxObject(rsvpNoteComboBox, rsvpNoteLabel, new List<string>() { "rsvp", "note" }, "RSVP Note"));

                dateOfReplyComboBox.BindingContext = new BindingContext();
                dateOfReplyComboBox.DataSource = headerTitleList;
                dateOfReplyComboBox.DisplayMember = "Value";
                comboBoxAndLabelList.Add(new LabelAndBoxObject(dateOfReplyComboBox, dateOfReplyLabel, new List<string>() { "date", "reply" }, "Date of Reply"));


                guestCountComboBox.BindingContext = new BindingContext();
                guestCountComboBox.DataSource = headerTitleList;
                guestCountComboBox.DisplayMember = "Value";
                comboBoxAndLabelList.Add(new LabelAndBoxObject(guestCountComboBox, guestCountLabel, new List<string>() {}, "Guest Count"));

                rsvpComboBox.BindingContext = new BindingContext();
                rsvpComboBox.DataSource = headerTitleList;
                rsvpComboBox.DisplayMember = "Value";
                comboBoxAndLabelList.Add(new LabelAndBoxObject(rsvpComboBox, rsvpLabel, new List<string>() { "rsvp" }, "RSVP"));

                dietaryRestrictionsComboBox.BindingContext = new BindingContext();
                dietaryRestrictionsComboBox.DataSource = headerTitleList;
                dietaryRestrictionsComboBox.DisplayMember = "Value";
                comboBoxAndLabelList.Add(new LabelAndBoxObject(dietaryRestrictionsComboBox, dietaryRestrictionsLabel, new List<string>() { "dietary", "restrictions" }, "Dietary Restrictions"));

                namePrefixComboBox.BindingContext = new BindingContext();
                namePrefixComboBox.DataSource = headerTitleList;
                namePrefixComboBox.DisplayMember = "Value";
                comboBoxAndLabelList.Add(new LabelAndBoxObject(namePrefixComboBox, namePrefixLabel, new List<string>() { "prefix" }, "Name Prefix"));

                lastNameComboBox.BindingContext = new BindingContext();
                firstNameComboBox.DataSource = headerTitleList;
                firstNameComboBox.DisplayMember = "Value";
                comboBoxAndLabelList.Add(new LabelAndBoxObject(firstNameComboBox, firstNameLabel, new List<string>() { "first" }, "First Name"));

                lastNameComboBox.BindingContext = new BindingContext();
                lastNameComboBox.DataSource = headerTitleList;
                lastNameComboBox.DisplayMember = "Value";
                comboBoxAndLabelList.Add(new LabelAndBoxObject(lastNameComboBox, lastNameLabel, new List<string>() { "last" }, "Last Name"));

                emailComboBox.BindingContext = new BindingContext();
                emailComboBox.DataSource = headerTitleList;
                emailComboBox.DisplayMember = "Value";
                comboBoxAndLabelList.Add(new LabelAndBoxObject(emailComboBox, emailLabel, new List<string>() { "email" }, "Email Address"));










                


                //TODO: Is this duplication of date of reply??

                dateCreatedComboBox.BindingContext = new BindingContext();
                dateCreatedComboBox.DataSource = headerTitleList;
                dateCreatedComboBox.DisplayMember = "Value";
                comboBoxAndLabelList.Add(new LabelAndBoxObject(dateCreatedComboBox, dateCreatedLabel, new List<string>() { "created" }, "Date Created"));

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
                                if (cell.Value.ToString().Contains(l.searchStrings[0], comp) && cell.Value.ToString().Contains(l.searchStrings[1], comp) && stringMatched == false)
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

                LoadingScreen.CloseForm();
            }
        }
    }
}
