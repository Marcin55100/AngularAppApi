namespace AngularAppApi.Api
{
    public interface IScoresDownloader
    {
        List<MatchScore> GetFakeFootballData();
        Task<List<MatchScore>> GetRealFootballData();
    }
}