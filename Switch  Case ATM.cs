Console.WriteLine("ATM ye hoşgeldiniz");
Console.WriteLine("Lütfen Bir İşlem Seçiniz");
Console.WriteLine("1- Bakiye Görüntüle");
Console.WriteLine("2- Para çekme");
Console.WriteLine("3- Para Yatırma");
Console.WriteLine("4- Çıkış yapıldı");
int bakiye = 1000;

string secim = Console.ReadLine();

switch (secim)
{
    case "1":
        Console.WriteLine("Şuanki Bakiyeniz"+ bakiye);
        Console.ReadLine();
        break;

        case "2":
        Console.WriteLine("Çekmek İstediğiniz Tutarı Giriniz");
        int cekilecek_tutar =Convert.ToInt32(Console.ReadLine());
        if (cekilecek_tutar > bakiye)
        {
            Console.WriteLine("Yetersiz Bakiye");
        }
        else
        {
            Console.WriteLine("Yeni Bakiyeniz"+(bakiye-cekilecek_tutar));
            Console.ReadLine();
        }
        break;
        case "3":
        Console.WriteLine("Yatırmak istediğiniz Tutarı Giriniz");
        int Yatirilacak_tutar=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Yeni Bakiyeniz" + (bakiye + Yatirilacak_tutar));
        Console.ReadLine();
        break;
        case "4":
        Console.WriteLine("ATM den Çıkış Yapılıyor");
        Console.WriteLine("Çıkış Yapıldı İyi Günler...");
        break;
    default:
        Console.WriteLine("Lütfen Geçerli bir değer giriniz");
        break;

}
