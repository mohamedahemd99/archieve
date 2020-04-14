using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace archive
{
    class Utils
    {
         public  void FillComoBox(ComboBox comboBox,string [] values)
        {
            comboBox.Items.Clear();
            comboBox.Items.AddRange(values);
            comboBox.SelectedIndex = 0;

        }
    }
}
