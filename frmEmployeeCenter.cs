﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Premier_Service_Solutions
{
    public partial class frmEmployeeCenter : Form
    {
        public frmEmployeeCenter()
        {
            InitializeComponent();
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            frmExistingEmployee existingEmployeeForm = new frmExistingEmployee();
            this.Close();
            existingEmployeeForm.Show();
        }
    }
}
