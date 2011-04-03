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
            String a = DateTime.Now.Date.ToLongDateString();
            int cut = 0;
            if (a == "Sunday" || a == "Monday" || a == "Friday")
            {
                cut = 6;
            }
            else if (a == "Tuesday")
            {
                cut = 7;
            }
            else
            {
                cut = 8;
            }
            day.Text = DateTime.Now.DayOfWeek.ToString().Substring(0,3);
            date.Text = DateTime.Now.Date.ToLongDateString().Substring(cut);

            AgendasModel current = Global.AGENDAS.Find(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            
        }

        void eventview_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            EventView eventview = (EventView)sender;
            NavigationService.Navigate(new Uri("/DetailAgenda.xaml?id=" + eventview.ID.ToString(), UriKind.Relative));
        }


        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            // Dapat data dari parameter

            EventViewContainer.Children.Clear();

            // data dari Global.Agendas diiterasi terus crate object Agenda
            AgendasModel result = Global.AGENDAS.Find(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);

            if (result.Count < 1)
            {

            }

            for (int i = 0; i < result.Count; ++i)
            {
                EventView eventview= new EventView();
                // Add Content
                eventview.Title = result[i].Title;
                eventview.Location = result[i].Location;
                eventview.ID = result[i].ID;

                // Add event handler
                eventview.MouseLeftButtonUp += new MouseButtonEventHandler(eventview_MouseLeftButtonUp);

                // Set margin
                eventview.Margin = new Thickness(0, 0, 0, 10);
                EventViewContainer.Children.Add(eventview);
            }
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

        private void PhoneApplicationPage_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        
    }
}