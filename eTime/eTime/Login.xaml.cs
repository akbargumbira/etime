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
    public partial class Login : PhoneApplicationPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void wbLogin_LoadCompleted(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            string strLoweredAddress = e.Uri.OriginalString.ToLower();
            if (strLoweredAddress.StartsWith("http://www.facebook.com/connect/login_success.html?code="))
            {
                txtStatus.Text = "trying to retrieve access token";
                wbLogin.Navigate(HelperClasses.FBUri.GetTokenLoadUri(e.Uri.OriginalString.Substring(56)));
                return;
            }
            string strTest = wbLogin.SaveToString();
            if (strTest.Contains("access_token"))
            {
                int nPos = strTest.IndexOf("access_token");
                string strPart = strTest.Substring(nPos + 13);
                nPos = strPart.IndexOf("</PRE>");
                // removes expires
                nPos = strPart.IndexOf("&expires=");
                if (nPos != -1)
                {
                    strPart = strPart.Substring(0, nPos);
                }
                //strPart = strPart.Substring(0,nPos);
                App.AccessToken = strPart;
                txtStatus.Text = "Authenticated - you will redirect to eTime";
                txtError.Text = "OK";
                NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
                return;
            }
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
            wbLogin.Navigate(HelperClasses.FBUri.GetLoginUri());
        }


    }
}