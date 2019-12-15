using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace prakt10
{
    class loader
    {
        public static int start_loader()
        {
            string[] str = File.ReadAllLines("..\\..\\..\\info\\anim.txt");
            Console.Clear();
            Thread.Sleep(1000);
            for (int i = 0; i < str.Length; i++)
            {
                foreach(var s in str[i])
                {
                    Console.Write(s);
                    Thread.Sleep(10);
                }
                Console.WriteLine();
            }
            Thread.Sleep(1000);
            return auth.start_auth();
        }
    }
}
