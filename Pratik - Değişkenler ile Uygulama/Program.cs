using System.Xml.Linq;

class Program
{ 

         static void Main(string[] args)
    {
        long TC; 
        string StrAd;
        string StrSoyad;
        long TelNo;
        int yas;
        double İlkÜrün;
        double İkinciÜrün;

    //Telefon numarası ondalıksız bir sayısal veri olduğu için long , ürün fiyatları ondalıklı veriler olduğu için double kullanmayı tercih ettim. 
      


        Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz: ");

        Console.WriteLine("T.C. Kimlik Numaranızı Giriniz: ");
        string StrTc = Console.ReadLine();

        long.TryParse(StrTc, out TC);
        

        Console.WriteLine("Adınızı Giriniz: ");
          StrAd = Console.ReadLine();

        Console.WriteLine("Soyadınızı Giriniz: ");
         StrSoyad = Console.ReadLine();

        Console.WriteLine("Telefon Numaranızı Giriniz: ");

         string StrTelNo=Console.ReadLine();

         long.TryParse(StrTelNo, out TelNo);
        



        Console.WriteLine("Yaşınızı Giriniz: ");

        string Stryas = Console.ReadLine();

        int.TryParse(Stryas, out yas);
      

        Console.WriteLine("İlk aldığınız ürünün fiyatını giriniz: ");

        string StrİlkÜrün = Console.ReadLine();


        double.TryParse(StrİlkÜrün, out İlkÜrün);
        Console.WriteLine("İkinci aldığınız ürünün fiyatını giriniz: ");

        string StrİkinciÜrün = Console.ReadLine();

        double.TryParse(StrİkinciÜrün, out İkinciÜrün);
       

       
        
            Console.WriteLine($"\n {TC} Tc numaralı {StrAd} {StrSoyad} isimli kişi için kayıt oluşturulmuştur. \n {TelNo} telefon numarasına bildirim mesajı gönderilmiştir. \n {İlkÜrün+İkinciÜrün} toplam harcama karsiliği kazanilan 10% patika puanı miktarı -> {(İlkÜrün+İkinciÜrün)/10} TL'dir");
           
        





    }

    

}