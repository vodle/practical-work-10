using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace prakt10
{
    class login
    {
        public static int start_login_screen()
        {
            Console.Clear();
            string login;
            string pass;
            Console.WriteLine("enter login: ");
            login = Console.ReadLine();
            Console.WriteLine("enter passeord: ");
            pass = Console.ReadLine();
            return trylogin(login, pass);
        }
        static int trylogin(string login, string pass)
        {
            StreamReader sr = new StreamReader("..\\..\\..\\info\\users.txt");
            string lines;
            string[] splitedlines;
            int res = 0;
            while (!sr.EndOfStream)
            {
                lines = sr.ReadLine();
                splitedlines = lines.Split(';');
                if(splitedlines[0] == login && splitedlines[1] == pass)
                {
                    if(login == "root" && pass == "toor")
                    {
                        res = 3;
                    }else
                    {
                        res = 1;
                    }
                }
                else
                {
                    res = 0;
                }
            }
            sr.Close();

            return res;
        }
    }
}
