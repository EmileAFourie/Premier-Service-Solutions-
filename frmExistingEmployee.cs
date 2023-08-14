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
    public partial class frmExistingEmployee : Form
    {
        public frmExistingEmployee()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool found = true;
            string employeeeID = txtbxEmployeeID.Text;

            if (!found)
            {
                MessageBox.Show("Employee could not be found.");
            }
            else
            {
                frmExistingEmployeeDetails frmDetails = new frmExistingEmployeeDetails();
                frmDetails.ShowDialog();
            }
        }
    }
}
