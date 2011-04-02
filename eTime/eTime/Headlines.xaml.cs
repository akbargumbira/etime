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
    public partial class Headlines : PhoneApplicationPage
    {
        public Headlines()
        {
            InitializeComponent();

            InlineCollection inlines = text1.Inlines;
            Run r = new Run();
            r.Text = "Montella Hanya Pikirkan Juve";
            r.FontWeight = FontWeights.Bold;
            inlines.Add(r);
            inlines.Add(new LineBreak());
            r = new Run();
            r.Text = "Pelatih AS Roma, Vicenzo Montella, menegaskan dirinya tak memikirkan masa depannya dan lebih memilih fokus ke pertandingan melawan Juventus, Minggu (3/4/2011).";
            inlines.Add(r);

            inlines = text2.Inlines;
            r = new Run();
            r.Text = "Gmail Motion, April Mop ala \"Mbah\" Google";
            r.FontWeight = FontWeights.Bold;
            inlines.Add(r);
            inlines.Add(new LineBreak());
            r = new Run();
            r.Text = "Mengenakan kaus biru berlogo Google, Paul McDonald memperkenalkan produk baru perusahaannya. Produk ini digadang-gadang mampu mempermudah umat manusia untuk ...";
            inlines.Add(r);

            inlines = text3.Inlines;
            r = new Run();
            r.Text = "Anjan Bantah Dimutasi karena Kasus Putri";
            r.FontWeight = FontWeights.Bold;
            inlines.Add(r);
            inlines.Add(new LineBreak());
            r = new Run();
            r.Text = "Direktur Narkoba Polda Metro Jaya, Komisaris Besar Polisi Anjan Pramuka Putra, membantah bila mutasi dirinya sebagai penyidik di Bareskrim Mabes Polri terkait kasus cicit (alm) mantan ...";
            inlines.Add(r);

            inlines = text4.Inlines;
            r = new Run();
            r.Text = "Miniatur Toko Apple Pun Jadi Bahan \"April Mop\"";
            r.FontWeight = FontWeights.Bold;
            inlines.Add(r);
            inlines.Add(new LineBreak());
            r = new Run();
            r.Text = "Buat para fans Apple, segala yang berbau merek tersebut mungkin diburu. Beberapa waktu lalu, miniatur sosok CEO Apple Steve Jobs terjual ...";
            inlines.Add(r);

            inlines = text5.Inlines;
            r = new Run();
            r.Text = "Hidayat Nur Wahid Pun Angkat Bicara";
            r.FontWeight = FontWeights.Bold;
            inlines.Add(r);
            inlines.Add(new LineBreak());
            r = new Run();
            r.Text = "Berbagai opini terus bermunculan menyusul rencana pembangunan gedung baru DPR RI. Kali ini, mantan Ketua MPR Hidayat Nur Wahid angkat bicara.";
            inlines.Add(r);

            inlines = text6.Inlines;
            r = new Run();
            r.Text = "Ben Prioritaskan Marshanda Lulus Kuliah";
            r.FontWeight = FontWeights.Bold;
            inlines.Add(r);
            inlines.Add(new LineBreak());
            r = new Run();
            r.Text = "Pasangan pengantin baru, presenter yang juga bermain sinetron Ben Kasyafani (27) dan Andriani Marshanda (21) mengaku tak akan menunda untuk punya anak. Tapi, prioritas Ben, Marshanda ...";
            inlines.Add(r);

            inlines = text7.Inlines;
            r = new Run();
            r.Text = "Ditumbangkan Gijon, Madrid Jauhi Gelar";
            r.FontWeight = FontWeights.Bold;
            inlines.Add(r);
            inlines.Add(new LineBreak());
            r = new Run();
            r.Text = "Tragis! Tampil di kandang sendiri, Stadion Santiago Bernabeu dalam lanjutan Liga BBVA, Sabtu atau Minggu (3/4/2011) dini hari WIB, Real Madrid tmbang dan dipaksa menyerah 0-1.";
            inlines.Add(r);
        }
    }
}