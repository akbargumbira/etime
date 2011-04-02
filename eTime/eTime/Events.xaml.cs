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
    public partial class Events : PhoneApplicationPage
    {
        public Events()
        {
            InitializeComponent();

            InlineCollection inlines = text1.Inlines;
            Run r = new Run();
            r.Text = "Bandung Soccer Fest 2011";
            r.FontWeight = FontWeights.Bold;
            inlines.Add(r);
            inlines.Add(new LineBreak());
            r = new Run();
            r.Text = "Peringatan HUT PERSIB Bandung.";
            inlines.Add(r);
            inlines.Add(new LineBreak());
            r = new Run();
            r.Text = "@GOR Pajajaran Bandung, Jl. Pajajaran Bandung";
            inlines.Add(r);
            inlines.Add(new LineBreak());
            r = new Run();
            r.Text = "time: 09.00 WIB, 1 April 2011 - 3 April 2011";
            inlines.Add(r);

            inlines = text2.Inlines;
            r = new Run();
            r.Text = "FRANCHISE & BUSINESS CONCEPT EXPO 2011";
            r.FontWeight = FontWeights.Bold;
            inlines.Add(r);
            inlines.Add(new LineBreak());
            r = new Run();
            r.Text = "Pameran konsep bisnis dan info franchise.";
            inlines.Add(r);
            inlines.Add(new LineBreak());
            r = new Run();
            r.Text = "@Graha Manggala Siliwangi, Jl Aceh 66 Bandung";
            inlines.Add(r);
            inlines.Add(new LineBreak());
            r = new Run();
            r.Text = "time: 8 April 2011 - 10 April 2011";
            inlines.Add(r);

            inlines = text3.Inlines;
            r = new Run();
            r.Text = "Pekan Kebudayaan Melayu ITB 2011";
            r.FontWeight = FontWeights.Bold;
            inlines.Add(r);
            inlines.Add(new LineBreak());
            r = new Run();
            r.Text = "Mengenal lebih dalam kebudayaan Melayu Indonesia.";
            inlines.Add(r);
            inlines.Add(new LineBreak());
            r = new Run();
            r.Text = "@Kampus ITB dan SABUGA, Jl. Tamansari";
            inlines.Add(r);
            inlines.Add(new LineBreak());
            r = new Run();
            r.Text = "time: 11 April 2011 - 17 April 2011";
            inlines.Add(r);

            inlines = text4.Inlines;
            r = new Run();
            r.Text = "Jabar Job Fair 2011";
            r.FontWeight = FontWeights.Bold;
            inlines.Add(r);
            inlines.Add(new LineBreak());
            r = new Run();
            r.Text = "Pameran Bursa Kerja.";
            inlines.Add(r);
            inlines.Add(new LineBreak());
            r = new Run();
            r.Text = "@Gedung Landmark, Jl. Braga No. 129 Bandung";
            inlines.Add(r);
            inlines.Add(new LineBreak());
            r = new Run();
            r.Text = "time: 09.00 - 18.00 WIB, 13 April 2011 - 14 April 2011";
            inlines.Add(r);
        }
    }
}