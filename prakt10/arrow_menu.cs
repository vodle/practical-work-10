using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt10
{
    class arrow_menu
    {
        public string[] punkt;
        public arrow_menu(string[] punkt)
        {
            this.punkt = punkt;
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
            }//drow
        }
            public int keyss()
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

                        numa = punkt.Length;
                        drow(punkt, punkt.Length);
                    }
                    if (numa > punkt.Length)
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
