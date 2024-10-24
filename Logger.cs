
using System;
using System.IO;

namespace AdvancedDesktopApp
{
    public static class Logger
    {
        public static void Log(string message)
        {
            string logPath = "logs/log.txt";
            Directory.CreateDirectory("logs");
            using (StreamWriter writer = new StreamWriter(logPath, true))
            {
                writer.WriteLine($"{DateTime.Now}: {message}");
            }
        }
    }
}
