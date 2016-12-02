using RADassignmentFour;
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
    public partial class SplashScreen : Form
    {
        /// <summary>
        /// int components. 
        /// </summary>
        public SplashScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// timer event, calls after 3 seconds to boot up the rest of the 
        /// program, disposes of the timer and hides the splash screen (does not
        /// dispose) as it's the main entry point reference. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            startForm.Show();
            this.Hide();
            //this.Dispose(); cannot dispose as it's the reference to the program (app run), always
            //forget this. 
            timer1.Stop();
            timer1.Dispose(); 
        }
    }
}
