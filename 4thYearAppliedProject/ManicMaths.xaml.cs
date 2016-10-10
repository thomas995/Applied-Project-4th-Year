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

namespace AppliedProject4thYear
{

    public sealed partial class ManicMath : Page
    {
        public ManicMath()
        {
            this.InitializeComponent();
        }

        private void PSGBackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ProblemSolvingGames), null);
        }

    }
}
