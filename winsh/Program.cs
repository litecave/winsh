using System;
using System.Diagnostics;

namespace winsh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WinSH - Shell for Windows.");
            Console.WriteLine("(c) litecave and contributors on GitHub, 2021.");
            if (args.Length == 0)
            {
                Shell.WinSH();
            }
            if (args[1] == "gh")
            {
                Process.Start("explorer.exe", "https://github.com/litecave/winsh");
            }
        }
    }
}
