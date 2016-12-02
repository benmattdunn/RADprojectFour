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
    public partial class OrderForm : Form
    {

        double _priceBefore = 0.0;
        double _salesTax = 0.00;
        double _TotalPrice = 0.00;

        private ProductInfoForm _previousForm; 

        /// <summary>
        /// default constructor, requires previous form. 
        /// </summary>
        /// <param name="productinfoform"></param>
        public OrderForm(ProductInfoForm productinfoform)
        {
            this._previousForm = productinfoform;
            InitializeComponent();
        }


        /// <summary>
        /// moves to the previous form. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void back_Event(object sender, EventArgs e)
        {
            this._previousForm.Show();
            this.Dispose(); 
        }

        /// <summary>
        /// exits the program and cancles the order. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Event(object sender, EventArgs e)
        {
            Program.endProgram(); 
        }



        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for placing an order with Dollar Computers \n \n"
                + "your order should arrive in 7-10 business days.");
        }

        
        /// <summary>
        /// On load, call the load display method. 
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_Load(object sender, EventArgs e)
        {
            this._loadDisplayValues(); 
        }


        /// <summary>
        /// loads the display values into memmorry and stores the actual calucalted values
        /// into the display. 
        /// </summary>
        private void _loadDisplayValues ()
        {
            //reset to make sure.
            _priceBefore = 0.0;

            if(!Double.TryParse(Program.viewProduct.cost.ToString(), out _priceBefore))
            {
                MessageBox.Show("something has gone with loading your order, please contact dollar computers!");
            }
            

            _salesTax = _priceBefore*0.13;
            _TotalPrice = _salesTax + _salesTax;

            // set calculcated values, as tey 
            this.PriceTextBox.Text = _priceBefore.ToString("c2");
            this.SalesTaxTextBox.Text = _salesTax.ToString("c2");
            this.TotalTextBox.Text = _TotalPrice.ToString("c2");




            this.ConditionTextBox.Text = Program.viewProduct.condition.ToString();
            this.ManufacturerTextBox.Text = Program.viewProduct.manufacturer.ToString();
            this.PlatFormTextBox.Text = Program.viewProduct.platform.ToString();
            this.ModelTextBox.Text = Program.viewProduct.model.ToString();
            // put the other information into the rich text box simply as a line by line string.
            // done this way to prevent errors in sizing should they occur.

            InfoRichTextBox.Text =
                "LCD SIZE: " + Program.viewProduct.screensize.ToString() + "\n" +
                "Memmory: " + Program.viewProduct.RAM_size.ToString() + "\n" +
                "CPU Brand: " + Program.viewProduct.CPU_brand.ToString() + "\n" +
                "CPU Type: " + Program.viewProduct.CPU_type.ToString() + "\n" +
                "CPU Number: " + Program.viewProduct.CPU_type.ToString() + "\n" +
                "GPU Speed: " + Program.viewProduct.CPU_speed.ToString() + "\n" +
                "GPU Type: " + Program.viewProduct.GPU_Type.ToString() + "\n" +
                "HDD: " + Program.viewProduct.HDD_size.ToString() + "\n" +
                "GPU Type: " + Program.viewProduct.GPU_Type.ToString() + "\n" +
                "WebCam: " + Program.viewProduct.webcam.ToString() + "\n" +
                "OS: " + Program.viewProduct.OS.ToString() + "\n";

            //sets the image text box, as it uses a short no conversion is nessicary. 

            this.ProductPictureBox.BackgroundImage = Program.computerImages[Program.viewProduct.productID-1];






        }
    }
}
