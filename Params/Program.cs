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
            TestSecondMethod();
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

        private static void TestSecondMethod()
        {
            // prepare test data, note that type of the array does not have to be specified
            var logTimes = new[]
            {
                new EventLog("Fatal error in AppCore.dll..." , DateTime.Now.AddMinutes(-15)),
                new EventLog("An unexpected AggregateException occurred in user code...", DateTime.Now.AddSeconds(-120)),
                new EventLog("File: 'invoice.xml' has been successfully exported", DateTime.Now.AddHours(-2)),
            };

            Logger.WriteLogsWithDescription(false, logTimes);

            Console.ReadKey();
        }
    }
}
