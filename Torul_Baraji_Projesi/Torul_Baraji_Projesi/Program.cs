using Torul_Baraji_Projesi;

class Program
{
    public static void Main(string[] args)
    {
        string metin = "********************************\n" +
                        "*     Torul Barajı Projesi     *\n" +
                        "********************************\n";
        Console.WriteLine(metin);
        Console.WriteLine("Hangi işlemi yapmak istersiniz ?");

        Console.WriteLine("--------------------------------");

        string metin2 = "1) Sisteme yeni balık verisi eklemek\n"
            + "2) Sisteme yeni Araştırmacı verisi eklemek\n"
            + "3) Tuzaklardan canlı ses kaydı dinlemek\n"
            + "4) Veri analizi(var olan verileri görüntüleme işlemleri)\n";

        while (true)
        {
            Console.WriteLine(metin2);
            int a = Convert.ToInt16(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Balik yeniBalik = Balik_ekle.Yeni_balik();
                    break;

                case 2:
                    Arastirmaci_Ekle Arastirmaci_Ekle = new Arastirmaci_Ekle();
                    Arastirmaci_Ekle.araştırmacı_ekle();
                    break;

                case 3:
                    Canli_ses sesCalma = new Canli_ses();
                    sesCalma.Cal();
                    break;

                case 4:
                    Veri veri = new Veri();
                    veri.Veri_yonetimi();
                    break;

                default:
                    Console.WriteLine("Geçerli işlem giriniz");
                    break;
            }
            Console.WriteLine("Başka işlem yapmak istiyor musunuz?");
            if (Console.ReadLine().ToLower() != "evet") break;
        }
    }
}




