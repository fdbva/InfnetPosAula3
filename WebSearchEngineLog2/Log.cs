using System;
using System.Collections.Generic;
using System.Text;

namespace WebSearchEngineLog2
{
    public class Log : ILog
    {
        public enum EnumLogFormatter
        {
            Default
        }
        public enum EnumLogWritter
        {
            Default
        }
        private string _logLine;
        private string _folderPath;
        private string _fileName;
        private ILogFormatter _logFormatter;
        private ILogWritter _logWritter;
        private IConfigurationLog _configurationLog;

        public Log()
        {
            _configurationLog = new ConfigurationLog
            {
                EnumLogFormatter = EnumLogFormatter.Default,
                EnumLogWritter = EnumLogWritter.Default
            };
            Initialize(_configurationLog);
        }

        public Log(IConfigurationLog configurationLog)
        {
            _configurationLog = configurationLog;
            Initialize(_configurationLog);
        }

        private void Initialize(IConfigurationLog configurationLog)
        {
            switch (configurationLog.EnumLogFormatter)
            {
                case EnumLogFormatter.Default:
                    _logFormatter = new LogFormatterDefault();
                    break;
                default:
                    break;
            }
            switch (configurationLog.EnumLogWritter)
            {
                case EnumLogWritter.Default:
                    _logWritter = new LogWritterDefault(configurationLog, out _folderPath, out _fileName);
                    break;
                default:
                    break;
            }
        }

        public void Insert(ISearchData searchData)
        {
            _logLine = 
                $"{searchData.UserId}[{DateTime.UtcNow:o}]: {searchData.Ip}, " +
                $"{searchData.Location}, {searchData.Language}, {searchData.Link}, {searchData.SearchQuery}";
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(System.IO.File.Create($"{_folderPath}/{_fileName}")))
            {
                file.WriteLine(_logLine);
            }
        }
    }
}
