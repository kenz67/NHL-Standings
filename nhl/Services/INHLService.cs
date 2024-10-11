using nhl.Data;

namespace nhl.Services
{
    public interface INHLService
    {
        List<ExpandedStandingsData> AtlanticDivision { get; }
        List<ExpandedStandingsData> CentralDivision { get; }
        List<ExpandedStandingsData> EasternConference { get; }
        List<ExpandedStandingsData> League { get; }
        List<ExpandedStandingsData> MetroPolitanDivision { get; }
        List<ExpandedStandingsData> PacificDivision { get; }
        List<ExpandedStandingsData> WesternConference { get; }

        Task ReadStandings();
    }
}