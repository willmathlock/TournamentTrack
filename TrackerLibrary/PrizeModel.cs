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
        /// The unique identifier for the prize.
        /// </summary>
        public int Id { get; set; }
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

        public PrizeModel()
        {

        }
        /// <summary>
        /// Constructor that receives all values as strings and does the parsing to store them as necessary.
        /// </summary>
        /// <param name="placeName"></param>
        /// <param name="placeNumber"></param>
        /// <param name="prizeAmount"></param>
        /// <param name="prizePercentage"></param>
        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue= 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(placeNumber, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
