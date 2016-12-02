using RADassignmentFour.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// Dollar computers for RAD assignment 4 
/// created by Ben Dunn 100098171
/// Date Decemeber 2, 2016 (final build)
/// 
/// notes on program page. 
namespace RADassignmentFour
{
    public partial class SelectionForm : Form
    {
        //field variables and default constructor
        Int32 _referenceIntRow = -1;
        private ProductModel _db;
        public SelectionForm()
        {

            InitializeComponent();
        }

        /// <summary>
        /// moves to the next form. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            ProductInfoForm productInfoForm = new ProductInfoForm(this);
            productInfoForm.Show(this);
            this.Hide();
        }


        /// <summary>
        /// Calls the program.endProgram() for exiting the program 
        /// through a single call from the highest level. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Event(object sender, EventArgs e)
        {
            Program.endProgram();
        }

        /// <summary>
        /// Upon load of this menu, sets the apropriate values to the apropriate areas. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);

        }


        /// <summary>
        /// moves the item into program memmorry after selection and updates the apropriate GUI components
        /// as needed. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _db = new ProductModel();
            _referenceIntRow = -1;

            //StudentsDataGridView.Rows[e.RowIndex].Cells[0].Value
            try
            {

                this.ProductDataGridView.SelectAll();
                _referenceIntRow = e.RowIndex+1;
                this.ProductDataGridView.CurrentCell = this.ProductDataGridView.Rows[e.RowIndex].Cells[0];
            }

            //dgvIcbSubsInfo.CurrentCell = dgvIcbSubsInfo.Rows[currentRow].Cells[0];
            //dataGridView.CurrentCell = dataGridView.Rows[dataGridView.NewRowIndex].Cells[0];


            catch (Exception ex) { MessageBox.Show(ex.ToString()); };
            Program.viewProduct = (product)(from products in _db.products
                                            where products.productID == _referenceIntRow
                                            select products).FirstOrDefault();
            //this.SELECTtextBox1.Text = _referenceIntRow.ToString(); Tester component

            //simple bool statement to prevent movement of the object 
            if (_referenceIntRow == -1)
            {
                this.TitleLabel.Text = "Dollar Computers HardWare List";
                this.NextButton.Enabled =false;
            }else
            {
                this.TitleLabel.Text = "Dollar Computers HardWare List: Hitting next will move to purchasing"; //why hide it?
                this.displayInfo(); //as requested, but in realitiy this would be better as inline code. 
                this.NextButton.Enabled = true;
            }

        }
        /// <summary>
        /// calls the dispose methods from the main program. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Program.endProgram();
        }

        private void displayInfo()
        {
            this.SelectionTextBox.Text = Program.viewProduct.model.ToString() + " Priced at: " + Program.viewProduct.cost.ToString();
        }
    }
}
