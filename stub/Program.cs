using System;

namespace stub
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                Main main = new Main(args[0], args[1], args[2]);
                main.Connect();
            }
        }
    }
}