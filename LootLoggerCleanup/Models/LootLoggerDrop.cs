using System.Text.Json.Serialization;

namespace LootLoggerCleanup.Models
{
	internal class LootLoggerDrop
	{
		[JsonPropertyName("name")]
		public string? Name { get; set; }

		[JsonPropertyName("id")]
		public int? Id { get; set; }

		[JsonPropertyName("quantity")]
		public int? Quantity { get; set; }

		[JsonPropertyName("price")]
		public int? Price { get; set; }
	}
}
