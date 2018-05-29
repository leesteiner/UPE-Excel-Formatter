using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
using System.Threading;
using System.Linq;
using Jacksonsoft;

namespace UPE_Excel_Formatter 
{




    public partial class UpeGuestListExportUtility : Form 
    {
        private StringComparison comp = StringComparison.OrdinalIgnoreCase;
        private Excel.Application oXL;
        private Excel._Workbook oWB;
        private Excel._Worksheet oSheet;
        private Excel.Range oRng;
        private Excel.Range titleRange;
        private List<CellObject> headerTitleList = new List<CellObject>();
        private List<RowObject> spreadsheetData = new List<RowObject>();
        private List<Tuple<int, string>> sortColumns = new List<Tuple<int, string>>();
        private List<Tuple<int,string>> neededColumns = new List<Tuple<int,string>>();
        private List<LabelAndBoxObject> comboBoxAndLabelList = new List<LabelAndBoxObject>();
        private String filename;
        




        public UpeGuestListExportUtility()
        {
            InitializeComponent();


            Dictionary<int, string> sortList = new Dictionary<int, string>()
            {
            {1, uniLabel.Text},
            {2, rsvpNoteLabel.Text},
            {3, dateOfReplyLabel.Text},
            {4, dietaryRestrictionsLabel.Text},
            {5, rsvpLabel.Text},
            {6, namePrefixLabel.Text},
            {7, firstNameLabel.Text },
            {8, lastNameLabel.Text},
            {9, emailLabel.Text},
            {10, dateCreatedLabel.Text}

            };
            //var sortByList = new List<(int sortIndex, string sortName)> 
            //{
            //    (1, firstNameLabel.Text),
            //    (2, lastNameLabel.Text),
            //    (3, emailLabel.Text),
            //    (4, uniLabel.Text),
            //    (5, namePrefixLabel.Text),
            //    (6, rsvpLabel.Text),
            //    (7, rsvpNoteLabel.Text),
            //    (8, dateOfReplyLabel.Text),
            //    (9, dietaryRestrictionsLabel.Text),
            //    (10, dateCreatedLabel.Text)




            
            //List<string> sortList = new List<string>()
            //{

            //};
            



            firstSortComboBox.BindingContext = new BindingContext();
            firstSortComboBox.ValueMember = "Key";
            firstSortComboBox.DisplayMember = "Value";
            firstSortComboBox.DataSource = new BindingSource(sortList, null);
            firstSortComboBox.SelectedIndex = 7;

            secondSortComboBox.BindingContext = new BindingContext();
            secondSortComboBox.ValueMember = "Key";
            secondSortComboBox.DisplayMember = "Value";
            secondSortComboBox.DataSource = new BindingSource(sortList, null);
            secondSortComboBox.SelectedIndex = 4;


            

        }

