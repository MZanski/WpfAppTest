using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace XAMLButton
{
    /// <summary> 
    /// Interaction logic for MainWindow.xaml 
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetupTestOutputTexBlock();
        }
        void OnClick1(object sender, RoutedEventArgs e)
        {
            button1.Foreground = new SolidColorBrush(Colors.Blue);

            TestOutputFromButtons.Text = "You hovered over the first button.";

            MessageBox.Show("On Hover click event occurs.");
        }
        void OnClick2(object sender, RoutedEventArgs e)
        {
            button2.Foreground = new SolidColorBrush(Colors.Green);

            TestOutputFromButtons.Text = "You hit the second button.";

            MessageBox.Show("On Press click event occurs.");
        }
        void OnClick3(object sender, RoutedEventArgs e)
        {
            button1.Foreground = new SolidColorBrush(Colors.Green);
            button2.Foreground = new SolidColorBrush(Colors.Blue);

            TestOutputFromButtons.Text = "You hit the third button.";

            MessageBox.Show("On Release click event occurs.");
        }

        void SetupTestOutputTexBlock()
        {
            TestOutputFromButtons.Text = "";
        }


    }
}