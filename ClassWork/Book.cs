using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork
{
    public class Book : Product
    {
        public string Genre;


        public void Run()
        {
            Console.Write("Input Counter : ");
            count = int.Parse(Console.ReadLine());
            if (count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("0 kitabiniz var! Proqram davam ede bilmez");
                return;
            }
            Console.ForegroundColor = ConsoleColor.White;
            Book[] Books = new Book[count];
            for (int i = 0; i < count; i++)
            {
                Books[i] = new Book();
                Console.Write("Name : ");
                Books[i].Name = Console.ReadLine();
                while (Books[i].Name == "" || Books[i].Name == " ")
                {
                    Console.WriteLine("Sevh format yeniden elave et");
                    Console.Write("Name : ");
                    Books[i].Name = Console.ReadLine();
                }
                Console.Write("No : ");
                Books[i].No = int.Parse(Console.ReadLine());
                Console.Write("Price : ");
                Books[i].price = int.Parse(Console.ReadLine());
                Console.Write("Genre : ");
                Books[i].Genre = Console.ReadLine();
                while (Books[i].Genre == "" || Books[i].Genre == " ")
                {
                    Console.WriteLine("Sevh format yeniden elave et");
                    Console.Write("Genre : ");
                    Books[i].Genre = Console.ReadLine();
                } 
                Console.WriteLine("\n");
            }
            int value = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1. Kitablari qiymete gore filtirle.\n2. Butun kitablari goster.\n0. Proqrami bagla\n");
                Console.Write("Sechiminiz : ");
                value = int.Parse(Console.ReadLine());
                switch (value)
                {
                    case 1:
                        Console.Write("Min qiymeti input ele : ");
                        int minPrice = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n");
                        Console.Write("Max qiymeti input ele : ");
                        int maxPrice = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n");
                        Console.WriteLine("Verdiyiniz qiymet diapozonunda olan kitablar : ");
                        foreach (var item in Books)
                        {
                            if (item.price <= maxPrice && item.price >= minPrice)
                            {
                                Console.WriteLine($"Name : {item.Name}\nPrice : {item.price}\nGenre : {item.Genre}\nNo : {item.No}\n");
                            }
                        }
                        break;
                    case 2:
                        foreach (var item in Books)
                        {
                            Console.WriteLine($"Name : {item.Name}\nPrice : {item.price}\nGenre : {item.Genre}\nNo : {item.No}\n");
                        }
                        break;
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Proqram sona catdi!");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Bele punkt yoxdur! Yeniden Sechim edin :\n");
                        break;
                }
            } while (value != 0);
        }
    }
}