        void importSpreadSheet()
        {

            foreach (LabelAndBoxObject l in comboBoxAndLabelList)
            {
                neededColumns.Add(new Tuple<int, string>(l.comboBox.SelectedIndex + 1, l.name));
            }




            var oWBS = oXL.Workbooks;
            oWB = oWBS.Open(filename);
            oSheet = (Excel._Worksheet)oWB.ActiveSheet;
            oRng = (Excel.Range)oSheet.UsedRange;
            int totalColumns = oRng.Columns.Count;
            int totalRows = oRng.Rows.Count;




            
            //TODO: Sort data by: Type, 

            for (int r = 2; r < totalRows; r++)
            {
                RowObject currentRow = new RowObject();
                currentRow.RowNumber = r;

                foreach (Tuple<int, string> c in neededColumns)
                {

                    if (c.Item2.Contains("date", comp))
                    {
                        string cellString = "";

                        if ((oSheet.Cells[r, c.Item1] as Range).Value2 != null)
                        {
                            cellString = (oSheet.Cells[r, c.Item1] as Range).Value2.ToString();
                            double date = double.Parse(cellString);
                            cellString = DateTime.FromOADate(date).ToString("MM/dd/yyyy");
                        }

                        else
                        {
                            cellString = "";
                        }

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

            oWB.Close(Type.Missing, Type.Missing, Type.Missing);
            oWBS.Close();

        }

        void exportSpreadsheet()
        {
            
            var oWBS = oXL.Workbooks;
            oWB = oWBS.Add();
            oSheet = (Excel._Worksheet)oWB.ActiveSheet;
            oXL.Visible = false;


            int sortColumn1 = 9;
            int sortColumn2 = 5;

            sortColumn1 = ((KeyValuePair<int, string>)firstSortComboBox.SelectedItem).Key;
            sortColumn2 = ((KeyValuePair<int, string>)secondSortComboBox.SelectedItem).Key;
            


            //TODO: Toggle boolean switch on RSVP Column Change
            //      add value to list of ints (insert rows)
            //      after sheet is formatted entirely, add rows (last rows first so they line up)
            //      make font same as title rows, merge cells


            int column = 1;


            foreach (Tuple<int, string> i in neededColumns)
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
            int totalColumns = oRng.Columns.Count;
            int totalRows = oRng.Rows.Count;
            Excel.Range titleRangeStart = oSheet.Cells[1, 1];
            Excel.Range titleRangeEnd = oSheet.Cells[1, totalColumns];
            Excel.Range bodyRangeStart = oSheet.Cells[2, totalColumns];
            Excel.Range bodyRangeEnd = oSheet.Cells[totalRows, totalColumns];
            //titleRange = (Excel.Range)oSheet.Range(oSheet.Cells[1, 1], oSheet.Cells[1, totalColumns]);
            titleRange = (Excel.Range)oSheet.get_Range(titleRangeStart, titleRangeEnd);
            
            //FORMAT DATA HERE

            oRng.Font.Name = "Garamond";
            oRng.Font.Size = 11;
            titleRange.Interior.Color = Excel.XlRgbColor.rgbLightBlue;
            titleRange.Font.Bold = true;
            titleRange.Font.Size = 12;
            oRng.Columns.AutoFit();

            for (int i = 1; i < totalColumns; i++)
            {
                oRng.Columns[i].AutoFit();

                if (oRng.Columns[i].ColumnWidth > 25)
                {
                    oRng.Columns[i].ColumnWidth = 25;
                }

            }

            dynamic bodyRange = oSheet.get_Range(bodyRangeStart, bodyRangeEnd);

            //TODO: Make columns dynamically sortable
            //SORT COLUMNS ARE NOT DYNAMIC - first sort is by Last Name (9), second by RSVP(5)
            oRng.Sort(oRng.Columns[sortColumn2, Type.Missing], XlSortOrder.xlAscending,
                            oRng.Columns[sortColumn1, Type.Missing], Type.Missing, XlSortOrder.xlAscending,
                            Type.Missing, XlSortOrder.xlAscending,
                            Excel.XlYesNoGuess.xlGuess, Type.Missing, Type.Missing,
                            XlSortOrientation.xlSortColumns, Excel.XlSortMethod.xlPinYin,
                            XlSortDataOption.xlSortNormal,
                            XlSortDataOption.xlSortNormal,
                            XlSortDataOption.xlSortNormal
                            );

            //bodyRange.Sort(bodyRange.Columns[sortColumn2]);
            oRng.Activate();
            oRng.Application.ActiveWindow.SplitRow = 1;
            oRng.Application.ActiveWindow.FreezePanes = true;
            oRng.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            oRng.Borders.Color = Excel.XlRgbColor.rgbBlack;
            oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;

            titleRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            titleRange.Borders.Color = Excel.XlRgbColor.rgbBlack;
            titleRange.Borders.Weight = Excel.XlBorderWeight.xlMedium;

            //titleRange.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
            //titleRange.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
            //titleRange.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
            //titleRange.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
            titleRange.AutoFilter(1, Type.Missing, Excel.XlAutoFilterOperator.xlAnd, Type.Missing, true);


            //Get Last cell in range
            string address = oRng.get_Address();
            string[] addressCells = address.Split(new char[] { ':' });
            string endCell = addressCells[1].Replace("$", "");

            //titleRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            //titleRange.Borders.Weight = Excel.XlBorderWeight.xlThin;
            //titleRange.Borders. = Excel.XlBordersIndex.xlEdgeBottom;
            //titleRange.Borders = Excel.XlBordersIndex.xlEdgeRight;
            //titleRange.Borders = Excel.XlBordersIndex.xlEdgeLeft;
            //titleRange.Borders = Excel.XlBordersIndex.xlEdgeTop;
            var printSettings = oSheet.PageSetup;
            printSettings.Orientation = Excel.XlPageOrientation.xlLandscape;
            printSettings.PrintArea = "A1:" + endCell;
            printSettings.Zoom = false;
            printSettings.FitToPagesWide = 1;
            printSettings.FitToPagesTall = false;
            printSettings.BottomMargin = oXL.InchesToPoints(0.75);
            printSettings.TopMargin = oXL.InchesToPoints(0.75);
            printSettings.LeftMargin = oXL.InchesToPoints(0.25);
            printSettings.RightMargin = oXL.InchesToPoints(0.25);


            //Header and Footer data here
            printSettings.LeftHeader = $"&\"Garamond\"&11&K000000{oRng.Rows.Count - 1} Guests";
            printSettings.CenterHeader = "&\"Garamond\"&B&24&K000000&F, as of &D";
            printSettings.RightFooter = "&\"Garamond\"&11&K000000&P of &N";
            printSettings.HeaderMargin = oXL.InchesToPoints(0.3);
            printSettings.FooterMargin = oXL.InchesToPoints(0.3);


            bool RsvpChecked = (((KeyValuePair<int, string>)secondSortComboBox.SelectedItem).Value.Contains("Rsvp", comp));



            if (RsvpChecked)
            {
                Excel.Range rsvpRangeStart = oSheet.Cells[2, sortColumn2];
                Excel.Range rsvpRangeEnd = oSheet.Cells[totalRows, sortColumn2];
                Excel.Range rsvpRange = (Excel.Range)oSheet.get_Range(rsvpRangeStart, rsvpRangeEnd);


                List<Tuple<int, string>> rsvpRowsToInsert = new List<Tuple<int, string>>();


                string changeStringCheck = oSheet.Cells[2, sortColumn2].Value;
                rsvpRowsToInsert.Add(new Tuple<int, string>(2, changeStringCheck));

                for (int r = 2;r<totalRows;r++)
                {
                    if (changeStringCheck != oSheet.Cells[r,sortColumn2].Value)
                    {
                        changeStringCheck = oSheet.Cells[r, sortColumn2].Value;
                        rsvpRowsToInsert.Add(new Tuple<int, string>(r, changeStringCheck));
                    }

                }
                rsvpRowsToInsert.Reverse();
                foreach (Tuple<int,string> t in rsvpRowsToInsert)
                {
                    oSheet.Rows[t.Item1].Insert();
                    oSheet.Cells[t.Item1, 1].Value = t.Item2;
                    oSheet.Range[oSheet.Cells[t.Item1, 1], oSheet.Cells[t.Item1,totalColumns]].Merge();
                }
                
                    //int currentColumn = 1;
                    ////IF CurrentColumn = sortcolumn2?


                    //foreach (CellObject c in r)
                    //{
                    //    oSheet.Cells[c.Row, currentColumn].Value = c.Value;
                    //    if (currentColumn == sortColumn2)
                    //    {
                    //        if (changeStringCheck != c.Value)
                    //        {
                    //            changeStringCheck = oSheet.Cells[c.Row, currentColumn].Value;
                    //            rsvpRowsToInsert.Add(new Tuple<int, string>(c.Row, changeStringCheck));
                    //        }
                    //    }

                    //    currentColumn++;

                    //}

                
            }





            oRng.WrapText = true;
            oXL.Visible = true;

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
        void importAndExportSpreadSheet()
        {
            //using (LoadingScreen loadScreen = new LoadingScreen(importAndExportSpreadSheet))
            //{
            //    loadScreen.ShowDialog(this);
            //}

            //new Thread(() => new LoadingScreen().ShowDialog()).Start();


            

            //TODO: SORT DATA HERE



            
        }
        
        private void continueButton_Click(object sender, EventArgs e)
        {
            //LoadingScreen.ShowLoadingScreen();
            //importAndExportSpreadSheet();
            //LoadingScreen.CloseForm();
            object result = Jacksonsoft.WaitWindow.Show(this.WorkerMethod, "Writing new excel sheet...");

            MessageBox.Show(result.ToString());
            System.Windows.Forms.Application.Exit();

        }

        
        void loadExcelSheet()
        {

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
                oXL.Visible = false;


                //Set this to false when on work computer, works fine in background unless there is a dialog popup
                var oWBS = oXL.Workbooks;
                oWB = oWBS.Open(filename);
                oSheet = (Excel._Worksheet)oWB.ActiveSheet;

                //Get total used range and set total columns and rows
                oRng = (Excel.Range)oSheet.UsedRange;
                totalColumns = oRng.Columns.Count;
                totalRows = oRng.Rows.Count;

                //LoadingScreen loadScreen = new LoadingScreen();
                //loadScreen.Show();
                //System.Windows.Forms.Application.DoEvents();


                //LoadingScreen.ShowLoadingScreen();
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

                #endregion

                #region Bind Form Elements

                //TODO: Sort Comboboxes in panel so columns sort this way
                //Bind comboboxes to list of header values, combine with label, search string, and corresponding header for final export, add to list

                uniComboBox.BindingContext = new BindingContext();
                uniComboBox.DataSource = headerTitleList;
                uniComboBox.DisplayMember = "Value";
                

                rsvpNoteComboBox.BindingContext = new BindingContext();
                rsvpNoteComboBox.DataSource = headerTitleList;
                rsvpNoteComboBox.DisplayMember = "Value";
                

                dateOfReplyComboBox.BindingContext = new BindingContext();
                dateOfReplyComboBox.DataSource = headerTitleList;
                dateOfReplyComboBox.DisplayMember = "Value";
                


                guestCountComboBox.BindingContext = new BindingContext();
                guestCountComboBox.DataSource = headerTitleList;
                guestCountComboBox.DisplayMember = "Value";
                


                rsvpComboBox.BindingContext = new BindingContext();
                rsvpComboBox.DataSource = headerTitleList;
                rsvpComboBox.DisplayMember = "Value";
                

                dietaryRestrictionsComboBox.BindingContext = new BindingContext();
                dietaryRestrictionsComboBox.DataSource = headerTitleList;
                dietaryRestrictionsComboBox.DisplayMember = "Value";
                

                namePrefixComboBox.BindingContext = new BindingContext();
                namePrefixComboBox.DataSource = headerTitleList;
                namePrefixComboBox.DisplayMember = "Value";
                

                lastNameComboBox.BindingContext = new BindingContext();
                firstNameComboBox.DataSource = headerTitleList;
                firstNameComboBox.DisplayMember = "Value";
                

                lastNameComboBox.BindingContext = new BindingContext();
                lastNameComboBox.DataSource = headerTitleList;
                lastNameComboBox.DisplayMember = "Value";
                

                emailComboBox.BindingContext = new BindingContext();
                emailComboBox.DataSource = headerTitleList;
                emailComboBox.DisplayMember = "Value";


                //TODO: Is this duplication of date of reply??

                dateCreatedComboBox.BindingContext = new BindingContext();
                dateCreatedComboBox.DataSource = headerTitleList;
                dateCreatedComboBox.DisplayMember = "Value";


                //This should be in the same order as SortList





                comboBoxAndLabelList.Add(new LabelAndBoxObject(uniComboBox, uniLabel, new List<string>() { "uni" }, "UNI"));
                comboBoxAndLabelList.Add(new LabelAndBoxObject(rsvpNoteComboBox, rsvpNoteLabel, new List<string>() { "rsvp", "note" }, "RSVP Note"));
                comboBoxAndLabelList.Add(new LabelAndBoxObject(dateOfReplyComboBox, dateOfReplyLabel, new List<string>() { "date", "reply" }, "Date of Reply"));
                comboBoxAndLabelList.Add(new LabelAndBoxObject(dietaryRestrictionsComboBox, dietaryRestrictionsLabel, new List<string>() { "dietary", "restrictions" }, "Dietary Restrictions"));
                comboBoxAndLabelList.Add(new LabelAndBoxObject(rsvpComboBox, rsvpLabel, new List<string>() { "rsvp" }, "RSVP"));
                comboBoxAndLabelList.Add(new LabelAndBoxObject(namePrefixComboBox, namePrefixLabel, new List<string>() { "prefix" }, "Name Prefix"));
                comboBoxAndLabelList.Add(new LabelAndBoxObject(firstNameComboBox, firstNameLabel, new List<string>() { "first" }, "First Name"));
                comboBoxAndLabelList.Add(new LabelAndBoxObject(lastNameComboBox, lastNameLabel, new List<string>() { "last" }, "Last Name"));
                comboBoxAndLabelList.Add(new LabelAndBoxObject(emailComboBox, emailLabel, new List<string>() { "email" }, "Email Address"));
                comboBoxAndLabelList.Add(new LabelAndBoxObject(dateCreatedComboBox, dateCreatedLabel, new List<string>() { "created" }, "Date Created"));
                comboBoxAndLabelList.Add(new LabelAndBoxObject(guestCountComboBox, guestCountLabel, new List<string>() { }, "Guest Count"));



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

                //loadScreen.Hide();
            }

        }
        private void loadExcelSheetButton_Click(object sender, EventArgs e)
        {
            


            loadExcelSheet();

        }

        private void WorkerMethod(object sender, Jacksonsoft.WaitWindowEventArgs e)
        {
            
            
            //if (e.Arguments.Count > 0)
            //{
            //    e.Result = e.Arguments[0].ToString();
            //}
            //else
            //{
            //    e.Result = "New sheet completed.";
            //}

            //if (InvokeRequired)
            //{
            //    Invoke((MethodInvoker)delegate { WorkerMethod(sender, e); });
            //    return;
            //}
            //// this code will run on main (UI) thread 
            //importAndExportSpreadSheet();

            
            int progress = 0;
            //	Do something
            while (progress < 100)
            {

                if (InvokeRequired)
                {
                    Invoke((MethodInvoker)delegate { WorkerMethod(sender, e); });
                    return;
                }
                // this code will run on main (UI) thread 
                importSpreadSheet();
                progress = 50;
                exportSpreadsheet();
                progress = 100;

                //	Update the wait window message
                e.Window.Message = string.Format("Please wait ... {0}%", progress.ToString().PadLeft(3));
            }

            //	Use the arguments sent in
            if (e.Arguments.Count > 0)
            {
                //	Set the result to return
                e.Result = e.Arguments[0].ToString();
            }
            else
            {
                //	Set the result to return
                e.Result = "New Sheet completed.";
            }
        }

    }
}
