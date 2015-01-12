namespace nHealthcareDotGov
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	public class BoolStringConverter : CustomCreationConverter<List<string>>
	{
		#region Public Methods and Operators

		public override List<string> Create(Type objectType)
		{
			return new List<string>();
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			var result = new List<string>();
			if (reader.TokenType == JsonToken.StartArray)
			{
				result = serializer.Deserialize<List<string>>(reader);
			}

			return result;
		}

		#endregion
	}

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
				if (reader.Value != null && reader.Value.ToString() == "up")
				{
					result = false;
				}
				else
				{
					result = serializer.Deserialize<bool>(reader);
				}
			}

			return result;
		}

		#endregion
	}
}