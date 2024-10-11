using Newtonsoft.Json;

namespace nhl.Data;
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class PlaceName
{
	[JsonProperty("default")]
	public string Default;

	[JsonProperty("fr")]
	public string Fr;
}

public class NHLStandingsData
{
	[JsonProperty("wildCardIndicator")]
	public bool? WildCardIndicator;

	[JsonProperty("standings")]
	public List<Standing> Standings;
}

public class Standing
{
	[JsonProperty("conferenceAbbrev")]
	public string ConferenceAbbrev;

	[JsonProperty("conferenceHomeSequence")]
	public int? ConferenceHomeSequence;

	[JsonProperty("conferenceL10Sequence")]
	public int? ConferenceL10Sequence;

	[JsonProperty("conferenceName")]
	public string ConferenceName;

	[JsonProperty("conferenceRoadSequence")]
	public int? ConferenceRoadSequence;

	[JsonProperty("conferenceSequence")]
	public int? ConferenceSequence;

	[JsonProperty("date")]
	public string Date;

	[JsonProperty("divisionAbbrev")]
	public string DivisionAbbrev;

	[JsonProperty("divisionHomeSequence")]
	public int? DivisionHomeSequence;

	[JsonProperty("divisionL10Sequence")]
	public int? DivisionL10Sequence;

	[JsonProperty("divisionName")]
	public string DivisionName;

	[JsonProperty("divisionRoadSequence")]
	public int? DivisionRoadSequence;

	[JsonProperty("divisionSequence")]
	public int? DivisionSequence;

	[JsonProperty("gameTypeId")]
	public int? GameTypeId;

	[JsonProperty("gamesPlayed")]
	public int? GamesPlayed;

	[JsonProperty("goalDifferential")]
	public int? GoalDifferential;

	[JsonProperty("goalDifferentialPctg")]
	public double? GoalDifferentialPctg;

	[JsonProperty("goalAgainst")]
	public int? GoalAgainst;

	[JsonProperty("goalFor")]
	public int? GoalFor;

	[JsonProperty("goalsForPctg")]
	public double? GoalsForPctg;

	[JsonProperty("homeGamesPlayed")]
	public int? HomeGamesPlayed;

	[JsonProperty("homeGoalDifferential")]
	public int? HomeGoalDifferential;

	[JsonProperty("homeGoalsAgainst")]
	public int? HomeGoalsAgainst;

	[JsonProperty("homeGoalsFor")]
	public int? HomeGoalsFor;

	[JsonProperty("homeLosses")]
	public int? HomeLosses;

	[JsonProperty("homeOtLosses")]
	public int? HomeOtLosses;

	[JsonProperty("homePoints")]
	public int? HomePoints;

	[JsonProperty("homeRegulationPlusOtWins")]
	public int? HomeRegulationPlusOtWins;

	[JsonProperty("homeRegulationWins")]
	public int? HomeRegulationWins;

	[JsonProperty("homeTies")]
	public int? HomeTies;

	[JsonProperty("homeWins")]
	public int? HomeWins;

	[JsonProperty("l10GamesPlayed")]
	public int? L10GamesPlayed;

	[JsonProperty("l10GoalDifferential")]
	public int? L10GoalDifferential;

	[JsonProperty("l10GoalsAgainst")]
	public int? L10GoalsAgainst;

	[JsonProperty("l10GoalsFor")]
	public int? L10GoalsFor;

	[JsonProperty("l10Losses")]
	public int? L10Losses;

	[JsonProperty("l10OtLosses")]
	public int? L10OtLosses;

	[JsonProperty("l10Points")]
	public int? L10Points;

	[JsonProperty("l10RegulationPlusOtWins")]
	public int? L10RegulationPlusOtWins;

	[JsonProperty("l10RegulationWins")]
	public int? L10RegulationWins;

	[JsonProperty("l10Ties")]
	public int? L10Ties;

	[JsonProperty("l10Wins")]
	public int? L10Wins;

	[JsonProperty("leagueHomeSequence")]
	public int? LeagueHomeSequence;

	[JsonProperty("leagueL10Sequence")]
	public int? LeagueL10Sequence;

	[JsonProperty("leagueRoadSequence")]
	public int? LeagueRoadSequence;

	[JsonProperty("leagueSequence")]
	public int? LeagueSequence;

	[JsonProperty("losses")]
	public int? Losses;

	[JsonProperty("otLosses")]
	public int? OtLosses;

	[JsonProperty("placeName")]
	public PlaceName PlaceName;

	[JsonProperty("pointPctg")]
	public double? PointPctg;

	[JsonProperty("points")]
	public int? Points;

	[JsonProperty("regulationPlusOtWinPctg")]
	public double? RegulationPlusOtWinPctg;

	[JsonProperty("regulationPlusOtWins")]
	public int? RegulationPlusOtWins;

	[JsonProperty("regulationWinPctg")]
	public double? RegulationWinPctg;

	[JsonProperty("regulationWins")]
	public int? RegulationWins;

	[JsonProperty("roadGamesPlayed")]
	public int? RoadGamesPlayed;

	[JsonProperty("roadGoalDifferential")]
	public int? RoadGoalDifferential;

	[JsonProperty("roadGoalsAgainst")]
	public int? RoadGoalsAgainst;

	[JsonProperty("roadGoalsFor")]
	public int? RoadGoalsFor;

	[JsonProperty("roadLosses")]
	public int? RoadLosses;

	[JsonProperty("roadOtLosses")]
	public int? RoadOtLosses;

	[JsonProperty("roadPoints")]
	public int? RoadPoints;

	[JsonProperty("roadRegulationPlusOtWins")]
	public int? RoadRegulationPlusOtWins;

	[JsonProperty("roadRegulationWins")]
	public int? RoadRegulationWins;

	[JsonProperty("roadTies")]
	public int? RoadTies;

	[JsonProperty("roadWins")]
	public int? RoadWins;

	[JsonProperty("seasonId")]
	public int? SeasonId;

	[JsonProperty("shootoutLosses")]
	public int? ShootoutLosses;

	[JsonProperty("shootoutWins")]
	public int? ShootoutWins;

	[JsonProperty("streakCode")]
	public string StreakCode;

	[JsonProperty("streakCount")]
	public int? StreakCount;

	[JsonProperty("teamName")]
	public TeamName TeamName;

	[JsonProperty("teamAbbrev")]
	public TeamAbbrev TeamAbbrev;

	[JsonProperty("teamLogo")]
	public string TeamLogo;

	[JsonProperty("ties")]
	public int? Ties;

	[JsonProperty("waiversSequence")]
	public int? WaiversSequence;

	[JsonProperty("wildcardSequence")]
	public int? WildcardSequence;

	[JsonProperty("winPctg")]
	public double? WinPctg;

	[JsonProperty("wins")]
	public int? Wins;
}

public class TeamAbbrev
{
	[JsonProperty("default")]
	public string Default;
}

public class TeamName
{
	[JsonProperty("default")]
	public string Default;

	[JsonProperty("fr")]
	public string Fr;
}