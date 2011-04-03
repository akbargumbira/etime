using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;

namespace eTime
{
    public class AgendasModel : List<AgendaModel>
    {
        public AgendasModel Find(int day, int month, int year)
        {
            AgendasModel result = new AgendasModel();
            for (int i = 0; i < Global.AGENDAS.Count; ++i)
            {
                if ((Global.AGENDAS[i].StartTime.Day == day) && (Global.AGENDAS[i].StartTime.Month == month) && (Global.AGENDAS[i].StartTime.Year== year))
                {
                    result.Add(Global.AGENDAS[i]);
                }
            }

            return result;
        }
    }
}
