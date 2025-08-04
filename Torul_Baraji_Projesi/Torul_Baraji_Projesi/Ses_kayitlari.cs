using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using Torul_Baraji_Projesi;

namespace Torul_Baraji_Projesi
{
    //tuzaktan alınan ses kayıtları için bir sınıf oluşturuldu
    public class Ses_oynatıcı
    {
        public void Sesi_çal(string dosya_yolu)
        {
            var sesdosyası = new AudioFileReader(dosya_yolu); //ses dosyası okunuyor
            var cikis_ = new WaveOutEvent(); // ses çıkışı sağanıyor
            {
                cikis_.Init(sesdosyası); //nesne oluşturulup ses dosyası belirliyor
                cikis_.Play();
                Console.WriteLine("Ses Aktarılıyor ...");
                while (cikis_.PlaybackState == PlaybackState.Playing)
                {
                    System.Threading.Thread.Sleep(1000);
                }
            }
            Console.WriteLine("Ses dosyası başarıyla çalındı.");
        }
    }



    public class Ses_calinmasi
    {
        public void Ses_kayitlari()
        {
            Console.WriteLine("Tuzağı seçiniz (1-3).");
            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    string dosya_yolu1 = @"C:\Users\LENOVO\Desktop\okul_ödevleri\Torul_Baraji_Projesi\ses_kaydi_1.wave";
                    Ses_oynatıcı ses1 = new Ses_oynatıcı();
                    ses1.Sesi_çal(dosya_yolu1);
                    break;
                case 2:
                    string dosya_yolu2 = @"C:\Users\LENOVO\Desktop\okul_ödevleri\Torul_Baraji_Projesi\ses_kaydi_2.wave";
                    Ses_oynatıcı ses2 = new Ses_oynatıcı();
                    ses2.Sesi_çal(dosya_yolu2);
                    break;
                case 3:
                    string dosya_yolu3 = @"C:\Users\LENOVO\Desktop\okul_ödevleri\Torul_Baraji_Projesi\ses_kaydi_3.wave";
                    Ses_oynatıcı ses3 = new Ses_oynatıcı();
                    ses3.Sesi_çal(dosya_yolu3);
                    break;
                default:
                    Console.WriteLine("Tuzak kurulum aşamasında .");
                    break;
            }
        }
    }

    public class Canli_ses 
    {
        public void Cal()
        {
            string dosya_yolu2 = @"C:\Users\LENOVO\Desktop\okul_ödevleri\Torul_Baraji_Projesi\ses_kaydi_2.wave";
            Ses_oynatıcı ses2 = new Ses_oynatıcı();
            ses2.Sesi_çal(dosya_yolu2);
        }
    }

}