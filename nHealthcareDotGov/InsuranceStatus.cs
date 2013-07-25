namespace nHealthcareDotGov
{
	using System.Collections.Generic;

	using Newtonsoft.Json;

	[JsonObject]
	public class InsuranceStatus
	{
		#region Constructors and Destructors

		public InsuranceStatus()
		{
			this.Items = new List<string>();
		}

		#endregion

		#region Public Properties

		public bool All { get; set; }
		public List<string> Items { get; set; }

		#endregion
	}
}