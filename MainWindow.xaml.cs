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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
            {
                textBox.FontFamily = new FontFamily(fontName);
            }

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            var fontSize1 = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
            {
                FontSizeConverter myFontSizeConverter = new FontSizeConverter();
                textBox.FontSize = (Double)myFontSizeConverter.ConvertFromString(fontSize1.ToString());
            }

        }

        bool isBold;
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            if (!isBold)
                textBox.FontWeight = FontWeights.Bold;
            else
                textBox.FontWeight = FontWeights.Normal;
            isBold = !isBold;
        }

        bool isDecor;
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            if (!isDecor)
                textBox.TextDecorations = TextDecorations.Underline;
            else
                textBox.TextDecorations = null;
            isDecor = !isDecor;
        }

        bool isItalic;
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            if (!isItalic)
                textBox.FontStyle = FontStyles.Italic;
            else
                textBox.FontStyle = FontStyles.Normal;
            isItalic = !isItalic;
        }


       

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            textBox.Foreground = Brushes.Black;
        }
        private void RadioButton_Click1(object sender, RoutedEventArgs e)
        {
            textBox.Foreground = Brushes.Red;
        }


    }
}