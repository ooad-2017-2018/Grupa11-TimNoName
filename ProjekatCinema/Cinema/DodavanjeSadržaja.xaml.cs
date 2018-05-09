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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Cinema
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DodavanjeSadržaja : Page
    {
        public DodavanjeSadržaja()
        {
            this.InitializeComponent();
        }
        IMobileServiceTable<Film> userTableObj = App.MobileService.GetTable<Film>();
            
        private void dug_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Film obj = new Film();
                obj.naslov = tbNaziv.Text;
                obj.redatelj = tbRed.Text;
                obj.zanr = zanr.dajZanr();
                obj.trailer = tbTrailer.Text;
                userTableObj.InsertAsync(obj);
                MessageDialog msgDialog = new MessageDialog("Uspješna registracija");
                msgDialog.ShowAsync();
            }
            catch (Exception ex)
            {
                MessageDialog msgDialogError = new MessageDialog("Error : " + ex.ToString());
                msgDialogError.ShowAsync();
            }
        }

        private void dugP_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
