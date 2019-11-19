using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt10
{
    class auth
    {
        public static int start_auth()
        {
            int resp;
            Console.Write("enter\n 1.login\n 2.register\n");
            resp = int.Parse(Console.ReadLine());
            return resp;
        }
    }
}
