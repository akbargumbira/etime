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
    public partial class HeadlineDetails : PhoneApplicationPage
    {
        public HeadlineDetails()
        {
            InitializeComponent();

            InlineCollection inlines = text1.Inlines;
            Run r = new Run();
            r.Text = App.judul;
            r.FontWeight = FontWeights.Bold;
            inlines.Add(r);
            inlines.Add(new LineBreak());
            r = new Run();
            r.Text = App.isi;
            inlines.Add(r);
        }
    }
}