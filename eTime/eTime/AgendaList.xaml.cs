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
            // Dapat data dari parameter

            // data dari Global.Agendas diiterasi terus crate object Agenda
            Agenda agenda = new Agenda();
            agenda.Title = "Hai";
            agenda.MouseLeftButtonUp += new MouseButtonEventHandler(agenda_MouseLeftButtonUp);

            stackPanelAgendas.Children.Add(agenda);
        }

        void agenda_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Agenda agenda = (Agenda)sender;
            NavigationService.Navigate(new Uri("/DetailAgenda.xaml?id=0", UriKind.Relative));
        }
    }
}