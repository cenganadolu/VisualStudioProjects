using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finding_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int yuzler;
            int onlar;
            int birler;

            Program program = new Program();
            //yüzler basamağı üretildi
            yuzler = program.number_random(0);
            while (yuzler == 0)
            {

                yuzler = program.number_random(0);
            }
            Console.Write(yuzler);
            //onlar basamağı üretildi
            onlar = program.number_random(0);
            while (yuzler == onlar)
            {
                onlar = program.number_random(0);
            }
            Console.Write(onlar);
            //birler basamağı üretildi
            birler = program.number_random(0);
            while ((birler == yuzler) || (birler == onlar))
            {
                birler = program.number_random(0);
            }
            Console.WriteLine(birler);
            //---------------------------------------------------
            int tahminNumarası = 0;
            int counter = 0;
            int yanlısyerde = 0;
            while (counter != 3)
            {
                string fromComputer;
                try
                {

                    Console.Write("Tahmininiz:");
                    fromComputer = Console.ReadLine();
                    if (fromComputer.Length > 3 || fromComputer.Length < 3)
                    {
                        Console.WriteLine("Lütfen 3 basamaklı bir sayı giriniz.");
                        continue;
                    }


                    string[] x = new string[fromComputer.Length];

                    for (int i = 0; i < fromComputer.Length; i++)
                    {
                        x[i] = fromComputer.Substring(i, 1);
                    }
                    if (int.Parse(x[0]) == int.Parse(x[1]) || int.Parse(x[1]) == int.Parse(x[2]) || int.Parse(x[0]) == int.Parse(x[2]))
                    {
                        Console.WriteLine("Rakamlar birbirinden farklı olmalı");
                        continue;
                    }
                    if(int.Parse(x[0])==0){
                        Console.WriteLine("Lütfen sayının ilk hanesini sıfırdan büyük giriniz..!!");
                        continue;
                    }
                    if (yuzler == int.Parse(x[0]))
                    {
                        counter++;
                    }
                    if (onlar == int.Parse(x[1]))
                    {
                        counter++;
                    }
                    if (birler == int.Parse(x[2]))
                    {
                        counter++;
                    }
                    if (yuzler == int.Parse(x[1]) || yuzler == int.Parse(x[2]))
                    {
                        yanlısyerde++;

                    }
                    if (onlar == int.Parse(x[0]) || onlar == int.Parse(x[2]))
                    {
                        yanlısyerde++;
                    }
                    if (birler == int.Parse(x[0]) || birler == int.Parse(x[1]))
                    {
                        yanlısyerde++;
                    }

                    tahminNumarası++;

                    if (counter == 0 && yanlısyerde == 0)
                    {
                        Console.WriteLine("0");
                    }
                    else
                    {
                        if (counter == 0)
                        {
                            Console.Write("");
                        }
                        else
                            Console.Write("+" + counter);
                            if(counter == 3){
                                Console.WriteLine("");
                                continue;
                            }
                            counter = 0;
                        if (yanlısyerde == 0)
                        {
                            Console.WriteLine("");
                        }
                        else
                            Console.WriteLine("-" + yanlısyerde);
                        yanlısyerde = 0;
                    }
                    
                        
                }
                catch (Exception e)
                {
                    Console.WriteLine("Hata var lütfen yeniden deneyin");
                }
                
            }
            Console.WriteLine("Tebrikler sayıyı " +tahminNumarası+".denemede buldunuz...");

        }
        // her rakam için random sayı alan metod
        public int number_random(int sayi)
        {
            Random rnd = new Random();
            sayi = rnd.Next(10);
            return sayi;
        }
    }
}