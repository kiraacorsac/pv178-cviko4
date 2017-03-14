using System;

namespace Params
{
    public static class Solution
    {
        #region solution testing

        public static void TestSolution()
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
            WriteLogsWithDescription("General message:");

            // now we have to explicitly state all preceding optional parameters (includeDate param)
            WriteLogsWithDescription("General message:", true, logTimes);

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
                new EventLog("File: 'invoice.xml' has been successfully exported", DateTime.Now.AddHours(-2))
            };

            WriteLogsWithDescription(false, logTimes);

            Console.ReadKey();
        }

        #endregion

        /// <summary>
        /// Writes out variable number of logs
        /// which consists of logged time and
        /// general log message (same for all logs)
        /// </summary>
        /// <param name="description">
        /// general description for all logs
        /// </param>
        /// <param name="includeDate">
        /// determines if date should be also
        /// included in the log output, this
        /// parameter is optional
        /// </param>
        /// <param name="logsToWriteOut">
        /// variable number of DateTimes 
        /// of recorded events
        /// </param>
        private static void WriteLogsWithDescription(string description, bool includeDate = true, params DateTime[] logsToWriteOut)
        {
            if (logsToWriteOut == null || logsToWriteOut.Length == 0)
            {
                return;
            }

            for (int i = 0; i < logsToWriteOut.Length; i++)
            {
                WriteLoggedTimeFromArgument(logsToWriteOut[i], description, includeDate);
            }
        }

        /// <summary>
        /// Writes out variable number of logs
        /// each log consists of log time and
        /// log specific message
        /// </summary>
        /// <param name="includeDate">
        /// determines if date should be also
        /// included in the log output, this
        /// parameter is optional
        /// </param>
        /// <param name="logsToWriteOut">
        /// variable number of DateTimes 
        /// each having a specific message,
        /// which contains recorded events
        /// </param>
        private static void WriteLogsWithDescription(bool includeDate = true, params EventLog[] logsToWriteOut)
        {
            if (logsToWriteOut == null || logsToWriteOut.Length == 0)
            {
                return;
            }

            for (int i = 0; i < logsToWriteOut.Length; i++)
            {
                WriteLoggedTimeFromArgument(logsToWriteOut[i].LoggeDateTime, logsToWriteOut[i].EventDescription, includeDate);
            }
        }

        /// <summary>
        /// helper method for params sample method
        /// </summary>
        /// <param name="logToWriteOut"></param>
        /// <param name="description"></param>
        /// <param name="includeDate"></param>
        private static void WriteLoggedTimeFromArgument(DateTime logToWriteOut, string description = "General event has occurred at: ", bool includeDate = true)
        {
            if (includeDate)
            {
                Console.WriteLine(
                    $"{description ?? "General event has occurred at: "} {logToWriteOut.ToShortDateString()} at: {logToWriteOut.ToShortTimeString()}");
            }
            else
            {
                Console.WriteLine(
                   $"{description ?? "General event has occurred at: "} at: {logToWriteOut.ToShortTimeString()}");
            }
        }
    }

    /// <summary>
    /// simple class that represents log event
    /// </summary>
    public class EventLog
    {
        public string EventDescription { get; private set; }
        public DateTime LoggeDateTime { get; private set; }

        public EventLog(string description, DateTime logTime)
        {
            EventDescription = description ?? "General event has occurred at: ";
            LoggeDateTime = logTime;
        }
    }
}
