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
    public partial class Quark : PhoneApplicationPage
    {
        public Quark()
        {
            InitializeComponent();
            textBlock2.Text = "Every eTime's user has his/her own quark value. It is recalculated every action that you do.";
            textBlock2.Text += "\nYou can exchange your quark to get : ";
            textBlock2.Text += "\n- new themes";
            textBlock2.Text += "\n- new emot icons";
            textBlock2.Text += "\n- etc";
        }
    }
}