using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace prakt10
{
    class menu_user
    {
        static string[] punkt = new string[] { "просмотреть", "ВЫХОД" };
        public static void start_user_menu()
        {
        strt:
            Console.Clear();
            int num = keyss();


            switch (num)
            {
                case 0:
                    {
                        string strings;
                        Console.Clear();
                        Console.WriteLine("введите имя файла\n");
                        string name = Console.ReadLine();
                        Console.Clear();
                        StreamReader sr = new StreamReader("..\\..\\..\\info\\" + name + ".txt");
                        while (!sr.EndOfStream)
                        {
                            strings = sr.ReadLine();
                            Console.WriteLine(strings);
                        }
                        Console.WriteLine("\n\nНажмине enter\n");
                        Console.ReadKey();
                        sr.Close();
                        goto strt;
                    }
                case 1:
                    {

                        break;
                    }

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
