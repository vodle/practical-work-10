using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace prakt10
{
    class menu_boh
    {
        static string[] punkt = new string[] { "просмотреть", "изменить", "ВЫХОД" };
        public static void start_buh_menu()
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
                        Console.WriteLine("введите имя пользователя\n");
                        string name = Console.ReadLine();
                        Console.Clear();
                        StreamReader sr = new StreamReader("..\\..\\..\\info\\users.txt");
                        while (!sr.EndOfStream)
                        {
                            strings = sr.ReadLine();
                            if ((strings.Split(';')[0]) == name) {
                                string[] str = strings.Split(';');
                                Console.WriteLine(str[0] + " " + str[3]);
                            }
                        }
                        Console.WriteLine("\n\nНажмине enter\n");
                        Console.ReadKey();
                        sr.Close();
                        goto strt;
                    }
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("введите имя пользователя\n");
                        string name = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("\nвведите сумму\n");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        string[] strs = File.ReadAllLines("..\\..\\..\\info\\users.txt");
                        StreamWriter sw = new StreamWriter("..\\..\\..\\info\\users.txt");
                        for (int i = 0; i < strs.Length; i++)
                        {
                            if ((strs[i].Split(';')[0]) == name)
                            {
                                string[] res = strs[i].Split(';');
                                sw.WriteLine(res[0] + ";" + res[1] + ";" + res[2] + ";" + amount);
                            }
                            else
                            {
                                sw.WriteLine(strs[i]);
                            }
                        }

                        sw.Close();
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
