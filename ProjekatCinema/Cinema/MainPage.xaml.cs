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
using Microsoft.WindowsAzure.MobileServices;
using Windows.UI.Popups;
using Cinema.Model;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Cinema
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void registracija_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Prijava));
        }

        private void dPrijava_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Prijava));
        }

        private void dRegistracija_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Registracija));
        }

        private void dAzuriranje_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AzuriranjeSadrzaja));
        }

        private void dDodavanje_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DodavanjeSadržaja));
        }

    }
}
