using System;

namespace MaasHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            

            try
            {
                Console.WriteLine("Lütfen adınızı giriniz : ");
                string Ad = Console.ReadLine();
                Console.WriteLine("\nÇalıştığınız saati giriniz: ");
                int saat = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nÇalıştığınız saatlik ücreti giriniz: ");
                int sUcret = Convert.ToInt32(Console.ReadLine());

                Maas calisan = new Maas(Ad, saat, sUcret);
                            
            }
            catch
            {
                Console.WriteLine("Verilere uygun değer girilmedi.\nSistem sonlandırılıyor...");
            }
            
        }
    }

    class Maas
    {
        public Maas(string adi, int calisilanSaat, int saatlikUcret)
        {
            int maas = calisilanSaat * saatlikUcret;
            Console.WriteLine("\nİsim: " + adi);
            Console.WriteLine("Aldığınız maaş: " + maas);
        }
        
    }
}
