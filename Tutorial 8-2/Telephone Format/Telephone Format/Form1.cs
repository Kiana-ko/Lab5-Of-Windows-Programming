using System;
using System.Windows.Forms;

namespace Telephone_Format
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The IsValidNumber method accepts a string and
        // returns true if it contains 10 digits, or false
        // otherwise.
        private bool IsValidNumber(string str)
        {
            const int VALID_LENGTH = 10;  // Length of a valid string
            bool validNumber = true;   // Flag to indicate validity

            if (str.Length != VALID_LENGTH)
            {
                validNumber = false;
            }
            else
            {
                // Check each character in str.
                for (int i = 0; i < str.Length; i++)
                {
                    // If this character is not a digit, the string is not valid.
                    int digitNumbers;
                    if (!int.TryParse(str[i].ToString(), out digitNumbers))
                    {
                        validNumber = false;
                        break;
                    }
                }
            }

            return validNumber;
        }


        // The TelephoneFormat method accepts a string argument
        // by reference and formats it as a telephone number.
        private void TelephoneFormat(ref string str)
        {
            // First, insert the left paren at position 0.
            str = str.Insert(0, "(");

            // Next, insert the right paren at position 4.
            str = str.Insert(4, ")");

            // Next, insert the hyphen at position 8.
            str = str.Insert(8, "-");
        }

        private void formatButton_Click(object sender, EventArgs e)
        {
            // Get a trimmed copy of the user's input.
            string input = numberTextBox.Text.Trim();

            // If the input is a valid number, format it
            // and display it.
            if (IsValidNumber(input))
            {
                TelephoneFormat(ref input);
                MessageBox.Show(input);
            }
            else
            {
                // Display an error message.
                MessageBox.Show("Invalid input");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
