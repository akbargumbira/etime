﻿using System;
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
            day.Text = DateTime.Now.DayOfWeek.ToString();
            date.Text = DateTime.Now.Date.ToLongDateString().Substring(cut);

            AgendasModel current = Global.AGENDAS.Find(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            
        }

        void eventview_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            AgendaView eventview = (AgendaView)sender;
            NavigationService.Navigate(new Uri("/DetailAgenda.xaml?id=" + eventview.ID.ToString(), UriKind.Relative));
        }


        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            // Dapat data dari parameter

            EventViewContainer.Children.Clear();

            // data dari Global.Agendas diiterasi terus crate object Agenda
            AgendasModel result = Global.AGENDAS.Find(DateTime.Now);

            if (result.Count < 1)
            {
                AgendaView agendaView = new AgendaView();
                agendaView.Title = "No Event";
                EventViewContainer.Children.Add(agendaView);
            }

            for (int i = 0; i < result.Count; ++i)
            {
                AgendaView agendaView= new AgendaView();
                TextBlock text = new TextBlock();
                text.Text = "Next Agenda";
                // Add Content
                agendaView.Title = result[i].Title;
                agendaView.Location = result[i].Location;
                agendaView.Start = result[i].EndDate.ToShortDateString() + "" + result[i].StartTime.ToShortTimeString();
                agendaView.End = result[i].EndDate.ToShortDateString() + " " + result[i].EndTime.ToShortTimeString();
                agendaView.ID = result[i].ID;

                // Add event handler
                agendaView.MouseLeftButtonUp += new MouseButtonEventHandler(eventview_MouseLeftButtonUp);

                // Set margin
                agendaView.Margin = new Thickness(0, 0, 0, 10);

                // Add
                EventViewContainer.Children.Add(agendaView);
            }


            EventViewContainer2.Children.Clear();

            // data dari Global.Agendas diiterasi terus crate object Agenda
            AgendasModel resultTomorrow = Global.AGENDAS.FindTomorrow(DateTime.Now);

            if (resultTomorrow.Count < 1)
            {
                AgendaView agendaView = new AgendaView();
                agendaView.Title = "No Event";
                EventViewContainer2.Children.Add(agendaView);
            }

            for (int i = 0; i < resultTomorrow.Count; ++i)
            {
                AgendaView agendaView = new AgendaView();
                // Add Content
                agendaView.Title = resultTomorrow[i].Title;
                agendaView.Location = resultTomorrow[i].Location;
                agendaView.Start = resultTomorrow[i].EndDate.ToShortDateString() + " " + resultTomorrow[i].StartTime.ToShortTimeString();
                agendaView.End = resultTomorrow[i].EndDate.ToShortDateString() + " " + resultTomorrow[i].EndTime.ToShortTimeString();
                agendaView.ID = resultTomorrow[i].ID;

                // Add event handler
                agendaView.MouseLeftButtonUp += new MouseButtonEventHandler(eventview_MouseLeftButtonUp);

                // Set margin
                agendaView.Margin = new Thickness(0, 0, 0, 10);

                // Add
                EventViewContainer2.Children.Add(agendaView);
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

        private void grid_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
        	Storyboard1.Begin();
        }

        private void grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //NavigationService.Navigate(new Uri("/Quark.xaml", UriKind.Relative));
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/About.xaml", UriKind.Relative));
        }

        
    }
}