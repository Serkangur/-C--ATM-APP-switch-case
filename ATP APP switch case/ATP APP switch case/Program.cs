using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATP_APP_switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 1000;
            Console.WriteLine("Lütfen bir işlem seçiniz");
            Console.WriteLine("1 bakiye görüntüleme");
            Console.WriteLine("2 para çek");
            Console.WriteLine("3 para yatır");
            Console.WriteLine("4 çıkış yap");

            string secim = Console.ReadLine();
            switch (secim)
            {
                case "1":
                    Console.WriteLine("bakiyeniz=" + bakiye);
                    Console.ReadLine();
                    break;

                case "2":
                    Console.WriteLine("çekilecek tutarı giriniz");
                    int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                    if (cekilecek_tutar > bakiye)
                    {
                        Console.WriteLine("bakiyenizden fazla para çekemessiz bu kadar paran yok a");
                        Console.ReadLine();
                    }

                    else
                    {
                        Console.WriteLine("kalana bakiyeniz=" + (bakiye - cekilecek_tutar));
                        Console.ReadLine();
                    }
                    break;

                case "3":
                    Console.WriteLine("Yatırmal istediğiniz tutarı giriniz");
                    int yatirilicak_para = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("toplam bakiye= " + (yatirilicak_para + bakiye));
                    Console.ReadLine();
                    break;

                case "4":

                    Console.WriteLine("çıkış yapıldı");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("lütfen geçerli bir değer giriniz");
                    Console.ReadLine();
                    break;

            }

        }
    }
}
