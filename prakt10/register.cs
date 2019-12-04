using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace prakt10
{
    class register
    {
        static string[] punkt = new string[] { "кассир","складмен","кадровик","бухгалтер","пользователь" };
        public static int start_register_screen()
        {
            Console.Clear();
            string login;
            string pass;
            Console.WriteLine("enter login: ");
            login = Console.ReadLine();
            Console.WriteLine("enter password: ");
            pass = Console.ReadLine();
            Console.Clear();
            foreach (string h in punkt)
            {
                Console.WriteLine(h);
            }
            arrow_menu am = new arrow_menu(punkt);
            int doljnost = am.keyss();

            return tryreg(login, pass, doljnost);
        }
        static int tryreg(string login, string pass, int dolj)
        {

            int count = 0, res = 0;
            string[] strings = File.ReadAllLines("..\\..\\..\\info\\users.txt");
            for (int i = 0; i < strings.Length; i++)
            {
                if(strings[i] == (login + ";" + pass))
                {
                    count++;
                    break;
                }
            }
            if (count == 0)
            {
                if (!(dolj == 4)) {
                    StreamWriter sw = new StreamWriter("..\\..\\..\\info\\users.txt", true);
                    sw.WriteLine(login + ";" + pass + ";" + dolj + ";0");
                    res = 1;
                    sw.Close();
                }
                else
                {
                    StreamWriter sw = new StreamWriter("..\\..\\..\\info\\users.txt", true);
                    sw.WriteLine(login + ";" + pass + ";" + ";0");
                    res = 1;
                    sw.Close();
                }
            }
            else
            {
                Console.Clear();
                Console.Write("пользователь с именем " + login + " уже есть\n нажмите enter");
                Console.ReadKey();
            }


            return res;
        }
        
    } 
}

