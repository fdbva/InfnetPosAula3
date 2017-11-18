using System;
using System.Collections.Generic;
using System.Text;

namespace WebSearchEngineLog2
{
    public class SearchData : ISearchData
    {
        public string UserId { get; set; }
        public string Link { get; set; }
        public string SearchQuery { get; set; }
        public string Language { get; set; }
        public string Ip { get; set; }
        public string Location { get; set; }
    }
}
