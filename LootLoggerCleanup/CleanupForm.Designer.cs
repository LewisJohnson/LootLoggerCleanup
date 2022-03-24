namespace LootLoggerCleanup
{
	partial class CleanupForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.StartDateLabel = new System.Windows.Forms.Label();
			this.EndDateLabel = new System.Windows.Forms.Label();
			this.StartDateDatePicker = new System.Windows.Forms.DateTimePicker();
			this.EndDateDatePicker = new System.Windows.Forms.DateTimePicker();
			this.AccountsCheckedListBox = new System.Windows.Forms.CheckedListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.CleanUpButton = new System.Windows.Forms.Button();
			this.StatusStrip = new System.Windows.Forms.StatusStrip();
			this.ToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
			this.ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.TwistedButton = new System.Windows.Forms.Button();
			this.TrailblazerButton = new System.Windows.Forms.Button();
			this.ShatteredRelicsButton = new System.Windows.Forms.Button();
			this.AccountsTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.ErrorLabel = new System.Windows.Forms.Label();
			this.ResultsTextBox = new System.Windows.Forms.TextBox();
			this.EntriesWithoutDateCheckBox = new System.Windows.Forms.CheckBox();
			this.StatusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// StartDateLabel
			// 
			this.StartDateLabel.AutoSize = true;
			this.StartDateLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.StartDateLabel.Location = new System.Drawing.Point(15, 298);
			this.StartDateLabel.Name = "StartDateLabel";
			this.StartDateLabel.Size = new System.Drawing.Size(76, 20);
			this.StartDateLabel.TabIndex = 0;
			this.StartDateLabel.Text = "Start Date";
			// 
			// EndDateLabel
			// 
			this.EndDateLabel.AutoSize = true;
			this.EndDateLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.EndDateLabel.Location = new System.Drawing.Point(15, 334);
			this.EndDateLabel.Name = "EndDateLabel";
			this.EndDateLabel.Size = new System.Drawing.Size(70, 20);
			this.EndDateLabel.TabIndex = 1;
			this.EndDateLabel.Text = "End Date";
			// 
			// StartDateDatePicker
			// 
			this.StartDateDatePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.StartDateDatePicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.StartDateDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.StartDateDatePicker.Location = new System.Drawing.Point(97, 298);
			this.StartDateDatePicker.Name = "StartDateDatePicker";
			this.StartDateDatePicker.Size = new System.Drawing.Size(113, 27);
			this.StartDateDatePicker.TabIndex = 2;
			this.StartDateDatePicker.Value = new System.DateTime(2022, 1, 19, 0, 0, 0, 0);
			// 
			// EndDateDatePicker
			// 
			this.EndDateDatePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.EndDateDatePicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.EndDateDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.EndDateDatePicker.Location = new System.Drawing.Point(97, 334);
			this.EndDateDatePicker.Name = "EndDateDatePicker";
			this.EndDateDatePicker.Size = new System.Drawing.Size(113, 27);
			this.EndDateDatePicker.TabIndex = 3;
			this.EndDateDatePicker.Value = new System.DateTime(2022, 3, 16, 0, 0, 0, 0);
			// 
			// AccountsCheckedListBox
			// 
			this.AccountsCheckedListBox.CheckOnClick = true;
			this.AccountsCheckedListBox.FormattingEnabled = true;
			this.AccountsCheckedListBox.Location = new System.Drawing.Point(376, 137);
			this.AccountsCheckedListBox.Name = "AccountsCheckedListBox";
			this.AccountsCheckedListBox.Size = new System.Drawing.Size(441, 246);
			this.AccountsCheckedListBox.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(8, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 37);
			this.label1.TabIndex = 5;
			this.label1.Text = "Dates";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(376, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(195, 37);
			this.label2.TabIndex = 6;
			this.label2.Text = "OSRS Accounts";
			// 
			// CleanUpButton
			// 
			this.CleanUpButton.BackColor = System.Drawing.Color.LightSkyBlue;
			this.CleanUpButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.CleanUpButton.Location = new System.Drawing.Point(656, 389);
			this.CleanUpButton.Name = "CleanUpButton";
			this.CleanUpButton.Size = new System.Drawing.Size(161, 37);
			this.CleanUpButton.TabIndex = 7;
			this.CleanUpButton.Text = "Start Clean-up";
			this.CleanUpButton.UseVisualStyleBackColor = false;
			this.CleanUpButton.Click += new System.EventHandler(this.CleanUpButton_Click);
			// 
			// StatusStrip
			// 
			this.StatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripProgressBar,
            this.ToolStripStatusLabel});
			this.StatusStrip.Location = new System.Drawing.Point(0, 798);
			this.StatusStrip.Name = "StatusStrip";
			this.StatusStrip.Size = new System.Drawing.Size(829, 26);
			this.StatusStrip.SizingGrip = false;
			this.StatusStrip.TabIndex = 9;
			this.StatusStrip.Text = "statusStrip1";
			// 
			// ToolStripProgressBar
			// 
			this.ToolStripProgressBar.Name = "ToolStripProgressBar";
			this.ToolStripProgressBar.Size = new System.Drawing.Size(200, 18);
			// 
			// ToolStripStatusLabel
			// 
			this.ToolStripStatusLabel.Name = "ToolStripStatusLabel";
			this.ToolStripStatusLabel.Size = new System.Drawing.Size(77, 20);
			this.ToolStripStatusLabel.Text = "                 ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 19);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(733, 20);
			this.label3.TabIndex = 10;
			this.label3.Text = "This app will remove entries from RuneLite\'s Loot Logger for the selected account" +
    "s during the specified dates.";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(12, 104);
			this.label4.Margin = new System.Windows.Forms.Padding(0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 28);
			this.label4.TabIndex = 11;
			this.label4.Text = "Events";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(12, 261);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(125, 28);
			this.label5.TabIndex = 12;
			this.label5.Text = "Custom Date";
			// 
			// TwistedButton
			// 
			this.TwistedButton.Location = new System.Drawing.Point(15, 207);
			this.TwistedButton.Name = "TwistedButton";
			this.TwistedButton.Size = new System.Drawing.Size(210, 29);
			this.TwistedButton.TabIndex = 13;
			this.TwistedButton.Text = "Twisted League";
			this.TwistedButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.TwistedButton.UseVisualStyleBackColor = true;
			this.TwistedButton.Click += new System.EventHandler(this.TwistedButton_Click);
			// 
			// TrailblazerButton
			// 
			this.TrailblazerButton.Location = new System.Drawing.Point(15, 172);
			this.TrailblazerButton.Name = "TrailblazerButton";
			this.TrailblazerButton.Size = new System.Drawing.Size(210, 29);
			this.TrailblazerButton.TabIndex = 14;
			this.TrailblazerButton.Text = "Trailblazer League";
			this.TrailblazerButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.TrailblazerButton.UseVisualStyleBackColor = true;
			this.TrailblazerButton.Click += new System.EventHandler(this.TrailblazerButton_Click);
			// 
			// ShatteredRelicsButton
			// 
			this.ShatteredRelicsButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ShatteredRelicsButton.Location = new System.Drawing.Point(15, 137);
			this.ShatteredRelicsButton.Name = "ShatteredRelicsButton";
			this.ShatteredRelicsButton.Size = new System.Drawing.Size(210, 29);
			this.ShatteredRelicsButton.TabIndex = 15;
			this.ShatteredRelicsButton.Text = "Shattered Relics League";
			this.ShatteredRelicsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ShatteredRelicsButton.UseVisualStyleBackColor = true;
			this.ShatteredRelicsButton.Click += new System.EventHandler(this.ShatteredRelicsButton_Click);
			// 
			// AccountsTextBox
			// 
			this.AccountsTextBox.Location = new System.Drawing.Point(433, 104);
			this.AccountsTextBox.Name = "AccountsTextBox";
			this.AccountsTextBox.Size = new System.Drawing.Size(384, 27);
			this.AccountsTextBox.TabIndex = 16;
			this.AccountsTextBox.TextChanged += new System.EventHandler(this.AccountsTextBox_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(376, 107);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(51, 20);
			this.label6.TabIndex = 17;
			this.label6.Text = "Folder";
			// 
			// ErrorLabel
			// 
			this.ErrorLabel.BackColor = System.Drawing.Color.DarkRed;
			this.ErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.ErrorLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.ErrorLabel.Location = new System.Drawing.Point(8, 432);
			this.ErrorLabel.Name = "ErrorLabel";
			this.ErrorLabel.Size = new System.Drawing.Size(809, 25);
			this.ErrorLabel.TabIndex = 18;
			this.ErrorLabel.Text = "This is an error";
			this.ErrorLabel.Visible = false;
			// 
			// ResultsTextBox
			// 
			this.ResultsTextBox.AcceptsReturn = true;
			this.ResultsTextBox.AcceptsTab = true;
			this.ResultsTextBox.Location = new System.Drawing.Point(8, 460);
			this.ResultsTextBox.MinimumSize = new System.Drawing.Size(0, 120);
			this.ResultsTextBox.Multiline = true;
			this.ResultsTextBox.Name = "ResultsTextBox";
			this.ResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.ResultsTextBox.Size = new System.Drawing.Size(809, 330);
			this.ResultsTextBox.TabIndex = 19;
			// 
			// EntriesWithoutDateCheckBox
			// 
			this.EntriesWithoutDateCheckBox.AutoSize = true;
			this.EntriesWithoutDateCheckBox.Location = new System.Drawing.Point(376, 398);
			this.EntriesWithoutDateCheckBox.Name = "EntriesWithoutDateCheckBox";
			this.EntriesWithoutDateCheckBox.Size = new System.Drawing.Size(203, 24);
			this.EntriesWithoutDateCheckBox.TabIndex = 20;
			this.EntriesWithoutDateCheckBox.Text = "Show entries without date";
			this.EntriesWithoutDateCheckBox.UseVisualStyleBackColor = true;
			this.EntriesWithoutDateCheckBox.CheckedChanged += new System.EventHandler(this.EntriesWithoutDateCheckBox_CheckedChanged);
			// 
			// CleanupForm
			// 
			this.ClientSize = new System.Drawing.Size(829, 824);
			this.Controls.Add(this.EntriesWithoutDateCheckBox);
			this.Controls.Add(this.ErrorLabel);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.AccountsTextBox);
			this.Controls.Add(this.ShatteredRelicsButton);
			this.Controls.Add(this.TrailblazerButton);
			this.Controls.Add(this.TwistedButton);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.StatusStrip);
			this.Controls.Add(this.CleanUpButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.AccountsCheckedListBox);
			this.Controls.Add(this.EndDateDatePicker);
			this.Controls.Add(this.StartDateDatePicker);
			this.Controls.Add(this.EndDateLabel);
			this.Controls.Add(this.StartDateLabel);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.ResultsTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.HelpButton = true;
			this.Name = "CleanupForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "OSRS | RuneLite Loot Logger Cleanup";
			this.Load += new System.EventHandler(this.OnLoad);
			this.StatusStrip.ResumeLayout(false);
			this.StatusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label StartDateLabel;
		private Label EndDateLabel;
		private DateTimePicker StartDateDatePicker;
		private CheckedListBox AccountsCheckedListBox;
		private Label label1;
		private Label label2;
		private Button CleanUpButton;
		private StatusStrip StatusStrip;
		private ToolStripProgressBar ToolStripProgressBar;
		private DateTimePicker EndDateDatePicker;
		private Label label3;
		private Label label4;
		private Label label5;
		private Button TwistedButton;
		private Button TrailblazerButton;
		private Button ShatteredRelicsButton;
		private TextBox AccountsTextBox;
		private Label label6;
		private Label ErrorLabel;
		private ToolStripStatusLabel ToolStripStatusLabel;
		private TextBox ResultsTextBox;
		private CheckBox EntriesWithoutDateCheckBox;
	}
}