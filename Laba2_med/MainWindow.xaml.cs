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

namespace Laba2_med
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ReplaceSymbolsButton_Click(object sender, RoutedEventArgs e)
        {
            // Получаем текст из TextBox
            string inputString = InputTextBox.Text;

            // Заменяем "+" и "-" на "0"
            string replacedString = ReplaceSymbols(inputString);

            // Устанавливаем результат в OutputTextBox
            OutputTextBox.Text = replacedString;
        }

        private string ReplaceSymbols(string input)
        {
            // Заменяем "+" и "-" на "0"
            return input.Replace("+", "0").Replace("-", "0");
        }
    }
}
