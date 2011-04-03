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

        private void text1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.judul = "Montella Hanya Pikirkan Juve";
            App.isi = "Pelatih AS Roma, Vicenzo Montella, menegaskan, dirinya tak memikirkan masa depannya dan lebih memilih untuk fokus ke pertandingan melawan Juventus, Minggu (3/4/2011).\n\nNasib Montella memang diragukan setelah Thomas DiBenedetto mengambil alih kepemilikan klub itu dari keluarga Sensi. Ambisi DiBenedetto untuk mengangkat prestasi Roma tentu membuat posisi Montella terancam. Pastinya, DiBenedetto akan lebih suka memakai pelatih berpengalaman ketimbang Montella yang cuma \"anak bawang\".\n\nMenanggapi kemungkinan itu, Montella bergeming. Ia lebih suka memikirkan bagaimana caranya meraih kemenangan atas Juve dan membuat Roma kembali bersaing untuk jatah Liga Champions.\n\nSaat ini \"I Giallorossi\" berada di peringkat keenam dengan 50 poin. Mereka tertinggal 6 poin dari Udinese yang menempati peringkat keempat.\"Saya percaya pertandingan hari Minggu jauh lebih penting ketimbang membicarakan hal-hal lain sekarang. Saya berterima kasih kepada DiBenedetto untuk kata-kata baiknya, tetapi sekarang saya bertanggung jawab kepada mereka yang memperkerjakan saya sebagai pelatih,\" ujarnya.\n\n\"Saya tak berpikir masa depan saya, karena saya belum tentu bertahan meski tim berada di peringkat keempat atau dipecat karena menempati posisi kelima. Saya berusaha melakukan yang terbaik dan kemudain kita akan lihat,\" sambungnya.\n\nIa menambahkan, \"Tim telah dijauhkan dari masalah ini. Sebagian besar waktu mereka tersita oleh masalah kepemilikan. Saya senang akhirnya melihat tim berkonsentrasi pada tugas yang ada di depan mata.\"";
            NavigationService.Navigate(new Uri("/HeadlineDetails.xaml", UriKind.Relative));
        }

        private void text2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.judul = "Gmail Motion, April Mop ala \"Mbah\" Google";
            App.isi = "Mengenakan kaus biru berlogo Google, Paul McDonald memperkenalkan produk baru perusahaannya. Produk ini digadang-gadang mampu mempermudah umat manusia untuk berkirim dan membaca e-mail. Produk baru ini merupakan revolusi besar dalam berkirim surat di dunia maya. Kita akan semakin terbebas dari keyboard dan mouse. Google menamakannya Gmail Motion.\n\nGmail Motion merupakan layanan surat elektronik yang memungkinkan kita membuka, menulis, membalas, dan mengirim surat elektronik hanya dengan bahasa tubuh (body language). Cukup menggerak-gerakkan tubuh dengan gerakan tertentu, maka e-mail Anda telah dikirim.\n\nDibantu seorang stafnya, McDonald, Product Manager Google, memaparkan cara ber-e-mail menggunakan bahasa tubuh. Staf berkemeja putih itu lantas menggerakkan tangannya menyerupai orang tengah membuka amplop. Dalam sekejap, e-mail terbuka dan siap untuk dibaca.\n\nKalau ingin membalas surat, cukup sejajarkan jari jempol kanan dengan telinga lalu arahkan jempol ke belakang. Nah, jika ingin reply all, ulangi gerakan serupa untuk reply, tetapi kali ini dengan menggunakan dua jari jempol. Mudah bukan?\n\nGerakan yang agak sukar saat surat hendak dikirim. Gerakan yang akan dibaca oleh komputer yaitu tangan diusap di lidah, seperti orang mengelem amplop. Lalu diikuti dengan gerakan setengah duduk yang disertai kedua tangan dijulurkan ke depan, seperti memberi perintah untuk maju.\n\nTak hanya itu, Gmail Motion juga mampu menerjemahkan gerakan tubuh tertentu untuk menulis pesan. Ini yang agak susah. Google memang hendak memudahkan kita tanpa disibukkan dengan tuts-tuts di papan ketik dan mouse. Aplikasi ini mampu menerjemahkan isi pikiran user menjadi teks dalam e-mail. Sangat mudah bukan?\n\nUsai menyimak presentasi McDonald–yang diperkuat dengan komentar dua pakar–saya yang terkesima dengan produk baru ini langsung menekan tombol \"Try Gmail Motion\". Saya tak mau hanya mendengarkan kecanggihan Gmail Motion dari orang lain. Saya ingin merasakan sendiri pengalaman yang asyik ini.\n\nJika Anda ingin mencoba aplikasi teranyar dari Google ini, silakan berkunjung ke http://gmail.com/motion. Jangan lupa sediakan perangkat komputer/laptop/tablet yang terhubung dengan kamera (webcam). Saya yakin, Anda akan mengalami pengalaman unik seperti yang saya rasakan tadi. Selamat mencoba!!!\n\nOops, Google memang unik dalam memberikan kesegaran bagi pelanggannya di pembuka April ini. Inilah April Mop ala \"Mbah\" Google.";
            NavigationService.Navigate(new Uri("/HeadlineDetails.xaml", UriKind.Relative));
        }

        private void text3_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.judul = "Anjan Bantah Dimutasi karena Kasus Putri";
            App.isi = "Direktur Narkoba Polda Metro Jaya Komisaris Besar Anjan Pramuka Putra membantah bila mutasi dirinya sebagai penyidik di Bareskrim Mabes Polri terkait kasus cicit (alm) mantan Presiden Soeharto, Putri Aryanti Haryowibowo. Saat dihubungi wartawan, Anjan membenarkan bahwa dirinya akan dimutasi.\n\n\"Ya, saya sudah mendengarnya. Saya akan dipindah ke Bareskrim Polri. Sertijabnya kapan, saya belum tahu,\" kata Anjan, Sabtu (2/4/2011).\n\nAnjan mengatakan, penggeseran dirinya dari Direktur Narkoba Polda Metro Jaya menjadi penyidik pengawas Bareskrim Polri bukan karena sesuatu atau hal yang penting, apalagi terkait penangkapan Putri.\n\n\"Justru saya sedang dipromosikan. Karena kan untuk naik eselon ke brigjen ya harus melalui tahapan itu,\" ucapnya.\n\nSeperti diketahui, jajaran Direktorat Narkoba Polda Metro Jaya yang dipimpin Anjan berhasil menangkap tangan cicit (alm) mantan Presiden Soeharto, Putri Aryanti Haryowibowo, ketika sedang menggunakan sabu di sebuah hotel bersama seorang oknum polisi yang berdinas di Mabes Polri, AKBP ES.";
            NavigationService.Navigate(new Uri("/HeadlineDetails.xaml", UriKind.Relative));
        }

        private void text4_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.judul = "Miniatur Toko Apple Pun Jadi Bahan \"April Mop\"";
            App.isi = "Buat para fans Apple, segala yang berbau merek tersebut mungkin diburu. Beberapa waktu lalu, miniatur sosok CEO Apple Steve Jobs terjual mahal di eBay. Bagaimana kira-kira kalau ada miniatur Apple Store lengkap dengan sosok Steve Jobs dan orang-orang yang mengantre iPhone dan iPad?\n\nBisa terbayang, berapa banyak orang yang penasaran pengin memilikinya. Apalagi, jika harganya terjangkau. Satu set Apple Store Playset dari Playmobil yang ditawarkan di situs ThinkGeek dijual 179,99 dollar AS. Murah?\n\nLihat dulu apa saja yang ditawarkan. Playmobil menyediakan video khusus untuk mempromosikan mainan baru buatannya. Selain gambaran singkat, mainan tersebut juga berisi komentar dari para desainernya. Ide dasarnya memang dari kenyataan bahwa fans Apple sangat fanatik ingin memiliki segala hal yang berbau Apple.\n\nMainan tersebut terdiri dari sebuah miniatur toko dua lantai dengan ukuran 72 x 36 x 40 cm, sosok orang (figurine) termasuk Steve Jobs, dan lebih dari 60 aksesori. Miniatur-miniatur iMac, iPhone, dan iPad termasuk di dalamnya. Bahkan, iPhone 4 asli bisa diletakkan sebagai layar di belakang miniatur Steve Jobs saat memberikan keynote speech di salah satu ruangan.\n\nTertarik? Pilih satu set miniatur tersebut atau bisa juga membeli tambahan figurine seharga 49,99 dollar AS untuk menambah jumlah orang yang mengantre di luar miniatur toko. Pilih jumlah yang akan dibeli, lalu klik \"Buy Now\". Voila, yang keluar bukannya konfirmasi pemesanan produk telah berhasil. \"Gotcha, Happy April Fool's Day. This really never gets old....\"\n\nSayang sekali, mainan tersebut baru sekadar khayalan. Namun, dengan sosok yang terlihat nyata, bukan tidak mungkin para desainer di Playmobil benar-benar membuatnya. Tinggal apakah Apple akan memberikan lisensi untuk pembuatan dan penjualan mainan dengan mereknya. Ini mungkin masih mimpi Playmobil, tetapi bukan mustahil bisa diwujudkan.";
            NavigationService.Navigate(new Uri("/HeadlineDetails.xaml", UriKind.Relative));
        }

        private void text5_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.judul = "Hidayat Nur Wahid Pun Angkat Bicara";
            App.isi = "Berbagai opini terus bermunculan menyusul rencana pembangunan gedung baru DPR RI. Kali ini, mantan Ketua MPR Hidayat Nur Wahid angkat bicara.\n\n\"DPR sebagai wakil rakyat seharusnya mempunyai mekanisme berkomunikasi dengan masyarakat secara elegan sehingga kebijakan yang dihasilkan tidak menimbulkan kontroversi di tengah masyarakat,\" tutur politisi Partai Keadilan Sejatera itu seusai membuka Musyawarah Kerja Wilayah DPD PKS Jateng di Magelang, Sabtu (2/4/2011).\n\nMenurut Hidayat Nur Wahid, seharusnya DPR mendengar apa yang menjadi suara hati rakyat, termasuk terkait kebijakan rencana pembangunan gedung baru DPR itu.\n\n\"Yang pasti, rakyat inginkan kinerja wakil rakyat itu meningkat,\" katanya.";
            NavigationService.Navigate(new Uri("/HeadlineDetails.xaml", UriKind.Relative));
        }

        private void text6_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.judul = "Ben Prioritaskan Marshanda Lulus Kuliah";
            App.isi = "Pasangan pengantin baru, presenter yang juga bermain sinetron Ben Kasyafani (27) dan Andriani Marshanda (21) mengaku tak akan menunda untuk punya anak. Tapi, prioritas Ben, Marshanda lulus kuliah dulu.\n\n\"Menunda sih enggak. Segimana dikasih saja oleh Allah,\" kata Ben dalam jumpa pers usai pernikahannya, di Hotel Sofyan Betawi, Menteng, Jakarta Pusat, Sabtu (2/4/2011).\n\nSebelum mendapat momongan, harap Ben, istrinya, yang akrab disapa Caca, bisa lebih dulu menyelesaikan kuliahnya. \"Tapi, ada prioritas, kuliah Caca. Saya berharap Caca bisa menyelesaikan dulu kuliahnya,\" kata Ben.\n\nNamun, kalau toh di tengah jalan mereka dikaruniai anak, Ben dan Caca tak akan menolaknya. \"Ya, kalau di tengah jalan dapat momongan, kami akan bersyukur dan tidak akan menolaknya,\" tuntas Ben.";
            NavigationService.Navigate(new Uri("/HeadlineDetails.xaml", UriKind.Relative));
        }

        private void text7_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.judul = "Ditumbangkan Gijon, Madrid Jauhi Gelar";
            App.isi = "Tragis! Tampil di kandang sendiri, Stadion Santiago Bernabeu, dalam lanjutan Liga BBVA, Sabtu atau Minggu (3/4/2011) dini hari WIB, Real Madrid tumbang dan dipaksa menyerah 0-1.\n\nHasil ini membuat Madrid semakin jauh dari gelar juara. Meski tetap berada di peringkat kedua, tetapi jaraknya dari Barcelona yang memimpin klasemen bisa semakin jauh. Madrid baru mengoleksi 73 poin atau terpaut lima angka dari Barcelona. Jarak itu bisa semakin jauh jika Barcelona mampu mengalahkan Villarreal.\n\nPelatih Real Madrid, Jose Mourinho, terpaksa mengandalkan Emmanuel Adebayor dan Mesut Oezil di lini depan setelah Cristiano Ronaldo dan Karim Benzema cedera. Hal itu tidak mengurangi daya gempur tim tuan rumah.\n\nAngel Di Maria hampir mengoyak gawang Gijon pada menit keenam. Menguasai umpan dari Sami Khedira, Di Maria langsung melepaskan tembakan keras dari luar kotak penalti. Apes bagi Madrid, tembakan gelandang asal Argentina itu masih mampu diblok oleh kiper Juan Pablo Colinas.\n\nAdebayor juga sempat membukukan peluang emas pada menit ke-32. Berawal dari umpan silang yang dilepaskan Khedira, Adebayor menanduk bola ke tengah gawang. Namun, Colinas kembali sukses menyelamatkan gawangnya dengan menepis tandukan penyerang asal Togo itu.\n\nMadrid semakin penasaran. Iker Casillas dan kawan-kawan terus berusaha membongkar pertahanan tamunya. Apa daya, beberapa peluang yang tercipta gagal dimaksimalkan sehingga Madrid harus bermain imbang tanpa gol pada babak pertama.\n\nTak ingin kehilangan poin penuh, Mourinho melakukan perubahan di babak kedua. Pelatih asal Portugal itu memasukkan Gonzalo Higuain untuk mengganti Granero pada menit ke-57.\n\nBaru tiga menit berada di lapangan, Higuain nyaris membobol gawang Gijon. Peluang itu berawal dari umpan dari Di Maria. Kemudian, Higuan menggiring bola ke kotak penalti sebelum melepaskan tembakan keras. Apes, tembakan penyerang asal Argentina itu masih bisa dimentahkan oleh Colinas.\n\nPada menit ke-64, giliran Adebayor yang melepaskan ancaman lewat tandukannya. Sial bagi Madrid, tandukan mantan penyerang Arsenal itu masih melayang tinggi di atas mistar Colinas.\n\nDi saat usahanya belum membuahkan hasil, Madrid justru kebobolan. Pada menit ke-79, Miguel De Las Cuevas sukses menggetarkan gawang Madrid setelah memaksimalkan umpan yang dilepaskan Nacho Cases dari sayap kiri. Dari jarak agak jauh, dia melepaskan tendangan keras ke pojok kanan bawah gawang Madrid, tanpa bisa dihadang kiper Iker Casillas.\n\nMadrid langsung meningkatkan intensitas serangannya. Khedira nyaris mencetak gol balasan memanfaatkan kemelut di depan gawang. Tembakan gelandang asal Jerman itu mampu dimentahkan oleh Colinas. Setelah itu, mereka terus mengurung Gijon. Sayang, mereka gagal mencetak gol dan terpaksa tunduk di depan publiknya sendiri.\n\nSusunan Pemain\n\nReal Madrid: Iker Casillas; Ricardo Carvalho, Raúl Albiol, Álvaro Arbeloa (Pepe 70), Sergio Ramos; Sami Khedira, Lassana Diarra, Esteban Graneron (Gonzalo Higuain 57), Ángel Di María (Canales 70); Emmanuel Adebayor, Mesut Oezil\n\nSporting Gijon: Juan Pablo Colinas; Alberto Botía, Ivan Soto, Roberto Canella (Jose Angel 6), Alberto Ramos; Nacho Cases, Alberto Rivera, Miguel de las Cuevas, Nacho Novo; David Barral, André Castro (Sebastian Eguren 89) ";
            NavigationService.Navigate(new Uri("/HeadlineDetails.xaml", UriKind.Relative));
        }
    }
}