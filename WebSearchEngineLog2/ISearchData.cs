namespace WebSearchEngineLog2
{
    public interface ISearchData
    {
        string UserId { get; set; }
        string Link { get; set; }
        string SearchQuery { get; set; }
        string Language { get; set; }
        string Ip { get; set; }
        string Location { get; set; }
    }
}