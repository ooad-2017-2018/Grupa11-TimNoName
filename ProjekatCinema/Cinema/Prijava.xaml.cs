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
    public sealed partial class Prijava : Page
    {
        public Prijava()
        {
            this.InitializeComponent();
        }


        private async void dPrijava_Click(object sender, RoutedEventArgs e)
        {
            try

            {
                string username = un.Text; string password = pw.Text;
                if (un.Text.Length == 0 || pw.Text.Length == 0)
                    await(new MessageDialog("Polja moraju biti popunjena")).ShowAsync();
                else if (un.Text.Length != 0 && pw.Text.Length != 0)
                {

                    IMobileServiceTable<RegistrovaniKorisnik> regKorisnik = App.MobileService.GetTable<RegistrovaniKorisnik>();

                    if (username == "nerminamamela" && password == "cao") this.Frame.Navigate(typeof(MainPage));
                    else
                    {

                        var korisnik = from a in regKorisnik where a.Username == username select a;
                        var lista = await korisnik.ToListAsync();
                        if (lista.Count != 1) throw new Exception("Korisnik sa unesenim podacima ne postoji!");
                        var x = lista[0];
                        if (x.Password != password && password != "") throw new Exception("Pogrešan password!");
                        RegistrovaniKorisnik k = null;
                        k = new RegistrovaniKorisnik();
                        //throw new Exception("Uspješan login!");

                        this.Frame.Navigate(typeof(KorisnikForma));
                    }
                }

               

            }
            catch (Exception izuzetak)
            {
                await(new MessageDialog(izuzetak.Message)).ShowAsync();
            }
        }

        private void dGost_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void ll_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Registracija));
        }
    }
}
