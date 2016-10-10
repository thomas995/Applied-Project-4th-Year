using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AppliedProject4thYear.SpeedLevels
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SpeedLevelsMainPage : Page
    {
        public SpeedLevelsMainPage()
        {
            this.InitializeComponent();
        }

        private void btnBrainBox_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(BrainBox.BrainBox)); 
        }

        private void btnDownToATea_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(DownToATea.DownToATea));
        }

        private void btnFoalShadow_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(FoalShadow.FoalShadow));
        }

        private void btnGoWithTheBuffLow_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(GoWithTheBuffLow.GoWithTheBuffLow));
        }

        private void btnSpotTheDifference_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SpotTheDifference.SpotTheDifference));
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
