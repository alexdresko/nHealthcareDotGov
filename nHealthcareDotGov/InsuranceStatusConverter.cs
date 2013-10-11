namespace nHealthcareDotGov
{
	using System;
	using System.Collections.Generic;

	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	

	public class InsuranceStatusConverter : CustomCreationConverter<InsuranceStatus>
	{
		#region Public Methods and Operators

		public override InsuranceStatus Create(Type objectType)
		{
			return new InsuranceStatus();
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			var result = new InsuranceStatus();
			if (reader.TokenType == JsonToken.StartArray)
			{
				result.Items = serializer.Deserialize<List<string>>(reader);
			}
			else
			{
				result.Items = new List<string>();
			}
			if (reader.TokenType != JsonToken.StartArray && reader.Value != null && reader.Value.ToString().ToLower() == "all")
			{
				result.All = true;
			}

			return result;
		}

		#endregion
	}
}