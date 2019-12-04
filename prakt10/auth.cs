using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt10
{
    class auth
    {
        static string[] punkt = new string[] { "вход","ВЫХОД" };
        public static int start_auth()
        {
            int resp;
            resp = keyss();
            return resp;
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
        static int keyss()
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
                    //Console.Clear();
                    numa--;
                    drow(punkt, numa);
                }
                if (keyPushed.Key == ConsoleKey.Enter)
                {
                    flag = true;
                }
                if (numa < 0)
                {
                    // Console.Clear();
                    numa = 1;
                    drow(punkt, 1);
                }
                if (numa > 1)
                {
                    // Console.Clear();
                    numa = 0;
                    drow(punkt, 0);
                    Console.ResetColor();
                }
            } while (!flag);
            return numa;

        }//keys
    }
}
