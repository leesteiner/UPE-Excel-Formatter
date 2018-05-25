using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPE_Excel_Formatter
{
    public class LabelAndBoxObject
    {
        public ComboBox comboBox { get; set; }
        public Label label { get; set; }
        public List<string> searchStrings { get; set; } = new List<string>();
        public string name { get; set; }

        public LabelAndBoxObject()
        {

        }
        public LabelAndBoxObject(ComboBox c, Label l, List<string> searchList, string n)
        {
            comboBox = c;
            label = l;
            searchStrings = searchList;
            name = n;
        }
    }
}
