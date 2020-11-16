using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainLibra;

namespace Gai
{
    public partial class CreatAvto : Form
    {
        public CreatAvto()
        {
            InitializeComponent();
        }

        private void CreatAvto_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databasegaiDataSet.Стс". При необходимости она может быть перемещена или удалена.
            this.стсTableAdapter.Fill(this.databasegaiDataSet.Стс);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databasegaiDataSet.Страховка". При необходимости она может быть перемещена или удалена.
            this.страховкаTableAdapter.Fill(this.databasegaiDataSet.Страховка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databasegaiDataSet.ПТС". При необходимости она может быть перемещена или удалена.
            this.пТСTableAdapter.Fill(this.databasegaiDataSet.ПТС);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databasegaiDataSet.Водители". При необходимости она может быть перемещена или удалена.
            this.водителиTableAdapter.Fill(this.databasegaiDataSet.Водители);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databasegaiDataSet.Авто". При необходимости она может быть перемещена или удалена.
            this.автоTableAdapter.Fill(this.databasegaiDataSet.Авто);
            this.автоBindingSource.AddNew();

        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            Vin vn = new Vin();
            Perem per = new Perem();
            if(vinTextBox.TextLength == 0) { MessageBox.Show("Введите вин");return; }
            vn.CheckVin(vinTextBox.Text);
            if(modelTextBox.TextLength == 0) { MessageBox.Show("Введите модель");return; }
            if(yearTextBox.TextLength == 0) { MessageBox.Show("Введите год");return; }
            if(per.year(yearTextBox.Text) == false) { return; }
            if(vinTextBox.Text == comboBox_PTS.Text &&vinTextBox.Text== comboBox_Sts.Text && vinTextBox.Text == comboBox_Sts.Text)
            {
                this.автоTableAdapter.InsertAvto(comboBox_Vlad.SelectedIndex, vinTextBox.Text, modelTextBox.Text,Convert.ToInt32( yearTextBox.Text), comboBox_PTS.SelectedIndex, comboBox_STrax.SelectedIndex, comboBox_Sts.SelectedIndex);
                Close();
            }
            else
            {
                MessageBox.Show("Вин в СТС, страховке, ПТС должны быть одинаковые");return;
            }
        }
    }
}
