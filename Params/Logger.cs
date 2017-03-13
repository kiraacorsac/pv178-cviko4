using System;

namespace Params
{
    public static class Logger
    {
        /// <summary>
        /// helper method
        /// </summary>
        public static void WriteLoggedTimeFromArgument(DateTime logToWriteOut, string description = "General event has occurred at: ", bool includeDate = true)
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


        /// <summary>
        /// Writes out variable number of logs
        /// which consists of logged time and
        /// general log message (same for all logs)
        /// </summary>
        /// <param name="description">
        /// general description for all logs
        /// </param>
        /// <param name="logsToWriteOut">
        /// variable number of DateTimes 
        /// of recorded events
        /// </param>
        /// <param name="includeDate">
        /// determines if date should be also
        /// included in the log output, this
        /// parameter is optional
        /// </param>
        
        public static void WriteLogsWithDescription(/* TODO - add parameters */)
        {
            // TODO...
        }
    }
}
