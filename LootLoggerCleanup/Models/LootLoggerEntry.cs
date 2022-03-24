using System.Text.Json.Serialization;

namespace LootLoggerCleanup.Models
{
	internal class LootLoggerEntry
	{
		[JsonPropertyName("name")]
		public string? Name { get; set; }

		[JsonPropertyName("level")]
		public int Level { get; set; }

		[JsonPropertyName("killCount")]
		public int KillCount { get; set; }

		[JsonPropertyName("type")]
		public string? Type { get; set; }

		[JsonPropertyName("drops")]
		public List<LootLoggerDrop>? Drops { get; set; }

		[JsonPropertyName("date")]
		public string? Date { get; set; }
	}
}
