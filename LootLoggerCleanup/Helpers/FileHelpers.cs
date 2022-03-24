namespace LootLoggerCleanup.Helpers
{
	public static class FileHelpers
	{
		public static void DeleteLines(List<int> lineIndexes, string path)
		{
			lineIndexes = lineIndexes.OrderByDescending(i => i).ToList();

			List<string>? textTines = File.ReadAllLines(path).ToList();

			foreach (int line in lineIndexes)
			{
				textTines.RemoveAt(line);
			}

			File.WriteAllLines((path), textTines.ToArray());
		}
	}
}
