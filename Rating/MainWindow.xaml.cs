using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public Uri halfStarSource = new Uri(@"halfstar.png", UriKind.Relative);
        public Uri starSource = new Uri(@"star.png", UriKind.Relative);
        public Uri emptyStarSource = new Uri(@"emptystar.png", UriKind.Relative);
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Rater(Image image)
        {
            switch (instance)
            {
                case 0:
                    {
                        image.Source = new BitmapImage(halfStarSource);
                        instance = 1;
                        break;
                    }
                case 1:
                    {
                        image.Source = new BitmapImage(starSource);
                        instance = 2;
                        break;
                    }
                case 2:
                    {
                        image.Source = new BitmapImage(emptyStarSource);
                        instance = 0;
                        break;
                    }
            }
        }
        private void Star1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string star = Star2.Source.ToString();
            string starSourcee = new BitmapImage(starSource).ToString();
            string halfStarSourcee = new BitmapImage(halfStarSource).ToString();
            if (star!=starSourcee||star==halfStarSourcee)
            {
                Star2.Source = new BitmapImage(emptyStarSource);
                Star3.Source = new BitmapImage(emptyStarSource);
                Star4.Source = new BitmapImage(emptyStarSource);
                Star5.Source = new BitmapImage(emptyStarSource);
            }
            Rater(Star1);

        }

        private void Star2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string star = Star3.Source.ToString();
            string starSourcee = new BitmapImage(starSource).ToString();
            string halfStarSourcee = new BitmapImage(halfStarSource).ToString();
            if (star != starSourcee || star == halfStarSourcee)
            {
                Star3.Source = new BitmapImage(emptyStarSource);
                Star4.Source = new BitmapImage(emptyStarSource);
                Star5.Source = new BitmapImage(emptyStarSource);
            }
            Star1.Source = new BitmapImage(starSource);
            Rater(Star2);
        }

        private void Star3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string star = Star4.Source.ToString();
            string starSourcee = new BitmapImage(starSource).ToString();
            string halfStarSourcee = new BitmapImage(halfStarSource).ToString();
            if (star != starSourcee || star == halfStarSourcee)
            {
                Star4.Source = new BitmapImage(emptyStarSource);
                Star5.Source = new BitmapImage(emptyStarSource);
            }

            Star1.Source = new BitmapImage(starSource);
            Star2.Source = new BitmapImage(starSource);
            Rater(Star3);
        }

        private void Star4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string star = Star5.Source.ToString();
            string starSourcee = new BitmapImage(starSource).ToString();
            string halfStarSourcee = new BitmapImage(halfStarSource).ToString();
            if (star != starSourcee || star == halfStarSourcee)
            {
                Star4.Source = new BitmapImage(emptyStarSource);
                Star5.Source = new BitmapImage(emptyStarSource);
            }
            Star1.Source = new BitmapImage(starSource);
            Star2.Source = new BitmapImage(starSource);
            Star3.Source = new BitmapImage(starSource);
            Rater(Star4);
        }

        private void Star5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Star1.Source = new BitmapImage(starSource);
            Star2.Source = new BitmapImage(starSource);
            Star3.Source = new BitmapImage(starSource);
            Star4.Source = new BitmapImage(starSource);
            Rater(Star5);
        }
    }
}
