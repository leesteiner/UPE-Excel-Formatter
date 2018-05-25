using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taramon.Exceller;
using Excel = Microsoft.Office.Interop.Excel;
using System.Collections;

namespace UPE_Excel_Formatter
{
    public partial class Form1 : Form
    {
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
                String filename = openFileDialog1.FileName;

                //em.Open(filename);
                //Start Excel and get Application object.

                oXL = new Excel.Application();
                oXL.Visible = true;
                oWB = oXL.Workbooks.Open(filename);
                oSheet = (Excel._Worksheet)oWB.ActiveSheet;
                oRng = (Excel.Range)oSheet.UsedRange;
                totalColumns = oRng.Columns.Count;
                totalRows = oRng.Rows.Count;
                //string[] headerTitles = new string[totalColumns+1];
                List<CellObject> headerTitleList = new List<CellObject>();
                List<CellObject> spreadsheetData = new List<CellObject>();
                //string[,] spreadsheetData = new string[totalRows,totalColumns];
                for (int c = 1; c < totalColumns; c++)
                {
                    string value = oSheet.Cells[1, c].Value.ToString();
                    CellObject cell = new CellObject(1, c, value);
                    //headerTitles[i] = oSheet.Cells[1, i].Value.ToString();
                    headerTitleList.Add(cell);
                }

                for (int r = 2 ; r < totalRows ; r++)
                {
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

                        
                        spreadsheetData.Add(cell);
                    }
                    
                }

                //for (int i = 1; i < totalRows; i++)
                //{
                //    for (int p = 1; p < totalColumns; p++)
                //    {
                        
                //        spreadsheetData[i, p] = oSheet.Cells[i, p].Value.ToString();
                //    }
                //}
                firstNameComboBox.DataSource = headerTitleList;
                firstNameComboBox.DisplayMember = "Value";


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
    }
}
