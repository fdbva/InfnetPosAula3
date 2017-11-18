namespace WebSearchEngineLog2
{
    internal class LogWritterDefault : ILogWritter
    {
        private IConfigurationLog configurationLog;

        public LogWritterDefault(out string folderPath, out string fileName)
        {
            folderPath = ""; //Environment.GetFolderPath(Environment.SpecialFolder.);
            fileName = "Log.log";
        }
        public LogWritterDefault(IConfigurationLog configurationLog, out string folderPath, out string fileName)
        {
            this.configurationLog = configurationLog;
            folderPath = null;
            fileName = null;
        }
    }
}