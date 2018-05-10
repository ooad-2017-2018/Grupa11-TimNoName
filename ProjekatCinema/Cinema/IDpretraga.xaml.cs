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

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Cinema
{
    public sealed partial class IDpretraga : UserControl
    {
        public IDpretraga()
        {
            this.InitializeComponent();
        }

        public int dajID() {
            return int.Parse(idB.Text);
        }
    }
}
