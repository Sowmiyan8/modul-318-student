using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Ext
{
    static class Extentions
    {
        public static void SafeClearItems(this ComboBox comboBox)
        {
            foreach (var item in new ArrayList(comboBox.Items))
            {
                comboBox.Items.Remove(item);
            }
        }
    }
}
