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
using MainClass;

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
            Perem per = new Perem();
            try
            {
                pattempt = Convert.ToInt32(File.ReadAllText("Pattemp.txt"));
            }
            catch { MessageBox.Show("Верните файл"); Close(); }

            this.сотрудникиTableAdapter.Fill(this.databasegaiDataSet.Сотрудники);
            // string sq = File.ReadAllText("Time.txt");
            if (File.Exists("Time.txt") == false && File.Exists("Pattemp.txt") == false)
            {
                per.SetKey(0);
            }
            else
            {
                per.SetKey(1);
            }
            label_pattempt.Text = "Количество попыток входа : " + pattempt;
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {

        }
    }
}
