using System;
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
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {

            InitializeComponent();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            ProductInfoForm productInfoForm = new ProductInfoForm(this);
            productInfoForm.Show(this);
            this.Hide();
        }


        private void Exit_Event(object sender, EventArgs e)
        {
            Program.endProgram();
        }
    }
}
