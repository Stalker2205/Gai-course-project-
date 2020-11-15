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
                Perem.keyz = 0;
            }
            else
            {
                Perem.keyz = 1;
            }
            label_pattempt.Text = "Количество попыток входа : " + pattempt;
        }
    }
}
