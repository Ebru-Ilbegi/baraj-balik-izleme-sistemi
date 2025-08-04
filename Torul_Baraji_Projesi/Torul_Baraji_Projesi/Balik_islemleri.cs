using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torul_Baraji_Projesi
{
    public  class Balik
    {
        //Kapsülleme işlemi yapılıyor ve böylece kontrollu erişim sağlanıyor

        public int Kayit_numarasi { get; set; }
        public string Ad { get; set; }
        public DateTime Kayit_tarihi = DateTime.Now;
        public string Davranislari { get; set; }
        public string Mevsimsel_davranislari { get; set; }
    }


//Balık ekleme işleminin yapıldığı class


    public class Balik_ekle 
    {
        public static Balik Yeni_balik()
        {
            Balik yeni = new Balik();
            try 
            { 
            //Balık verileri kullanıcıdan alınıyor
            Console.WriteLine("Balığın kayıt numarasını girin");
            yeni.Kayit_numarasi = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Kayit numarası string olamaz");
                Environment.Exit(0); //programı kapatıyor hata aldığı için
            }

            try 
            { 
            Console.WriteLine("Balığın adını girin");
            yeni.Ad = Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Ad integer bir ifade olamaz");
                Environment.Exit(0);
            }

            try
            {
                Console.WriteLine("Balığın davranışlarını girin");
                yeni.Davranislari = Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Balığın davranışları string olmalı.");
                Environment.Exit(0);
            }

            try 
            { 
            Console.WriteLine("Balığın mevsimsel davranışlarını girin");
                yeni.Mevsimsel_davranislari = Console.ReadLine();
            }
            catch(FormatException)
            {
                Console.WriteLine("Mevsimsel davranışlar string olmalı.");
                Environment.Exit(0);
            }

            //Veri kaydını yapalım

            string dosya_yolu = @"C:\Users\LENOVO\Desktop\okul_ödevleri\Torul_Baraji_Projesi\balik_bilgileri.csv";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Append,FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            {
                sw.WriteLine($"{yeni.Kayit_numarasi} {yeni.Ad} {yeni.Davranislari} {yeni.Mevsimsel_davranislari} {yeni.Kayit_tarihi}");
            }
            sw.Close();
            fs.Close();

            return yeni;
        }
        
    }

//Eklene balıkların verilerinin okunduğu kısım

    public class Balik_goster : Okuma_islemi
    {
        public override void Okuma()
        {
            string dosya_yolu = @"C:\Users\LENOVO\Desktop\okul_ödevleri\Torul_Baraji_Projesi\balik_bilgileri.csv";
            FileStream fs = new FileStream(dosya_yolu,FileMode.Open,FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            
            string yazi ;
            while ((yazi = sw.ReadLine()) != null)
            {
                string duzgun_yazi = yazi.Replace(",", " ");
                Console.WriteLine(duzgun_yazi);
            }
            sw.Close();
            fs.Close();

        }
    }
}
