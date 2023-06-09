﻿using System;
using System.Windows.Forms;

namespace Password_Validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The NumberUpperCase method accepts a string argument
        // and returns the number of uppercase letters it contains.
        private int NumberUpperCase(string str)
        {
            int upperCaseLettersCount = 0;
            foreach (char letter in str)
            {
                if (char.IsUpper(letter)) 
                {
                    upperCaseLettersCount++;
                }
            }
            return upperCaseLettersCount;
        }

        // The NumberLowerCase method accepts a string argument
        // and returns the number of lowercase letters it contains.
        private int NumberLowerCase(string str)
        {
            int lowerCaseLettersCount = 0;
            foreach (char letter in str)
            {
                if (char.IsLower(letter))
                {
                    lowerCaseLettersCount++;
                }
            }
            return lowerCaseLettersCount;
        }

        // The NumberDigits method accepts a string argument
        // and returns the number of numeric digits it contains.
        private int NumberDigits(string str)
        {
            int digitsCount = 0;
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    digitsCount++;
                }
            }
            return digitsCount;
        }

        private void checkPasswordButton_Click(object sender, EventArgs e)
        {
            const int MIN_LENGTH = 8;  // Password's minimum length

            // Get the password from the TextBox.
            string password = passwordTextBox.Text;

            // Validate the password.
            if (password.Length >= MIN_LENGTH &&
                NumberUpperCase(password) >= 1 &&
                NumberLowerCase(password) >= 1 &&
                NumberDigits(password) >= 1)
            {
                MessageBox.Show("The password is valid.");
            }
            else
            {
                MessageBox.Show("The password does not meet the requirements.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
