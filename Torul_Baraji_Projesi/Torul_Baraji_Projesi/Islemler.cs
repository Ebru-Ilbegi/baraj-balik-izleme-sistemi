using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torul_Baraji_Projesi
{
    //abstract class ile okuma işlemi yapıldı
    public abstract class Okuma_islemi
    {
        public void oku()
        {
            Console.WriteLine("Dosya okunuyor ...");
        }
        public abstract void Okuma();
    }


}
