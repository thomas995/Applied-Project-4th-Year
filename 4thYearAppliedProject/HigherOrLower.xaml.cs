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

        DispatcherTimer dispatcherTimer;
        int timesTicked = 60;
        int timesToTick = 60;
        public void DispatcherTimerSetup()
        {
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        async void dispatcherTimer_Tick(object sender, object e)
        {
            TimerLog.Text = timesTicked.ToString();
            if (timesTicked > timesToTick)
            {
                TimerStatus.Text = "Calling dispatcherTimer.Stop()\n";
                dispatcherTimer.Stop();
                TimerStatus.Text = "dispatcherTimer.IsEnabled = " + dispatcherTimer.IsEnabled + "\n";
            }
            timesTicked--;

            if (timesTicked == -1)
            {
                dispatcherTimer.Stop(); // stops timer going below 0
                var dialog = new Windows.UI.Popups.MessageDialog
                ("Out of time! You scored a total of: " + HoLScore);
                var result = await dialog.ShowAsync();
                this.Frame.Navigate(typeof(MainPage), null);
            }
        }
        private void TimerStart_Click_1(object sender, RoutedEventArgs e)
        {
            DispatcherTimerSetup();
        }

        private void TimerStop_Click_1(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
        }
        private void Page_Loaded_1(object sender, RoutedEventArgs e)
        {
            TimerStatus.Text = "dispatcherTimer.IsEnabled = False";
        }
    
int HoLScore = 0;
        Random random1 = new Random(200);
        Random random2 = new Random(205);
        Random random3 = new Random(210);
        Random random4 = new Random(220);

        int Lives = 5;
        int randomNumber1;
        int randomNumber2;
        int randomNumber3;
        int randomNumber4;
        private int randomNumber1And2;
        private int randomNumber3And4;

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

            Random random1 = new Random(randomNumber1 * randomNumber2);
            Random random2 = new Random(randomNumber2 * randomNumber3);
            Random random3 = new Random(randomNumber3 * randomNumber4);
            Random random4 = new Random(randomNumber1 * randomNumber4);

            randomNumber1 = random1.Next(1, 101);

            //Random random2 = new Random();
            randomNumber2 = random2.Next(1, 101);

            btnFirstChoice.Content = randomNumber1;
            btnSecondChoice.Content = randomNumber2;

            // Bottom Question
            randomNumber4 = random4.Next(1, 101);

            //Random random3 = new Random();
            randomNumber3 = random3.Next(1, 101);

            btnChoice3.Content = randomNumber3;
            btnChoice4.Content = randomNumber4;

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

            Random random1 = new Random(randomNumber1 * randomNumber2);
            Random random2 = new Random(randomNumber2 * randomNumber3);
            Random random3 = new Random(randomNumber3 * randomNumber4);
            Random random4 = new Random(randomNumber1 * randomNumber4);
            // Top Question
            randomNumber2 = random2.Next(1, 101);

           // Random random1 = new Random();
            randomNumber1 = random1.Next(1, 101);

            btnFirstChoice.Content = randomNumber1;
            btnSecondChoice.Content = randomNumber2;


            // Bottom Question
            randomNumber4 = random4.Next(1, 101);

            //Random random3 = new Random();
            randomNumber3 = random3.Next(1, 101);

            btnChoice3.Content = randomNumber3;
            btnChoice4.Content = randomNumber4;


        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            DispatcherTimerSetup();

            btnStart.Visibility = Visibility.Collapsed;
            txtLives.Visibility = Visibility.Visible;
            btnChoiceOne.Visibility = Visibility.Visible;
            btnChoiceTwo.Visibility = Visibility.Visible;
            btnChoice3.Visibility = Visibility.Visible;
            btnChoice4.Visibility = Visibility.Visible;
            btnFirstChoice.Visibility = Visibility.Visible;
            btnSecondChoice.Visibility = Visibility.Visible;
            btnFirstChoice_Copy.Visibility = Visibility.Visible;
            btnFirstChoice_Copy1.Visibility = Visibility.Visible;



            txtLives.Text = Lives.ToString();

            randomNumber2 = random2.Next(1, 101);
            //Random random1 = new Random();
            randomNumber1 = random1.Next(1, 101);

            btnFirstChoice.Content = (randomNumber1);
            btnSecondChoice.Content = randomNumber2;

            // Bottom Question
            randomNumber4 = random4.Next(1, 101);

            //Random random3 = new Random();
            randomNumber3 = random3.Next(1, 101);

            btnChoice3.Content = randomNumber3;
            btnChoice4.Content = randomNumber4;

        }

        private async void btnChoiceOne_Click(object sender, RoutedEventArgs e)
        {
            randomNumber1And2 = randomNumber1 + randomNumber2;
            randomNumber3And4 = randomNumber3 + randomNumber4;

            if (randomNumber1And2 > randomNumber3And4)
            {
                HoLScore++;
                displayScore.Text = HoLScore.ToString();
            }
            else if (randomNumber1And2 < randomNumber3And4)
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

            //Random random2 = new Random();
            randomNumber2 = random2.Next(1, 101);

            btnFirstChoice.Content = randomNumber1;
            btnSecondChoice.Content = randomNumber2;

            // Bottom Question
            randomNumber4 = random4.Next(1, 101);

            //Random random3 = new Random();
            randomNumber3 = random3.Next(1, 101);

            btnChoice3.Content = randomNumber3;
            btnChoice4.Content = randomNumber4;

        }

        private async void btnChoiceTwo_Click(object sender, RoutedEventArgs e)
        {
            randomNumber1And2 = randomNumber1 + randomNumber2;
            randomNumber3And4 = randomNumber3 + randomNumber4;

            if (randomNumber3And4 > randomNumber1And2)
            {
                HoLScore++;
                displayScore.Text = HoLScore.ToString();
            }
            else if (randomNumber3And4 < randomNumber1And2)
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

            //Random random2 = new Random();
            randomNumber2 = random2.Next(1, 101);

            btnFirstChoice.Content = randomNumber1;
            btnSecondChoice.Content = randomNumber2;

            // Bottom Question
            randomNumber4 = random4.Next(1, 101);

            //Random random3 = new Random();
            randomNumber3 = random3.Next(1, 101);

            btnChoice3.Content = randomNumber3;
            btnChoice4.Content = randomNumber4;

        }
    }
}
