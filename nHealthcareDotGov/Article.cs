namespace nHealthcareDotGov
{
	using System;
	using System.Collections.Generic;

	using Newtonsoft.Json;

	[JsonObject]
	public class Article
	{
		#region Public Properties

		[JsonProperty("audience")]
		public List<string> Audience { get; set; }

		[JsonProperty("barrier")]
		public string Barrier { get; set; }

		[JsonProperty("bite")]
		public string Bite { get; set; }

		[JsonProperty("categories")]
		public string[] Categories { get; set; }

		[JsonProperty("condition")]
		public string Condition { get; set; }

		[JsonProperty("content")]
		public string Content { get; set; }

		[JsonProperty("date")]
		public DateTime Date { get; set; }

		[JsonProperty("excerpt")]
		public string Excerpt { get; set; }

		[JsonProperty("featured")]
		[JsonConverter(typeof(FeaturedConverter))]
		public bool Featured { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty(propertyName: "insurance-status")]
		[JsonConverter(typeof(InsuranceStatusConverter))]
		public InsuranceStatus InsuranceStatus { get; set; }

		[JsonProperty("lang")]
		public string Lang { get; set; }

		[JsonProperty("layout")]
		public string Layout { get; set; }

		[JsonProperty("legislation")]
		public string Legislation { get; set; }

		[JsonProperty("life-event")]
		public string LifeEvent { get; set; }

		[JsonProperty("meta-description")]
		public string MetaDescription { get; set; }

		[JsonProperty("meta-title")]
		public string MetaTitle { get; set; }

		[JsonProperty("named-document")]
		public string NamedDocument { get; set; }

		[JsonProperty("other-subject")]
		public string OtherSubject { get; set; }

		[JsonProperty("path")]
		public string Path { get; set; }

		[JsonProperty("plan")]
		public string Plan { get; set; }

		[JsonProperty("process-step")]
		public string ProcessStep { get; set; }

		[JsonProperty("published")]
		public bool? Published { get; set; }

		[JsonProperty("question-header")]
		public string QuestionHeader { get; set; }

		[JsonProperty("questions")]
		public string[] Questions { get; set; }

		[JsonProperty("related")]
		[JsonConverter(typeof(BoolStringConverter))]
		public List<string> Related { get; set; }

		[JsonProperty("segment")]
		public string Segment { get; set; }

		[JsonProperty("seo-keywords")]
		public string SeoKeywords { get; set; }

		[JsonProperty("sort")]
		public int Sort { get; set; }

		[JsonProperty("state-dropdown")]
		public string StateDropdown { get; set; }

		[JsonProperty("tags")]
		public string[] Tags { get; set; }

		[JsonProperty("target-population")]
		public string TargetPopulation { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("title-short")]
		public string TitleShort { get; set; }

		[JsonProperty("topics")]
		public string[] Topics { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }

		#endregion
	}
}