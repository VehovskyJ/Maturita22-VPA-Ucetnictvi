using System;
using System.IO;
using System.Windows;

namespace WpfApplication1 {
    public partial class AddItemWindow : Window {
        public AddItemWindow() {
            InitializeComponent();

        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e) {

        }

        private void cancel(object sender, RoutedEventArgs e) {
            this.Close();
        }

        private void add(object sender, RoutedEventArgs e) {
            string transakce = this.datum.Text + ";" + this.druh.Text + ";" + this.ucet.Text + ";" + this.penez.Text + ";" + this.kategorie.Text + ";" + this.osoba.Text;
            string path = MainWindow.filePath;
            if (!File.Exists(path)) {
                MessageBox.Show("Soubor neexistuje nebo nebyl vybran", "Pozor", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
            using (StreamWriter sw = File.CreateText(path)) {
                sw.WriteLine(transakce);
            }
            this.Close();
        }
    }
}