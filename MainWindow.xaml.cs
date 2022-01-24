using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp3_Window
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
            if (TextBox != null)
            {
                TextBox.FontFamily = new FontFamily(fontName);
            }
        }


        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            string fontSize = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (TextBox != null)
            {
                TextBox.FontSize = Convert.ToDouble(fontSize);
            }
        }



        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (TextBox != null)
            {
                TextBox.Foreground = Brushes.Red;
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (TextBox != null)
            {
                TextBox.Foreground = Brushes.Black;
            }
        }

        private void ToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            TextBox.FontWeight = FontWeights.Normal;
        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            TextBox.FontWeight = FontWeights.Bold;
        }

        private void ToggleButton_Checked_1(object sender, RoutedEventArgs e)
        {
            TextBox.FontStyle = FontStyles.Italic;
        }

        private void ToggleButton_Unchecked_1(object sender, RoutedEventArgs e)
        {
            TextBox.FontStyle = FontStyles.Normal;
        }

        private void ToggleButton_Checked_2(object sender, RoutedEventArgs e)
        {
            TextBox.TextDecorations = TextDecorations.Underline;
        }

        private void ToggleButton_Unchecked_2(object sender, RoutedEventArgs e)
        {
            TextBox.TextDecorations = null;
        }




 

        private void ExitExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void OpenExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Текстовые (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (open.ShowDialog() == true)
            {
                TextBox.Text = File.ReadAllText(open.FileName);
            }

        }

        private void SaveExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter= "Текстовые (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (save.ShowDialog() == true)
                File.WriteAllText(save.FileName, TextBox.Text);
        }
    }
}

