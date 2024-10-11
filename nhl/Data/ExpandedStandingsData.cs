namespace nhl.Data
{
    public class ExpandedStandingsData
    {
        public String Conference { get; set; }
        public String Division { get; set; }
        public String TeamName { get; set; }
        public int GamesPlayed { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int OTL { get; set; }
        public int Points { get; set; }
        public int MaxPoints { get; set; }
        public int PredictedPoints { get; set; }
        public int BestDivisionFinish { get; set; }
        public int BestConferenceFinish { get; set; }
        public int BestLeagueFinish { get; set; }
        public int WorstDivisionFinish { get; set; }
        public int WorstConferenceFinish { get; set; }
        public int WorstLeagueFinish { get; set; }
    }
}
