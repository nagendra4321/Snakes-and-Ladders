using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using snakes.Resources;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace snakes
{
    public partial class MainPage : PhoneApplicationPage
    {
        public int i, one = 0, two = 0;
        string[] img = { "1.png", "2.png", "3.png", "4.png", "5.png", "6.png" };
        string[] turn = { "Player 1 Turn Tap", "Player 2 Turn Tap" };
        string palyer1 = "plr1";
        string player2 = "plr2";
       
        BitmapImage bluebmp = new BitmapImage(new Uri("/Assets/Blue.png",UriKind.RelativeOrAbsolute));
        ImageBrush blue = new ImageBrush();
         BitmapImage greenbmp = new BitmapImage(new Uri("/Assets/Green.png",UriKind.RelativeOrAbsolute));
         ImageBrush green = new ImageBrush();
       

     //   BitmapImage orangebmp = new BitmapImage(new Uri("/Assets/Orange.png"));
        
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void PhoneApplicationPage_Loaded_1(object sender, RoutedEventArgs e)
        {
            blue.ImageSource=bluebmp;
            green.ImageSource=greenbmp;
            img1.Opacity = 100;


            if (lbturn.Text == "")
            {
                lbturn.Text = turn[0];
            }
        }

        private void lbturn_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            ContentPanelDice.Visibility = Visibility.Visible;
            ContentPanel.Visibility = Visibility.Collapsed;
            lbturn.Visibility = Visibility.Collapsed;
            Random ran = new Random();
            i = ran.Next(1, 7);
            switch (i)
            {
                case 1:
                    imgdice.Source = new BitmapImage(new Uri("/Assets/1.jpg", UriKind.RelativeOrAbsolute));
                    break;
                case 2:
                    imgdice.Source = new BitmapImage(new Uri("/Assets/2.jpg", UriKind.RelativeOrAbsolute));
                    break;
                case 3:
                    imgdice.Source = new BitmapImage(new Uri("/Assets/3.jpg", UriKind.RelativeOrAbsolute));
                    break;
                case 4:
                    imgdice.Source = new BitmapImage(new Uri("/Assets/4.jpg", UriKind.RelativeOrAbsolute));
                    break;
                case 5:
                    imgdice.Source = new BitmapImage(new Uri("/Assets/5.jpg", UriKind.RelativeOrAbsolute));
                    break;
                case 6:
                    imgdice.Source = new BitmapImage(new Uri("/Assets/6.jpg", UriKind.RelativeOrAbsolute));
                    break;
                default:
                    break;
            }
        }

        private void imgdice_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            ContentPanel.Visibility = Visibility.Visible;
            ContentPanelDice.Visibility = Visibility.Collapsed;
            lbturn.Visibility = Visibility.Visible;
            if (lbturn.Text == "Player 1 Turn Tap")
            {
                dellastplace(palyer1, one);
                one = position(one, i);
                place(palyer1, one, blue);
               snakesladders(one, palyer1, blue);
                if (one >= 36)
                {
                    MessageBox.Show("player 1 wins");
                    NavigationService.Navigate(new Uri("/Assets/retry.xaml", UriKind.RelativeOrAbsolute));
                }


            }
            if (lbturn.Text == "Player 2 Turn Tap")
            {
                dellastplace(player2, two);
                two = position(two, i);
                place(player2, two,green);
                snakesladders(two, player2,green);
                if (two >= 36)
                {
                    MessageBox.Show("player 2 wins");
                    NavigationService.Navigate(new Uri("/Assets/retry.xaml", UriKind.RelativeOrAbsolute));
                }


            }


            if (lbturn.Text == "Player 1 Turn Tap")
            {
                if (i == 6)
                {
                }
                else
                {
                    lbturn.Text = turn[1];
                }
            }

            else if (lbturn.Text == "Player 2 Turn Tap")
            {
                if (i == 6)
                {
                }
                else
                {
                    lbturn.Text = turn[0];
                }
            }


           
        }
        public int position(int plyr, int val)
        {
            plyr = plyr + val;
            return plyr;


        }
        public void place(string player, int val ,ImageBrush color)
        {
            if (val == 1)
            {
                
                pnt1.Background=color;
                pnt1.Opacity = 100;
            }
            else if (val == 2)
            {
                pnt2.Background = color;
                pnt2.Opacity = 100;
            }
            else if (val == 3)
            {
                pnt3.Background = color;
                pnt3.Opacity = 100;
            }
            else if (val == 4)
            {
                pnt4.Background = color;
                pnt4.Opacity = 100;
            }
            else if (val == 5)
            {
                pnt5.Background = color;
                pnt5.Opacity = 100;
            }
            else if (val == 6)
            {
                pnt6.Background = color;
                pnt6.Opacity = 100;
            }
            else if (val == 7)
            {
                pnt7.Background = color;
                pnt7.Opacity = 100;
            }
            else if (val == 8)
            {
                pnt8.Background = color;
                pnt8.Opacity = 100;
            }
            else if (val == 9)
            {
                pnt9.Background = color;
                pnt9.Opacity = 100;
            }
            else if (val == 10)
            {
                pnt10.Background = color;
                pnt10.Opacity = 100;
            }
            else if (val == 11)
            {
                pnt11.Background = color;
                pnt11.Opacity = 100;
            }
            else if (val == 12)
            {
                pnt12.Background = color;
                pnt12.Opacity = 100;
            }
            else if (val == 13)
            {
                pnt13.Background = color;
                pnt13.Opacity = 100;
            }
            else if (val == 14)
            {
                pnt14.Background = color;
                pnt14.Opacity = 100;
            }
            else if (val == 15)
            {
                pnt15.Background = color;
                pnt15.Opacity = 100;
            }
            else if (val == 16)
            {
                pnt16.Background = color;
                pnt16.Opacity = 100;
            }
            else if (val == 17)
            {
                pnt17.Background = color;
                pnt17.Opacity = 100;
            }
            else if (val == 18)
            {
                pnt18.Background = color;
                pnt18.Opacity = 100;
            }
            else if (val == 19)
            {
                pnt19.Background = color;
                pnt19.Opacity = 100;
            }
            else if (val == 20)
            {
                pnt20.Background = color;
                pnt20.Opacity = 100;
            }
            else if (val == 21)
            {
                pnt21.Background = color;
                pnt21.Opacity = 100;
            }
            else if (val == 22)
            {
                pnt22.Background = color;
                pnt22.Opacity = 100;
            }
            else if (val == 23)
            {
                pnt23.Background = color;
                pnt23.Opacity = 100;
            }
            else if (val == 24)
            {
                pnt24.Background = color;
                pnt24.Opacity = 100;
            }
            else if (val == 25)
            {
                pnt25.Background = color;
                pnt25.Opacity = 100;
            }
            else if (val == 26)
            {
                pnt26.Background = color;
                pnt26.Opacity = 100;
            }
            else if (val == 27)
            {
                pnt27.Background = color;
                pnt27.Opacity = 100;
            }
            else if (val == 28)
            {
                pnt28.Background = color;
                pnt28.Opacity = 100;
            }
            else if (val == 29)
            {
                pnt29.Background = color;
                pnt29.Opacity = 100;
            }
            else if (val == 30)
            {
                pnt30.Background = color;
                pnt30.Opacity = 100;
            }
            else if (val == 31)
            {
                pnt31.Background = color;
                pnt31.Opacity = 100;
            }
            else if (val == 32)
            {
                pnt32.Background = color;
                pnt32.Opacity = 100;
            }
            else if (val == 33)
            {
                pnt33.Background = color;
                pnt33.Opacity = 100;
            }
            else if (val == 34)
            {
                pnt34.Background = color;
                pnt34.Opacity = 100;
            }
            else if (val == 35)
            {
                pnt35.Background = color;
                pnt35.Opacity = 100;
            }
            else if (val == 36)
            {
                pnt36.Background = color;
                pnt36.Opacity = 100;
            }
        }
         public void dellastplace(string player,int val)
        {
            if (val == 1)
            {
                pnt1.Background = null;
                pnt1.Opacity = 0;
            }
            else if (val == 2)
            {
                pnt2.Background = null;
                pnt2.Opacity = 0;
            }
            else if (val == 3)
            {
                pnt3.Background = null;
                pnt3.Opacity = 0;
            }
            else if (val == 4)
            {
                pnt4.Background = null;
                pnt4.Opacity = 0;
            }
            else if (val == 5)
            {
                pnt5.Background = null;
                pnt5.Opacity = 0;
            }
            else if (val == 6)
            {
                pnt6.Background = null;
                pnt6.Opacity = 0;
            }
            else if (val == 7)
            {
                pnt7.Background = null;
                pnt7.Opacity = 0;
            }
            else if (val == 8)
            {
                pnt8.Background = null;
                pnt8.Opacity = 0;
            }
            else if (val == 9)
            {
                pnt9.Background = null;
                pnt9.Opacity = 0;
            }
            else if (val == 10)
            {
                pnt10.Background = null;
                pnt10.Opacity = 0;
            }
            else if (val == 11)
            {
                pnt11.Background = null;
                pnt11.Opacity = 0;
            }
            else if (val == 12)
            {
                pnt12.Background = null;
                pnt12.Opacity = 0;
            }
            else if (val == 13)
            {
                pnt13.Background = null;
                pnt13.Opacity = 0;
            }
            else if (val == 14)
            {
                pnt14.Background = null;
                pnt14.Opacity = 0;
            }
            else if (val == 15)
            {
                pnt15.Background = null;
                pnt15.Opacity = 0;
            }
            else if (val == 16)
            {
                pnt16.Background = null;
                pnt16.Opacity = 0;
            }
            else if (val == 17)
            {
                pnt17.Background = null;
                pnt17.Opacity = 0;
            }
            else if (val == 18)
            {
                pnt18.Background = null;
                pnt18.Opacity = 0;
            }
            else if (val == 19)
            {
                pnt19.Background = null;
                pnt19.Opacity = 0;
            }
            else if (val == 20)
            {
                pnt20.Background = null;
                pnt20.Opacity = 0;
            }
            else if (val == 21)
            {
                pnt21.Background = null;
                pnt21.Opacity = 0;
            }
            else if (val == 22)
            {
                pnt22.Background = null;
                pnt22.Opacity = 0;
            }
            else if (val == 23)
            {
                pnt23.Background = null;
                pnt23.Opacity = 0;
            }
            else if (val == 24)
            {
                pnt24.Background = null;
                pnt24.Opacity = 0;
            }
            else if (val == 25)
            {
                pnt25.Background = null;
                pnt25.Opacity = 0;
            }
            else if (val == 26)
            {
                pnt26.Background = null;
                pnt26.Opacity = 0;
            }
            else if (val == 27)
            {
                pnt27.Background = null;
                pnt27.Opacity = 0;
            }
            else if (val == 28)
            {
                pnt28.Background = null;
                pnt28.Opacity = 0;
            }
            else if (val == 29)
            {
                pnt29.Background = null;
                pnt29.Opacity = 0;
            }
            else if (val == 30)
            {
                pnt30.Background = null;
                pnt30.Opacity = 0;
            }
            else if (val == 31)
            {
                pnt31.Background = null;
                pnt31.Opacity = 0;
            }
            else if (val == 32)
            {
                pnt32.Background = null;
                pnt32.Opacity = 0;
            }
            else if (val == 33)
            {
                pnt33.Background = null;
                pnt33.Opacity = 0;
            }
            else if (val == 34)
            {
                pnt34.Background = null;
                pnt34.Opacity = 0;
            }

            else if (val == 35)
            {
                pnt35.Background = null;
                pnt35.Opacity = 0;
            }
            else if (val == 36)
            {
                pnt36.Background = null;
                pnt36.Opacity = 0;
            }
        }
         public void snakesladders(int val,string player,ImageBrush color)
        {
            switch (val)
            {
                case 17:
                    pnt17.Background = null;
                    pnt17.Opacity = 0;
                    pnt4.Background = color;
                    pnt4.Opacity = 100;
                    if (player=="plr1")
                    {
                        one = 4;
                    }
                    else
                    {
                        two = 4;
                    }
                    break;
                case 20:
                    pnt20.Background = null;
                    pnt20.Opacity = 0;
                    pnt6.Background = color;
                    pnt6.Opacity = 100;
                    if (player == "plr1")
                    {
                        one = 6;
                    }
                    else
                    {
                        two = 6;
                    }
                    break;
                case 24:
                    pnt24.Background = null;
                    pnt24.Opacity = 0;
                    pnt16.Background = color;
                    pnt16.Opacity = 100;
                    if (player == "plr1")
                    {
                        one = 16;
                    }
                    else
                    {
                        two = 16;
                    }
                    break;
                case 32:
                    pnt32.Background = null;
                    pnt32.Opacity = 0;
                    pnt30.Background = color;
                    pnt30.Opacity = 100;
                    if (player == "plr1")
                    {
                        one = 30;
                    }
                    else
                    {
                        two = 30;
                    }
                    break;
                case 34:
                    pnt34.Background = null;
                    pnt34.Opacity = 0;
                    pnt12.Background = color;
                    pnt12.Opacity = 100;
                    if (player == "plr1")
                    {
                        one = 12;
                    }
                    else
                    {
                        two = 12;
                    }
                    break;
                case 2:
                    pnt2.Background = null;
                    pnt2.Opacity = 0;
                    pnt15.Background = color;
                    pnt15.Opacity = 100;
                    if (player == "plr1")
                    {
                        one = 15;
                    }
                    else
                    {
                        two = 15;
                    }
                    break;
                case 5:
                    pnt5.Background = null;
                    pnt5.Opacity = 0;
                    pnt7.Background = color;
                    pnt7.Opacity = 100;
                    if (player == "plr1")
                    {
                        one = 7;
                    }
                    else
                    {
                        two = 7;
                    }
                    break;
                case 9:
                    pnt9.Background = null;
                    pnt9.Opacity = 0;
                    pnt27.Background = color;
                    pnt27.Opacity = 100;
                    if (player == "plr1")
                    {
                        one = 27;
                    }
                    else
                    {
                        two = 27;
                    }
                    break;
                case 18:
                    pnt18.Background = null;
                    pnt18.Opacity = 0;
                    pnt29.Background = color;
                    pnt29.Opacity = 100;
                    if (player == "plr1")
                    {
                        one = 29;
                    }
                    else
                    {
                        two = 29;
                    }
                    break;
                case 25:
                    pnt25.Background = null;
                    pnt25.Opacity = 0;
                    pnt35.Background = color;
                    pnt35.Opacity = 100;
                    if (player == "plr1")
                    {
                        one = 35;
                    }
                    else
                    {
                        two = 35;
                    }
                    break;
            }
        }
     
        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}