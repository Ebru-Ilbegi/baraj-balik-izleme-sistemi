using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torul_Baraji_Projesi
{
    public class Veri
    {
        public void Veri_yonetimi()
        {
            Console.WriteLine("Yapmak istediğiniz işlemi seçin");
            string metin = "1 - Kayıtlı balıkları görüntülemek\n" + "2 - Kayıtlı araştırmacıları görüntülemek\n" + "3 - Sistemde kayıtlı olan ses kayıtlarını dinlemek";
            Console.WriteLine(metin);
            int a = Convert.ToInt16(Console.ReadLine());

            switch(a)
            {
                case 1:
                    Console.WriteLine("Balıklar gösteriliyor...");
                    Balik_goster balik_Goster = new Balik_goster();
                    balik_Goster.Okuma();
                    break;

                case 2:
                    Araştirmaci_goster araştirmaci_= new Araştirmaci_goster();
                    araştirmaci_.Okuma();
                    break;
                case 3:
                    Ses_calinmasi ses = new Ses_calinmasi();
                    ses.Ses_kayitlari();
                    break;
                default:
                    Console.WriteLine("Geçerli bir işlem seçiniz.");
                    break;
            }
        }
    }
}
