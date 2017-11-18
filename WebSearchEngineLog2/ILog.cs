using System;

namespace WebSearchEngineLog2
{
    public interface ILog
    {
        void Insert(ISearchData searchData);
    }
}
