using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace prakt10
{
    class menu_kadrovik
    {
        static string[] punkt = new string[] { "просмотреть пользователей", "добавить пользователя","удалить пользователя", "ВЫХОД" };
        public static void start_kadrovik_menu()
        {
        strt:
            Console.Clear();
            int num = keyss();


            switch (num)
            {
                case 0:
                    {
                        string[] users = File.ReadAllLines("..\\..\\..\\info\\users.txt");
                        for (int i = 0; i < users.Length; i++)
                        {
                            Console.WriteLine(users[i]);
                        }
                        Console.ReadKey();
                        goto strt;
                    }
                case 1:
                    {
                        register.start_register_screen();
                        goto strt;
                    }
                case 2:
                    {
                        string[] users = File.ReadAllLines("..\\..\\..\\info\\users.txt");
                        StreamWriter sw = new StreamWriter("..\\..\\..\\info\\users.txt");
                        Console.Clear();
                        Console.WriteLine("введите имя пользователя");
                        string name = Console.ReadLine();
                        for (int i = 0; i < users.Length; i++)
                        {
                            string[] del_name = users[i].Split(';');
                            if (name != del_name[0])
                            {
                                sw.WriteLine(users[i]);
                            }
                        }

                        sw.Close();
                        goto strt;
                    }
                case 3:
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
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    else if (i == sw)
                    {

                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(name[i]);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;

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

                        numa = 3;
                        drow(punkt, 3);
                    }
                    if (numa > 3)
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
