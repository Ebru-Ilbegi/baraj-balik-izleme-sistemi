using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torul_Baraji_Projesi
{
    // Araştırmacının tanımlamasının yapıldığı sınıf
    public class Araştırmacı
    {
        //kapsülleme işlemi yapılıyor , 
        private string isim;
        private string unvan;
        private string bolum;

        public Araştırmacı(string isim, string unvan, string bolum)
        {
            this.isim = isim;
            this.unvan = unvan;
            this.bolum = bolum;
        }

        //getter setter blokları ayarlanıyor
        //get ile değer alınıyor set ile değerler atanıyor 
        //value = isim isim için oluşturulan get , set de

        public string İsim
        {
            get { return isim; }
            set { isim = value; }
        }
        public string Unvan
        {
            get { return unvan; }
            set { unvan = value; } //Unvan = unvan gibi oldu 
        }
        public string Bolum
        {
            get { return bolum; }
            set { bolum = value; }
        }
        //kapsülleme yapıldı
    }

    // Araştırmacı ekleme işlemlerinin yapıldığı sınıf

    public class Arastirmaci_Ekle
    {
        public Araştırmacı araştırmacı_ekle()
        {
            Console.WriteLine("Araştırmacının ad ve soyad bilgilerini giriniz.");
            string İsim = Console.ReadLine();

            Console.WriteLine("Araştırmacının unvan bilgilerini giriniz.");
            string unvan = Console.ReadLine();

            Console.WriteLine("Araştırmacının bölüm bilgilerini giriniz.");
            string bolum = Console.ReadLine();
            
            //araştırmacı için nesne oluşturalım
            Araştırmacı ars = new Araştırmacı(İsim,unvan,bolum);

            // Bir dosyaya kayıt işlemi gerçekleştirelim

            string dosya_yolu = @"C:\Users\LENOVO\Desktop\okul_ödevleri\Torul_Baraji_Projesi\arastirmaci_bilgileri.csv";
            FileStream fs = new FileStream(dosya_yolu,FileMode.Append,FileAccess.Write);
            //dosyayı açıyoruz
            StreamWriter sw = new StreamWriter(fs);//burada bilgileri dosyaya ekliyoruz
            {
                sw.WriteLine($"{ars.Unvan} {ars.İsim} {ars.Bolum}");
            }

            sw.Close();//yazma işlemini durdurduk
            fs.Close();//dosyayı serbest bıraktık            
            return ars;
        }
    }

    public class Araştirmaci_goster : Okuma_islemi
    {
        public override void Okuma()
        {
            //verilerin kayitli olduğu dosyadan okuma işlemi yapılacak
            string dosya_yolu = @"C:\Users\LENOVO\Desktop\okul_ödevleri\Torul_Baraji_Projesi\arastirmaci_bilgileri.csv";
            FileStream fs = new FileStream(dosya_yolu,FileMode.Open,FileAccess.Read); //okuma işlemi için dosyayı açtık
            StreamReader sr = new StreamReader(fs); //dosyayı okuyoruz

            //okuma işleminde virgülsüz bir okuma olması için döngü
            string yazi;
            while ((yazi = sr.ReadLine()) != null )
            {
                string yazi_ = yazi.Replace(",", " ");
                Console.WriteLine(yazi_);
            }
            sr.Close();
            fs.Close();
           
        }
    }

}
