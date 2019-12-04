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
            
        }
    }
}
