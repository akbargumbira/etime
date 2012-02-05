using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace eTime
{
    public class AgendasModel : List<AgendaModel> 
    {
        const string filename = "Agendas.xml";
        
        public AgendasModel Find(int day, int month, int year)
        {
            AgendasModel result = new AgendasModel();
            for (int i = 0; i < Global.AGENDAS.Count; ++i)
            {
                if ((Global.AGENDAS[i].StartDate.Day == day) && (Global.AGENDAS[i].StartDate.Month == month) && (Global.AGENDAS[i].StartDate.Year== year))
                {
                    result.Add(Global.AGENDAS[i]);
                }
            }

            return result;
        }

        public AgendasModel Find(DateTime dt)
        {
            AgendasModel result = new AgendasModel();
            for (int i = 0; i < Global.AGENDAS.Count; ++i)
            {
                if ((Global.AGENDAS[i].StartDate.Day == dt.Day) && (Global.AGENDAS[i].StartDate.Month == dt.Month) && (Global.AGENDAS[i].StartDate.Year == dt.Year))
                {
                    result.Add(Global.AGENDAS[i]);
                }
            }

            return result;
        }

        public AgendasModel FindTomorrow(DateTime dt)
        {
            AgendasModel result = new AgendasModel();

            dt = dt.AddDays(1);
            for (int i = 0; i < Global.AGENDAS.Count; ++i)
            {
                if ((Global.AGENDAS[i].StartDate.Day == dt.Day) && (Global.AGENDAS[i].StartDate.Month == dt.Month) && (Global.AGENDAS[i].StartDate.Year == dt.Year))
                {
                    result.Add(Global.AGENDAS[i]);
                }
            }

            return result;
        }

        

        public AgendasModel getNearestAgenda()
        {
            AgendasModel result = new AgendasModel();
            DateTime dtNow = DateTime.Now;
            for (int i = 0; i < Global.AGENDAS.Count; ++i)
            {
                if (Global.AGENDAS[i].isAfter(dtNow) == true)
                {
                    result.Add(Global.AGENDAS[i]);
                }
            }

            return result;
        }

        public AgendaModel Find(int id)
        {
            foreach (AgendaModel model in this)
            {
                if (model.ID == id)
                {
                    return model;
                }
            }

            return null;
        }

        public bool Remove(int id)
        {
            // Find
            AgendaModel agenda = Find(id);

            // Remove
            return this.Remove(agenda);
        }

        public void Save()
        {
            IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForApplication();
            IsolatedStorageFileStream stream = storage.CreateFile(filename);
            XmlSerializer xml = new XmlSerializer(GetType());
            xml.Serialize(stream, this);
            stream.Close();
            stream.Dispose();

        }
        public static AgendasModel Load()
        {
            IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForApplication();
            AgendasModel AgendasData;
            if (storage.FileExists(filename))
            {
                IsolatedStorageFileStream stream = storage.OpenFile("Agendas.xml", FileMode.Open);
                XmlSerializer xml = new XmlSerializer(typeof(AgendasModel));
                AgendasData = xml.Deserialize(stream) as AgendasModel;
                stream.Close();
                stream.Dispose();
            }
            else
            {
                AgendasData = new AgendasModel();
            }
            return AgendasData;
        }
        
    }
}
