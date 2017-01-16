using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1 {

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private SortedDictionary<Pokoj, Gosc> rezerwacje1 = new SortedDictionary<Pokoj, Gosc>();

        public MainWindow() {
            InitializeComponent();
            dodaj.Visibility = Visibility.Hidden;
            lab1.Visibility = Visibility.Hidden;
            data.Visibility = Visibility.Hidden;
            lab2.Visibility = Visibility.Hidden;
            lab3.Visibility = Visibility.Hidden;
            lab4.Visibility = Visibility.Hidden;
            lab5.Visibility = Visibility.Hidden;
            imiego.Visibility = Visibility.Hidden;
            nazwgo.Visibility = Visibility.Hidden;
            nrpo.Visibility = Visibility.Hidden;
            cena.Visibility = Visibility.Hidden;
            dod2.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            dodaj.Visibility = Visibility.Visible;
            lab1.Visibility = Visibility.Visible;
            data.Visibility = Visibility.Visible;
        }

        private void dodre_Click(object sender, RoutedEventArgs e) {
            lab2.Visibility = Visibility.Visible;
            lab3.Visibility = Visibility.Visible;
            lab4.Visibility = Visibility.Visible;
            lab5.Visibility = Visibility.Visible;
            imiego.Visibility = Visibility.Visible;
            nazwgo.Visibility = Visibility.Visible;
            nrpo.Visibility = Visibility.Visible;
            cena.Visibility = Visibility.Visible;
            dod2.Visibility = Visibility.Visible;
            dodaj.Visibility = Visibility.Hidden;
            lab1.Visibility = Visibility.Hidden;
            data.Visibility = Visibility.Hidden;
        }

        private void dod2_Click(object sender, RoutedEventArgs e) {
            string imie = imiego.Text;
            string nazwisko = nazwgo.Text;
            int nrPokoju = Convert.ToInt32(nrpo.Text);
            double cenaZaDzien = Convert.ToDouble(cena.Text);
            if (nrPokoju <= 0) throw new ArgumentOutOfRangeException();
            if (cenaZaDzien <= 0) throw new ArgumentOutOfRangeException();
            wynik.Text = rezerwacje1.ToString();
        }

        private void wyczyść_Click(object sender, RoutedEventArgs e) {
            rezerwacje1.Clear();
        }
    }
}