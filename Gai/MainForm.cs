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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databasegaiDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.databasegaiDataSet.Сотрудники);
            this.праваTableAdapter.Fill(this.databasegaiDataSet.Права);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databasegaiDataSet.Водители". При необходимости она может быть перемещена или удалена.
            this.водителиTableAdapter.Fill(this.databasegaiDataSet.Водители);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databasegaiDataSet.Страховка". При необходимости она может быть перемещена или удалена.
            this.страховкаTableAdapter.Fill(this.databasegaiDataSet.Страховка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databasegaiDataSet.Стс". При необходимости она может быть перемещена или удалена.
            this.стсTableAdapter.Fill(this.databasegaiDataSet.Стс);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databasegaiDataSet.ПТС". При необходимости она может быть перемещена или удалена.
            this.пТСTableAdapter.Fill(this.databasegaiDataSet.ПТС);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databasegaiDataSet.Авто". При необходимости она может быть перемещена или удалена.
            this.автоTableAdapter.Fill(this.databasegaiDataSet.Авто);
            LoginForm log = new LoginForm();
            log.ShowDialog();
            if (Perem.key == 1)
            {//1,2,3,11
                this.сотрудникиTableAdapter.LoginMainForm(databasegaiDataSet.Сотрудники, Perem.password, Perem.login);
                Label_FirstName.Text = Convert.ToString(databasegaiDataSet.Сотрудники[0][1]);
                Label_SecondName.Text = Convert.ToString(databasegaiDataSet.Сотрудники[0][2]);
                Label_Patronymic.Text = Convert.ToString(databasegaiDataSet.Сотрудники[0][3]);
                label_rank.Text = Convert.ToString(databasegaiDataSet.Сотрудники[0][11]);
            }
            else
            {
                Close();
            }
        }

        private void автоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl_Avto.Visible = true;
            tabControl_Drivers.Visible = false;
        }

        private void водителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl_Avto.Visible = false;
            tabControl_Drivers.Visible = true;
        }

        private void button_SearchFIO_Click(object sender, EventArgs e)
        {
            if (textBox_Surname.TextLength == 0) { MessageBox.Show("Введите фамилию"); return; }
            if (textBox_firstName.TextLength == 0) { MessageBox.Show("Введите имя"); return; }
            if (textBox_Patronymic.TextLength == 0) { MessageBox.Show("Введите отчество"); return; }
            this.водителиTableAdapter.Fio(databasegaiDataSet.Водители, textBox_Surname.Text, textBox_firstName.Text, textBox_Patronymic.Text);
        }

        private void button_Discharg_Click(object sender, EventArgs e)
        {
            this.водителиTableAdapter.Fill(this.databasegaiDataSet.Водители);
        }

        private void button_SuarchPass_Click(object sender, EventArgs e)
        {
            if (textBox_seriesPass.TextLength == 0) { MessageBox.Show("Введите серию паспорта"); return; }
            if (textBox_numberPass.TextLength == 0) { MessageBox.Show("Введите номер паспорта"); return; }
            this.водителиTableAdapter.Passport(databasegaiDataSet.Водители, Convert.ToInt32(textBox_seriesPass.Text), Convert.ToInt32(textBox_numberPass.Text));

        }

        private void button_Discharge_Click(object sender, EventArgs e)
        {
            this.праваTableAdapter.Fill(this.databasegaiDataSet.Права);
        }

        private void button_SerchVin_Click(object sender, EventArgs e)
        {
            this.автоTableAdapter.SerchVin(databasegaiDataSet.Авто, textBox_Vin.Text);
        }

        private void button_CleraVIN_Click(object sender, EventArgs e)
        {
            this.автоTableAdapter.Fill(this.databasegaiDataSet.Авто);
        }

        private void button_SerchStax_Click(object sender, EventArgs e)
        {
            this.автоTableAdapter.SerchStrax(databasegaiDataSet.Авто, Convert.ToInt32(textBox_NumberStrax.Text));
        }

        private void button_ClearStrax_Click(object sender, EventArgs e)
        {
            this.автоTableAdapter.Fill(this.databasegaiDataSet.Авто);
        }

        private void button_SerchPTSVin_Click(object sender, EventArgs e)
        {
            if (textBox_VinNumberPTS.TextLength == 0) { MessageBox.Show("Введите вин"); return; }
            this.пТСTableAdapter.VinPTS(databasegaiDataSet.ПТС, textBox_VinNumberPTS.Text);
        }

        private void button_ClearPTS_Click(object sender, EventArgs e)
        {
            this.пТСTableAdapter.Fill(this.databasegaiDataSet.ПТС);
        }

        private void button_SerchPTSseriesAndNumber_Click(object sender, EventArgs e)
        {
            if (textBox_NumberPTS.TextLength == 0) { MessageBox.Show("Введите номер птс"); return; }
            if (textBox_SeriesPTS.TextLength == 0) { MessageBox.Show("Введите серию птс"); return; }
            try
            {
                пТСTableAdapter.NumberAndSeriesPTS(databasegaiDataSet.ПТС, Convert.ToInt32(textBox_NumberPTS.Text), Convert.ToInt32(textBox_SeriesPTS.Text));
            }
            catch { MessageBox.Show("Серия и номер ПТС должны быть в цифровой форме"); return; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.пТСTableAdapter.Fill(this.databasegaiDataSet.ПТС);
        }

        private void button_SerchSTSVin_Click(object sender, EventArgs e)
        {
            if (textBox_VinSTS.TextLength == 0) { MessageBox.Show("Введите вин"); return; }
            стсTableAdapter.Vin(databasegaiDataSet.Стс, textBox_VinSTS.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.стсTableAdapter.Fill(this.databasegaiDataSet.Стс);
        }

        private void button_SerchSTSRegZnak_Click(object sender, EventArgs e)
        {
            if (textBox_RegZnak.TextLength == 0) { MessageBox.Show("Введите регистрационный знак"); return; }
            стсTableAdapter.RegistrZnak(databasegaiDataSet.Стс, textBox_RegZnak.Text);
        }

        private void button_clearSTS_Click(object sender, EventArgs e)
        {
            this.стсTableAdapter.Fill(this.databasegaiDataSet.Стс);
        }

        private void button_SerchStraxVin_Click(object sender, EventArgs e)
        {
            if (textBox_VinStrax.TextLength == 0) { MessageBox.Show("Введите вин"); return; }
            this.страховкаTableAdapter.VinStrax(databasegaiDataSet.Страховка, textBox_VinStrax.Text);
        }

        private void button_ClearStraxVin_Click(object sender, EventArgs e)
        {
            this.страховкаTableAdapter.Fill(this.databasegaiDataSet.Страховка);
        }

        private void button_SerchStrax_Click(object sender, EventArgs e)
        {
            if (textBox_seriesPTSSTRAX.TextLength == 0) { MessageBox.Show("Введите серию"); return; }
            if (textBox_NumberPTSStrax.TextLength == 0) { MessageBox.Show("Введите номер"); return; }
            try
            {
                страховкаTableAdapter.SeriesAndNumberStrax(databasegaiDataSet.Страховка, Convert.ToInt32(textBox_seriesPTSSTRAX.Text), Convert.ToInt32(textBox_NumberPTSStrax.Text));
            }
            catch { MessageBox.Show("Серия и номер должны быть цифровыми"); return; }
        }

        private void button_ClearStrax1_Click(object sender, EventArgs e)
        {
            this.страховкаTableAdapter.Fill(this.databasegaiDataSet.Страховка);
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            if (tabControl_Avto.Visible == true)
            {
                string ss = Convert.ToString(tabControl_Avto.SelectedTab.Text);
                MessageBox.Show(ss);
                switch (ss)
                {
                    case "Авто":

                        break;
                    case "ПТС":

                        break;
                    case "СТС":

                        break;
                    case "Страховка":

                        break;
                    default:
                        MessageBox.Show("Такого нету");
                        break;

                }
            }
            else
            {

            }
        }
    }
}
