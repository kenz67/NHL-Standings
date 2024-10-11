using Newtonsoft.Json;
using nhl.Data;

namespace nhl.Services
{
    public class NHLService : INHLService
    {
        private List<ExpandedStandingsData> _League;
        private List<ExpandedStandingsData> _EasternConference;
        private List<ExpandedStandingsData> _WesternConference;
        private List<ExpandedStandingsData> _AtlanticDivision;
        private List<ExpandedStandingsData> _MetroPolitanDivision;
        private List<ExpandedStandingsData> _CentralDivision;
        private List<ExpandedStandingsData> _PacificDivision;

        public List<ExpandedStandingsData> League { get => _League; }
        public List<ExpandedStandingsData> EasternConference { get => _EasternConference; }
        public List<ExpandedStandingsData> WesternConference { get => _WesternConference; }
        public List<ExpandedStandingsData> AtlanticDivision { get => _AtlanticDivision; }
        public List<ExpandedStandingsData> MetroPolitanDivision { get => _MetroPolitanDivision; }
        public List<ExpandedStandingsData> CentralDivision { get => _CentralDivision; }
        public List<ExpandedStandingsData> PacificDivision { get => _PacificDivision; }

        public async Task ReadStandings()
        {
            var result = new List<ExpandedStandingsData>();
            HttpClient client = new();
            //https://gitlab.com/dword4/nhlapi/-/blob/master/new-api.md
            var response = await client.GetStringAsync("https://api-web.nhle.com/v1/standings/now");
            NHLStandingsData data = JsonConvert.DeserializeObject<NHLStandingsData>(response) ?? new NHLStandingsData();
            foreach (var standing in data.Standings)
            {
                result.Add(new ExpandedStandingsData
                {
                    Conference = standing.ConferenceName,
                    Division = standing.DivisionName,
                    TeamName = standing.TeamName.Default,
                    GamesPlayed = (int)standing.GamesPlayed,
                    Wins = (int)standing.Wins,
                    Losses = (int)standing.Losses,
                    OTL = (int)standing.OtLosses,
                    Points = (int)standing.Points,
                    MaxPoints = (int)standing.Points + ((82 - (int)standing.GamesPlayed) * 2),
                    PredictedPoints = standing.GamesPlayed > 0 ? (int)Math.Truncate((float)standing.Points / (float)standing.GamesPlayed * 82) : 164
                });
            }

            //result = result.OrderBy(r => r.Conference).ThenBy(r => r.Division).ThenByDescending(r => r.Points).ToList();
            _League = result.OrderByDescending(r => r.Points).ThenBy(r => r.GamesPlayed).ToList();
            _EasternConference = result.Where(r => r.Conference.Equals("Eastern")).ToList();
            _WesternConference = result.Where(r => r.Conference.Equals("Western")).ToList();

            _AtlanticDivision = result.Where(r => r.Division.Equals("Atlantic")).ToList();
            _MetroPolitanDivision = result.Where(r => r.Division.Equals("Metropolitan")).ToList();
            _CentralDivision = result.Where(r => r.Division.Equals("Central")).ToList();
            _PacificDivision = result.Where(r => r.Division.Equals("Pacific")).ToList();

            //TODO Set Magic number for playoffs
            SetDivisionPosition(_AtlanticDivision);
            SetDivisionPosition(_MetroPolitanDivision);
            SetDivisionPosition(_CentralDivision);
            SetDivisionPosition(_PacificDivision);

            SetConferencePosition(_EasternConference);
            SetConferencePosition(_WesternConference);

            SetLeaguePosition(_League);
        }

        private void SetDivisionPosition(List<ExpandedStandingsData> data)
        {
            for (int i = 0; i < data.Count; i++)
            {
                var current = data[i].Points;
                var max = data[i].MaxPoints;

                for (int j = 0; j < data.Count; j++)
                {
                    if (max >= data[j].Points)
                    {
                        data[i].BestDivisionFinish = j + 1;
                        break;
                    }
                }

                for (int j = data.Count; j > 0; j--)
                {
                    if (current <= data[j - 1].MaxPoints)
                    {
                        data[i].WorstDivisionFinish = j;
                        break;
                    }
                }
            }
        }

        private void SetConferencePosition(List<ExpandedStandingsData> data)
        {
            for (int i = 0; i < data.Count; i++)
            {
                var current = data[i].Points;
                var max = data[i].MaxPoints;

                for (int j = 0; j < data.Count; j++)
                {
                    if (max >= data[j].Points)
                    {
                        data[i].BestConferenceFinish = j + 1;
                        break;
                    }
                }

                for (int j = data.Count; j > 0; j--)
                {
                    if (current <= data[j - 1].MaxPoints)
                    {
                        data[i].WorstConferenceFinish = j;
                        break;
                    }
                }
            }
        }

        private void SetLeaguePosition(List<ExpandedStandingsData> data)
        {
            for (int i = 0; i < data.Count; i++)
            {
                var current = data[i].Points;
                var max = data[i].MaxPoints;

                for (int j = 0; j < data.Count; j++)
                {
                    if (max >= data[j].Points)
                    {
                        data[i].BestLeagueFinish = j + 1;
                        break;
                    }
                }

                for (int j = data.Count; j > 0; j--)
                {
                    if (current <= data[j - 1].MaxPoints)
                    {
                        data[i].WorstLeagueFinish = j;
                        break;
                    }
                }
            }
        }
    }
}
