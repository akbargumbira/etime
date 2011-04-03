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
    public partial class AgendaView : UserControl
    {
        public string Title
        {
            get { return textBlockTitle.Text; }
            set { textBlockTitle.Text = value; }
        }

        private string location;
        public string Location
        {
            get { return location; }
            set { location = value; Render(); }
        }

        private string start;
        public string Start
        {
            get { return start; }
            set { start = value; Render(); }
        }

        private string end;
        public string End
        {
            get { return end; }
            set { end = value; Render(); }
        }

        public int ID;

        public AgendaView()
        {
            InitializeComponent();
        }

        public void Render()
        {
            textBlockContent.Text = "@" + location + " from " + start + " until " + end + ".";
        }
    }
}
