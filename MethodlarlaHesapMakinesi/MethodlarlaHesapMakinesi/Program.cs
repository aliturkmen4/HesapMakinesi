using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodlarlaHesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Hesap Makinesi-----");
            Console.WriteLine("(1)Toplama-(2)Çıkarma-(3)Çarpma-(4)Bölme-(0)Çıkış");
            while (true)
            {
                char cevap = Console.ReadKey().KeyChar;
                Console.WriteLine("1.sayıyı giriniz: ");
                double sayi1 = double.Parse(Console.ReadLine());
                Console.WriteLine("2.sayıyı giriniz: ");
                double sayi2 = double.Parse(Console.ReadLine());
                
                if (cevap == '0' || cevap == '1' || cevap == '2' || cevap == '3' || cevap == '4')
                {
                    switch (cevap)
                    {
                        case '1':
                            Console.WriteLine(Toplama(sayi1, sayi2));
                            break;
                        case '2':
                            Console.WriteLine(Cıkarma(sayi1, sayi2));
                            break;
                        case '3':
                            Console.WriteLine(Carpma(sayi1, sayi2));
                            break;
                        case '4':
                            Console.WriteLine(Bolme(sayi1, sayi2));
                            break;
                          
                    }
                    if (cevap == '0')
                    {
                        Console.WriteLine("Çıkış yapılıyor...  ");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı bir giriş yaptınız!!");
                }
            }       
        }
        static double Toplama(double num1,double num2)
        {
            return num1 + num2;
        }
        static double Cıkarma(double num1, double num2)
        {
            if (num1 > num2)
            {
                return num1 - num2;
            }
            else if (num2>num1)
            {
                return num2 - num1;
            }
            else
            {
                return 0;
            }
        }
        static double Carpma(double num1, double num2)
        {
            return num1 * num2;
        }
        static double Bolme(double num1, double num2)
        {
            if (num1 > num2)
            {
                return num1 / num2;
            }
            else if (num2 > num1)
            {
                return num2 / num1;
            }
            else
            {
                return 1;
            }
        }
    }
}
