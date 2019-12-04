using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace prakt10
{
    class register
    {
        static string[] punkt = new string[] { "кассир","складмен","кадровик","бухгалтер","пользователь" };
        public static int start_register_screen()
        {
            Console.Clear();
            string login;
            string pass;
            Console.WriteLine("enter login: ");
            login = Console.ReadLine();
            Console.WriteLine("enter passeord: ");
            pass = Console.ReadLine();

            int doljnost = keys();

            return tryreg(login, pass, doljnost);
        }
        static int tryreg(string login, string pass, int dolj)
        {

            int count = 0, res = 0;
            string[] strings = File.ReadAllLines("..\\..\\..\\info\\users.txt");
            for (int i = 0; i < strings.Length; i++)
            {
                if(strings[i] == (login + ";" + pass))
                {
                    count++;
                    break;
                }
            }
            if (count == 0)
            {
                if (!(dolj == 4)) {
                    StreamWriter sw = new StreamWriter("..\\..\\..\\info\\users.txt", true);
                    sw.WriteLine(login + ";" + pass + ";" + dolj + ";0");
                    res = 1;
                    sw.Close();
                }
                else
                {
                    StreamWriter sw = new StreamWriter("..\\..\\..\\info\\users.txt", true);
                    sw.WriteLine(login + ";" + pass + ";" + ";0");
                    res = 1;
                    sw.Close();
                }
            }
            else
            {
                Console.Clear();
                Console.Write("пользователь с именем " + login + " уже есть\n нажмите enter");
                Console.ReadKey();
            }


            return res;
        }
        static void drow(string[] name, int sw)
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

        static int keys()
        {
            int num = 0;
            bool flag = false;

            do
            {
                ConsoleKeyInfo keyPushed = Console.ReadKey();
                if (keyPushed.Key == ConsoleKey.DownArrow)
                {

                    num++;
                    drow(punkt, num);
                }
                if (keyPushed.Key == ConsoleKey.UpArrow)
                {

                    num--;
                    drow(punkt, num);
                }
                if (keyPushed.Key == ConsoleKey.Enter)
                {
                    flag = true;
                }
                if (num < 0)
                {

                    num = 4;
                    drow(punkt, 4);
                }
                if (num > 4)
                {

                    num = 0;
                    drow(punkt, 0);
                    Console.ResetColor();
                }
            } while (!flag);
            return num;

        }//keys
    } 
}

