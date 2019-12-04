using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt10
{
    class auth
    {
        static string[] punkt = new string[] { "вход","ВЫХОД" };
        public static int start_auth()
        {
            arrow_menu am = new arrow_menu(punkt);
            Console.Clear();
            foreach (string h in punkt)
            {
                Console.WriteLine(h);
            }
            int num = am.keyss();
            return num;
        }
      
    }
}
