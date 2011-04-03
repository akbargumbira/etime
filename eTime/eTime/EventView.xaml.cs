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

namespace eTime
{
    public partial class EventView : UserControl
    {
        public string Title
        {
            get { return textBlockTitle.Text; }
            set { textBlockTitle.Text = value; }
        }

        public string Location
        {
            get { return textBlockLocation.Text; }
            set { textBlockLocation.Text = "di " + value; }
        }

        public string Start
        {
            get { return textBlockStart.Text; }
            set { textBlockStart.Text = "mulai " + value; }
        }

        public string End
        {
            get { return textBlockEnd.Text; }
            set { textBlockEnd.Text = "sampai " + value; }
        }

        public int ID;

        public EventView()
        {
            InitializeComponent();
        }
    }
}
