using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace prakt10
{
    class menu_admin
    {
       
        static string[] punkt = new string[] {"создать","изменит","просмотреть", "удалить", "удалить пользователя", "ВЫХОД"};
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
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("введите имя файла\n");
                            string name = Console.ReadLine();
                            if (name == "0")
                            {
                                goto strt;
                            }
                            else
                            {
                                File.Create("..\\..\\..\\info\\" + name + ".txt");
                                Console.Clear();
                                Console.WriteLine("файл " + name + "удален!");
                                goto strt;
                            }
                        }catch(Exception e)
                        {
                            Console.WriteLine("ошибка: " + e.Message);
                            Thread.Sleep(1000);
                            goto strt;
                        }
                    }
                case 1:
                    {
                        try
                        {
                            Console.Clear();
                            DirectoryInfo dir = new DirectoryInfo("..\\..\\..\\info\\");
                            foreach (var item in dir.GetFiles())
                            {
                                Console.WriteLine(item.Name);
                            }
                            Console.WriteLine("введите имя файла\n");
                            string name = Console.ReadLine();
                            StreamWriter sw = new StreamWriter("..\\..\\..\\info\\" + name + ".txt", true);
                            Console.Clear();
                            Console.WriteLine("введите текст, который будет добавлен\n");
                            string text = Console.ReadLine();
                            sw.WriteLine(text);
                            sw.Close();

                            goto strt;
                        }catch(Exception e)
                        {
                            Console.WriteLine("ошибка " + e.Message);
                            Thread.Sleep(1000);
                            goto strt;
                        }
                    }
                case 2:
                    Console.Clear();
                    DirectoryInfo dire = new DirectoryInfo("..\\..\\..\\info\\");
                    foreach (var item in dire.GetFiles())
                    {
                        Console.WriteLine(item.Name);
                    }
                    Console.Write("\n\n");
                    Console.WriteLine("введите имя файла");
                    string file_name = Console.ReadLine();
                    string[] strings = File.ReadAllLines("..\\..\\..\\info\\" + file_name + ".txt");
                    Console.Clear();
                    for (int i = 0; i < strings.Length; i++)
                    {
                        Console.WriteLine(strings[i]);
                    }
                    Console.WriteLine("\n\nнажмите enter");
                    Console.ReadKey();
                    goto strt;

                case 3:
                    {
                        Console.Clear();
                        DirectoryInfo dir = new DirectoryInfo("..\\..\\..\\info\\");
                        foreach (var item in dir.GetFiles())
                        {
                            Console.WriteLine(item.Name);
                        }
                        Console.Write("\n\n");
                        Console.WriteLine("введите имя файла\n");
                        string name = Console.ReadLine();
                        File.Delete("..\\..\\..\\info\\" + name + ".txt");

                        goto strt;
                    }
                case 4:
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
                        if (name == "0")
                        {
                            goto strt;
                        }
                        else
                        {
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
                    }
                case 5:
                    break;

            }
            
        }
        

    }
}
