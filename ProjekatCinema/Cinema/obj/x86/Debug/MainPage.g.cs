﻿#pragma checksum "C:\Users\Korisnik\Desktop\CinemaEdinaZadnje\Grupa11-TimNoName\ProjekatCinema\Cinema\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5BE6C7B7AD27C74D26E26A3580DA3EBA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cinema
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.VG = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.LDugmad = (global::Windows.UI.Xaml.Controls.ColumnDefinition)(target);
                }
                break;
            case 3:
                {
                    this.Sredina = (global::Windows.UI.Xaml.Controls.ColumnDefinition)(target);
                }
                break;
            case 4:
                {
                    this.DDugmad = (global::Windows.UI.Xaml.Controls.ColumnDefinition)(target);
                }
                break;
            case 5:
                {
                    this.dPrijava = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 39 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.dPrijava).Click += this.dPrijava_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.dRegistracija = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 40 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.dRegistracija).Click += this.dRegistracija_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.dDodavanje = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 41 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.dDodavanje).Click += this.dDodavanje_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.dAzuriranje = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 42 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.dAzuriranje).Click += this.dAzuriranje_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.dBrisanje = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 43 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.dBrisanje).Click += this.dBrisanje_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

