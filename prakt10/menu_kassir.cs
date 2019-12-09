using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace prakt10
{
    class menu_kassir
    {
        static string[] punkt = new string[] { "продать товар", "все товары", "ВЫХОД" };
        public static void start_kassir_menu()
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
                        try
                        {
                            Console.Clear();
                            string[] str = File.ReadAllLines("..\\..\\..\\info\\sklad.txt");
                            for (int i = 0; i < str.Length; i++)
                            {
                                Console.WriteLine(str[i]);
                            }
                            Console.WriteLine("\n\n");
                            Console.WriteLine("введите название товара, который будет продан");
                            string name = Console.ReadLine();
                            if (name == "0")
                            {
                                goto strt;
                            }
                            else
                            {
                                Console.WriteLine("введите кол-во товара");
                                int count = Convert.ToInt32(Console.ReadLine());

                                string[] strs = File.ReadAllLines("..\\..\\..\\info\\sklad.txt");
                                StreamWriter sw = new StreamWriter("..\\..\\..\\info\\sklad.txt");
                                for (int i = 0; i < strs.Length; i++)
                                {
                                    string[] prodcou = strs[i].Split(';');
                                    int prodcount = int.Parse(prodcou[1]);
                                    if (strs[i].Split(';')[0] != name)
                                    {
                                        sw.WriteLine(strs[i]);
                                    }
                                    else if (((strs[i].Split(';')[0]) == name) && (count != prodcount))
                                    {
                                        sw.WriteLine(strs[i].Split(';')[0] + ";" + (prodcount - count));
                                    }
                                    else if ((strs[i] == name) && (count == prodcount))
                                    {
                                        Console.WriteLine("товар продан");
                                        Thread.Sleep(1000);
                                    }
                                }
                                sw.Close();
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("ошибка: " + e.Message);
                            Thread.Sleep(1000);
                            goto strt;
                        }
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
