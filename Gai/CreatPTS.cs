﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gai
{
    public partial class CreatPTS : Form
    {
        public CreatPTS()
        {
            InitializeComponent();
        }

        private void пТСBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пТСBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databasegaiDataSet);

        }

        private void CreatPTS_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databasegaiDataSet.ПТС". При необходимости она может быть перемещена или удалена.
            this.пТСTableAdapter.Fill(this.databasegaiDataSet.ПТС);

        }
    }
}