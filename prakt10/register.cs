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
        public static int start_register_screen()
        {
            Console.Clear();
            string login;
            string pass;
            Console.WriteLine("enter login: ");
            login = Console.ReadLine();
            Console.WriteLine("enter passeord: ");
            pass = Console.ReadLine();
            return tryreg(login, pass);
        }
        static int tryreg(string login, string pass)
        {
            StreamWriter sw = new StreamWriter("..\\..\\..\\info\\users.txt", true);
            sw.WriteLine(login + ";" + pass + "\n");
            int res = 1;
            sw.Close();


            return res;
        } 
    } 
}

