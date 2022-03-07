﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zjf0525CMSApp
{
    public partial class JobDetailsForm : Form
    {
        public JobDetailsForm()
        {
            InitializeComponent();
        }

        private void txtCarNo_Leave(object sender, EventArgs e)
        {
            if((txtCarNo.Text=="")||(txtCarNo.Text== null)){
               
                MessageBox.Show("Please Specify a Valid Car Number");
                txtCarNo.Focus();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCarNo.Text.Length < 6)
                {
                    MessageBox.Show("Please Specify a Valid Car Number");
                    txtCarNo.Focus();
                    return;


                }
                if (Convert.ToInt32(txtWorkerId.Text) < 1)
                {
                    MessageBox.Show("Please Specify a Valid Car Number");

                    txtWorkerId.Focus();
                    return;
                }


                if (Convert.ToDateTime(dateTimePicker1.Text) > DateTime.Today)
                {
                    MessageBox.Show("Please Specify a Valid Car Number");
                    dateTimePicker1.Focus();
                    return;
                }
            }
            catch (Exception ex) {
                    MessageBox.Show(ex.Message);
            }
            }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
