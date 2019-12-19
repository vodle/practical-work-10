using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace prakt10
{
    class menu_boh
    {
        static string[] punkt = new string[] { "просмотреть", "изменить", "выплатить зп", "ВЫХОД" };
        public static void start_buh_menu()
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
                        string strings;
                        Console.Clear();
                        Console.WriteLine("введите имя пользователя\n");
                        string name = Console.ReadLine();
                        if (name == "0")
                        {
                            goto strt;
                        }
                        else
                        {
                            Console.Clear();
                            StreamReader sr = new StreamReader("..\\..\\..\\info\\users.txt");
                            while (!sr.EndOfStream)
                            {
                                strings = sr.ReadLine();
                                if ((strings.Split(';')[0]) == name)
                                {
                                    string[] str = strings.Split(';');
                                    Console.WriteLine(str[0] + " " + str[3]);
                                }
                            }
                            Console.WriteLine("\n\nНажмине enter\n");
                            Console.ReadKey();
                            sr.Close();
                            goto strt;
                        }
                    }
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("введите имя пользователя\n");
                        string name = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("\nвведите сумму\n");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (name == "0")
                        {
                            goto strt;
                        }
                        else
                        {

                            string[] strs = File.ReadAllLines("..\\..\\..\\info\\users.txt");
                            StreamWriter sw = new StreamWriter("..\\..\\..\\info\\users.txt");
                            for (int i = 0; i < strs.Length; i++)
                            {
                                if ((strs[i].Split(';')[0]) == name)
                                {
                                    string[] res = strs[i].Split(';');
                                    sw.WriteLine(res[0] + ";" + res[1] + ";" + res[2] + ";" + amount);
                                }
                                else
                                {
                                    sw.WriteLine(strs[i]);
                                }
                            }

                            sw.Close();
                            goto strt;
                        }
                    }
                case 2:
                    Console.Clear();
                    string[] users = File.ReadAllLines("..\\..\\..\\info\\users.txt");
                    string[] bank = File.ReadAllLines("..\\..\\..\\info\\bank.txt");
                    StreamWriter writer = new StreamWriter("..\\..\\..\\info\\users.txt");
                    int summ = int.Parse(bank[0]);
                    int colvo = summ / users.Length - 1;
                    for (int i = 0; i < users.Length; i++)
                    {
                        if(users[i].Split(';')[0] == "root")
                        {
                            writer.WriteLine(users[i]);
                        }else
                        {
                            writer.WriteLine(users[i].Split(';')[0] + ";" + users[i].Split(';')[1] + ";" + users[i].Split(';')[2] + ";" + (int.Parse(users[i].Split(';')[3])) + (int)colvo) ;
                        }
                    }
                    goto strt;

                case 3:
                    break;

            }
            
        }
    }
}
