using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace eTime
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            date.Text = DateTime.Now.Date.ToString();
            day.Text = DateTime.Now.DayOfWeek.ToString().Substring(0,3);
        }

        private void IconButtonCalendar_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Calendar.xaml", UriKind.Relative));
        }

        private void IconButtonAddAgenda_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/AddAgenda.xaml", UriKind.Relative));
        }

        private void IconButtonSetting_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Setting.xaml", UriKind.Relative));
        }

        private void BarMenuItemEvents_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Events.xaml", UriKind.Relative));
        }

        private void BarMenuItemHeadline_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Headlines.xaml", UriKind.Relative));
        }
    }
}