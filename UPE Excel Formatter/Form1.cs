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


            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel or CSV Files|*.xls;*.xlsx;*.xlsm;*.csv";
            openFileDialog1.Title = "Select an Excel file";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String filename = openFileDialog1.FileName;


                //Start Excel and get Application object.
                using (ExcelManager em = new ExcelManager())
                {
                    em.Open(filename);
                    List<RowObject> allRows = new List<RowObject>();
                    //Change column count!
                    int columnCount = 20;
                    int rowCount = 40;
                    for (int i=0;i<rowCount;i++)
                    {
                        RowObject currentRow = new RowObject();
                        ArrayList rowArray = new ArrayList();
                        rowArray = em.GetRangeFormattedValues($"A{i}", $"AZ{i}");
                    }
                }

                

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
