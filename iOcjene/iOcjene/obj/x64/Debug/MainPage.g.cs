﻿#pragma checksum "C:\Users\David\Documents\GitHub\iOcjene\iOcjene\iOcjene\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CC3ABA4EDA81429079E52D056D51CC82"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iOcjene
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 12
                {
                    this.Border = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 3: // MainPage.xaml line 22
                {
                    this.Predmeti = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Predmeti).Click += this.Predmeti_Click;
                }
                break;
            case 4: // MainPage.xaml line 23
                {
                    this.Ispiti = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Ispiti).Click += this.Ispiti_Click;
                }
                break;
            case 5: // MainPage.xaml line 24
                {
                    this.UsmeneProvjere = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.UsmeneProvjere).Click += this.UsmeneProvjere_Click;
                }
                break;
            case 6: // MainPage.xaml line 25
                {
                    this.NegativneOcjene = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.NegativneOcjene).Click += this.NegativneOcjene_Click;
                }
                break;
            case 7: // MainPage.xaml line 26
                {
                    this.Odjava = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Odjava).Click += this.Odjava_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

