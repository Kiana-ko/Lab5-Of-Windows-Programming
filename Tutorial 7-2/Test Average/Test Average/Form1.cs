using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The Average method accepts an int array argument
        // and returns the Average of the values in the array.
        private double Average(int[] iArray)
        {
            int total = 0;   
            double average;

            foreach (int value in iArray)
            {
                total = total + value;
            }

            double averageOutput = (double)total / iArray.Length;

            return averageOutput;

            // Step through the array, adding each element to
            // the accumulator. 
            // TODO

            // Calculate the average.
            // TODO

            // Return the average.
            // TODO
        }

        // The Highest method accepts an int array argument
        // and returns the highest value in that array.
       private int Highest(int[] iArray)
             
        {
            // Declare a variable to hold the highest value, and
            // initialize it with the first value in the array.
            // TODO

            // Step through the rest of the array, beginning at
            // element 1. When a value greater than highest is found,
            // assign that value to highest.
            for (int index = 1; index < iArray.Length; index++) ;
            // TODO

                // Return the highest value.
                // TODO
        }

        // The Lowest method accepts an int array argument
        // and returns the lowest value in that array.
        private int Lowest(int[] iArray)
        {
            // Declare a variable to hold the lowest value, and
            // initialize it with the first value in the array.
            // TODO

            int lowestValue = iArray[0];

            // Step through the rest of the array, beginning at
            // element 1. When a value less than lowest is found,
            // assign that value to lowest.
            // TODO

            foreach (int value in iArray)
            {
                if (value < lowestValue)
                {
                    lowestValue = value;
                }
            }

            // Return the lowest value.
            // TODO
            return lowestValue;
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Local variables
                const int SIZE = 5;            // Number of tests
                int[] scores = new int[SIZE];  // Array of test scores
                int index = 0;                 // Loop counter
                int highestScore;              // To hold the highest score
                int lowestScore;               // To hold the lowest score
                double averageScore;           // To hold the average score
                StreamReader inputFile;        // For file input

                // Open the file and get a StreamReader object.
                inputFile = File.OpenText("TestScores.txt");

                // Read the test scores into the array.
                while (!inputFile.EndOfStream && index < scores.Length)
                {
                    scores[index] = int.Parse(inputFile.ReadLine());
                    index++;
                }

                // Close the file.
                inputFile.Close();

                // Display the test scores.
                foreach (int value in scores)
                {
                    testScoresListBox.Items.Add(value);
                }

                // Get the highest, lowest, and average scores.
                highestScore = Highest(scores);
                lowestScore = Lowest(scores);
                averageScore = Average(scores);

                // Display the values.
                highScoreLabel.Text = highestScore.ToString();
                lowScoreLabel.Text = lowestScore.ToString();
                averageScoreLabel.Text = averageScore.ToString("n1");
            }
            catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}

