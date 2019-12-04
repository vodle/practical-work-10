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
       
        static string[] punkt = new string[] {"создать","изменит","просмотреть", "удалить", "ВЫХОД"};
        public static void start_admin_menu()
        {

        strt:
            Console.Clear();
            foreach(string h in punkt)
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
                        Console.WriteLine("введите имя файла\n");
                        string name = Console.ReadLine();
                        File.Create("..\\..\\..\\info\\" + name + ".txt");
                        goto strt;
                    }
                case 1:
                    {
                        
                        Console.Clear();
                        Console.WriteLine("введите имя файла\n");
                        string name = Console.ReadLine();
                        StreamWriter sw = new StreamWriter("..\\..\\..\\info\\" + name + ".txt", true);
                        Console.Clear();
                        Console.WriteLine("введите текст, который будет добавлен\n");
                        string text = Console.ReadLine();
                        sw.WriteLine(text);
                        sw.Close();

                        goto strt;
                    }
                case 2:
                    Console.Clear();
                    Console.WriteLine("enter file name\n");
                    string file_name = Console.ReadLine();
                    string[] strings = File.ReadAllLines("..\\..\\..\\info\\" + file_name + ".txt");
                    Console.Clear();
                    for (int i = 0; i < strings.Length; i++)
                    {
                        Console.WriteLine(strings[i]);
                    }
                    Console.WriteLine("\n\nenter enter");
                    Console.ReadKey();
                    goto strt;

                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine("введите имя файла\n");
                        string name = Console.ReadLine();
                        File.Delete("..\\..\\..\\info\\" + name + ".txt");

                        goto strt;
                    }
                case 4:
                    {

                        break;
                    }

            }
            
        }
        

    }
}
