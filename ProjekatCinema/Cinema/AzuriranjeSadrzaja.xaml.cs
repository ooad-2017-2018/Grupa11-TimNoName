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
    public sealed partial class AzuriranjeSadrzaja : Page
    {
        public AzuriranjeSadrzaja()
        {
            this.InitializeComponent();
        }

        private void dugP_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
        IMobileServiceTable<Film> film = App.MobileService.GetTable<Film>();
     

        private async void dP_Click(object sender, RoutedEventArgs e)
        {
           
            try
            {

                var items = from x in film where x.IdFilma == IDP.dajID()  select x; 

               
                var nadjenFilm = await items.ToListAsync();
                if (nadjenFilm.Count != 1) throw new Exception("Film sa unesenim ID ne postoji!");
                var i = nadjenFilm[0];
                await film.DeleteAsync(i);
                await (new Windows.UI.Popups.MessageDialog("Pronađen film!")).ShowAsync();

            }
            catch (Exception ex)
            {
                await (new Windows.UI.Popups.MessageDialog(ex.Message)).ShowAsync();
            }

            
        }

        private void dug_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Film obj = new Film();
                obj.IdFilma = IDP.dajID();
                obj.Naslov = tbNaziv.Text;
                obj.Redatelj = tbRed.Text;
                obj.Zanr = tbZanr.Text;
                obj.Trailer = tbTrailer.Text;
                film.InsertAsync(obj);
                MessageDialog msgDialog = new MessageDialog("Uspješno ažuriran film!");
                msgDialog.ShowAsync();
            }
            catch (Exception ex)
            {
                MessageDialog msgDialogError = new MessageDialog("Error: " + ex.ToString());
                msgDialogError.ShowAsync();
            }
        }
    }
}
