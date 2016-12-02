using RADassignmentFour.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
    public partial class ProductInfoForm : Form
    {
        ///field variables. 
        private SelectionForm _previousForm;
        /// <summary>
        /// passing in the product just forces this constuctor to creat the
        /// prior form dunamically, doesn't actually pass through the 
        /// 
        /// </summary>
        /// <param name="prod"></param>
        public ProductInfoForm(product prod)
        {
            InitializeComponent();
            _previousForm = new SelectionForm();
            loadIntoForm(Program.viewProduct);
        }


        /// <summary>
        /// Constructor that stores the previous form on creation. 
        /// </summary>
        /// <param name="selectionForm"></param>
        public ProductInfoForm(SelectionForm selectionForm)
        {
            this._previousForm = selectionForm;
            InitializeComponent();
            loadIntoForm(Program.viewProduct);
        }


        /// <summary>
        /// brings up the next form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm(this);
            orderForm.Show();
            this.Hide();
        }


        /// <summary>
        /// brings the previous form back into display. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Back_Event(object sender, EventArgs e)
        {
            this._previousForm.Show();
            this.Dispose();
        }


        /// <summary>
        /// calls the exit event. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Event(object sender, EventArgs e)
        {
            Program.endProgram();
        }


        /// <summary>
        /// on load, move the static values of the program object into the values of
        /// the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            loadIntoForm(Program.viewProduct);
        }

        /// <summary>
        /// actually does the real load, 
        /// </summary>
        /// <param name="prod"></param>
        private void loadIntoForm(product prod)
        {
            this.ProductIDTextBox.Text = Program.viewProduct.productID.ToString();
            this.ConditionTextBox.Text = Program.viewProduct.condition.ToString();
            this.CostTextBox.Text = Program.viewProduct.cost.ToString();

            this.PlatformTextBox.Text = Program.viewProduct.platform.ToString();
            this.OSTextBox.Text = Program.viewProduct.OS.ToString();
            this.ManufacturerTextBox.Text = Program.viewProduct.manufacturer.ToString();
            this.ModelTextBox.Text = Program.viewProduct.model.ToString();

            this.MemoryTextBox.Text = Program.viewProduct.RAM_size.ToString();
            this.CPUBrandtextBox.Text = Program.viewProduct.CPU_brand.ToString();
            this.CPUTypeTextBox.Text = Program.viewProduct.CPU_type.ToString();


            this.LCDSizeTextBox.Text = Program.viewProduct.displaytype.ToString();
            this.CPUNumberTextBox.Text = Program.viewProduct.CPU_number.ToString();
            this.CPUSpeedTextBox.Text = Program.viewProduct.CPU_speed.ToString();

            this.HDDTextBox.Text = Program.viewProduct.HDD_size.ToString();
            this.GPUTypeTextBox.Text = Program.viewProduct.GPU_Type.ToString();
            this.WebCamTextBox.Text = Program.viewProduct.webcam.ToString();
        }


        /// <summary>
        /// read a binary file from a source
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public T ReadFromBinaryFile<T>(string filePath)
        {
            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }


        /// <summary>
        /// Read event, included in lower section due to code level.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    MessageBox.Show(openFileDialog.FileName);
                    var ob = this.ReadFromBinaryFile<product>(openFileDialog.FileName);
                    Program.viewProduct = (product)ob; //attempt to cast, if it fails the file is either not one of mine, or incorrectly corrupt. 
                    this.loadIntoForm(Program.viewProduct); 
                }
                catch (Exception ex) { MessageBox.Show("File is not formatted or is corrupt!"); }
                
            }




        }


        /// <summary>
        /// Typical bin write method. 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filePath"></param>
        /// <param name="objectToWrite"></param>
        /// <param name="append"></param>
        public void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
        {
            using (Stream stream = 
                File.Open(filePath, append ? FileMode.Append : FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }

        /// <summary>
        /// save event, writes to a bin file for security. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            //string sfdname = saveFileDialog.FileName;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(saveFileDialog.FileName);
                this.WriteToBinaryFile<product>(saveFileDialog.FileName, Program.viewProduct, false);
            }
            /*
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
           
            */
        }
    }
}

