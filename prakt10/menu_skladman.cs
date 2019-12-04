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
            foreach (string h in punkt)
            {
                Console.WriteLine(h);
            }
            arrow_menu am = new arrow_menu(punkt);
            int num = am.keyss();


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
           
        }
    }
}
