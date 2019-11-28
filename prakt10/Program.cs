using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace prakt10
{
    class Program
    {
        static void Main(string[] args)
        {
            strt:
            Console.Clear();
            int log;
            int ch = auth.start_auth();
            switch (ch)
            {
                case 0:
                    log = login.start_login_screen();
                    switch (log)
                    {
                        case 0:
                            goto strt;
                        case 10:
                            Console.WriteLine("вы вошли как кассир");
                            Console.ReadKey();
                            menu_kassir.start_kassir_menu();
                            break;
                        case 11:
                            Console.WriteLine("вы вошли как складмен");
                            Console.ReadKey();
                            menu_skladman.start_skladmen_menu();
                            break;
                        case 12:
                            Console.WriteLine("вы вошли как кадровик");
                            Console.ReadKey();
                            menu_kadrovik.start_kadrovik_menu();
                            break;
                        case 13:
                            Console.WriteLine("вы вошли как бухгалтер");
                            Console.ReadKey();
                            menu_boh.start_buh_menu();
                            break;
                        case 14:
                            Console.WriteLine("вы вошли как пользователь");
                            Console.ReadKey();
                            menu_user.start_user_menu();
                            break;
                        case 3:
                            menu_admin.start_admin_menu();
                            break;
                    }
                    break;
                case 1:
                    break;
            }
            
        }
    }
}
