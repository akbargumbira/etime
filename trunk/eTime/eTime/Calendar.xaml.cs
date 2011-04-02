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
    public partial class Calendar : PhoneApplicationPage
    {
        public Calendar()
        {
            InitializeComponent();
        }

        private void BarIconButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/AddAgenda.xaml", UriKind.Relative));
        }

        private void Date_Click(object sender, MouseButtonEventArgs e)
        {
            
        }
    }
}