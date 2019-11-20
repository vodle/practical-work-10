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
                case 1:
                    log = login.start_login_screen();
                    switch (log)
                    {
                        case 0:
                            goto strt;
                        case 1:
                            break;
                        case 3:
                            menu_admin.start_admin_menu();
                            break;
                    }
                    break;
                case 2:
                    break;
            }
            
        }
    }
}
