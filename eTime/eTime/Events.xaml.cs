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

            //1
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

            //2
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

            //3
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

            //4
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            string title = "Bandung Soccer Fest 2011";
            string description = "Peringatan HUT PERSIB Bandung.";
            DateTime startDate = new DateTime(2011, 4, 1);
            DateTime startTime = new DateTime(2011, 4, 1, 9, 0, 0);
            DateTime endDate = new DateTime(2011, 4, 3);
            DateTime endTime = new DateTime(2011, 4, 3, 15, 0, 0);
            string location = "GOR Pajajaran Bandung, Jl. Pajajaran Bandung";
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
                MessageBox.Show("Event have been added");

            }

            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string title = "FRANCHISE & BUSINESS CONCEPT EXPO 2011";
            string description = "Pameran konsep bisnis dan info franchise.";
            DateTime startDate = new DateTime(2011, 4, 8);
            DateTime startTime = new DateTime(2011, 4, 8, 9, 0, 0);
            DateTime endDate = new DateTime(2011, 4, 10);
            DateTime endTime = new DateTime(2011, 4, 10, 15, 0, 0);
            string location = "Graha Manggala Siliwangi, Jl Aceh 66 Bandung";
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
                MessageBox.Show("Event have been added");

            }
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string title = "Pekan Kebudayaan Melayu ITB 2011";
            string description = "Mengenal lebih dalam kebudayaan Melayu Indonesia.";
            DateTime startDate = new DateTime(2011, 4, 11);
            DateTime startTime = new DateTime(2011, 4, 11, 9, 0, 0);
            DateTime endDate = new DateTime(2011, 4, 17);
            DateTime endTime = new DateTime(2011, 4, 17, 15, 0, 0);
            string location = "Kampus ITB dan SABUGA, Jl. Tamansari";
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
                MessageBox.Show("Event have been added");

            }
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string title = "Jabar Job Fair 2011";
            string description = "Pameran Bursa Kerja.";
            DateTime startDate = new DateTime(2011, 4, 13);
            DateTime startTime = new DateTime(2011, 4, 8, 9, 0, 0);
            DateTime endDate = new DateTime(2011, 4, 14);
            DateTime endTime = new DateTime(2011, 4, 10, 18, 0, 0);
            string location = "Gedung Landmark, Jl. Braga No. 129 Bandung";
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
                MessageBox.Show("Event have been added");

            }
            
        }
    }
}