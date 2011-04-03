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
    public partial class Calendar : PhoneApplicationPage
    {
        public static string[] MONTHS = { 
                                                  "January", "February", "March", "April", "May", "Juni",
                                                  "July", "August", "September", "October","November", "December"
                                        };

        public static string[] DAYS = {
                                          "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"
                                      };

        DateTime now;
        int month;
        int year;
        List<TextBlock> textBlockDates;
        
        public Calendar()
        {
            InitializeComponent();
            InitCalendar();
        }

        private void RenderCalendar()
        {
            // Render year and month
            RenderYear();
            RenderMonth();

            // Render Calendar Grid
            RenderGridCalendar();
        }

        private void RenderMonth()
        {
            textBlockMonth.Text = MONTHS[month];
        }

        private void RenderYear()
        {
            textBlockYear.Text = year.ToString();
        }

        private void RenderGridCalendar()
        {
            // Init
            DateTime tmp = new DateTime(year, month + 1, 1);
            DayOfWeek dow = new DayOfWeek();
            TextBlock tb = null;
            int i = 0;

            // Define first day in first week
            dow = tmp.DayOfWeek;
            int div = dow - DayOfWeek.Monday + 1;
            Console.WriteLine(div);
            tmp = tmp.Subtract(new TimeSpan(div, 0, 0, 0));

            // Render Non active dates in first week
            for (i = 0; i < div; ++i)
            {
                tb = textBlockDates[i];
                tb.Foreground = new SolidColorBrush(Colors.Gray);
                tb.Text = tmp.Day.ToString();
                tmp = tmp.AddDays(1);
            }

            // Render Dates
            while (tmp.Month <= month + 1 && tmp.Year <= year)
            {
                tb = textBlockDates[i];
                tb.Text = tmp.Day.ToString();

                // Set highlight
                if (Global.AGENDAS.Find(tmp.Day, tmp.Month, tmp.Year).Count > 0)
                {
                    tb.FontSize = 40;
                    tb.FontWeight = FontWeights.Bold;
                    tb.Foreground = new SolidColorBrush(Colors.Red);
                }
                else
                {
                    tb.FontSize = 30;
                    tb.FontWeight = FontWeights.Normal;
                    tb.Foreground = new SolidColorBrush(Colors.White);
                }

                tmp = tmp.AddDays(1);
                ++i;
            }

            // Render non active dates in last week
            while (i < 42)
            {
                tb = textBlockDates[i];
                tb.Foreground = new SolidColorBrush(Colors.Gray);
                tb.Text = tmp.Day.ToString();
                tmp = tmp.AddDays(1);
                ++i;
            }
        }

        private void InitCalendar()
        {
            textBlockDates = new List<TextBlock>();
            TextBlock tb;
            Border border = new Border();
            int i;

            // Border brush
            Brush brush = new SolidColorBrush(Colors.White);

            // Border thicknessBorder
            Thickness thicknessBorder = new Thickness(1);

            // Margin thicknessMargin
            Thickness thicknessMargin = new Thickness(2, 0, 0, 0);

            // Create grid element
            for (i = 0; i < 7; ++i)
            {
                for (int j = 0; j < 7; ++j)
                {
                    // Create new border
                    border = new Border();

                    // Create new text block
                    tb = new TextBlock();

                    // Set column and row
                    border.SetValue(Grid.ColumnProperty, j);
                    border.SetValue(Grid.RowProperty, i);

                    // Set border brush
                    border.BorderBrush = brush;

                    if (i == 0)
                    {
                        // Set header
                        tb.Text = DAYS[j];
                    }

                    // Add to border
                    border.Child = tb;
                    
                    // Add to Calendar
                    gridCalendar.Children.Add(border);

                    if (i > 0)
                    {
                        // Set Margin
                        tb.Margin = thicknessMargin;

                        // Add Event Handler
                        tb.MouseLeftButtonUp += new MouseButtonEventHandler(tb_MouseLeftButtonUp);

                        // Set border thicknessBorder
                        border.BorderThickness = thicknessBorder;

                        // Add To list;
                        textBlockDates.Add(tb);
                    }
                }
            }

            // Set current month and year
            now = DateTime.Now;
            month = now.Month - 1;
            year = now.Year;
        }

        void tb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            TextBlock tb = (TextBlock)sender;
            string uri = "/AgendaList.xaml?day=" + tb.Text + "&month=" + (month + 1) + "&year=" + year;
            NavigationService.Navigate(new Uri(uri, UriKind.Relative));
        }

        private void BarIconButton_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/AddAgenda.xaml", UriKind.Relative));
        }

        private void textBlockPrevYear_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            DecYear();
            RenderCalendar();
        }

        private void DecYear()
        {
            --year;
            if (year < 0)
            {
                year = 0;
            }
        }

        private void textBlockNextYear_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ++year;
            RenderCalendar();
        }

        private void textBlockNextMonth_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            month = (month + 1) % MONTHS.Length;
            if (month == 0)
            {
                // Next Year
                ++year;
            }

            RenderCalendar();
        }

        private void textBlockPrevMonth_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            month = (MONTHS.Length + month - 1) % MONTHS.Length;
            if (month == MONTHS.Length - 1)
            {
                // Prev Year
                DecYear();
            }
            RenderCalendar();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            // Render Calendar grid
            RenderCalendar();
        }
    }
}