namespace nHealthcareDotGov
{
	using System.Collections.Generic;
	using System.Net.Http;
	using System.Text.RegularExpressions;
	using System.Threading.Tasks;

	using Newtonsoft.Json;

	public class HealthcareGovRepository
	{
		#region Public Methods and Operators

		public static async Task<IEnumerable<Article>> GetArticles()
		{
			using (var client = new HttpClient())
			{
				var data = await client.GetStringAsync("https://www.healthcare.gov/api/articles.json");
				data = data.Substring(0, data.Length - "},false]}".Length - 1) + "}]}";
				var converted = GetArticlesFromString(data);
				foreach (var article in converted.Articles)
				{
					article.Content = Regex.Replace(article.Content, "href=\"/", "href=\"http://www.healthcare.gov/");
					article.Excerpt = Regex.Replace(article.Excerpt, "href=\"/", "href=\"http://www.healthcare.gov/");
				}
				return converted.Articles;
			}

		}

		public static ArticlesContainer GetArticlesFromString(string data)
		{
			var converted = JsonConvert.DeserializeObject<ArticlesContainer>(data);
			return converted;
		}

		#endregion
	}
}