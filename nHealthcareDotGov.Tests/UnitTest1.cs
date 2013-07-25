namespace nHealthcareDotGov.Tests
{
	using System.Linq;

	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class UnitTest1
	{
		#region Public Methods and Operators

		[TestMethod]
		public void TestMethod1()
		{
			var articles = HealthcareGovRepository.GetArticles();
			articles.Wait(10000);

			Assert.IsFalse(articles.Result.Any(p => p.Content.Contains("€")), "Has funny character");
			Assert.IsFalse(articles.Result.Any(p => p.Content.Contains("???")), "Has ???");
			Assert.IsFalse(articles.Result.Any(p => p.Content.Contains("â")), "has â");
			Assert.IsTrue(articles.Result.Any(), "Did not return any articles");
		}

		#endregion
	}
}