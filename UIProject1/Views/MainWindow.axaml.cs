using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Diagnostics;
using System.Diagnostics;
using System.ComponentModel.Design;

namespace UIProject1.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnButtonClick(object? sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Celsius.Text))
            {
                Fahrenheit.Text = "-";
            }
            else
            {
                if (double.TryParse(Celsius.Text, out double C))
                {
                    var F = C * (9d / 5d) + 32;
                    Fahrenheit.Text = F.ToString("0.0");
                }
                else
                {
                    Fahrenheit.Text = "Incorrect input";
                }
            }
        }
    }
}