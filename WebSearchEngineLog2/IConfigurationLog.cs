using System;
using System.Collections.Generic;
using System.Text;

namespace WebSearchEngineLog2
{
    public interface IConfigurationLog
    {
        string FolderPath { get; set; }
        string FileName { get; set; }
        Log.EnumLogFormatter EnumLogFormatter { get; set; }
        Log.EnumLogWritter EnumLogWritter { get; }
    }
}
