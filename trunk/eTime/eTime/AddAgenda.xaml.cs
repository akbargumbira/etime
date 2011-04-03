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
    public partial class AddAgenda : PhoneApplicationPage
    {
        public AddAgenda()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string title = textBoxTitle.Text;
            string description = textBoxDesc.Text;
            DateTime startDate = (DateTime)selectStartDate.Value;
            DateTime startTime = (DateTime)EventTimePickerStart.Value;
            DateTime endDate = (DateTime)selectEndDate.Value;
            DateTime endTime = (DateTime)EventTimePickerEnd.Value;
            string location = textBoxLocation.Text;
            if ((title == "") || (description == "") || (location == ""))
            {
                MessageBox.Show("You haven't fill title or description or location");
            }
            else
            {
                AgendaModel input = new AgendaModel();
                input.ID = Global.AGENDAS.Count;
                input.Title = title;
                input.Description = description;
                input.StartDate = startDate;
                input.StartTime = startTime;
                input.EndDate = endDate;
                input.EndTime = endTime;
                input.Location = location;

                Global.AGENDAS.Add(input);
                MessageBox.Show("Event have been added : \nTitle : " + title + "\n" + "Description : " + description + "\nStart Date : " + startDate.ToShortDateString() + "\n" + "Start Time : " + startTime.ToShortTimeString() + "\nEnd Date : " + endDate.ToShortDateString() + "\nEnd Time : " + endTime.ToShortTimeString() + "\nLocation : " + location);

                NavigationService.GoBack();
            }
        }
        
        //Contoh ambil value date ma time picker
        /* private void TimePickerStart_ValueChanged(object sender, DateTimeValueChangedEventArgs e)
        {
            var time = (DateTime) EventTimePickerStart.Value;
            MessageBox.Show(time.ToShortTimeString());
        }

        private void TimePickerEnd_ValueChanged(object sender, DateTimeValueChangedEventArgs e)
        {
            var time = (DateTime) EventTimePickerEnd.Value;
            MessageBox.Show(time.ToShortTimeString());
        } */

    }
}