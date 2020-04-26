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
