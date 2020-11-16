using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gai
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databasegaiDataSet.Страховка". При необходимости она может быть перемещена или удалена.
            this.страховкаTableAdapter.Fill(this.databasegaiDataSet.Страховка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databasegaiDataSet.Стс". При необходимости она может быть перемещена или удалена.
            this.стсTableAdapter.Fill(this.databasegaiDataSet.Стс);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databasegaiDataSet.ПТС". При необходимости она может быть перемещена или удалена.
            this.пТСTableAdapter.Fill(this.databasegaiDataSet.ПТС);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databasegaiDataSet.Авто". При необходимости она может быть перемещена или удалена.
            this.автоTableAdapter.Fill(this.databasegaiDataSet.Авто);

        }

        private void автоBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.автоBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databasegaiDataSet);

        }
    }
}
