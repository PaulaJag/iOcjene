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
    public sealed partial class Predmeti : Page
    {
        public Predmeti()
        {
            this.InitializeComponent();

            string currentDirectory = Environment.CurrentDirectory;

            int zbrojUkupno = 0;


            string directoryMatematika = "\\Matematika.txt";
            string[] matematika = File.ReadAllLines(currentDirectory + directoryMatematika);

            int zbrojMatematika = 0;
            for (int i = 0; i < matematika.Length; i++)
            {
                zbrojMatematika += int.Parse(matematika[i]);
                zbrojUkupno += int.Parse(matematika[i]);
            }
            double prosjek = (double)zbrojMatematika / matematika.Length;

            Matematika.Text = prosjek.ToString("0.00");


            string directoryHrvatski = "\\HrvatskiJezik.txt";
            string[] hrvatski = File.ReadAllLines(currentDirectory + directoryHrvatski);

            int zbrojHrvatski = 0;
            for (int i = 0; i < hrvatski.Length; i++)
            {
                zbrojHrvatski += int.Parse(hrvatski[i]);
                zbrojUkupno += int.Parse(hrvatski[i]);
            }
            double prosjekHrvatski = (double)zbrojHrvatski / hrvatski.Length;

            HrvatskiJezik.Text = prosjekHrvatski.ToString("0.00");


            string directoryEngleski = "\\EngleskiJezik.txt";
            string[] engleski = File.ReadAllLines(currentDirectory + directoryEngleski);

            int zbrojEngleski = 0;
            for (int i = 0; i < engleski.Length; i++)
            {
                zbrojEngleski += int.Parse(engleski[i]);
                zbrojUkupno += int.Parse(engleski[i]);
            }
            double prosjekEngleski = (double)zbrojEngleski / engleski.Length;

            EngleskiJezik.Text = prosjekEngleski.ToString("0.00");


            string directoryFizika = "\\Fizika.txt";
            string[] fizika = File.ReadAllLines(currentDirectory + directoryFizika);

            int zbrojFizika = 0;
            for (int i = 0; i < fizika.Length; i++)
            {
                zbrojFizika += int.Parse(fizika[i]);
                zbrojUkupno += int.Parse(fizika[i]);
            }
            double prosjekFizika = (double)zbrojFizika / fizika.Length;

            Fizika.Text = prosjekFizika.ToString("0.00");


            string directoryMikroupravljači = "\\Mikroupravljači.txt";
            string[] mikroupravljači = File.ReadAllLines(currentDirectory + directoryMikroupravljači);

            int zbrojMikroupravljači = 0;
            for (int i = 0; i < mikroupravljači.Length; i++)
            {
                zbrojMikroupravljači += int.Parse(mikroupravljači[i]);
                zbrojUkupno += int.Parse(mikroupravljači[i]);
            }
            double prosjekMikroupravljači = (double)zbrojMikroupravljači / mikroupravljači.Length;

            Mikroupravljači.Text = prosjekMikroupravljači.ToString("0.00");


            string directoryOperacijskiSustavi = "\\OperacijskiSustavi.txt";
            string[] operacijskisustavi = File.ReadAllLines(currentDirectory + directoryOperacijskiSustavi);

            int zbrojOperacijskiSustavi = 0;
            for (int i = 0; i < operacijskisustavi.Length; i++)
            {
                zbrojOperacijskiSustavi += int.Parse(operacijskisustavi[i]);
                zbrojUkupno += int.Parse(operacijskisustavi[i]);
            }
            double prosjekOperacijskiSustavi = (double)zbrojOperacijskiSustavi / operacijskisustavi.Length;

            OperacijskiSustavi.Text = prosjekOperacijskiSustavi.ToString("0.00");


            string directoryProgramiranje = "\\Programiranje.txt";
            string[] programiranje = File.ReadAllLines(currentDirectory + directoryProgramiranje);

            int zbrojProgramiranje = 0;
            for (int i = 0; i < programiranje.Length; i++)
            {
                zbrojProgramiranje += int.Parse(programiranje[i]);
                zbrojUkupno += int.Parse(programiranje[i]);
            }
            double prosjekProgramiranje = (double)zbrojProgramiranje / programiranje.Length;

            Programiranje.Text = prosjekProgramiranje.ToString("0.00");


            string directoryRačunalneMreže = "\\RačunalneMreže.txt";
            string[] računalnemreže = File.ReadAllLines(currentDirectory + directoryRačunalneMreže);

            int zbrojRačunalneMreže = 0;
            for (int i = 0; i < računalnemreže.Length; i++)
            {
                zbrojRačunalneMreže += int.Parse(računalnemreže[i]);
                zbrojUkupno += int.Parse(računalnemreže[i]);
            }
            double prosjekRačunalneMreže = (double)zbrojRačunalneMreže / računalnemreže.Length;

            RačunalneMreže.Text = prosjekRačunalneMreže.ToString("0.00");


            string directorySkriptniJezici = "\\SkriptniJezici.txt";
            string[] skriptnijezici = File.ReadAllLines(currentDirectory + directorySkriptniJezici);

            int zbrojSkriptniJezici = 0;
            for (int i = 0; i < skriptnijezici.Length; i++)
            {
                zbrojSkriptniJezici += int.Parse(skriptnijezici[i]);
                zbrojUkupno += int.Parse(skriptnijezici[i]);
            }
            double prosjekSkriptniJezici = (double)zbrojSkriptniJezici / skriptnijezici.Length;

            SkriptniJezici.Text = prosjekSkriptniJezici.ToString("0.00");


            string directoryTjelesni = "\\Tjelesni.txt";
            string[] tjelesni = File.ReadAllLines(currentDirectory + directoryTjelesni);

            int zbrojTjelesni = 0;
            for (int i = 0; i < tjelesni.Length; i++)
            {
                zbrojTjelesni += int.Parse(tjelesni[i]);
                zbrojUkupno += int.Parse(tjelesni[i]);
            }
            double prosjekTjelesni = (double)zbrojTjelesni / tjelesni.Length;

            Tjelesni.Text = prosjekTjelesni.ToString("0.00");


            string directoryWebDizajn = "\\WebDizajn.txt";
            string[] webdizajn = File.ReadAllLines(currentDirectory + directoryWebDizajn);

            int zbrojWebDizajn = 0;
            for (int i = 0; i < webdizajn.Length; i++)
            {
                zbrojWebDizajn += int.Parse(webdizajn[i]);
                zbrojUkupno += int.Parse(webdizajn[i]);
            }
            double prosjekWebDizajn = (double)zbrojWebDizajn / webdizajn.Length;

            WebDizajn.Text = prosjekWebDizajn.ToString("0.00");


            double prosjekUkupan = (double)zbrojUkupno / (matematika.Length + hrvatski.Length + engleski.Length + fizika.Length + mikroupravljači.Length + operacijskisustavi.Length + programiranje.Length + računalnemreže.Length + skriptnijezici.Length + tjelesni.Length + webdizajn.Length);

            UkupanProsjek.Text = prosjekUkupan.ToString("0.00");
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
