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
    public sealed partial class Registracija : Page
    {
        public Registracija()
        {
            this.InitializeComponent();
        }

        IMobileServiceTable<RegistrovaniKorisnik> userTableObj = App.MobileService.GetTable<RegistrovaniKorisnik>();

        private void dReg_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                RegistrovaniKorisnik obj = new RegistrovaniKorisnik();
                obj.Ime = tbIme.Text;
                obj.Prezime = tbPrezime.Text;
                obj.Password = tbPw.Password.ToString();
                obj.Username = tbUn.Text;
                obj.EMail = tbJMBG.Text;
                obj.BrojKartice = tbKartica.Text;
                obj.DatumRodjenja = Convert.ToDateTime(tbDatum.Text);
                userTableObj.InsertAsync(obj);
                MessageDialog msgDialog = new MessageDialog("Uspješna registracija!");
                msgDialog.ShowAsync();
                this.Frame.Navigate(typeof(MainPage));
            }
            catch (Exception ex)
            {
                MessageDialog msgDialogError = new MessageDialog("Error : " + ex.ToString());
                msgDialogError.ShowAsync();
            }
        }
    }
}
