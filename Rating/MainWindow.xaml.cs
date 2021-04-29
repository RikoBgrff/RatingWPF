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

namespace Rating
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int instance = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Star1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           
            switch (instance)
            {
                case 0:
                    {
                        Star1.Source  = new BitmapImage(new Uri("emptystar.png"));
                        instance = 1;
                        break;
                    }
                case 1:
                    {
                        Star1.Source = new BitmapImage(new Uri("halfstar.png")); 
                        instance = 2;
                        break;
                    }
                case 2:
                    {
                        Star1.Source = new BitmapImage(new Uri("star.png"));
                        instance = 0;
                        break;
                    }
            }

        }
    }
}
