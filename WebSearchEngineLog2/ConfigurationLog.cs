using System;
using System.Collections.Generic;
using System.Text;

namespace WebSearchEngineLog2
{
    public class ConfigurationLog : IConfigurationLog
    {
        public string FolderPath { get; set; }
        public string FileName { get; set; }
        public Log.EnumLogFormatter EnumLogFormatter { get; set; }
        public Log.EnumLogWritter EnumLogWritter { get; set; }
    }
}
