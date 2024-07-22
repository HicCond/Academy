using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SoftServe
{
    internal class Task
    {
        static void Main(string[] args)
        {


            //Task1

            Console.WriteLine("Hello World!\n");

            Console.ReadLine();

            Console.Clear();

            //Task2

            Console.WriteLine("───▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄───\r\n───█▒▒░░░░ ░░░░░▒▒█───\r\n────█░░█░░░░░█░░█────\r\n─▄▄──█░░░▀█▀░░░█──▄▄─\r\n█░░█─▀▄░░░░░░░▄▀─█░░█\r\n");

            
            Console.ReadLine();

            
            Console.Clear();



            Console.WriteLine("───▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄───\r\n───█▒▒░░░░░░░░░▒▒█───\r\n────█░░█░░░░░█░░█────\r\n─▄▄──█░░░▀█▀░░░█──▄▄─\r\n█░░█─▀▄░░░░░░░▄▀─█░░█\r\n");

            Thread.Sleep(1000);

            Console.Clear();

            Console.WriteLine("───▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄───\r\n───█▒▒░░░░░░░░░▒▒█───\r\n────█░░░░░░░░░░░█────\r\n─▄▄──█░░░▀█▀░░░█──▄▄─\r\n█░░█─▀▄░░░░░░░▄▀─█░░█\r\n");

            Thread.Sleep(1000);

            Console.Clear();



            Console.WriteLine("───▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄───\r\n───█▒▒░░░░░░░░░▒▒█───\r\n────█░░█░░░░░█░░█────\r\n─▄▄──█░░░▀█▀░░░█──▄▄─\r\n█░░█─▀▄░░░░░░░▄▀─█░░█\r\n");

            Thread.Sleep(1000);

            Console.Clear();

            Console.WriteLine("───▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄───\r\n───█▒▒░░░░░░░░░▒▒█───\r\n────█░░░░░░░░░░░█────\r\n─▄▄──█░░░▀█▀░░░█──▄▄─\r\n█░░█─▀▄░░░░░░░▄▀─█░░█\r\n");

            Thread.Sleep(1000);

            Console.Clear();



            Console.WriteLine("───▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄───\r\n───█▒▒░░░░░░░░░▒▒█───\r\n────█░░█░░░░░█░░█────\r\n─▄▄──█░░░▀█▀░░░█──▄▄─\r\n█░░█─▀▄░░░░░░░▄▀─█░░█\r\n");

            Thread.Sleep(1000);

            Console.Clear();

            Console.WriteLine("───▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄───\r\n───█▒▒░░░░░░░░░▒▒█───\r\n────█░░░░░░░░░░░█────\r\n─▄▄──█░░░▀█▀░░░█──▄▄─\r\n█░░█─▀▄░░░░░░░▄▀─█░░█\r\n");

            Thread.Sleep(1000);

            Console.Clear();

            Console.ReadLine();


            //Task3
            Console.Clear();

            Console.Write("Is bear sleeping? Print ‘y’ if he is. ");
            string line = Console.ReadLine();

            if(line == "y")
            {
              Console.WriteLine("───▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄───\r\n───█▒▒░░░░░░░░░▒▒█───\r\n────█░░░░░░░░░░░█────\r\n─▄▄──█░░░▀█▀░░░█──▄▄─\r\n█░░█─▀▄░░░░░░░▄▀─█░░█\r\n");
              Console.Read();
            }
            else
            {
              Console.WriteLine("───▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄───\r\n───█▒▒░░░░░░░░░▒▒█───\r\n────█░░█░░░░░█░░█────\r\n─▄▄──█░░░▀█▀░░░█──▄▄─\r\n█░░█─▀▄░░░░░░░▄▀─█░░█\r\n");
              Console.Read();
            }


            //Task4
            //Пояснення до завдання не було, тому виконав по-своєму
            Console.Clear() ;

            int PyramidHeight = 5;
            

            for (int i = PyramidHeight; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }

            Console.ReadLine();


            Console.WriteLine("Print height of pyramid: ");
            PyramidHeight = Convert.ToInt32(Console.ReadLine());

            for (int i = PyramidHeight; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
