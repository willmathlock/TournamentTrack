using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
	/// <summary>
    /// Represents one Prize
    /// </summary>
	public class PrizeModel
	{
		/// <summary>
        /// The place where such Prize would be given.
        /// </summary>
		public int PlaceNumber { get; set; }

		/// <summary>
        /// The name of such place.
        /// </summary>
		public string PlaceName { get; set; }

		/// <summary>
        /// The prize amount(decimal).
        /// </summary>
		public decimal PrizeAmount { get; set; }

		/// <summary>
        /// The prize percentage of the total prize.
        /// </summary>
		public double PrizePercentage { get; set; }
	}
}
