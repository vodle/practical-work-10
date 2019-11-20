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
            int reg;
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
                            menu_user.start_user_menu();
                            break;
                        case 3:
                            menu_admin.start_admin_menu();
                            break;
                    }
                    break;
                case 2:
                    reg = register.start_register_screen();
                    ch = 1;
                    goto strt;
            }
            
        }
    }
}
