using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
	/// <summary>
	/// Team members and name.
	/// </summary>
	public class TeamModel
	{
		/// <summary>
		/// Represents the team members.
		/// </summary>
		public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

		/// <summary>
		/// Represents the team name.
		/// </summary>
		public string TeamName { get; set; }
	}
}
