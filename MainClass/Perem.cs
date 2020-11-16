using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MainLibra
{
    public class Perem
    {
        public static int key;
        public static string login;
        public static string password;
        public static int KeyForm;
        public bool year(string year)
        {
            try
            {
              Convert.ToInt32(year);
            }
            catch { MessageBox.Show("год должен быть числом");return false; }
            if( year.Length != 4)
            {
                MessageBox.Show("Год состоит из 4-х цифр");return false;
            }
            else
            {
                return true;
            }
        }

    }
}