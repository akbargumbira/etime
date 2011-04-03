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


        protected void tes(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            // Dapat data dari parameter
            string day = "";
            string month = "";
            string year = "";
            NavigationContext.QueryString.TryGetValue("day", out day);
            NavigationContext.QueryString.TryGetValue("month", out month);
            NavigationContext.QueryString.TryGetValue("year", out year);

            // data dari Global.Agendas diiterasi terus crate object Agenda
            AgendasModel result = Global.AGENDAS.Find(Convert.ToInt32(day), Convert.ToInt32(month), Convert.ToInt32(year));
            for (int i = 0; i < result.Count; ++i)
            {
                Agenda agenda = new Agenda();
                // Add Content
                agenda.Title = result[i].Title;
                agenda.Description = result[i].Description;
                agenda.Start = result[i].StartDate.ToShortDateString() + " " + result[i].StartTime.ToShortTimeString();
                agenda.End = result[i].EndDate.ToShortDateString() + " " + result[i].EndTime.ToShortTimeString();
                agenda.Location = result[i].Location;

                // Add event handler
                //agenda.MouseLeftButtonUp += new MouseButtonEventHandler(agenda_MouseLeftButtonUp);

                // Set margin
                agenda.Margin = new Thickness(0, 0, 0, 10);
                //stackPanelAgendas.Children.Add(agenda);
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
    }
}