using System.Text;
using System.Linq;
using static System.Console;
using static Logic.GreetingClass;


namespace ConsoleUI
{
    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public static void Main(string[] args)
        {
            // Console.Write("Enter user name:");
            // string userName = Console.ReadLine();
            // Console.Clear();
            // Console.WriteLine(GreetingClass.GreetingMethod(userName));
            // Console.ReadKey();
  
            Write("Enter user name:");
            string userName = ReadLine();
            Clear();
            WriteLine(GreetingMethod(userName));
            ReadKey();
        }
    }
}
