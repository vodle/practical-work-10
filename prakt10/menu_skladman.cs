using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace prakt10
{
    class menu_skladman
    {
        static string[] punkt = new string[] { "добаваить товар", "все товары", "ВЫХОД" };
        public static void start_skladmen_menu()
        {
        strt:
            Console.Clear();
            int num = keyss();


            switch (num)
            {
                case 0:
                    {
                        Console.Clear();
                        StreamWriter sw = new StreamWriter("..\\..\\..\\info\\sklad.txt", true);
                        Console.WriteLine("введите товар, который будет добавлен\n");
                        string text = Console.ReadLine();
                        sw.WriteLine(text);
                        sw.Close();
                        goto strt;
                    }
                case 1:
                    {
                        Console.Clear();
                        string[] str = File.ReadAllLines("..\\..\\..\\info\\sklad.txt");
                        for (int i = 0; i < str.Length; i++)
                        {
                            Console.WriteLine(str[i]);
                        }
                        Console.ReadKey();
                        goto strt;
                    }
                case 2:
                    break;

            }
            void drow(string[] name, int sw)
            {
                Console.Clear();
                for (int i = 0; i < name.Length; i++)
                {

                    if (i != sw)
                    {

                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(name[i]);

                    }
                    else if (i == sw)
                    {

                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(name[i]);

                    }
                }
            }//drow
            int keyss()
            {
                int numa = 0;
                bool flag = false;

                do
                {
                    ConsoleKeyInfo keyPushed = Console.ReadKey();
                    if (keyPushed.Key == ConsoleKey.DownArrow)
                    {

                        numa++;
                        drow(punkt, numa);
                    }
                    if (keyPushed.Key == ConsoleKey.UpArrow)
                    {

                        numa--;
                        drow(punkt, numa);
                    }
                    if (keyPushed.Key == ConsoleKey.Enter)
                    {
                        flag = true;
                    }
                    if (numa < 0)
                    {

                        numa = 2;
                        drow(punkt, 2);
                    }
                    if (numa > 2)
                    {

                        numa = 0;
                        drow(punkt, 0);
                        Console.ResetColor();
                    }
                } while (!flag);
                return numa;

            }//keys
        }
    }
}
