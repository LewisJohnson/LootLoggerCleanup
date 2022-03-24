using LootLoggerCleanup.Helpers;
using LootLoggerCleanup.Models;
using System.Text.Json;

namespace LootLoggerCleanup
{
	public partial class CleanupForm : Form
	{
		private bool writeEntriesWithoutDateToResultsTextbox = false;

		public CleanupForm()
		{
			InitializeComponent();
		}


		private void CleanUpButton_Click(object sender, EventArgs e)
		{
			ResultsTextBox.Text = string.Empty;
			ErrorLabel.Visible = false;

			ListBox.SelectedObjectCollection? accountsSelected = AccountsCheckedListBox.SelectedItems;

			ToolStripStatusLabel.Text = "Reading files";
			StatusStrip.Update();

			if (accountsSelected.Count < 1)
			{
				ErrorLabel.Visible = true;
				ErrorLabel.Text = $"Please select at least 1 account";

				return;
			}

			string lootBaseDir = AccountsTextBox.Text;
		
			DateTime startDate = StartDateDatePicker.Value;
			DateTime endDate = EndDateDatePicker.Value;

			foreach (var account in accountsSelected)
			{
				ToolStripStatusLabel.Text = $"Starting clean-up for account: '{ account }'";
				StatusStrip.Update();

				string npcFilePath = $"{lootBaseDir}\\{ account }\\npc";
				string[] npcLogFilesPaths = Directory.GetFiles(npcFilePath, "*.log");

				if (npcLogFilesPaths.Length < 1)
				{
					ErrorLabel.Visible = true;
					ErrorLabel.Text = $"Could not find any log entries for account: { account }";

					return;
				}

				List<string> errorFiles = new List<string>();

				foreach (string logFilePath in npcLogFilesPaths)
				{
					ToolStripStatusLabel.Text = $"{ account }: Cleaning file { logFilePath }";
					StatusStrip.Update();

					// We need to read line-by-line as the logs are saved as JSONL
					string[]? jsonLines = File.ReadAllLines(logFilePath);
					List<int> linesToDelete = new List<int>();

					for (int i = 0; i < jsonLines.Length; i++)
					{
						var line = jsonLines[i];
						LootLoggerEntry loggerFile = JsonSerializer.Deserialize<LootLoggerEntry>(line)!;

						// Skip or log to results textbox if we can't find a date
						if (loggerFile.Date == null)
						{
							if (writeEntriesWithoutDateToResultsTextbox)
							{
								if (!errorFiles.Contains(logFilePath))
								{
									errorFiles.Add(logFilePath);

									ResultsTextBox.AppendText($"Could not find date for some entries in file { logFilePath }");
									ResultsTextBox.AppendText(Environment.NewLine);
								}

								ResultsTextBox.AppendText($"\tNPC: { loggerFile.Name } (Level: { loggerFile.Level })");
								ResultsTextBox.AppendText(Environment.NewLine);

								if (loggerFile.Drops != null && loggerFile.Drops.Count > 0)
								{
									foreach (LootLoggerDrop? drop in loggerFile.Drops)
									{
										ResultsTextBox.AppendText($"\t\tDrop: { drop.Name } ({ drop.Quantity })");
										ResultsTextBox.AppendText(Environment.NewLine);
									}
								}
							}

							continue;
						}

						DateTime entryDate = DateTime.Parse(loggerFile.Date);

						if (entryDate >= startDate && startDate <= endDate)
						{
							linesToDelete.Add(i);
						}
					}

					if (linesToDelete.Count > 0)
					{
						ResultsTextBox.AppendText($"{account}: Deleting { linesToDelete.Count } entries from { Path.GetFileName(logFilePath) }");
						ResultsTextBox.AppendText(Environment.NewLine);

						FileHelpers.DeleteLines(linesToDelete, logFilePath);
					}
				}

				ToolStripStatusLabel.Text = "Done";
				ToolStripProgressBar.Value = 100;
			}
		}

		public void OnLoad(object sender, EventArgs e)
		{
			string accountsDirLocation = $"C:\\Users\\{ Environment.UserName }\\.runelite\\loots";

			AccountsTextBox.Text = accountsDirLocation;
		}

		private void ShatteredRelicsButton_Click(object sender, EventArgs e)
		{
			StartDateDatePicker.Value = new DateTime(2022, 1, 19);
			EndDateDatePicker.Value = new DateTime(2022, 3, 16);
		}

		private void TrailblazerButton_Click(object sender, EventArgs e)
		{
			StartDateDatePicker.Value = new DateTime(2020, 10, 28);
			EndDateDatePicker.Value = new DateTime(2021, 1, 6);
		}

		private void TwistedButton_Click(object sender, EventArgs e)
		{
			StartDateDatePicker.Value = new DateTime(2019, 11, 14);
			EndDateDatePicker.Value = new DateTime(2020, 1, 16);
		}

		private void AccountsTextBox_TextChanged(object sender, EventArgs e)
		{
			ErrorLabel.Visible = false;

			TextBox accountsTextBox = (TextBox)sender;
			string accountsDirLocation = accountsTextBox.Text;

			AccountsCheckedListBox.Items.Clear();

			try
			{
				string[] accountsDir = Directory.GetDirectories(accountsDirLocation);

				foreach (var dir in accountsDir)
				{
					DirectoryInfo dirInfo = new DirectoryInfo(dir);
					AccountsCheckedListBox.Items.Add(dirInfo.Name);
				}
			}
			catch (Exception)
			{
				ErrorLabel.Visible = true;
				ErrorLabel.Text = $"Unable to find any user accounts in at: { accountsDirLocation }";
			}
		}

		private void EntriesWithoutDateCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox entriesCheckBox = (CheckBox)sender;

			if (entriesCheckBox.Checked)
			{
				writeEntriesWithoutDateToResultsTextbox = true;
			}
			else
			{
				writeEntriesWithoutDateToResultsTextbox = false;
			}

		}
	}
}