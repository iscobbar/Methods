using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        //Q1: kullanıcıdan adsoyad tc ve yaş bilgilerini alan bir kayıt metodu tanımlayın. (out)
        //Q2: kullanıcıdan gelen bilgileri güncelleyen Güncelle metodunu tanımlayınız.(ref)
        //Q3: Kullanıcının bilgilerini ekrana yazdıran metod. Listele metodu.
        //Q4: Urunekle isimli metot aşağıdaki bilgiler ile bir ürün oluşturacak 
        //    urunadi - ürünaçıklaması - ürünfiyatı - ürünindirimyüzdesi
        //Q5: static double indirimli fiyat hesapla (ürün fiyati, ürün indirim yüzdesi) 
        //    yeni fiyatı hesaplayıp döndürsün 
        //    (ref ve out yok)
        //Q6: ürülistele isimli metot tüm bilgileri parametre olarak alıp bilgileri ekrana listelesin
        //    Void
        static void Main(string[] args)
        {
            string ad, soyad;
            byte yas;
            Console.WriteLine("kayıt olmak için alttaki bilgileri giriniz");
            Kayit(out ad, out soyad, out yas);
            Console.WriteLine("bilgileri güncellemek için alttaki bilgileri giriniz");
            Guncelle(ref ad, ref soyad, ref yas);
            Console.WriteLine("Kaydınızın son hali aşağıdaki gibidir");
            Listele(ad, soyad, yas);
            string urunad, urunacikla;
            double fiyat;
            byte indirim;
            urunekle(out urunad, out urunacikla, out fiyat, out indirim);
            fiyat = indirimlifiyathesapla(fiyat, indirim);
            Console.WriteLine("Ürün bilgileri aşağıdaki gibidir");
            urunliste(urunad, urunacikla, fiyat, indirim);



            Console.Read();
        }
        //Q1     
        static void Kayit(out string ad, out string soyad, out byte yas)
        {
            Console.WriteLine("Adınızı giriniz");
            Console.ReadLine();
            Console.WriteLine("Soyadınızı giriniz");
            Console.ReadLine();
            Console.WriteLine("Yaşınızı giriniz");
            yas = Convert.ToByte(Console.ReadLine());
        }
        //Q2
        static void Guncelle(ref string ad, ref string soyad, ref byte yas)
        {
            Console.WriteLine("Adınızı giriniz");
            Console.ReadLine();
            Console.WriteLine("Soyadınızı giriniz");
            Console.ReadLine();
            Console.WriteLine("Yaşınızı giriniz");
            Console.ReadLine();
        }
        //Q3
        static void Listele(string ad, string soyad, byte yas)
        {
            Console.WriteLine($"Kullancı Adı: {ad}");
            Console.WriteLine($"Kullancı Soyadı: {soyad}");
            Console.WriteLine($"Kullancı Yaşı: {yas}");
        }
        //Q4
        static void urunekle(out string urunad, out string urunacikla, out double fiyat, out byte indirim)
        {
            Console.WriteLine("Ürünün adını giriniz: ");
            urunad = Console.ReadLine();
            Console.WriteLine("Ürünün açıklamasını giriniz: ");
            urunacikla = Console.ReadLine();
            Console.WriteLine("Ürünün fiyatını giriniz: ");
            fiyat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ürünün indirimini giriniz: ");
            indirim = Convert.ToByte(Console.ReadLine());
        }
        //Q5
        static double indirimlifiyathesapla(double fiyat, double indirim)
        {
            double ind = fiyat - (fiyat * (indirim / 100));
            return ind;
        }
        //Q6
        static void urunliste(string urunad, string urunacikla, double fiyat, byte indirim)
        {
            Console.WriteLine($"Ürünün adı: {urunad}");
            Console.WriteLine($"Ürünün açıklaması: {urunacikla}");
            Console.WriteLine($"Ürünün fiyatı: {fiyat}");
            Console.WriteLine($"Ürünün indirim oranu: %{indirim}");
        }

    }
}