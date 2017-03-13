using System;

namespace Params
{
    /// <summary>
    /// Ukol: Doplneni tridy Logger
    /// 
    /// I. Implementace tridy Logger,
    ///    vsechny potrebne informace
    ///    jsou uvedeny v xml popiscich
    ///    prislusnych metod
    /// 
    /// II. spusteni projektu
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            TestFirstMethod();
        }

        private static void TestFirstMethod()
        {
            // prepare test data
            var logTimes = new DateTime[3]
            {
                DateTime.Now.AddDays(-1),
                DateTime.Now.AddMonths(-1),
                DateTime.Now.AddYears(-1)
            };

            // optional parameters does not have to be specified, what will be the output ?
            Logger.WriteLogsWithDescription("General message:");

            // now we have to explicitly state all preceding optional parameters (includeDate param)
            Logger.WriteLogsWithDescription("General message:", true, logTimes);

            Console.WriteLine("\nPress any key to continue with solution test...\n");
            Console.ReadKey();
        }
    }
}
