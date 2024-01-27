using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplifiedBank
{
    internal class ColorfulMessage
    {
        /// <summary>
        /// Colors the console output green
        /// </summary>
        /// <param name="message">Console output</param>
        public static void success(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        /// <summary>
        /// Colors the console output red
        /// </summary>
        /// <param name="message">Console output</param>
        public static void failure(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
