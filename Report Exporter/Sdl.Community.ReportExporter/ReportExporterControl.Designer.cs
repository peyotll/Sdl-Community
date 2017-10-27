﻿namespace Sdl.Community.ReportExporter
{
	partial class ReportExporterControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportExporterControl));
			this.mainPanel = new System.Windows.Forms.Panel();
			this.adaptiveMT = new System.Windows.Forms.CheckBox();
			this.adaptiveLearnings = new System.Windows.Forms.CheckBox();
			this.optionsLabel = new System.Windows.Forms.Label();
			this.exitBtn = new System.Windows.Forms.Button();
			this.targetBtn = new System.Windows.Forms.Button();
			this.csvBtn = new System.Windows.Forms.Button();
			this.copyBtn = new System.Windows.Forms.Button();
			this.languagesListBox = new System.Windows.Forms.CheckedListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.includeHeaderCheck = new System.Windows.Forms.CheckBox();
			this.projListbox = new System.Windows.Forms.ListBox();
			this.selectProjLbl = new System.Windows.Forms.Label();
			this.internalFuzzies = new System.Windows.Forms.CheckBox();
			this.locked = new System.Windows.Forms.CheckBox();
			this.perfectMatch = new System.Windows.Forms.CheckBox();
			this.contextMatch = new System.Windows.Forms.CheckBox();
			this.crossRep = new System.Windows.Forms.CheckBox();
			this.mainPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.crossRep);
			this.mainPanel.Controls.Add(this.contextMatch);
			this.mainPanel.Controls.Add(this.perfectMatch);
			this.mainPanel.Controls.Add(this.locked);
			this.mainPanel.Controls.Add(this.internalFuzzies);
			this.mainPanel.Controls.Add(this.adaptiveMT);
			this.mainPanel.Controls.Add(this.adaptiveLearnings);
			this.mainPanel.Controls.Add(this.optionsLabel);
			this.mainPanel.Controls.Add(this.exitBtn);
			this.mainPanel.Controls.Add(this.targetBtn);
			this.mainPanel.Controls.Add(this.csvBtn);
			this.mainPanel.Controls.Add(this.copyBtn);
			this.mainPanel.Controls.Add(this.languagesListBox);
			this.mainPanel.Controls.Add(this.label1);
			this.mainPanel.Controls.Add(this.includeHeaderCheck);
			this.mainPanel.Controls.Add(this.projListbox);
			this.mainPanel.Controls.Add(this.selectProjLbl);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(626, 447);
			this.mainPanel.TabIndex = 0;
			// 
			// adaptiveMT
			// 
			this.adaptiveMT.AutoSize = true;
			this.adaptiveMT.Location = new System.Drawing.Point(431, 213);
			this.adaptiveMT.Name = "adaptiveMT";
			this.adaptiveMT.Size = new System.Drawing.Size(130, 17);
			this.adaptiveMT.TabIndex = 15;
			this.adaptiveMT.Text = "Adaptive MT Baseline";
			this.adaptiveMT.UseVisualStyleBackColor = true;
			this.adaptiveMT.CheckedChanged += new System.EventHandler(this.adaptiveMT_CheckedChanged);
			// 
			// adaptiveLearnings
			// 
			this.adaptiveLearnings.AutoSize = true;
			this.adaptiveLearnings.Location = new System.Drawing.Point(432, 190);
			this.adaptiveLearnings.Name = "adaptiveLearnings";
			this.adaptiveLearnings.Size = new System.Drawing.Size(158, 17);
			this.adaptiveLearnings.TabIndex = 14;
			this.adaptiveLearnings.Text = "Adaptive MT with Learnings";
			this.adaptiveLearnings.UseVisualStyleBackColor = true;
			this.adaptiveLearnings.CheckedChanged += new System.EventHandler(this.fragmentMatches_CheckedChanged);
			// 
			// optionsLabel
			// 
			this.optionsLabel.AutoSize = true;
			this.optionsLabel.Location = new System.Drawing.Point(433, 174);
			this.optionsLabel.Name = "optionsLabel";
			this.optionsLabel.Size = new System.Drawing.Size(137, 13);
			this.optionsLabel.TabIndex = 12;
			this.optionsLabel.Text = "Aditional Report Information";
			// 
			// exitBtn
			// 
			this.exitBtn.Location = new System.Drawing.Point(432, 401);
			this.exitBtn.Name = "exitBtn";
			this.exitBtn.Size = new System.Drawing.Size(107, 23);
			this.exitBtn.TabIndex = 11;
			this.exitBtn.Text = "Exit";
			this.exitBtn.UseVisualStyleBackColor = true;
			this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
			// 
			// targetBtn
			// 
			this.targetBtn.Location = new System.Drawing.Point(433, 136);
			this.targetBtn.Name = "targetBtn";
			this.targetBtn.Size = new System.Drawing.Size(107, 23);
			this.targetBtn.TabIndex = 10;
			this.targetBtn.Text = "Open Target Folder";
			this.targetBtn.UseVisualStyleBackColor = true;
			this.targetBtn.Click += new System.EventHandler(this.targetBtn_Click);
			// 
			// csvBtn
			// 
			this.csvBtn.Location = new System.Drawing.Point(432, 107);
			this.csvBtn.Name = "csvBtn";
			this.csvBtn.Size = new System.Drawing.Size(107, 23);
			this.csvBtn.TabIndex = 9;
			this.csvBtn.Text = "Copy to CSV files";
			this.csvBtn.UseVisualStyleBackColor = true;
			this.csvBtn.Click += new System.EventHandler(this.csvBtn_Click);
			// 
			// copyBtn
			// 
			this.copyBtn.Location = new System.Drawing.Point(431, 75);
			this.copyBtn.Name = "copyBtn";
			this.copyBtn.Size = new System.Drawing.Size(108, 23);
			this.copyBtn.TabIndex = 8;
			this.copyBtn.Text = "Copy to clipboard";
			this.copyBtn.UseVisualStyleBackColor = true;
			this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
			// 
			// languagesListBox
			// 
			this.languagesListBox.FormattingEnabled = true;
			this.languagesListBox.Location = new System.Drawing.Point(249, 75);
			this.languagesListBox.Name = "languagesListBox";
			this.languagesListBox.Size = new System.Drawing.Size(177, 349);
			this.languagesListBox.TabIndex = 7;
			this.languagesListBox.SelectedIndexChanged += new System.EventHandler(this.languagesListBox_SelectedIndexChanged_1);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(246, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Select language(s) for export:";
			// 
			// includeHeaderCheck
			// 
			this.includeHeaderCheck.AutoSize = true;
			this.includeHeaderCheck.Location = new System.Drawing.Point(251, 30);
			this.includeHeaderCheck.Name = "includeHeaderCheck";
			this.includeHeaderCheck.Size = new System.Drawing.Size(140, 17);
			this.includeHeaderCheck.TabIndex = 5;
			this.includeHeaderCheck.Text = "Include header in export";
			this.includeHeaderCheck.UseVisualStyleBackColor = true;
			this.includeHeaderCheck.CheckedChanged += new System.EventHandler(this.includeHeaderCheck_CheckedChanged);
			// 
			// projListbox
			// 
			this.projListbox.FormattingEnabled = true;
			this.projListbox.Location = new System.Drawing.Point(19, 30);
			this.projListbox.Name = "projListbox";
			this.projListbox.Size = new System.Drawing.Size(221, 394);
			this.projListbox.TabIndex = 1;
			this.projListbox.SelectedIndexChanged += new System.EventHandler(this.projListbox_SelectedIndexChanged);
			// 
			// selectProjLbl
			// 
			this.selectProjLbl.AutoSize = true;
			this.selectProjLbl.Location = new System.Drawing.Point(16, 9);
			this.selectProjLbl.Name = "selectProjLbl";
			this.selectProjLbl.Size = new System.Drawing.Size(75, 13);
			this.selectProjLbl.TabIndex = 0;
			this.selectProjLbl.Text = "Select project:";
			// 
			// internalFuzzies
			// 
			this.internalFuzzies.AutoSize = true;
			this.internalFuzzies.Location = new System.Drawing.Point(431, 236);
			this.internalFuzzies.Name = "internalFuzzies";
			this.internalFuzzies.Size = new System.Drawing.Size(99, 17);
			this.internalFuzzies.TabIndex = 16;
			this.internalFuzzies.Text = "Internal Fuzzies";
			this.internalFuzzies.UseVisualStyleBackColor = true;
			this.internalFuzzies.CheckedChanged += new System.EventHandler(this.internalFuzzies_CheckedChanged);
			// 
			// locked
			// 
			this.locked.AutoSize = true;
			this.locked.Location = new System.Drawing.Point(431, 260);
			this.locked.Name = "locked";
			this.locked.Size = new System.Drawing.Size(62, 17);
			this.locked.TabIndex = 17;
			this.locked.Text = "Locked";
			this.locked.UseVisualStyleBackColor = true;
			this.locked.CheckedChanged += new System.EventHandler(this.locked_CheckedChanged);
			// 
			// perfectMatch
			// 
			this.perfectMatch.AutoSize = true;
			this.perfectMatch.Location = new System.Drawing.Point(431, 284);
			this.perfectMatch.Name = "perfectMatch";
			this.perfectMatch.Size = new System.Drawing.Size(93, 17);
			this.perfectMatch.TabIndex = 18;
			this.perfectMatch.Text = "Perfect Match";
			this.perfectMatch.UseVisualStyleBackColor = true;
			this.perfectMatch.CheckedChanged += new System.EventHandler(this.perfectMatch_CheckedChanged);
			// 
			// contextMatch
			// 
			this.contextMatch.AutoSize = true;
			this.contextMatch.Location = new System.Drawing.Point(431, 308);
			this.contextMatch.Name = "contextMatch";
			this.contextMatch.Size = new System.Drawing.Size(95, 17);
			this.contextMatch.TabIndex = 19;
			this.contextMatch.Text = "Context Match";
			this.contextMatch.UseVisualStyleBackColor = true;
			this.contextMatch.CheckedChanged += new System.EventHandler(this.contextMatch_CheckedChanged);
			// 
			// crossRep
			// 
			this.crossRep.AutoSize = true;
			this.crossRep.Location = new System.Drawing.Point(431, 332);
			this.crossRep.Name = "crossRep";
			this.crossRep.Size = new System.Drawing.Size(127, 17);
			this.crossRep.TabIndex = 20;
			this.crossRep.Text = "Cross File Repetitions";
			this.crossRep.UseVisualStyleBackColor = true;
			this.crossRep.CheckedChanged += new System.EventHandler(this.crossRep_CheckedChanged);
			// 
			// ReportExporterControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(626, 447);
			this.Controls.Add(this.mainPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ReportExporterControl";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SDL Trados Studio 2017 – Export Analysis Reports";
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Label selectProjLbl;
		private System.Windows.Forms.ListBox projListbox;
		private System.Windows.Forms.CheckBox includeHeaderCheck;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckedListBox languagesListBox;
		private System.Windows.Forms.Button copyBtn;
		private System.Windows.Forms.Button exitBtn;
		private System.Windows.Forms.Button targetBtn;
		private System.Windows.Forms.Button csvBtn;
		private System.Windows.Forms.Label optionsLabel;
		private System.Windows.Forms.CheckBox adaptiveMT;
		private System.Windows.Forms.CheckBox adaptiveLearnings;
		private System.Windows.Forms.CheckBox internalFuzzies;
		private System.Windows.Forms.CheckBox crossRep;
		private System.Windows.Forms.CheckBox contextMatch;
		private System.Windows.Forms.CheckBox perfectMatch;
		private System.Windows.Forms.CheckBox locked;
	}
}