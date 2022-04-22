using System;
using System.IO;
using Microsoft.Win32;

namespace WpfApplication1 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow {
        public static string filePath;
        
        public MainWindow() {
            InitializeComponent();
        }

        private void endProgram(object sender, System.Windows.RoutedEventArgs e) {
            Environment.Exit(0);
        }

        private void loadFiles(object sender, System.Windows.RoutedEventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true) {
                filePath = openFileDialog.FileName;
            }
        }

        private void newItem(object sender, System.Windows.RoutedEventArgs e) {
            AddItemWindow addItemWindow = new AddItemWindow();
            addItemWindow.Show();
        }

        private void listItems(object sender, System.Windows.RoutedEventArgs e) {
            ListItemsWindow listItemsWindow = new ListItemsWindow();
            listItemsWindow.Show();
        }
        
    }
}