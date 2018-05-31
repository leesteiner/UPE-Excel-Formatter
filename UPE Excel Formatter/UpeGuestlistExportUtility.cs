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

        #region Variables
        // For matching header data to fields
        private StringComparison comp = StringComparison.OrdinalIgnoreCase;

        //Excel COM Objects
        private Excel.Application oXL;
        private _Workbook oWB;
        private _Worksheet oSheet;
        private Range oRng;
        private Range titleRange;

        //Storage lists
        private List<CellObject> headerTitleList = new List<CellObject>();
        private List<RowObject> spreadsheetData = new List<RowObject>();
        private List<Tuple<int, string>> sortColumns = new List<Tuple<int, string>>();
        private List<Tuple<int,string>> neededColumns = new List<Tuple<int,string>>();
        private List<LabelAndBoxObject> comboBoxAndLabelList = new List<LabelAndBoxObject>();



        private String filename;

        private int sortColumnOne;
        private int sortColumnTwo;

        

        #endregion


        public UpeGuestListExportUtility()
        {

            InitializeComponent();

            #region Initialize dictionary, Bind sort boxes

            //Match fields to numbers. This order represents the final spreadsheet setup.
            //If changing order, 
            Dictionary<int, string> sortList = new Dictionary<int, string>()
            {
            {1, uniLabel.Text},
            {2, rsvpNoteLabel.Text},
            {3, dateOfReplyLabel.Text},
            {4, guestCountLabel.Text},
            {5, guestNameLabel.Text},
            {6, guestDietaryRestrictionsLabel.Text},
            {7, rsvpLabel.Text},
            {8, dietaryRestrictionsLabel.Text},
            {9, namePrefixLabel.Text},
            {10, firstNameLabel.Text },
            {11, lastNameLabel.Text},
            {12, emailLabel.Text},
            {13, nameSuffixLabel.Text},
            {14, addressOneLabel.Text},
            {15, addressTwoLabel.Text},
            {16, addressThreeLabel.Text},
            {17, cityLabel.Text},
            {18, stateLabel.Text},
            {19, postalLabel.Text},
            {20, countryLabel.Text},
            };

            //Bind Dictionary of key/value pairs to two sorting Comboboxes

            firstSortComboBox.BindingContext = new BindingContext();
            firstSortComboBox.ValueMember = "Key";
            firstSortComboBox.DisplayMember = "Value";
            firstSortComboBox.DataSource = new BindingSource(sortList, null);
            //7 matches LastName above minus 1, to account for 0 index on Lists
            firstSortComboBox.SelectedIndex = 10;

            secondSortComboBox.BindingContext = new BindingContext();
            secondSortComboBox.ValueMember = "Key";
            secondSortComboBox.DisplayMember = "Value";
            secondSortComboBox.DataSource = new BindingSource(sortList, null);
            //4 matches rsvpLabel above minus 1, to account for 0 index on Lists
            secondSortComboBox.SelectedIndex = 6;

            #endregion

        }

        void loadHeaders()
        {

            int totalColumns = 0;
            int totalRows = 0;


            #region Open Excel, get header data from first row, bind form to header data

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

                //For each column in Header (row 1), create cell object, pass in row 1, column num and value
                //Add cell to headerTitleList

                //TODO: Add more fields
                //TODO: Allow for input of final sheet
                for (int c = 1; c < totalColumns + 1; c++)
                {
                    string value;
                    if(oSheet.Cells[1,c].Value != null)
                    {
                        value = oSheet.Cells[1, c].Value.ToString();
                        CellObject cell = new CellObject(1, c, value);
                        headerTitleList.Add(cell);
                    }
                    else
                    {
                        value = "";
                    }
                    
                    
                }

                //Add last cell to headerTitleList for user option in case match can't be made later
                headerTitleList.Add(new CellObject(1, totalColumns + 2, "No match found."));

                //Cleanup, release ComObjects and Close Workbook

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

                bindFormElements();

                #endregion

                #region Match Headers to Form Element Selections

                //Iterate through ComboBoxes in Form
                foreach (LabelAndBoxObject l in comboBoxAndLabelList)
                {
                    //Set initial selected item to last in header list, which should be "No match found"
                    l.comboBox.SelectedItem = headerTitleList[headerTitleList.Count - 1];

                    bool stringMatched = false;


                    Tuple<byte, byte, byte> matchedColor = new Tuple<byte, byte, byte>(200, 200, 200);
                    Tuple<byte, byte, byte> unmatchedColor = new Tuple<byte, byte, byte>(255, 110, 110);

                    //Iterate through cells in HeaderTitle List
                    while (stringMatched == false)
                    {
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
                                    l.comboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(matchedColor.Item1)))), ((int)(((byte)(matchedColor.Item2)))), ((int)(((byte)(matchedColor.Item3)))));
                                    break;
                                }

                            }

                            //If there is only one string
                            else if (l.searchStrings.Count == 1)
                            {
                                if (cell.Value.ToString().Contains(l.searchStrings[0], comp) && stringMatched == false)
                                {
                                    l.comboBox.SelectedItem = cell;
                                    stringMatched = true;
                                    l.comboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(matchedColor.Item1)))), ((int)(((byte)(matchedColor.Item2)))), ((int)(((byte)(matchedColor.Item3)))));
                                    break;
                                }

                            }
                        }
                        if (stringMatched) { break; }
                        //If no match found, change color, exit loop
                        l.comboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(unmatchedColor.Item1)))), ((int)(((byte)(unmatchedColor.Item2)))), ((int)(((byte)(unmatchedColor.Item3)))));
                        break;
                    }



                }


                #endregion

            }

        }

        void importSpreadSheet()
        {

            #region set headers, open spreadsheet
            //Application already open.

            //Match column numbers and header titles to fields. Add to neededColumns list
            foreach (LabelAndBoxObject l in comboBoxAndLabelList)
            {
                if (l.radioInclude.Checked == true)
                {
                    neededColumns.Add(new Tuple<int, string>(l.comboBox.SelectedIndex + 1, l.name));
                }
                
            }

            //Open Workbook, set sheet to active sheet, 
            var oWBS = oXL.Workbooks;
            oWB = oWBS.Open(filename);
            oSheet = (Excel._Worksheet)oWB.ActiveSheet;
            oRng = (Excel.Range)oSheet.UsedRange;

            #endregion

            #region import body of spreadsheet into spreadsheetData

            //iterate through all non-header rows
            for (int r = 2; r < oRng.Rows.Count; r++)
            {
                //currentRow will hold row # and values
                RowObject currentRow = new RowObject();
                currentRow.RowNumber = r;

                //for each matched column, add cell data for this row
                foreach (Tuple<int, string> c in neededColumns)
                {

                    //TODO: Change this to compare against list<int> or 2 ints for speed?
                    //if column contains date, import to DateTime, then string
                    if (c.Item2.Contains("date", comp))
                    {
                        string cellString = "";

                        //Check for null value
                        if ((oSheet.Cells[r, c.Item1] as Range).Value2 != null)
                        {
                            cellString = (oSheet.Cells[r, c.Item1] as Range).Value2.ToString();
                            double date = double.Parse(cellString);
                            cellString = DateTime.FromOADate(date).ToString("MM/dd/yyyy");
                        }

                        //in case of null, add blank cell
                        else
                        {
                            cellString = "";
                        }

                        
                        //store location (r,c) and value in CellObject, add to row
                        CellObject cell = new CellObject(r, c.Item1, cellString);
                        currentRow.Cells.Add(cell);

                    }

                    //for all columns without a date, store location (r,c) and value in CellObject, add to row
                    else
                    {
                        string cellString = (string)(oSheet.Cells[r, c.Item1] as Range).Text;
                        CellObject cell = new CellObject(r, c.Item1, cellString);
                        currentRow.Cells.Add(cell);
                    }


                }

                //Add row to spreadsheet data model
                spreadsheetData.Add(currentRow);

            }

            #endregion

            //Cleanup, close Workbook
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            GC.WaitForPendingFinalizers();

            oWB.Close(Type.Missing, Type.Missing, Type.Missing);
            oWBS.Close();

        }

        void exportSpreadsheet()
        {
            #region open new book, export spreadsheetData
            //Open new workbook, hide
            var oWBS = oXL.Workbooks;
            oWB = oWBS.Add();
            oSheet = (Excel._Worksheet)oWB.ActiveSheet;
            oXL.Visible = false;


            //TODO BUG - below is where the sort issue is. Pass in different data.
            //Set initial sort columns in case of error with Dictionary import
            int sortColumn1 = 10;
            int sortColumn2 = 6;

            //Get user-defined columns by which to sort
            sortColumn1 = ((KeyValuePair<int, string>)firstSortComboBox.SelectedItem).Key;
            sortColumn2 = ((KeyValuePair<int, string>)secondSortComboBox.SelectedItem).Key;
           
            int column = 1;

            //Export header column
            foreach (Tuple<int, string> i in neededColumns)
            {
                oSheet.Cells[1, column++].Value = i.Item2;
            }

            //Export body of spreadsheet
            foreach (RowObject r in spreadsheetData)
            {
                int currentColumn = 1;
                foreach (CellObject c in r)
                {
                    oSheet.Cells[c.Row, currentColumn].Value = c.Value;
                    currentColumn++;
                }
            }

            #endregion

            #region Get all dimensions for initial formatting
            oRng = (Excel.Range)oSheet.UsedRange;
            int totalColumns = oRng.Columns.Count;
            int totalRows = oRng.Rows.Count;
            Excel.Range titleRangeStart = oSheet.Cells[1, 1];
            Excel.Range titleRangeEnd = oSheet.Cells[1, totalColumns];
            Excel.Range bodyRangeStart = oSheet.Cells[2, totalColumns];
            Excel.Range bodyRangeEnd = oSheet.Cells[totalRows, totalColumns];
            titleRange = (Excel.Range)oSheet.get_Range(titleRangeStart, titleRangeEnd);

            #endregion

            #region Formatting
            //TODO Print header at top of each page
            //TODO Finish commenting!

            //FORMAT DATA HERE

            //Font formatting
            oRng.Font.Name = "Garamond";
            oRng.Font.Size = 11;
            titleRange.Font.Size = 12;
            titleRange.Font.Bold = true;
            titleRange.Interior.Color = Excel.XlRgbColor.rgbLightBlue;


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

            //TODO: Make sure sort column is in NeededColumns
            //TODO: Bug - sorting by incorrect column, step through process with Column #'s
            //TODO: Graphics - align radio group box, boxes feel a little cramped, add Titles, background color for verified boxes is weird
            //TODO: Graphics - add more instructional text

            /*oRng.Sort(oRng.Columns[sortColumn2, Type.Missing], XlSortOrder.xlAscending,
                            oRng.Columns[sortColumn1, Type.Missing], Type.Missing, XlSortOrder.xlAscending,
                            Type.Missing, XlSortOrder.xlAscending,
                            Excel.XlYesNoGuess.xlGuess, Type.Missing, Type.Missing,
                            XlSortOrientation.xlSortColumns, Excel.XlSortMethod.xlPinYin,
                            XlSortDataOption.xlSortNormal,
                            XlSortDataOption.xlSortNormal,
                            XlSortDataOption.xlSortNormal
                            );
                            */

            //bodyRange.Sort(bodyRange.Columns[sortColumn2]);
            oRng.Activate();
            oRng.Application.ActiveWindow.SplitRow = 1;
            oRng.Application.ActiveWindow.FreezePanes = true;
            oRng.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            oRng.Borders.Color = Excel.XlRgbColor.rgbBlack;
            oRng.Borders.Weight = Excel.XlBorderWeight.xlThin;

            titleRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            titleRange.Borders.Color = Excel.XlRgbColor.rgbBlack;
            titleRange.Borders.Weight = Excel.XlBorderWeight.xlThin;

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
            //printSettings.PrintTitleRows = "$1:$1";
            

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
                Excel.Range thisCell;
                Excel.Range thisLastCell;
                Excel.Range thisRow;
                foreach (Tuple<int,string> t in rsvpRowsToInsert)
                {
                    thisCell = (Excel.Range)oSheet.Cells[t.Item1, 1];
                    oSheet.Rows[t.Item1].Insert();
                    thisCell = (Excel.Range)oSheet.Cells[t.Item1, 1];
                    thisLastCell = (Excel.Range)oSheet.Cells[t.Item1, totalColumns];
                    thisRow = (Excel.Range)oSheet.get_Range(thisCell, thisLastCell);
                    thisCell.Value = t.Item2;
                    oSheet.Range[thisCell, oSheet.Cells[t.Item1,totalColumns]].Merge();
                    thisCell.Style.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    thisRow.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    thisRow.Borders.Color = Excel.XlRgbColor.rgbBlack;
                    thisRow.Borders.Weight = Excel.XlBorderWeight.xlMedium;
                    thisRow.Font.Name = "Garamond";
                    thisRow.Interior.Color = Excel.XlRgbColor.rgbLightBlue;
                    thisRow.Font.Bold = true;
                    thisRow.Font.Size = 12;
                    thisRow = null;
                    
                }

                #endregion

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
            //TODO: Enable importing of merged rows (check for null value in Last Name column, discard entire row?



            oRng = (Excel.Range)oSheet.UsedRange;
            oRng.BorderAround2(XlLineStyle.xlContinuous, XlBorderWeight.xlMedium, XlColorIndex.xlColorIndexAutomatic, XlRgbColor.rgbBlack, Type.Missing);

            oRng.WrapText = true;
            oXL.Visible = true;

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            GC.WaitForPendingFinalizers();

            
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
            
        }

        
        private void continueButton_Click(object sender, EventArgs e)
        {


        }

        void bindFormElements()
        {
            #region Bind comboBoxes
            //Bind comboboxes to list of header values, combine with label, search string, and corresponding header for final export, add to list




            //TODO: Iterate through below... duh.
            
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


            guestNameComboBox.BindingContext = new BindingContext();
            guestNameComboBox.DataSource = headerTitleList;
            guestNameComboBox.DisplayMember = "Value";

            guestDietaryRestrictionsComboBox.BindingContext = new BindingContext();
            guestDietaryRestrictionsComboBox.DataSource = headerTitleList;
            guestDietaryRestrictionsComboBox.DisplayMember = "Value";

            rsvpComboBox.BindingContext = new BindingContext();
            rsvpComboBox.DataSource = headerTitleList;
            rsvpComboBox.DisplayMember = "Value";

            dietaryRestrictionsComboBox.BindingContext = new BindingContext();
            dietaryRestrictionsComboBox.DataSource = headerTitleList;
            dietaryRestrictionsComboBox.DisplayMember = "Value";

            namePrefixComboBox.BindingContext = new BindingContext();
            namePrefixComboBox.DataSource = headerTitleList;
            namePrefixComboBox.DisplayMember = "Value";

            firstNameComboBox.BindingContext = new BindingContext();
            firstNameComboBox.DataSource = headerTitleList;
            firstNameComboBox.DisplayMember = "Value";

            lastNameComboBox.BindingContext = new BindingContext();
            lastNameComboBox.DataSource = headerTitleList;
            lastNameComboBox.DisplayMember = "Value";

            emailComboBox.BindingContext = new BindingContext();
            emailComboBox.DataSource = headerTitleList;
            emailComboBox.DisplayMember = "Value";

            nameSuffixComboBox.BindingContext = new BindingContext();
            nameSuffixComboBox.DataSource = headerTitleList;
            nameSuffixComboBox.DisplayMember = "Value";
            //: Is this duplication of date of reply??

            addressOneComboBox.BindingContext = new BindingContext();
            addressOneComboBox.DataSource = headerTitleList;
            addressOneComboBox.DisplayMember = "Value";

            addressTwoComboBox.BindingContext = new BindingContext();
            addressTwoComboBox.DataSource = headerTitleList;
            addressTwoComboBox.DisplayMember = "Value";

            addressThreeComboBox.BindingContext = new BindingContext();
            addressThreeComboBox.DataSource = headerTitleList;
            addressThreeComboBox.DisplayMember = "Value";

            cityCombobox.BindingContext = new BindingContext();
            cityCombobox.DataSource = headerTitleList;
            cityCombobox.DisplayMember = "Value";

            stateComboBox.BindingContext = new BindingContext();
            stateComboBox.DataSource = headerTitleList;
            stateComboBox.DisplayMember = "Value";

            postalComboBox.BindingContext = new BindingContext();
            postalComboBox.DataSource = headerTitleList;
            postalComboBox.DisplayMember = "Value";

            countryComboBox.BindingContext = new BindingContext();
            countryComboBox.DataSource = headerTitleList;
            countryComboBox.DisplayMember = "Value";



            //{ 1, uniLabel.Text},
            //{ 2, rsvpNoteLabel.Text},
            //{ 3, dateOfReplyLabel.Text},
            //{ 4, guestCountLabel.Text},
            //{ 5, guestNameLabel.Text},
            //{ 6, guestDietaryRestrictionsLabel.Text},
            //{ 7, rsvpLabel.Text},
            //{ 8, dietaryRestrictionsLabel.Text},
            //{ 9, namePrefixLabel.Text},
            //{ 10, firstNameLabel.Text },
            //{ 11, lastNameLabel.Text},
            //{ 12, emailLabel.Text},
            //{ 13, nameSuffixLabel.Text},
            //{ 14, addressOneLabel.Text},
            //{ 15, addressTwoLabel.Text},
            //{ 16, addressThreeLabel.Text},
            //{ 17, cityLabel.Text},
            //{ 18, stateLabel.Text},
            //{ 19, postalLabel.Text},
            //{ 20, countryLabel.Text},



            //This should be in the same order as SortList 

            comboBoxAndLabelList.Add(new LabelAndBoxObject(uniComboBox, uniLabel, new List<string>() { "uni" }, "UNI"));
            comboBoxAndLabelList.Add(new LabelAndBoxObject(rsvpNoteComboBox, rsvpNoteLabel, new List<string>() { "rsvp", "note" }, "RSVP Note"));
            comboBoxAndLabelList.Add(new LabelAndBoxObject(dateOfReplyComboBox, dateOfReplyLabel, new List<string>() { "date", "reply" }, "Date of Reply"));
            comboBoxAndLabelList.Add(new LabelAndBoxObject(guestCountComboBox, guestCountLabel, new List<string>() { "guest", "count" }, "Guest Count"));
            comboBoxAndLabelList.Add(new LabelAndBoxObject(guestNameComboBox, guestNameLabel, new List<string>() { "guest", "name" }, "Guest Name"));
            comboBoxAndLabelList.Add(new LabelAndBoxObject(guestDietaryRestrictionsComboBox, guestDietaryRestrictionsLabel, new List<string>() { "guest", "dietary" }, "Guest Dietary Restrictions"));
            comboBoxAndLabelList.Add(new LabelAndBoxObject(rsvpComboBox, rsvpLabel, new List<string>() { "rsvp" }, "RSVP"));
            comboBoxAndLabelList.Add(new LabelAndBoxObject(dietaryRestrictionsComboBox, dietaryRestrictionsLabel, new List<string>() { "dietary", "restrictions" }, "Dietary Restrictions"));
            comboBoxAndLabelList.Add(new LabelAndBoxObject(namePrefixComboBox, namePrefixLabel, new List<string>() { "prefix" }, "Name Prefix"));
            comboBoxAndLabelList.Add(new LabelAndBoxObject(firstNameComboBox, firstNameLabel, new List<string>() { "first" }, "First Name"));
            comboBoxAndLabelList.Add(new LabelAndBoxObject(lastNameComboBox, lastNameLabel, new List<string>() { "last" }, "Last Name"));
            comboBoxAndLabelList.Add(new LabelAndBoxObject(emailComboBox, emailLabel, new List<string>() { "email" }, "Email Address"));
            comboBoxAndLabelList.Add(new LabelAndBoxObject(nameSuffixComboBox, nameSuffixLabel, new List<string>() { "suffix" }, "Name Suffix"));
            comboBoxAndLabelList.Add(new LabelAndBoxObject(addressOneComboBox, addressOneLabel, new List<string>() { "address", "one" }, "Address One"));
            comboBoxAndLabelList.Add(new LabelAndBoxObject(addressTwoComboBox, addressTwoLabel, new List<string>() { "address", "two" }, "Address Two"));
            comboBoxAndLabelList.Add(new LabelAndBoxObject(addressThreeComboBox, addressThreeLabel, new List<string>() { "address", "three" }, "Address Three"));
            comboBoxAndLabelList.Add(new LabelAndBoxObject(cityCombobox, cityLabel, new List<string>() { "city" }, "City"));
            comboBoxAndLabelList.Add(new LabelAndBoxObject(stateComboBox, stateLabel, new List<string>() { "state" }, "State"));
            comboBoxAndLabelList.Add(new LabelAndBoxObject(postalComboBox, postalLabel, new List<string>() { "postal" }, "Postal"));
            comboBoxAndLabelList.Add(new LabelAndBoxObject(countryComboBox, countryLabel, new List<string>() { "country" }, "Country"));


            #endregion

        }

        private void loadExcelSheetButton_Click(object sender, EventArgs e)
        {
            
            loadHeaders();

        }

        private void WorkerMethod(object sender, Jacksonsoft.WaitWindowEventArgs e)
        {
            
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
                //TODO: code below is not working correctly
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
                e.Result = "New sheet generated, click Ok to close utility.";
            }
        }

        private void fieldMatchPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var v = new HeaderConfirmation(comboBoxAndLabelList))
            {
                this.Visible = false;
                var result = v.ShowDialog();
                
                if (result == DialogResult.OK)
                {
                    comboBoxAndLabelList = v.returnComboBoxAndLabelList;
                    //Open new wait window with WorkerMethod
                    object res = Jacksonsoft.WaitWindow.Show(this.WorkerMethod, "Writing new excel sheet...");
                    //MessageBox.Show(result.ToString());
                    System.Windows.Forms.Application.Exit();
                }
                if (result == DialogResult.Cancel)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
        }

        private void onSelectionChange(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            cb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
        }
    }
}
