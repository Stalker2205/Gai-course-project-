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
        public bool CheckVin (string strok)
        {
            return strok.Length == 17 ;
        }
    }
}
