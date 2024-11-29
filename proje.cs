using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Öğrenci listesini oluştur
        List<string> ogrenciListe = new List<string> { "ahmet", "mehmet" };
        int ogrencisayi = ogrenciListe.Count; // Başlangıçta 2 öğrenci var

        Console.WriteLine("Geziye gelenler:");
        foreach (var ogrenci in ogrenciListe)
        {
            Console.WriteLine(ogrenci);
        }

        while (true)
        {
            Console.WriteLine("1 - Öğrenci ekle, 2 - Toplam öğrenci sayısını göster, 0 - Çıkış");
            int karar = 0;

            // Kullanıcıdan giriş al
            try
            {
                karar = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Geçersiz giriş! Lütfen bir sayı girin.");
                continue;
            }

            if (karar == 1)
            {
                Console.WriteLine("Yeni öğrencinin adını girin:");
                string ogrenciIsmi = Console.ReadLine();
                ogrenciListe.Add(ogrenciIsmi);
                ogrencisayi++;
                Console.WriteLine($"Öğrenci {ogrenciIsmi} eklendi.");
            }
            else if (karar == 2)
            {
                Console.WriteLine($"Toplam eklenen öğrenci sayısı: {ogrencisayi}");
            }
            else if (karar == 0)
            {
                // Döngüden çık
                break;
            }
            else
            {
                Console.WriteLine("Geçersiz seçenek. Lütfen tekrar deneyin.");
            }
        }

        // Araç kapasitesini sor
        Console.WriteLine("Araç kapasitesini girin:");
        int kapasite = 0;

        try
        {
            kapasite = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Geçersiz kapasite girdiniz.");
            return; // Hatalı giriş varsa programı sonlandır
        }

        // Kapasite kontrolü
        if (ogrencisayi <= kapasite)
        {
            Console.WriteLine($"Geziye katılacak {ogrencisayi} öğrenci var ve araç kapasitesi yeterli.");
        }
        else
        {
            Console.WriteLine($"Araç kapasitesi yeterli değil. {ogrencisayi} öğrenci var.");
        }
    }
}