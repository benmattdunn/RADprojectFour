﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RADassignmentFour
{
    public partial class OrderForm : Form
    {
        private ProductInfoForm _previousForm; 
        public OrderForm(ProductInfoForm productinfoform)
        {
            this._previousForm = productinfoform;
            InitializeComponent();
        }


        /// Shared events ///


        private void back_Event(object sender, EventArgs e)
        {
            this._previousForm.Show();
            this.Dispose(); 
        }

        private void Exit_Event(object sender, EventArgs e)
        {
            Program.endProgram(); 
        }



        private void FinishButton_Click(object sender, EventArgs e)
        {

        }


    }
}
