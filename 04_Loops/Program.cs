using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //For(x;y;z)
            //x: başlangıç değeri
            //y: bitiş
            //z: artış-azalış

            //int i;
            //for(i=1;i<=5;i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 1;i<=20;i++)
            //{
            //    Console.WriteLine(i); ;
            //}

            //for(int i=3;i<=50;i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}


            #endregion

            #region For Döngüsü ile Karar Yapıları
            //for(int i=1;i<=100;i++)
            //{
            //    if(i%5==0)
            //    {
            //        Console.WriteLine(i);
            //    }    
            //}

            //ÖRN: 1-10 arasındaki sayıları toplama
            //int totalValue = 0;
            //for (int i = 1;i<=10;i++)
            //{
            //    totalValue += i;

            //}
            //Console.WriteLine(totalValue);

            //ÖRN: 1-20 arasındaki çift sayıların toplamı
            //int totalValue = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);

            //    }
            //}
            //Console.WriteLine("--------------");
            //Console.WriteLine(totalValue);

            // ÖRN: 1-50 arasında 7'ye tam bölünen kaç sayı olduğunu bulan program.
            //int count = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }

            //}
            //Console.WriteLine(count);

            //ÖRN: Bir bakteri türü her saatin sonunda kendini ikiye bölerek çoğaltmaktadır. Yeni oluşan bakteriler 2'ye bölünerek çoğalıyor. 24 saatin sonunda kaç bakteri olur?
            //int bacterium = 1;
            //for (int i = 1;i<=24;i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".Saat sonunda"+bacterium);
            //}
            #endregion

            #region While Döngüsü
            //while: şart sağlandığı müddetçe
            //while(Şart)
            //{
            //    (işlemler)
            //}

            // ÖRN: Ekrana 10 defa merhaba döngüler yazan program.
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba döngüler");
            //    i++;
            //}

            //ÖRN: 1-10 arasında 3'e tam bölünen sayıları bulan program.
            //int i = 1;
            //while (i<=10)
            //{
            //    if (i%3==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //ÖRN: 1 ile 10 arasındaki sayıların toplamını hesaplayan program.
            //int i = 1;
            //int sum = 0;
            //while(i<=10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);


            #endregion

            #region Örnek Sınav Sorusu
            //ÖRN: Klayyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.
            //456

            //Console.Write("Sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10; //sayının 10'a bölümünden kalan 1ler basamağını verir.
            //tens = (number % 100) / 10;
            //hundreds = number / 100;//sayıyı 100'e bölümünden kalan yüzler basamağını verir.


            //Console.WriteLine(ones + "-" + tens + "-" + hundreds);

            //sum = ones + tens + hundreds;

            //Console.WriteLine(sum);
            #endregion
            Console.Read();
        }
    }
}
