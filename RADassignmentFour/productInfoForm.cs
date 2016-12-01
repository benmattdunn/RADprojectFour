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
    public partial class ProductInfoForm : Form
    {
        private SelectionForm _previousForm;
        /// <summary>
        /// Default constructor, will become a bin reference hand in rather then a 
        /// default in the future. Sets the selection form.
        /// </summary>
        public ProductInfoForm()
        {
            InitializeComponent();
            _previousForm = new SelectionForm();


        }


        /// <summary>
        /// Constructor that stores the previous form on creation. 
        /// </summary>
        /// <param name="selectionForm"></param>
        public ProductInfoForm(SelectionForm selectionForm)
        {
            this._previousForm = selectionForm;
            InitializeComponent();
        }



        private void NextButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm(this);
            orderForm.Show(); 
            this.Hide();
        }



        private void Back_Event(object sender, EventArgs e)
        {
            this._previousForm.Show();
            this.Dispose(); 
        }



        private void Exit_Event(object sender, EventArgs e)
        {
            Program.endProgram(); 
        }
    }
}
