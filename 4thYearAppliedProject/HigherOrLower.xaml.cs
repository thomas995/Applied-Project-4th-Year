using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AppliedProject4thYear
{



    public sealed partial class HigherOrLower : Page
    {


        public HigherOrLower()
        {
            this.InitializeComponent();
        }


        int HoLScore = 0;
        Random random1 = new Random();
        Random random2 = new Random();
        int Lives = 5;
        int randomNumber1; // always hit the top one first
        int randomNumber2;



        private void PSGBackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ProblemSolvingGames), null);
        }

        private async void btnFirstChoice_Click(object sender, RoutedEventArgs e)
        {
            if (randomNumber1 > randomNumber2)
            {
                HoLScore++;
                displayScore.Text = HoLScore.ToString();
            }
            else if (randomNumber1 < randomNumber2)
            {
                Lives--;
                txtLives.Text = Lives.ToString();
                if (Lives == 0)
                {
                    var dialog = new Windows.UI.Popups.MessageDialog(
                    "You have lost! You scored a total of: " + HoLScore);
                    var result = await dialog.ShowAsync();
                    this.Frame.Navigate(typeof(MainPage), null);
                }
            }


            randomNumber1 = random1.Next(1, 101);

            Random random2 = new Random();
            randomNumber2 = random2.Next(1, 101);

            btnFirstChoice.Content = randomNumber1;
            btnSecondChoice.Content = randomNumber2;

        }

        private async void btnSecondChoice_Click(object sender, RoutedEventArgs e)
        {
            if (randomNumber2 > randomNumber1)
            {
                HoLScore++;
                displayScore.Text = HoLScore.ToString();
            }
            else if (randomNumber2 < randomNumber1)
            {
                Lives--;
                txtLives.Text = Lives.ToString();
                if (Lives == 0)
                {
                    var dialog = new Windows.UI.Popups.MessageDialog(
                    "You have lost! You scored a total of: " + HoLScore);
                    var result = await dialog.ShowAsync();
                    this.Frame.Navigate(typeof(MainPage), null);
                }
            }


            randomNumber2 = random2.Next(1, 101);

            Random random1 = new Random();
            randomNumber1 = random1.Next(1, 101);

            btnFirstChoice.Content = randomNumber1;
            btnSecondChoice.Content = randomNumber2;

        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            btnStart.Visibility = Visibility.Collapsed;
            txtLives.Visibility = Visibility.Visible;
            txtLives.Text = Lives.ToString();

            randomNumber2 = random2.Next(1, 101);
            Random random1 = new Random();
            randomNumber1 = random1.Next(1, 101);

            btnFirstChoice.Content = randomNumber1;
            btnSecondChoice.Content = randomNumber2;
            
        }

        
    }
}
