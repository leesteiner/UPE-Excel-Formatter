using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPE_Excel_Formatter
{
    /// <summary>
    /// Contains a row number and list of cell objects (int Column, int Row, string Value)
    /// </summary>

    public class RowObject :IEnumerable
    {

        public int RowNumber { get; set; }
        private List<CellObject> cells = new List<CellObject>();
        public List<CellObject> Cells
        {
            get
            {
                return cells;
            }
            set
            {
                cells = value;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)Cells).GetEnumerator();
        }
    }
}
