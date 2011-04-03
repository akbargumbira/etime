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

        public string Description
        {
            get { return textBlockDesc.Text; }
            set { textBlockDesc.Text = value; }
        }

        public string Location
        {
            get { return textBlockLocation.Text; }
            set { textBlockLocation.Text = value; }
        }

        public EventView()
        {
            InitializeComponent();
        }
    }
}
