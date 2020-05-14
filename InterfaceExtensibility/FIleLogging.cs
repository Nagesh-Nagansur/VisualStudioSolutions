using System.IO;

namespace Extensibility
{
    public class FIleLogging : ILogger
    {
        string path = @"D:\Log";
        public void LogError(string message)
        {
           
        }

        public void LogInfo(string message)
        {
            File.WriteAllText(path, message);
        }
    }
}
