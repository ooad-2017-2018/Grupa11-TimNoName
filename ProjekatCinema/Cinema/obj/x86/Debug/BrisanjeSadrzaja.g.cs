﻿#pragma checksum "C:\Users\Korisnik\Desktop\CinemaEdinaZadnje\Grupa11-TimNoName\ProjekatCinema\Cinema\BrisanjeSadrzaja.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0060408AB5F8541B35F56FD7D7807673"
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
    partial class BrisanjeSadrzaja : 
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
                    this.lTrailer = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.lRed = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.lNaziv = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.tbTrailer = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5:
                {
                    this.tbRed = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6:
                {
                    this.tbNaziv = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7:
                {
                    this.dug = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 23 "..\..\..\BrisanjeSadrzaja.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.dug).Click += this.dug_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.dugP = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 24 "..\..\..\BrisanjeSadrzaja.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.dugP).Click += this.dugP_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.IDP = (global::Cinema.IDpretraga)(target);
                    #line 25 "..\..\..\BrisanjeSadrzaja.xaml"
                    ((global::Cinema.IDpretraga)this.IDP).Loaded += this.IDP_Loaded;
                    #line default
                }
                break;
            case 10:
                {
                    this.dP = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 26 "..\..\..\BrisanjeSadrzaja.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.dP).Click += this.dP_Click;
                    #line default
                }
                break;
            case 11:
                {
                    this.lZanr = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.tbZanr = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 13:
                {
                    this.VisualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 14:
                {
                    this.Wide = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 15:
                {
                    this.Mini = (global::Windows.UI.Xaml.VisualState)(target);
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

