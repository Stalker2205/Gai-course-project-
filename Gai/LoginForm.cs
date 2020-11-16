using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MainLibra;

namespace Gai
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        int pattempt;
        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                pattempt = Convert.ToInt32(File.ReadAllText("Pattemp.txt"));
            }
            catch { MessageBox.Show("Верните файл"); Close(); }

            this.сотрудникиTableAdapter.Fill(this.databasegaiDataSet.Сотрудники);
            // string sq = File.ReadAllText("Time.txt");
            if (File.Exists("Time.txt") == false && File.Exists("Pattemp.txt") == false)
            {
                Perem.key = 0;
            }
            else
            {
                Perem.key = 1;
            }
            label_pattempt.Text = "Количество попыток входа : " + pattempt;
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (Perem.key == 0)
            {
                MessageBox.Show("Верните файл на место");
                Close();
            }
            else
            {
            ykazat:
                if (pattempt == 0)
                {
                    string file = File.ReadAllText("Time.txt");
                    DateTime DateFile = Convert.ToDateTime(file);
                    int minuteFile = DateFile.Minute;
                    DateTime DateNow = DateTime.Now;
                    if ((minuteFile + 3) < DateNow.Minute)
                    {
                        pattempt = 3; label_pattempt.Text = "Количество попыток входа : " + pattempt; File.WriteAllText("Pattemp.txt", Convert.ToString(pattempt)); goto ykazat;
                    }
                    else { MessageBox.Show("подождите " + ((minuteFile + 3) - minuteFile) + " минут"); return; }
                }
                else
                {
                    int kol = 0;
                    if (Label_Logins.TextLength == 0) { MessageBox.Show("Введите логин"); return; }
                    if (Label_Password.TextLength == 0) { MessageBox.Show("Введите пароль"); return; }
                    сотрудникиTableAdapter.Login(databasegaiDataSet.Сотрудники, Label_Logins.Text, Label_Password.Text);
                    kol = databasegaiDataSet.Сотрудники.Rows.Count;
                    if (kol == 1)
                    {
                        Perem.KeyForm = 1;
                        Perem.login = Label_Logins.Text;
                        Perem.password = Label_Password.Text;
                        pattempt = 3;
                        File.WriteAllText("Pattemp.txt", Convert.ToString(pattempt));
                        Close();
                    }
                    else
                    {
                        Perem.KeyForm = 0;
                        MessageBox.Show("Такой комбинации логина и пароля не существует");
                        pattempt--;
                        label_pattempt.Text = "Количество попыток входа : " + pattempt; File.WriteAllText("Pattemp.txt", Convert.ToString(pattempt));
                        if (pattempt == 0) { File.WriteAllText("Time.txt", Convert.ToString(DateTime.Now)); File.WriteAllText("Pattemp.txt", Convert.ToString(pattempt)); }

                    }
                }

            }
        }
    }
}
