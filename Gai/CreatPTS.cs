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
    public partial class CreatPTS : Form
    {
        public CreatPTS()
        {
            InitializeComponent();
        }


        private void CreatPTS_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databasegaiDataSet.Категории". При необходимости она может быть перемещена или удалена.
            this.категорииTableAdapter.Fill(this.databasegaiDataSet.Категории);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databasegaiDataSet.Водители". При необходимости она может быть перемещена или удалена.
            this.водителиTableAdapter.Fill(this.databasegaiDataSet.Водители);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databasegaiDataSet.ПТС". При необходимости она может быть перемещена или удалена.
            this.пТСTableAdapter.Fill(this.databasegaiDataSet.ПТС);
            this.пТСBindingSource.AddNew();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vin vn = new Vin();
            Perem per = new Perem();
            if(номерПтсTextBox1.TextLength == 0) { MessageBox.Show("Введите номер ПТС");return; }
            if(серияПТСTextBox1.TextLength == 0) { MessageBox.Show("Введите серию ПТС");return; }
            this.пТСTableAdapter.NumberAndSeriesPTS(databasegaiDataSet.ПТС, Convert.ToInt32(номерПтсTextBox1.Text),Convert.ToInt32(серияПТСTextBox1.Text));
            if(this.databasegaiDataSet.ПТС.Rows.Count != 0)
            {
                MessageBox.Show("Птс с такой серией и номером уже существует");return;
            }
            if(dateTimePicker1.Value > DateTime.Now) { MessageBox.Show("Дата не может быть больше текущей"); return; }
            if ((dateTimePicker1.Value.Year - DateTime.Now.Year) < 14) { MessageBox.Show("Возраст не может быть меньше 14 лет");return; }
            if(адремTextBox.TextLength == 0) { MessageBox.Show("Введите адрес проживания");return; }
            if(особыеОтметкиTextBox.TextLength == 0 || таможенныеОграниченияTextBox.TextLength == 0) { MessageBox.Show("Особые отметки и таможенные ограничени не могут быть не заполненны, если они отсутсвуют введите 'Нет'");return; }
            if (!vn.CheckVin(vinTextBox.Text)) { MessageBox.Show("Длина вина 17 символов");return; }
            if(маркаTextBox.TextLength == 0) { MessageBox.Show("Введите марку");return; }
            if(наименованиеTextBox.TextLength == 0) { MessageBox.Show("Введите наименование (тип ТС)");return; }
            if(изготовительTextBox.TextLength == 0) { MessageBox.Show("Введите изготовителя ТС");return; }
            if(серияTextBox.TextLength == 0) { MessageBox.Show("Введите серию Авто");return; }
            if(номерTextBox.TextLength == 0) { MessageBox.Show("Введите Гос номер"); return; }
            if(!per.year(годИзготовленияTextBox.Text)) { return; }
            if(модель_НомерДвигателяTextBox.TextLength == 0) { MessageBox.Show("Введите Модель и номер двигателя"); return; }
            if(мощьностьДвигателяTextBox1.TextLength == 0) { MessageBox.Show("Введите Мощьность двигателя"); return; }
            if(объемДвигателяTextBox1.TextLength == 0) { MessageBox.Show("Введите объем двигателя"); return; }
            if(типДвигателяTextBox.TextLength == 0) { MessageBox.Show("Введите Тип двиателя"); return; }
            if(шассиTextBox.TextLength == 0) { MessageBox.Show("Введите номер шасси"); return; }
            if(кузовTextBox.TextLength == 0) { MessageBox.Show("Введите номер кузова"); return; }
            if(максимальнаяМассаTextBox.TextLength == 0) { MessageBox.Show("Введите максимальную массу"); return; }
            if(массаБезНагрузкиTextBox.TextLength == 0) { MessageBox.Show("Введите массу без нагрузки"); return; }
            try { Convert.ToInt32(мощьностьДвигателяTextBox1.Text); } catch { MessageBox.Show("Мощьность двигателя должна быть числом в ЛС"); return; }
            try { Convert.ToInt32(объемДвигателяTextBox1.Text); } catch { MessageBox.Show("Объем двигателя должен быть числом"); return; }
            try { Convert.ToInt32(максимальнаяМассаTextBox); } catch { MessageBox.Show("Максимальная масса должна быть числом"); return; }
            try { Convert.ToInt32(массаБезНагрузкиTextBox.Text); }catch { MessageBox.Show("Масса без нагрузки должна быть числом"); return; }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.пТСBindingSource.AddNew();
        }
    }
}
