using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
	public class TournamentModel
	{
		/// <summary>
		/// Represents the Tournament Name.
		/// </summary>
		public string TournamentName { get; set; }

		/// <summary>
		/// Represents the Fee to enter said tournament.
		/// </summary>
		public decimal EntryFee { get; set; }

		/// <summary>
		/// Represents which teams are participating on the tournament.
		/// </summary>
		public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

		/// <summary>
		/// Represents the prizes from the tournament classification.
		/// </summary>
		public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

		/// <summary>
		/// Represents the rounds of a matchup.
		/// </summary>
		public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

	}
}
