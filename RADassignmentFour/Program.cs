using RADassignmentFour.Models;
using RADassignmentFour.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Dollar computers for RAD assignment 4 
/// created by Ben Dunn 100098171
/// Date Decemeber 2, 2016 (final build)
/// 
/// 
/// 
/// Notes:
/// 
/// Nothing special about this one other then I used a binary file writer rather then 
/// a text file writer for the save/load function. The reason for this is security as 
/// the being defined by a bin prevents the user from 'editing' the file. Ideally 
/// if I was programming this for another aplication in which security would be an issue
/// I would encode the bin with a server side hash tag to unpack it during the user 
/// session (as this is an online program). I already used a file load from text in
/// assignment 1 for the language file (thus I know how to do it easily) and figured
/// this would be an ideal replacement and improvement of the code. In addition
/// it allows me to serialize the objects directly which is far more useful then a text
/// based file reference (such as a JSON). (basically gaming wise, I could create a 
/// class and define objects in an editor rather then through the program and then
/// load these objects in as bin files into the program... Skyrim editor in a nutshell.
/// 
/// also because of the [serializable], [nonserializable] property I can further hide
/// information if need be.
/// 
/// </summary>
namespace RADassignmentFour
{
    static class Program
    {
        //field variables for ease of use. 
        public static List<Image> computerImages;
        public static product viewProduct;  
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            computerImages = new List<Image>(); //while I could just add them, I prefer the method  incase I make mistakes. 
            _addImages();
            viewProduct = new product(); 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreen());
        }

        /// <summary>
        /// main method for aplicaition exit, 
        /// as I have no threads set up in this program
        /// and made it indestuctable through hard coding
        /// its a simple call from the top most level. 
        /// </summary>
        public static void endProgram()
        {
            Application.Exit(); 
        }

        /// <summary>
        /// A super lazy way of getting the computer images into the program
        /// reliable however. 
        /// </summary>
        private static void _addImages()
        {
            computerImages.Add(new Bitmap((Bitmap)Resources._1));
            computerImages.Add(new Bitmap((Bitmap)Resources._2));
            computerImages.Add(new Bitmap((Bitmap)Resources._3));
            computerImages.Add(new Bitmap((Bitmap)Resources._4));
            computerImages.Add(new Bitmap((Bitmap)Resources._5));
            computerImages.Add(new Bitmap((Bitmap)Resources._6));
            computerImages.Add(new Bitmap((Bitmap)Resources._7));
            computerImages.Add(new Bitmap((Bitmap)Resources._8));
            computerImages.Add(new Bitmap((Bitmap)Resources._9));
            computerImages.Add(new Bitmap((Bitmap)Resources._10));
            computerImages.Add(new Bitmap((Bitmap)Resources._11));
            computerImages.Add(new Bitmap((Bitmap)Resources._12));
            computerImages.Add(new Bitmap((Bitmap)Resources._13));
            computerImages.Add(new Bitmap((Bitmap)Resources._14));
            computerImages.Add(new Bitmap((Bitmap)Resources._15));
            computerImages.Add(new Bitmap((Bitmap)Resources._16));
            computerImages.Add(new Bitmap((Bitmap)Resources._17));
            computerImages.Add(new Bitmap((Bitmap)Resources._18));
            computerImages.Add(new Bitmap((Bitmap)Resources._19));
            computerImages.Add(new Bitmap((Bitmap)Resources._20));
            computerImages.Add(new Bitmap((Bitmap)Resources._21));
            computerImages.Add(new Bitmap((Bitmap)Resources._22));
        }
    }
}
