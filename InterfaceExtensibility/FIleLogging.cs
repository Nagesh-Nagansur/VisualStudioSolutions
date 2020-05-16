using System.IO;

namespace Extensibility
{
    public class FIleLogging : ILogger
    {
        string path = @"D:\Log\logs.txt";
        public void LogError(string message)
        {
           
        }

        public void LogInfo(string message)
        {
            File.AppendAllText(path, message);
        }
    }
}
