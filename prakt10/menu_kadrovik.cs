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
                        string[] users = File.ReadAllLines("..\\..\\..\\info\\users.txt");
                        Console.WriteLine("имена пользователей");
                        for (int i = 0; i < users.Length; i++)
                        {
                            Console.WriteLine(users[i].Split(';')[0]);
                        }
                        Console.Write("\n\npress enter\n");
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
                        Console.WriteLine("имена пользователей");
                        for (int i = 0; i < users.Length; i++)
                        {
                            Console.WriteLine(users[i].Split(';')[0]);
                        }
                        Console.WriteLine("\nвведите имя пользователя");
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
            
        }
    }
}
