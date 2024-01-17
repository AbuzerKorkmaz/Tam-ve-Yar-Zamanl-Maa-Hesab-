namespace Teori43
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GirisMesajı();
            Console.WriteLine("Tam zamanlı çalışan mısınız? E/H");
            string cevap=Console.ReadLine();
            Console.WriteLine("Bu ayki  Maaşınız : " + HesapSonucu(cevap) );

        }

        static void GirisMesajı()
        {
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("               Maas hesaplamak Uygulamasına hoşgeldiiz");
            Console.WriteLine("**************************************************************************");
        }
        static double HesapSonucu(string EH)
        {
            double totalUcret = 0;
            if (EH == "E")
            {
                Console.WriteLine("Toplam Yaptığınız Satiş Miktarı Giriniz :  ");
                double tutar = Convert.ToDouble(Console.ReadLine());
                totalUcret = TamZamanlıPrimHesapla(tutar);

            }
            else if (EH == "H")
            {
                Console.WriteLine("Toplam Yaptığınız Satiş Miktarı Giriniz :  ");
                double tutarYariZaman = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Saatlik Çalışma Miktarı Giriniz :  ");
                double saat = Convert.ToDouble(Console.ReadLine());
                totalUcret = YariZamanliPrimHesapla(tutarYariZaman, saat);
            }
            return totalUcret;
        }
        static double TamZamanlıPrimHesapla(double satisMiktari)
        {
            double Pirim;
            double temelMaas = 20000;
            if (satisMiktari < 100000) Pirim= satisMiktari * 1.01;
            else if (satisMiktari >= 100000 && satisMiktari < 250000) Pirim= satisMiktari * 1.02;
            else return Pirim= satisMiktari * 1.03;
            return temelMaas + Pirim;

        }
        static double  YariZamanliPrimHesapla(double satisTutari,double calismaSaati)
        {
            double Pirim;
            double saatlikUcret = 100;
            Pirim=satisTutari * 1.01;
            return Pirim + saatlikUcret * calismaSaati;
        }

      
    }
}