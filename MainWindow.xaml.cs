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

namespace lesson_9_new
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string[] ArraySplit(string text)
        {
            string[] words = text.Split(' ');
            return words;
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSeparateLine_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                string text = textBox1.Text;
                string[] words = ArraySplit(text);
                listBox.Items.Clear();
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i] != String.Empty) 
                    listBox.Items.Add(words[i]);
                }
                textBox1.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("Введите текст");
            }
        }

        private void btnReverse_Click(object sender, RoutedEventArgs e)
        {
            if (textBox2.Text != string.Empty)
            {
                string text = textBox2.Text;
                string[] words = ArraySplit(text);
                text = string.Empty;
                for (int i = words.Length-1; i >= 0 ; i--)
                {
                         text += words[i] + " ";
                }
                label.Content = text;
                textBox2.Text = String.Empty;
                 
            }
            else
            {
                MessageBox.Show("Введите текст");
            }
        }
    }
}
