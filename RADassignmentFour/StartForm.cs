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
    public partial class StartForm : Form
    {
        /// <summary>
        /// init componsents. 
        /// </summary>
        public StartForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// exit event call
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Program.endProgram();
        }

        /// <summary>
        /// moves to the selection form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartNewOrderButton_Click(object sender, EventArgs e)
        {
            SelectionForm selectionForm = new SelectionForm();
            selectionForm.Show();
            this.Dispose(); 
        }



        /// <summary>
        /// Read event, if the bin file is loaded without error moves onto
        /// the next form. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenSavedOrderButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    MessageBox.Show(openFileDialog.FileName);
                    var ob = this.ReadFromBinaryFile<product>(openFileDialog.FileName);
                    Program.viewProduct = (product)ob; //attempt to cast, if it fails the file is either not one of mine, or incorrectly corrupt. 

                    ProductInfoForm productinfoform = new ProductInfoForm(Program.viewProduct);
                    productinfoform.Show();
                    this.Dispose();
                }
                catch (Exception ex) { MessageBox.Show("File is not formatted or is corrupt!"); }

            }

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
                //generic object read from binary source. Casting issue are expected if the
                //file is not related to the object. 
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }
    }
}
