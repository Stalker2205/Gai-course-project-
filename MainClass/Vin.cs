using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainLibra
{
    public class Vin
    {
        private string _vin;
        public bool CheckVin(string vin)
        {
            if( vin.Length == 17 )
            {
                _vin = vin;
                return true;
            }
            else
            {
                MessageBox.Show("Вин должен быть длинной 17 символов");
                return false;
            }
        }
    }
}
