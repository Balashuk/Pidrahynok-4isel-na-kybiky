using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0;
            double v1=0, v2=0, v3=0, v4=0, v5=0, v6=0;
            for (int z = 1; z <= 15; z++)
            {
                Console.Write("Введiть число, яке випало яке випало на кубику(число вiд 1 до 6): ");
                a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        v1++;
                        break;
                    case 2:
                        v2++;
                        break;
                    case 3:
                        v3++;
                        break;
                    case 4:
                        v4++;
                        break;
                    case 5:
                        v5++;
                        break;
                    case 6:
                        v6++;
                        break;
                }
            }
            Console.Clear();
            Console.WriteLine("Всього випало кубикiв по \nЧисло 1 випало: " + v1.ToString() + " рази. \nчисло 2 випало : " + v2.ToString() + " рази. " + "\nчисло 3 випао : " + v3.ToString() + " рази. " + "\nчисло 4 випало: " + v4.ToString() + " рази. " + "\nчисло 5 випало: " + v5.ToString() + " рази. " + "\nчисло 6 випало: " + v6.ToString() + " рази. ");
            Console.ReadKey();
            //for (int i=0; i<=15; i++)
            //{
            //    Random rnd = new Random();
            //    Console.WriteLine(rnd.Next(1, 6));
            //
            //Console.ReadKey();
            //switch(a)
            //{
            //    case:
            //}
        }
    }
}
