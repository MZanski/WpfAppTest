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
            SetupMiddleSection();
        }
        void OnClick1(object sender, RoutedEventArgs e)
        {
            if (button1.Opacity == 0) { return; }

            button1.Foreground = new SolidColorBrush(Colors.Blue);

            TestOutputFromButtons.Text = "You hovered over the first button.";

            MessageBox.Show("On Hover click event occurs.");
        }
        void OnClick2(object sender, RoutedEventArgs e)
        {
            if (button2.Opacity == 0) { return; }

            button2.Foreground = new SolidColorBrush(Colors.Green);

            TestOutputFromButtons.Text = "You hit the second button.";

            MessageBox.Show("On Press click event occurs.");
        }
        void OnClick3(object sender, RoutedEventArgs e)
        {
            if (button3.Opacity == 0) { return; }

            button1.Foreground = new SolidColorBrush(Colors.Green);
            button2.Foreground = new SolidColorBrush(Colors.Blue);

            TestOutputFromButtons.Text = "You hit the third button.";

            MessageBox.Show("On Release click event occurs.");
        }

        void SetupTestOutputTexBlock()
        {
            TestOutputFromButtons.Text = "";
        }

        void SetupMiddleSection()
        {
            button1.Opacity = 0;
            button2.Opacity = 0;
            button3.Opacity = 0;
        }

        void ToggleOptionsClick(object sender, RoutedEventArgs e)
        {
            if (button3.Opacity == 0)
            {
                button1.Opacity = 1;
                button2.Opacity = 1;
                button3.Opacity = 1;
            }
            else
            {
                button1.Opacity = 0;
                button2.Opacity = 0;
                button3.Opacity = 0;
            }
        }


    }
}