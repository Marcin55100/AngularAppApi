using AngularAppApi.Api;
using Microsoft.AspNetCore.Mvc;

namespace AngularAppApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FootballResultsController : ControllerBase
    {
        private readonly ILogger<FootballResultsController> _logger;
        private readonly IScoresDownloader _scoresDownloader;

        public FootballResultsController(ILogger<FootballResultsController> logger, IScoresDownloader scoresDownloader)
        {
            _logger = logger;
            _scoresDownloader = scoresDownloader;
        }

        [HttpGet]
        public async Task<List<MatchScore>> Get()
        {
            return await _scoresDownloader.GetRealFootballData();
        }

        [HttpGet("fake")]
        public MatchScore[] GetFake()
        {
            return _scoresDownloader.GetFakeFootballData().ToArray();
        }
    }
}