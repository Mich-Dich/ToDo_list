using System;
using System.Windows;

namespace ToDo
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e) {

            DragMove();
        }

        private void BU_minimize_Click(object sender, RoutedEventArgs e) {

            WindowState = WindowState.Minimized;
        }

        private void BU_close_Click(object sender, RoutedEventArgs e) {

            Close();
        }

        private void BU_maximize_Click(object sender, RoutedEventArgs e) {

            if(WindowState == WindowState.Maximized) 
                WindowState = WindowState.Normal; 
            else 
                WindowState = WindowState.Maximized;
        }

    }
}
