using System;
using System.Drawing;
using System.Windows.Forms;

namespace TriviaGrupÖdev
{
    //PDF TE ŞIKLAR GÖZÜKMEDİĞİ İÇİN BU ŞEKİLDE HAZIRLANDI.
    public partial class Form2 : Form
    {
        int puan = 0;
        int countdown = 10; // Sayaç başlangıç değeri
        int bilm = 0;
        string u1 = "Doğru cevap! 30 puan kazandınız";
        string u2 = "Tebrikler";
        bool isButtonDSelected = false;
        bool isButtonASelected = false;
        bool isButtonBSelected = false;
        bool isButtonCSelected = false;

        public Form2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (countdown > 0)
            {
                countdown--; // Sayaç azalsın
                label_sure_sayi.Text = countdown.ToString(); // Label'da göster
            }
            else
            {
                timer1.Stop(); 
                var result = MessageBox.Show("Süre doldu! Bir sonraki soruya geçiliyor.", "Bilgi", MessageBoxButtons.OK);
                label_puan_sayi.Text = puan.ToString(); // Label'da göster
                if (result == DialogResult.OK)
                {
                    if (bilm == 0)
                    {
                        ResetTimer();
                        label_bilgi.Text = "Bir sınıftan nesne oluşturmak için hangi anahtar kelime\nkullanılır?";
                        button_a.Text = "A) class";
                        button_b.Text = "B) new";
                        button_c.Text = "C) object";
                        button_d.Text = "D) bilgi verilmemiş";
                        bilm = 1;
                        label_puan_sayi.Text = puan.ToString(); // Label'da göster
                    }
                    else if (bilm == 1)
                    {
                        label_puan_sayi.Text = puan.ToString(); // Label'da göster
                        ResetTimer();
                        label_bilgi.Text = "#C dilinde 'Garbage Collection' hangi işlevi yerine getirir?";
                        button_a.Text = "A) Belleği  boşaltmak";
                        button_b.Text = "B) Dosya yönetimi yapmak";
                        button_c.Text = "C) Hata ayıklamak";
                        button_d.Text = "D) Ağ iletişimini kontrol etmek";
                        bilm = 2;
                    }else if (bilm == 2)
                    {
                        label_puan_sayi.Text = puan.ToString(); // Label'da göster
                        ResetTimer();
                        label_bilgi.Text = "CCS'de yazı tipi boyutunu ayarlamak için hangi özellik\nkullanılır?";
                        button_a.Text = "A) font-style";
                        button_b.Text = "B) font-size";
                        button_c.Text = "C) text-size";
                        button_d.Text = "D) bilgi verilmemiş...";
                        u1 = "Tebrikler! Orta seviyeye ulaştınız. Sorular biraz daha zorlaşacak!";
                        u2 = "Zorluk Artıyor";
                        bilm = 3;
                    }
                    else if (bilm == 3)
                    {
                        label_puan_sayi.Text = puan.ToString(); // Label'da göster
                        ResetTimer();
                        label_bilgi.Text = "Bir CSS sınıfını seçmek için hangi sembol kullanılır?";
                        button_a.Text = "A) #";
                        button_b.Text = "B) .";
                        button_c.Text = "C) :";
                        button_d.Text = "D) bilgi verilmemiş...";
                        u1 = "Vay be! Zor seviyeye geldiniz. Artık çok daha dikkatli olmalısınız!";
                        u2 = "Zorluk Artıyor";
                        bilm = 4;
                    }else if (bilm == 4)
                    {
                        label_puan_sayi.Text = puan.ToString(); // Label'da göster
                        ResetTimer();
                        label_bilgi.Text = "C# dilinde 'nullable types' nedir?";
                        button_a.Text = "A) NULL değer";
                        button_b.Text = "B) bilgi verilmemiş...";
                        button_c.Text = "C) Nullable";
                        button_d.Text = "D) bilgi verilmemiş...";
                        u1 = "Tüm soruları tamamladınız!\n\nToplam Puanınız: " + puan + "\n\nHarika! Uzman seviyesinde bilgiye sahipsiniz. Daha karmaşık projeler" +
                            "\nüzerinde çalışarak deneyiminizi arttırabilirsiniz.";
                        u2 = "Sonuçlar";
                        label_puan_sayi.Text = puan.ToString(); // Label'da göster
                        bilm = 5;
                    }else if (bilm == 5)
                    {
                        label_puan_sayi.Text = puan.ToString(); // Label'da göster
                        label_bilgi.Text = "Trivia Tamamlandı!";
                        button_a.Text = "";
                        button_b.Text = "";
                        button_c.Text = "";
                        button_d.Text = "";
                        timer1.Stop();
                        u1 = "Tüm soruları tamamladınız!\n\nToplam Puanınız: " + puan + "\n\nHarika! Uzman seviyesinde bilgiye sahipsiniz. Daha karmaşık projeler" +
                            "\nüzerinde çalışarak deneyiminizi arttırabilirsiniz.";
                        u2 = "Sonuçlar";
                        label_puan_sayi.Text = puan.ToString(); // Label'da göster
                    }
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // 1 saniyelik aralık
            timer1.Start(); // Timer'ı başlat
            label_sure_sayi.Text = countdown.ToString(); // İlk değeri göster
        }

        private void button_d_Click(object sender, EventArgs e)
        {
            
            isButtonDSelected = true;
            button_d.BackColor = Color.Yellow;
        }

        private void button_a_Click(object sender, EventArgs e)
        {
            
            isButtonASelected = true;
            button_a.BackColor = Color.Yellow;
        }

        private void button_b_Click(object sender, EventArgs e)
        {
            
            isButtonBSelected = true;
            button_b.BackColor = Color.Yellow;
        }

        private void button_c_Click(object sender, EventArgs e)
        {
           
            isButtonCSelected = true;
            button_c.BackColor = Color.Yellow;
        }

        private void button_onay2_Click(object sender, EventArgs e)
        {
            if (isButtonDSelected)
            {
                ResetSelections();
                MessageBox.Show("Yanlış Cevap!", "Uyarı");
            }
            else if (isButtonASelected)
            {
                ResetSelections();
                MessageBox.Show("Yanlış Cevap!", "Uyarı");
            }
            else if (isButtonBSelected)
            {
                ResetSelections();
                timer1.Stop();
                var result = MessageBox.Show(u1, u2, MessageBoxButtons.OK);
                label_puan_sayi.Text = puan.ToString(); // Label'da göster
                if (result == DialogResult.OK)
                {
                    if(bilm == 0)
                    {
                        ResetTimer();
                        label_bilgi.Text = "Bir sınıftan nesne oluşturmak için hangi anahtar kelime\nkullanılır?";
                        button_a.Text = "A) class";
                        button_b.Text = "B) new";
                        button_c.Text = "C) object";
                        button_d.Text = "D) bilgi verilmemiş";
                        bilm = 1;
                        puan += 30; // Puanı artır
                        label_puan_sayi.Text = puan.ToString(); // Label'da göster
                    }
                    else if (bilm == 1)
                    {
                        puan += 30; // Puanı artır
                        label_puan_sayi.Text = puan.ToString(); // Label'da göster
                        ResetTimer();
                        label_bilgi.Text = "#C dilinde 'Garbage Collection' hangi işlevi yerine getirir?";
                        button_a.Text = "A) Belleği  boşaltmak";
                        button_b.Text = "B) Dosya yönetimi yapmak";
                        button_c.Text = "C) Hata ayıklamak";
                        button_d.Text = "D) Ağ iletişimini kontrol etmek";
                        bilm = 2;
                    }else if (bilm == 2)
                    {
                        puan += 30; // Puanı artır
                        label_puan_sayi.Text = puan.ToString(); // Label'da göster
                        ResetTimer();
                        label_bilgi.Text = "CCS'de yazı tipi boyutunu ayarlamak için hangi özellik\nkullanılır?";
                        button_a.Text = "A) font-style";
                        button_b.Text = "B) font-size";
                        button_c.Text = "C) text-size";
                        button_d.Text = "D) bilgi verilmemiş...";
                        u1 = "Tebrikler! Orta seviyeye ulaştınız. Sorular biraz daha zorlaşacak!";
                        u2 = "Zorluk Artıyor";
                        bilm = 3;
                    }else if (bilm == 3)
                    {
                        puan += 30; // Puanı artır
                        label_puan_sayi.Text = puan.ToString(); // Label'da göster
                        ResetTimer();
                        label_bilgi.Text = "Bir CSS sınıfını seçmek için hangi sembol kullanılır?";
                        button_a.Text = "A) #";
                        button_b.Text = "B) .";
                        button_c.Text = "C) :";
                        button_d.Text = "D) bilgi verilmemiş...";
                        u1 = "Vay be! Zor seviyeye geldiniz. Artık çok daha dikkatli olmalısınız!";
                        u2 = "Zorluk Artıyor";
                        bilm = 4;
                    }else if (bilm == 4)
                    {
                        puan += 30; // Puanı artır
                        ResetTimer();
                        label_bilgi.Text = "C# dilinde 'nullable types' nedir?";
                        button_a.Text = "A) NULL değer";
                        button_b.Text = "B) bilgi verilmemiş...";
                        button_c.Text = "C) Nullable";
                        button_d.Text = "D) bilgi verilmemiş...";
                        timer1.Stop();
                        u1 = "Tüm soruları tamamladınız!\n\nToplam Puanınız: "+puan+"\n\nHarika! Uzman seviyesinde bilgiye sahipsiniz. Daha karmaşık projeler" +
                            "\nüzerinde çalışarak deneyiminizi arttırabilirsiniz.";
                        u2 = "Sonuçlar";
                        bilm = 5;
                    }else if (bilm == 5)
                    {
                        label_puan_sayi.Text = puan.ToString(); // Label'da göster
                        label_bilgi.Text = "Trivia Tamamlandı!";
                        button_a.Text = "";
                        button_b.Text = "";
                        button_c.Text = "";
                        button_d.Text = "";
                        timer1.Stop();
                        u1 = "Tüm soruları tamamladınız!\n\nToplam Puanınız: " + puan + "\n\nHarika! Uzman seviyesinde bilgiye sahipsiniz. Daha karmaşık projeler" +
                            "\nüzerinde çalışarak deneyiminizi arttırabilirsiniz.";
                        u2 = "Sonuçlar";
                        button_onay2.Enabled = false;
                        label_sure.Text = "";
                        label_sure_sayi.Text = "";
                        label_puan_sayi.Text = puan.ToString(); // Label'da göster
                    }
                }
            }
            else if (isButtonCSelected)
            {
                ResetSelections();
                MessageBox.Show("Yanlış Cevap!", "Uyarı");
            }

        
        }

        private void ResetSelections()
        {
            isButtonASelected = false;
            isButtonBSelected = false;
            isButtonCSelected = false;
            isButtonDSelected = false;
            button_a.BackColor = Color.LightCyan;
            button_b.BackColor = Color.LightCyan;
            button_c.BackColor = Color.LightCyan;
            button_d.BackColor = Color.LightCyan;
        }
        private void ResetTimer()
        {
            countdown = 5;
            label_sure_sayi.Text = countdown.ToString(); // Label'da göster
            timer1.Stop(); // Timer'ı durdur
            timer1.Start(); // Timer'ı yeniden başlat
        }


    }
}
