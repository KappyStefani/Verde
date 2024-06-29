using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verde.Classes.Auxiliar
{
    internal class FuncGeral
    {
        private void PopulaListView(ListView listview, string nome, string presente)
        {
            ListViewItem item = new ListViewItem(new[] { nome, presente });
            listview.Items.Add(item);
        }

    }
}
