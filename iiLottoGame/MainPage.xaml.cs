using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace iiLottoGame
{
    public partial class MainPage : ContentPage
    {
        const int MAX = 5;

        // Initialize an array with MAX elements
        int[] lottoArray = new int[MAX];

        // Initialize a new random object
        Random rand = new Random();

        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Generate random numbers, check to see if the numbers match the user's entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPlay_Clicked(object sender, EventArgs e)
        {
            // Generate random numbers
            PopulateRandomNumbers();

            // Display lotto numbers
            DisplayLottoNumbers();

            // Check to see if user won/lost
            CheckLottoNumbers();
        }

       
        /// <summary>
        /// Check the lotto numbers and display an alert for win/loss
        /// </summary>
        private void CheckLottoNumbers()
        {
            if(lotto1.Text != EntryGuess1.Text || 
                lotto2.Text != EntryGuess2.Text || 
                lotto3.Text != EntryGuess3.Text || 
                lotto4.Text != EntryGuess4.Text || 
                lotto5.Text != EntryGuess5.Text)
            {
                DisplayAlert("Loser", "You lost!", "Close");
            }
            else
            {
                DisplayAlert("Winner", "You won!", "Close");
            }
        }

        /// <summary>
        ///   Display the randomly generated numbers
        /// </summary>
        private void DisplayLottoNumbers()
        {
            lotto1.Text = lottoArray[0].ToString();
            lotto2.Text = lottoArray[1].ToString();
            lotto3.Text = lottoArray[2].ToString();
            lotto4.Text = lottoArray[3].ToString();
            lotto5.Text = lottoArray[4].ToString();
        }

        /// <summary>
        /// Create 5 different random numbers and push them to an array
        /// </summary>
        private void PopulateRandomNumbers()
        {
            int index = 0;

            while (index < 5)
            {
                // For testing
                //lottoArray[index] = rand.Next(2);
                lottoArray[index] = rand.Next(100);
                index++;
            }
        }
    }
}
