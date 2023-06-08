using System;
using System.Windows.Forms;

namespace Random_Card
{
    public partial class Form1 : Form
    {
        private class Card
        {
            public string Value { get; set; }
            public string Suit { get; set; }
        }

        private Card[] cardArray;

        public Form1()
        {
            InitializeComponent();
            InitializeCardArray();
        }

        private void InitializeCardArray()
        {
            // Populate the cardArray with card objects
            cardArray = new Card[]
            {
                new Card { Value = "Ace", Suit = "Hearts" },
                new Card { Value = "2", Suit = "Hearts" },
                // Add more card objects as needed
            };
        }

        private void getCardButton_Click(object sender, EventArgs e)
        {
            // Create a Random object.
            Random randomCard = new Random();

            // Get a random index.
            int randomCardIndex = randomCard.Next(0, cardArray.Length);

            // Display a card.
            Card randomlyPickedCard = cardArray[randomCardIndex];
            MessageBox.Show($"{randomlyPickedCard.Value} of {randomlyPickedCard.Suit}");
        }


        private void cardPictureBox_Click(object sender, EventArgs e)
        {
            // Handle the click event for the picture box if needed
        }
    }
}
