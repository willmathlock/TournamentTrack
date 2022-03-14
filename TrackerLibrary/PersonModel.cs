using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
	/// <summary>
	/// Represents one person.
	/// </summary>
	public class PersonModel
	{
		/// <summary>
		/// First name of the Person.
		/// </summary>
		public string FirstName { get; set; }

		/// <summary>
		/// Last name of a Person.
		/// </summary>
		public string LastName { get; set; }

		/// <summary>
		/// Email Address of a Person.
		/// </summary>
		public string EmailAddress { get; set; }

		/// <summary>
		/// Cellphone number(string) of a Person.
		/// </summary>
		public string Cellphone { get; set; }
	}
}
