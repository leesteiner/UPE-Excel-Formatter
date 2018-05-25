using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPE_Excel_Formatter
{
    public class CellObject
    {
        public int Column { get; set; }
        public int Row { get; set; }
        public string Value { get; set; }

        public CellObject()
        {

        }

        public CellObject(int row, int col, string v)
        {
            Column = col;
            Row = row;
            Value = v;
        }
    }
}
