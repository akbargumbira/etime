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
using System.Diagnostics;

namespace eTime
{
    public partial class DetailAgenda : PhoneApplicationPage
    {
        private WebClient m_wcPostMessage;
        private HelperClasses.FBWallPost m_fbPost;

        public DetailAgenda()
        {
            InitializeComponent();
        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            if (m_wcPostMessage == null)
            {
                m_wcPostMessage = new WebClient();
                m_wcPostMessage.UploadStringCompleted += new UploadStringCompletedEventHandler(m_wcPostMessage_UploadStringCompleted);
            }
            try
            {
                m_wcPostMessage.UploadStringAsync(HelperClasses.FBUri.GetPostMessageUri(), "POST", m_fbPost.GetPostParameters(App.AccessToken));
            }
            catch (Exception eX)
            {
                UpdateUIStatus("Post to wall failed", eX.Message);
            }
        }

        private string CreateMessage()
        {
            string strMessage = "Saya akan melakukan " + textBlockTitle.Text + " dimulai jam " + textBlockStartTime.Text + " tanggal " + textBlockStartDate.Text + " sampai jam " + textBlockEndTime.Text + " tanggal " + textBlockEndDate.Text + " Di " + textBlockLocation.Text;
            return strMessage;
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            string strMessage = CreateMessage();
            m_fbPost = new HelperClasses.FBWallPost(strMessage);
            //m_fbPost = new HelperClasses.FBWallPost(true);
        }

        void m_wcPostMessage_UploadStringCompleted(object sender, UploadStringCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                UpdateUIStatus("Error posting message", e.Error.Message);
                return;
            }
            try
            {
                UpdateUIStatus("Berhasil Posting ke Wall", e.Result);
            }
            catch (Exception eX)
            {
                UpdateUIStatus("Error handling post result", eX.Message);
            }
        }

        private void UpdateUIStatus(string strStatus, string strError)
        {
            txtStatus.Text = strStatus;
            //txtError.Text = strError;
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            // Dapat data dari parameter
            string ID = "";
            NavigationContext.QueryString.TryGetValue("id", out ID);
            
            // data dari Global.Agendas diiterasi terus crate object Agenda
            AgendaModel thisAgenda = Global.AGENDAS[Convert.ToInt32(ID)];
            textBlockTitle.Text = thisAgenda.Title;
            textBlockDesc.Text = thisAgenda.Description;
            textBlockStartDate.Text = thisAgenda.StartDate.ToShortDateString();
            textBlockStartTime.Text = thisAgenda.StartTime.ToShortTimeString();
            textBlockEndDate.Text = thisAgenda.EndDate.ToShortDateString();
            textBlockEndTime.Text = thisAgenda.EndTime.ToShortTimeString();
            textBlockLocation.Text = thisAgenda.Location;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = 0;
            Global.AGENDAS.RemoveAt(id);
        }

    }
}