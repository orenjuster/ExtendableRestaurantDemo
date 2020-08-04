using ExtensibleRestaurant.Api;
using System;
using System.IO;

namespace ExtensibleRestaurant.Core.Server
{
    class CoreLogger : ILogger
    {
        private const string LogFilePath = @"c:\temp\restaurant.log";

        public void Log(string msg)
        {
            string decoratedMsg = $"\n[{DateTime.Now}] - {msg}";
            File.AppendAllText(LogFilePath, decoratedMsg);
        }
    }
}
