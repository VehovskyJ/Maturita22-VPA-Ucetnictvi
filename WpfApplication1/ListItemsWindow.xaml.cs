using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;

namespace WpfApplication1 {
    public partial class ListItemsWindow : Window {
        public ListItemsWindow() {
            InitializeComponent();
            
            
            string path = MainWindow.filePath;
            if (!File.Exists(path)) {
                MessageBox.Show("Soubor neexistuje nebo nebyl vybran", "Pozor", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
            
            List<Transakce> transakce = new List<Transakce>();
            
            string[] lines = System.IO.File.ReadAllLines(path);

            foreach (var line in lines) {
                string[] polozky = line.Split(';');
                transakce.Add(new Transakce(polozky[0], polozky[1], polozky[2], polozky[3], polozky[4], polozky[5]));
            }    
            
            datagrids.ItemsSource = transakce;  

        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e) {
            string path = MainWindow.filePath;
            if (!File.Exists(path)) {
                MessageBox.Show("Soubor neexistuje nebo nebyl vybran", "Pozor", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
            
            foreach (var item in datagrids.Items.OfType<Transakce>()) {
                string transakce = item.Datum + ";" + item.Druh + ";" + item.Ucet + ";" + item.Cena + ";" + item.Kategorie + ";" + item.Osoba;
                using (StreamWriter sw = File.CreateText(path)) {
                    sw.WriteLine(transakce);
                }
            }
            
            this.Close();
        }
    }
}