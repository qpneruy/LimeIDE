using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System;
using Python.Runtime;

namespace LimeIDE
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string url = inputTextBox.Text;

            if (!string.IsNullOrEmpty(url))
            {
                // Call the Python function with the URL
                string strCmdText;
                System.Diagnostics.Process.Start("CMD.exe", "/C yt-dlp --sleep-interval 1 --concurrent-fragments 2 bestvideo[ext=mp4]+bestaudio[ext=m4a]/bestvideo[ext=webm]+bestaudio[ext=webm]/best " + url);
            }
            else
            {
                MessageBox.Show("Please enter a valid URL.", "Error");
            }
        }


    }
}