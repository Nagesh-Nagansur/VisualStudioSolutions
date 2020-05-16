using System;

namespace Extensibility
{
    public class DBmigrator
    {
        private readonly ILogger _logger;
        public DBmigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("Migrating started at {0}"+ DateTime.Now.ToString("HH:mm:ss:mm"));
            
            _logger.LogInfo("\nMigrating stoped at {0}" + DateTime.Now.ToString("HH:mm:ss:mm"));
           

        }
    }
}
