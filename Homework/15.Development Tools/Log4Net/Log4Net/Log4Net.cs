using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;

namespace Log4Net
{
    public class Log4Net
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Log4Net));

        public static void Main(string[] args)
        {
            // Set up a simple configuration that logs on the console.
            XmlConfigurator.Configure();

            log.Info("Entering application.");
            Console.Write("Entering application.");
            Console.ReadKey();
            log.Debug("Debuging application.");
            Console.WriteLine("Debuging application.");
            Console.Write("Enter a number > 4!");
            var n = Console.ReadLine();
            int k = 0;
            if (int.TryParse(n, out k))
            {
                if (k <= 4)
                {
                    log.Error("Input number < = 4, expected grater than 4");
                    throw new ArgumentOutOfRangeException("Input number is <= than 4!");
                }
                else
                {
                    log.Info("One  more correct number added!");
                }
            }
            else
            {
                log.Error("Input data is not a number!");
                throw new ArgumentException("Input data is not a number!");
            }

            log.Info("Exiting application!");
        }
    }
}
