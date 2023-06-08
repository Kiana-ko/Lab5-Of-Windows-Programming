using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seating_Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayPriceButton_Click(object sender, EventArgs e)
        {
            // Variables for the selected row and column
            int row, col;
            
            // Constants for the maximum row and column subscripts
            const int MAX_ROW = 5;
            const int MAX_COL = 3;

            // Create an array with the seat prices.
            decimal[,] prices = { {450m, 450m, 450m, 450m},
                                  {425m, 425m, 425m, 425m},
                                  {400m, 400m, 400m, 400m},
                                  {375m, 375m, 375m, 375m},
                                  {375m, 375m, 375m, 375m},
                                  {350m, 350m, 350m, 350m}
                                };
            // TODO
            // Get the selected row number.
                // Get the selected column number.
                    // Make sure the row is within range.
                        // Make sure the column is within rnge.
                            // Display the selected seat's price.
                            // Error message for invalid column.
                        // Error message for invalid row.
                    // Display an error message for noninteger column.
                // Display an error message for noninteger row.
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
