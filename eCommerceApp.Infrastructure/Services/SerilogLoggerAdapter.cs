using eCommerceApp.Application.Services.Interfaces.Logging;
using Microsoft.Extensions.Logging;

namespace eCommerceApp.Infrastructure.Services
{
    public class SerilogLoggerAdapter<T>(ILogger<T> logger) : IApplogger<T>
    {
        public void LogError(Exception ex,string message) => logger.LogInformation(ex,message);

        public void LogInformation(string message) => logger.LogInformation(message);

        public void LogWarning(string message) => logger.LogWarning(message);
    
    }
}



