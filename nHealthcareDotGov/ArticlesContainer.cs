namespace nHealthcareDotGov
{
	using System.Collections.Generic;

	using Newtonsoft.Json;

	[JsonObject]
	public class ArticlesContainer
	{
		#region Public Properties

		[JsonProperty("articles")]
		public List<Article> Articles { get; set; }

		#endregion
	}
}