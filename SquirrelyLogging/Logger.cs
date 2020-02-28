using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using NLog.Config;
using NLog.Targets;

namespace SquirrelyLogging {
    public class Logger {

        private static readonly Lazy<Logger> Lazy = new Lazy<Logger>(() => new Logger());
        public static Logger LoggerInstance => Lazy.Value;

        private NLog.Logger _currentLog;

        private Logger() {
            LoggingConfiguration config = new LoggingConfiguration();

            FileTarget logFile = new FileTarget("logFile") { FileName = "log.log" };
            ConsoleTarget logConsole = new ConsoleTarget("logConsole");

            config.AddRule(LogLevel.Info, LogLevel.Fatal, logConsole);
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logFile);

            LogManager.Configuration = config;
        }

        //logger.Info("Hello World");

        public void SetLogger(string logger) => _currentLog = LogManager.GetLogger(logger);

        //String
        public void LogInfo(string message) => _currentLog.Info(message);
        public void LogWarn(string message) => _currentLog.Warn(message);
        public void LogFatal(string message) => _currentLog.Fatal(message);
        public void LogDebug(string message) => _currentLog.Debug(message);
        public void LogError(string message) => _currentLog.Error(message);

        //Exception
        public void LogInfo(Exception ex) => _currentLog.Info(StringBuilder.BuildString(ex));
        public void LogWarn(Exception ex) => _currentLog.Warn(StringBuilder.BuildString(ex));
        public void LogFatal(Exception ex) => _currentLog.Fatal(StringBuilder.BuildString(ex));
        public void LogDebug(Exception ex) => _currentLog.Debug(StringBuilder.BuildString(ex));
        public void LogError(Exception ex) => _currentLog.Error(StringBuilder.BuildString(ex));
    }
}
