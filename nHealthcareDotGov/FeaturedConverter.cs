namespace nHealthcareDotGov
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	public class FeaturedConverter : CustomCreationConverter<bool>
	{
		#region Public Methods and Operators

		public override bool Create(Type objectType)
		{
			return false;
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			var result = false;
			if (reader.TokenType == JsonToken.StartArray)
			{
				result = serializer.Deserialize<List<bool>>(reader).First();
			}
			else
			{
				result = serializer.Deserialize<bool>(reader);
			}

			return result;
		}

		#endregion
	}
}