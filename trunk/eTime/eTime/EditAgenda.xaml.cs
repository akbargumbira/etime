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
    public partial class EditAgenda : PhoneApplicationPage
    {
        int intId = 0;
        AgendaModel agendaModel;

        public EditAgenda()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            // Get strId
            string strId = "";
            NavigationContext.QueryString.TryGetValue("id", out strId);

            // Conver string strId to int
            intId = 0;
            int.TryParse(strId, out intId);

            // Get agenda model
            agendaModel = Global.AGENDAS.Find(intId);

            // Set to View
            textBoxTitle.Text = agendaModel.Title;
            textBoxDesc.Text = agendaModel.Description;
            
            textBoxLocation.Text = agendaModel.Location;

            string value = "";
            if (NavigationContext.QueryString.TryGetValue("edit", out value))
            {
                if (value == "0")
                {
                    selectStartDate.Value = agendaModel.StartDate;
                    EventTimePickerStart.Value = agendaModel.StartTime;
                    selectEndDate.Value = agendaModel.EndDate;
                    EventTimePickerEnd.Value = agendaModel.EndTime;
                }   
            }
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
                // Not Valid
                MessageBox.Show("You haven't fill title or description or location");
            }
            else
            {
                // Edit
                agendaModel.Title = title;
                agendaModel.Description = description;
                agendaModel.StartDate = startDate;
                agendaModel.StartTime = startTime;
                agendaModel.EndDate = endDate;
                agendaModel.EndTime = endTime;
                agendaModel.Location = location;

                // Show message box
                MessageBox.Show("Your agenda has been edited.");

                NavigationService.GoBack();
            }
        }

        private void selectStartDate_ValueChanged(object sender, DateTimeValueChangedEventArgs e)
        {
            if (DateTime.Compare((DateTime)selectStartDate.Value, (DateTime)selectEndDate.Value) > 0)
            {
                selectEndDate.Value = selectStartDate.Value;
            }
        }

        private void selectEndDate_ValueChanged(object sender, DateTimeValueChangedEventArgs e)
        {
            if (DateTime.Compare((DateTime)selectStartDate.Value, (DateTime)selectEndDate.Value) > 0)
            {
                selectStartDate.Value = selectEndDate.Value;
            }
        }
    }
}