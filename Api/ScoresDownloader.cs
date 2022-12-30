using AngularAppApi.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;

namespace AngularAppApi.Api
{
    public class ScoresDownloader : IScoresDownloader
    {
        private const string ROUND_OF_16_URI = "https://livescore6.p.rapidapi.com/matches/v2/list-by-league?Category=soccer&Ccd=world-cup&Scd=round-of-16&Timezone=-7";
        private static HttpRequestMessage _httpRequestMessage = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = null,
            Headers =
                {
                    { "X-RapidAPI-Key", "0b647f6580mshe3d7d50be0da1a0p196931jsnbd32120feff2" },
                    { "X-RapidAPI-Host", "livescore6.p.rapidapi.com" },
                },
        };

        public List<MatchScore> GetFakeFootballData()
        {
            return new List<MatchScore>()
            {
                new MatchScore("Poland", 1, "Germany", 0),
                new MatchScore("Senegal", 0, "Equador", 3),
                new MatchScore("Spain", 0, "France", 0)
            };
        }

        public async Task<List<MatchScore>> GetRealFootballData()
        {
            var list = new List<MatchScore>();
            var client = new HttpClient();
            _httpRequestMessage.RequestUri = new Uri(ROUND_OF_16_URI);

            var model = await GetResponse(client);

            model.Stages
                .FirstOrDefault()?.Events?
                .ToList()?
                .ForEach(e =>
                {
                    list.Add(new MatchScore(e.T1?.FirstOrDefault().Nm, e.Tr1 == null ? default : int.Parse(e.Tr1), e.T2?.FirstOrDefault().Nm, e.Tr1 == null ? default : int.Parse(e.Tr2)));
                });
            return list;
        }

        private async Task<FootballApiModel> GetResponse(HttpClient client)
        {
            using (var response = await client.SendAsync(_httpRequestMessage))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
                return JsonConvert.DeserializeObject<FootballApiModel>(body);
            }
        }
    }
}
