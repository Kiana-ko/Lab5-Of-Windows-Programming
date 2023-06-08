using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lottery_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            // Create an array to hold the numbers.
            int Min = 0;
            int Max = 7;
            int[] numberContainer = new int[7];

            // TODO


            // Create a Random object.
            // TODO

            Random randomNumbers = new Random();

            // Fill the array with random numbers, in the range
            // of 0 through 99.
            // TODO
            foreach (int number in numberContainer) {
                int arrayLength = numberContainer.Length;
                Console.WriteLine( arrayLength + Min + Max );
            }


            

            // Display the array elements in the Label controls.
            // TODO
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
