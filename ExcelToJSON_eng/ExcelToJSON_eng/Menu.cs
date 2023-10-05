using ExcelToJSON_eng;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KsaweryAPP
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void openExcelToJSONpl_Click(object sender, EventArgs e)
        {
            ExcelToJSONpl secondForm = new();
            secondForm.ShowDialog();
        }

        private void openExcelToJSONeng_Click(object sender, EventArgs e)
        {
            ExcelToJSONeng secondForm = new();
            secondForm.ShowDialog();
        }
    }
}
