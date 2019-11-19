using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace prakt10
{
    class menu_admin
    {
       
        static string[] punkt = new string[] {"создать", "удалить", "ВЫХОД"};
        public static void start_menu()
        {

        strt:
            Console.Clear();
             int num = keys();
            
            
            switch (num)
            {
                case 0:
                    {
                        Console.Clear();
                        Console.WriteLine("введите имя файла\n");
                        string name = Console.ReadLine();
                        File.Create("C:\\prakt10\\" + name + ".txt");
                        goto strt;
                    }
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("введите имя файла\n");
                        string name = Console.ReadLine();
                        File.Delete("C:\\prakt10\\" + name + ".txt");
                        goto strt;
                    } 
                case 2:
                    {

                        goto strt;
                    }
                
            }
            
        }
        static void drow(string[] name, int sw)
        {
            Console.Clear();
            for (int i = 0; i <= 2; i++)
            {
                
                if(i != sw)
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
                    //Console.Clear();
                    num--;
                    drow(punkt, num);
                }
                if (keyPushed.Key == ConsoleKey.Enter)
                {
                    flag = true;
                }
                if (num < 0)
                {
                   // Console.Clear();
                    num = 3;
                    drow(punkt, 3);
                }
                if (num > 3)
                {
                   // Console.Clear();
                    num = 0;
                    drow(punkt, 0);
                    Console.ResetColor();
                }
            } while (!flag);
            return num;

        }//keys

    }
}
