using System;
using System.Security.Principal;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winsh
{
    public class Shell
    {
        static string userName = Environment.UserName;
        public static void WinSH()
        {
            Console.Write("{0}> ", userName);
            string Command = Console.ReadLine();
        }
    }
}
