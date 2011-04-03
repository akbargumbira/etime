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
    public partial class AgendaList : PhoneApplicationPage
    {
        public AgendaList()
        {
            InitializeComponent();
        }

        void agenda_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Agenda agenda = (Agenda)sender;
            NavigationService.Navigate(new Uri("/DetailAgenda.xaml?id="+agenda.ID.ToString(), UriKind.Relative));
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            // Make empty
            stackPanelAgendas.Children.Clear();

            // Dapat data dari parameter
            string day = "";
            string month = "";
            string year = "";
            NavigationContext.QueryString.TryGetValue("day", out day);
            NavigationContext.QueryString.TryGetValue("month", out month);
            NavigationContext.QueryString.TryGetValue("year", out year);

            // data dari Global.Agendas diiterasi terus crate object Agenda
            AgendasModel result =  Global.AGENDAS.Find(int.Parse(day), int.Parse(month), int.Parse(year)); 
            for (int i = 0; i < result.Count; ++i)
            {
                Agenda agenda = new Agenda();
                // Add Content
                agenda.ID = result[i].ID;
                agenda.Title = result[i].Title;
                agenda.Description = result[i].Description;
                agenda.Start = result[i].StartDate.ToShortDateString() + " " + result[i].StartTime.ToShortTimeString();
                agenda.End = result[i].EndDate.ToShortDateString() + " " + result[i].EndTime.ToShortTimeString();
                agenda.Location = result[i].Location;

                // Add event handler
                agenda.MouseLeftButtonUp += new MouseButtonEventHandler(agenda_MouseLeftButtonUp);

                // Set margin
                agenda.Margin = new Thickness(0, 0, 0, 10);
                stackPanelAgendas.Children.Add(agenda);
            }
        }
    }
}