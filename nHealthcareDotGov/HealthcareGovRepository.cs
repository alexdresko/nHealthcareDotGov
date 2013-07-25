namespace nHealthcareDotGov
{
	using System.Collections.Generic;
	using System.Net.Http;
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
				var converted = JsonConvert.DeserializeObject<ArticlesContainer>(data);
				return converted.Articles;
			}

			//using (var client = new WebClient())
			//{
			//	client.Encoding = Encoding.UTF8;
			//	var data = await client.DownloadStringTaskAsync("https://www.healthcare.gov/api/articles.json");
			//	data = data.Substring(0, data.Length - "},false]}".Length - 1) + "}]}";
			//	var converted = JsonConvert.DeserializeObject<ArticlesContainer>(data);
			//	return converted.Articles;
			//}
		}

		#endregion
	}
}