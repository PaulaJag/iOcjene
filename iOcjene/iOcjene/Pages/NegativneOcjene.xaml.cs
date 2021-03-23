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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace iOcjene.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NegativneOcjene : Page
    {
        public NegativneOcjene()
        {
            this.InitializeComponent();

            string currentDirectory = Environment.CurrentDirectory;

            int zbrojUkupno = 0;


            string directoryMatematika = "\\Matematika.txt";
            string[] matematika = File.ReadAllLines(currentDirectory + directoryMatematika);

            int zbrojMatematika = 0;
            for (int i = 0; i < matematika.Length; i++)
            {
                if (matematika[i] == "1")
                {
                    zbrojMatematika += int.Parse(matematika[i]);
                }
            }

            Matematika.Text = zbrojMatematika.ToString("0");


            string directoryHrvatskiJezik = "\\HrvatskiJezik.txt";
            string[] hrvatskijezik = File.ReadAllLines(currentDirectory + directoryHrvatskiJezik);

            int zbrojHrvatskiJezik = 0;
            for (int i = 0; i < hrvatskijezik.Length; i++)
            {
                if (hrvatskijezik[i] == "1")
                {
                    zbrojHrvatskiJezik += int.Parse(hrvatskijezik[i]);
                }
            }

            HrvatskiJezik.Text = zbrojHrvatskiJezik.ToString("0");


            string directoryEngleskiJezik = "\\EngleskiJezik.txt";
            string[] engleskijezik = File.ReadAllLines(currentDirectory + directoryEngleskiJezik);

            int zbrojEngleskiJezik = 0;
            for (int i = 0; i < engleskijezik.Length; i++)
            {
                if (engleskijezik[i] == "1")
                {
                    zbrojEngleskiJezik += int.Parse(engleskijezik[i]);
                }
            }

            EngleskiJezik.Text = zbrojEngleskiJezik.ToString("0");


            string directoryFizika = "\\Fizika.txt";
            string[] fizika = File.ReadAllLines(currentDirectory + directoryFizika);

            int zbrojFizika = 0;
            for (int i = 0; i < fizika.Length; i++)
            {
                if (fizika[i] == "1")
                {
                    zbrojFizika += int.Parse(fizika[i]);
                }
            }

            Fizika.Text = zbrojFizika.ToString("0");


            string directoryMikroupravljači = "\\Mikroupravljači.txt";
            string[] mikroupravljači = File.ReadAllLines(currentDirectory + directoryMikroupravljači);

            int zbrojMikroupravljači = 0;
            for (int i = 0; i < mikroupravljači.Length; i++)
            {
                if (mikroupravljači[i] == "1")
                {
                    zbrojMikroupravljači += int.Parse(mikroupravljači[i]);
                }
            }

            Mikroupravljači.Text = zbrojMikroupravljači.ToString("0");


            string directoryOperacijskiSustavi = "\\OperacijskiSustavi.txt";
            string[] operacijskisustavi = File.ReadAllLines(currentDirectory + directoryOperacijskiSustavi);

            int zbrojOperacijskiSustavi = 0;
            for (int i = 0; i < operacijskisustavi.Length; i++)
            {
                if (operacijskisustavi[i] == "1")
                {
                    zbrojOperacijskiSustavi += int.Parse(operacijskisustavi[i]);
                }
            }

            OperacijskiSustavi.Text = zbrojOperacijskiSustavi.ToString("0");


            string directoryProgramiranje = "\\Programiranje.txt";
            string[] programiranje = File.ReadAllLines(currentDirectory + directoryProgramiranje);

            int zbrojProgramiranje = 0;
            for (int i = 0; i < programiranje.Length; i++)
            {
                if (programiranje[i] == "1")
                {
                    zbrojProgramiranje += int.Parse(programiranje[i]);
                }
            }

            Programiranje.Text = zbrojProgramiranje.ToString("0");


            string directoryRačunalneMreže = "\\RačunalneMreže.txt";
            string[] računalnemreže = File.ReadAllLines(currentDirectory + directoryRačunalneMreže);

            int zbrojRačunalneMreže = 0;
            for (int i = 0; i < računalnemreže.Length; i++)
            {
                if (računalnemreže[i] == "1")
                {
                    zbrojRačunalneMreže += int.Parse(računalnemreže[i]);
                }
            }

            RačunalneMreže.Text = zbrojRačunalneMreže.ToString("0");


            string directorySkriptniJezici = "\\SkriptniJezici.txt";
            string[] skriptnijezici = File.ReadAllLines(currentDirectory + directorySkriptniJezici);

            int zbrojSkriptniJezici = 0;
            for (int i = 0; i < skriptnijezici.Length; i++)
            {
                if (skriptnijezici[i] == "1")
                {
                    zbrojSkriptniJezici += int.Parse(skriptnijezici[i]);
                }
            }

            SkriptniJezici.Text = zbrojSkriptniJezici.ToString("0");


            string directoryTjelesni = "\\Tjelesni.txt";
            string[] tjelesni = File.ReadAllLines(currentDirectory + directoryTjelesni);

            int zbrojTjelesni = 0;
            for (int i = 0; i < tjelesni.Length; i++)
            {
                if (tjelesni[i] == "1")
                {
                    zbrojTjelesni += int.Parse(tjelesni[i]);
                }
            }

            Tjelesni.Text = zbrojTjelesni.ToString("0");


            string directoryWebDizajn = "\\WebDizajn.txt";
            string[] webdizajn = File.ReadAllLines(currentDirectory + directoryWebDizajn);

            int zbrojWebDizajn = 0;
            for (int i = 0; i < webdizajn.Length; i++)
            {
                if (fizika[i] == "1")
                {
                    zbrojWebDizajn += int.Parse(webdizajn[i]);
                }
            }

            WebDizajn.Text = zbrojWebDizajn.ToString("0");
        }

        private void NavPocetna_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void Predmeti_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Predmeti));
        }

        private void NegativneOcjene_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(NegativneOcjene));
        }

        private void Ispiti_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Ispiti));
        }

        private void UsmeneProvjere_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(UsmeneProvjere));
        }
    }
}
