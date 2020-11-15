using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MainClass
{
    public class Perem
    {
        private int _key;
        public  int SetKey (int key)
        {
            _key = key;
            return _key;
        }

        public int GetKey (int key)
        {
            return _key;
        }
        
    }
}