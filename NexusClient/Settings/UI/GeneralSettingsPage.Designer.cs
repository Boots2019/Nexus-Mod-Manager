﻿namespace Nexus.Client.Settings.UI
{
	partial class GeneralSettingsPage
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
			this.components = new System.ComponentModel.Container();
			this.flpGeneral = new System.Windows.Forms.FlowLayoutPanel();
			this.gbxAssociations = new System.Windows.Forms.GroupBox();
			this.flpFileAssociations = new System.Windows.Forms.FlowLayoutPanel();
			this.ckbShellExtensions = new System.Windows.Forms.CheckBox();
			this.ckbAssociateURL = new System.Windows.Forms.CheckBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.ckbScanSubfolders = new System.Windows.Forms.CheckBox();
			this.ckbOverrideLocalNames = new System.Windows.Forms.CheckBox();
			this.ckbAddMissingInfo = new System.Windows.Forms.CheckBox();
			this.ckbCheckForUpdates = new System.Windows.Forms.CheckBox();
			this.ckbShowSidePanel = new System.Windows.Forms.CheckBox();
			this.ckbSkipReadmeFiles = new System.Windows.Forms.CheckBox();
			this.ckbHideModUpdateWarningIcon = new System.Windows.Forms.CheckBox();
			this.cbxProgramUpdateCheckInterval = new System.Windows.Forms.ComboBox();
			this.ttpTip = new System.Windows.Forms.ToolTip(this.components);
			this.ckbCloseManagerAfterGameLaunch = new System.Windows.Forms.CheckBox();
			this.lblTraceLogDirectory = new System.Windows.Forms.Label();
			this.tbxTraceLogDirectory = new System.Windows.Forms.TextBox();
			this.butSelectTraceLogDirectory = new System.Windows.Forms.Button();
			this.lblTempPathDirectory = new System.Windows.Forms.Label();
			this.lblTempPathWarning = new System.Windows.Forms.Label();
			this.tbxTempPathDirectory = new System.Windows.Forms.TextBox();
			this.butSelectTempPathDirectory = new System.Windows.Forms.Button();
			this.fbdTraceLogDirectory = new System.Windows.Forms.FolderBrowserDialog();
			this.fbdTempPathDirectory = new System.Windows.Forms.FolderBrowserDialog();
			this.flpGeneral.SuspendLayout();
			this.gbxAssociations.SuspendLayout();
			this.flpFileAssociations.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// flpGeneral
			// 
			this.flpGeneral.AutoScroll = true;
			this.flpGeneral.Controls.Add(this.gbxAssociations);
			this.flpGeneral.Controls.Add(this.groupBox5);
			this.flpGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flpGeneral.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flpGeneral.Location = new System.Drawing.Point(0, 0);
			this.flpGeneral.Name = "flpGeneral";
			this.flpGeneral.Size = new System.Drawing.Size(398, 294);
			this.flpGeneral.TabIndex = 25;
			this.flpGeneral.WrapContents = false;
			this.flpGeneral.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flpGeneral_MouseMove);
			this.flpGeneral.MouseHover += new System.EventHandler(this.flpGeneral_MouseHover);
			// 
			// gbxAssociations
			// 
			this.gbxAssociations.AutoSize = true;
			this.gbxAssociations.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.gbxAssociations.Controls.Add(this.flpFileAssociations);
			this.gbxAssociations.Location = new System.Drawing.Point(3, 3);
			this.gbxAssociations.MinimumSize = new System.Drawing.Size(368, 0);
			this.gbxAssociations.Name = "gbxAssociations";
			this.gbxAssociations.Size = new System.Drawing.Size(368, 71);
			this.gbxAssociations.TabIndex = 22;
			this.gbxAssociations.TabStop = false;
			this.gbxAssociations.Text = "Associations";
			// 
			// flpFileAssociations
			// 
			this.flpFileAssociations.AutoSize = true;
			this.flpFileAssociations.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flpFileAssociations.Controls.Add(this.ckbShellExtensions);
			this.flpFileAssociations.Controls.Add(this.ckbAssociateURL);
			this.flpFileAssociations.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flpFileAssociations.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flpFileAssociations.Location = new System.Drawing.Point(3, 16);
			this.flpFileAssociations.Name = "flpFileAssociations";
			this.flpFileAssociations.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.flpFileAssociations.Size = new System.Drawing.Size(362, 52);
			this.flpFileAssociations.TabIndex = 4;
			// 
			// ckbShellExtensions
			// 
			this.ckbShellExtensions.AutoSize = true;
			this.ckbShellExtensions.Location = new System.Drawing.Point(13, 6);
			this.ckbShellExtensions.Name = "ckbShellExtensions";
			this.ckbShellExtensions.Size = new System.Drawing.Size(231, 17);
			this.ckbShellExtensions.TabIndex = 3;
			this.ckbShellExtensions.Text = "Add shell extensions for supported file types";
			this.ckbShellExtensions.UseVisualStyleBackColor = true;
			// 
			// ckbAssociateURL
			// 
			this.ckbAssociateURL.AutoSize = true;
			this.ckbAssociateURL.Location = new System.Drawing.Point(13, 29);
			this.ckbAssociateURL.Name = "ckbAssociateURL";
			this.ckbAssociateURL.Size = new System.Drawing.Size(151, 17);
			this.ckbAssociateURL.TabIndex = 6;
			this.ckbAssociateURL.Text = "Associate with NXM URLs";
			this.ckbAssociateURL.UseVisualStyleBackColor = true;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.ckbCloseManagerAfterGameLaunch);
			this.groupBox5.Controls.Add(this.ckbScanSubfolders);
			this.groupBox5.Controls.Add(this.ckbOverrideLocalNames);
			this.groupBox5.Controls.Add(this.ckbAddMissingInfo);
			this.groupBox5.Controls.Add(this.ckbCheckForUpdates);
			this.groupBox5.Controls.Add(this.cbxProgramUpdateCheckInterval);
			this.groupBox5.Controls.Add(this.ckbShowSidePanel);
			this.groupBox5.Controls.Add(this.ckbSkipReadmeFiles);
			this.groupBox5.Controls.Add(this.ckbHideModUpdateWarningIcon);
			this.groupBox5.Controls.Add(this.butSelectTraceLogDirectory);
			this.groupBox5.Controls.Add(this.tbxTraceLogDirectory);
			this.groupBox5.Controls.Add(this.lblTraceLogDirectory);
			this.groupBox5.Controls.Add(this.butSelectTempPathDirectory);
			this.groupBox5.Controls.Add(this.tbxTempPathDirectory);
			this.groupBox5.Controls.Add(this.lblTempPathDirectory);
			this.groupBox5.Controls.Add(this.lblTempPathWarning);
			this.groupBox5.Location = new System.Drawing.Point(3, 80);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(368, 300);
			this.groupBox5.TabIndex = 23;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Options";
			// 
			// ckbScanSubfolders
			// 
			this.ckbScanSubfolders.AutoSize = true;
			this.ckbScanSubfolders.Location = new System.Drawing.Point(16, 88);
			this.ckbScanSubfolders.Name = "ckbScanSubfolders";
			this.ckbScanSubfolders.Size = new System.Drawing.Size(217, 17);
			this.ckbScanSubfolders.TabIndex = 5;
			this.ckbScanSubfolders.Text = "Scan Mods directory subfolders for mods";
			this.ckbScanSubfolders.UseVisualStyleBackColor = true;
			// 
			// ckbOverrideLocalNames
			// 
			this.ckbOverrideLocalNames.AutoSize = true;
			this.ckbOverrideLocalNames.Location = new System.Drawing.Point(16, 180);
			this.ckbOverrideLocalNames.Name = "ckbOverrideLocalNames";
			this.ckbOverrideLocalNames.Size = new System.Drawing.Size(217, 17);
			this.ckbOverrideLocalNames.TabIndex = 5;
			this.ckbOverrideLocalNames.Text = "Allow NMM to update mod names";
			this.ckbOverrideLocalNames.UseVisualStyleBackColor = true;
			// 
			// ckbAddMissingInfo
			// 
			this.ckbAddMissingInfo.AutoSize = true;
			this.ckbAddMissingInfo.Location = new System.Drawing.Point(16, 65);
			this.ckbAddMissingInfo.Name = "ckbAddMissingInfo";
			this.ckbAddMissingInfo.Size = new System.Drawing.Size(143, 17);
			this.ckbAddMissingInfo.TabIndex = 4;
			this.ckbAddMissingInfo.Text = "Add missing info to Mods";
			this.ckbAddMissingInfo.UseVisualStyleBackColor = true;
			// 
			// ckbCheckForUpdates
			// 
			this.ckbCheckForUpdates.AutoSize = true;
			this.ckbCheckForUpdates.Location = new System.Drawing.Point(16, 19);
			this.ckbCheckForUpdates.Name = "ckbCheckForUpdates";
			this.ckbCheckForUpdates.Size = new System.Drawing.Size(163, 17);
			this.ckbCheckForUpdates.TabIndex = 0;
			this.ckbCheckForUpdates.Text = "Check for updates on startup - interval (in days):";
			this.ckbCheckForUpdates.UseVisualStyleBackColor = true;
			// 
			// cbxProgramUpdateCheckInterval
			// 
			this.cbxProgramUpdateCheckInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxProgramUpdateCheckInterval.FormattingEnabled = true;
			this.cbxProgramUpdateCheckInterval.Location = new System.Drawing.Point(267, 17);
			this.cbxProgramUpdateCheckInterval.Name = "cbxProgramUpdateCheckInterval";
			this.cbxProgramUpdateCheckInterval.Size = new System.Drawing.Size(64, 21);
			this.cbxProgramUpdateCheckInterval.TabIndex = 1;
			// 
			// ckbCloseManagerAfterGameLaunch
			// 
			this.ckbCloseManagerAfterGameLaunch.AutoSize = true;
			this.ckbCloseManagerAfterGameLaunch.Location = new System.Drawing.Point(16, 111);
			this.ckbCloseManagerAfterGameLaunch.Name = "ckbCloseManagerAfterGameLaunch";
			this.ckbCloseManagerAfterGameLaunch.Size = new System.Drawing.Size(171, 17);
			this.ckbCloseManagerAfterGameLaunch.TabIndex = 7;
			this.ckbCloseManagerAfterGameLaunch.Text = "Close {0} after launching game";
			this.ckbCloseManagerAfterGameLaunch.UseVisualStyleBackColor = true;
			// 
			// ckbShowSidePanel
			// 
			this.ckbShowSidePanel.AutoSize = true;
			this.ckbShowSidePanel.Location = new System.Drawing.Point(16, 134);
			this.ckbShowSidePanel.Name = "ckbShowSidePanel";
			this.ckbShowSidePanel.Size = new System.Drawing.Size(217, 17);
			this.ckbShowSidePanel.TabIndex = 8;
			this.ckbShowSidePanel.Text = "Enable mod info side panel";
			this.ckbShowSidePanel.UseVisualStyleBackColor = true;
			// 
			// ckbSkipReadmeFiles
			// 
			this.ckbSkipReadmeFiles.AutoSize = true;
			this.ckbSkipReadmeFiles.Location = new System.Drawing.Point(16, 42);
			this.ckbSkipReadmeFiles.Name = "ckbSkipReadmeFiles";
			this.ckbSkipReadmeFiles.Size = new System.Drawing.Size(217, 17);
			this.ckbSkipReadmeFiles.TabIndex = 8;
			this.ckbSkipReadmeFiles.Text = "Don't extract ReadMe files";
			this.ckbSkipReadmeFiles.UseVisualStyleBackColor = true;
			// 
			// ckbHideModUpdateWarningIcon
			// 
			this.ckbHideModUpdateWarningIcon.AutoSize = true;
			this.ckbHideModUpdateWarningIcon.Location = new System.Drawing.Point(16, 157);
			this.ckbHideModUpdateWarningIcon.Name = "ckbHideModUpdateWarningIcon";
			this.ckbHideModUpdateWarningIcon.Size = new System.Drawing.Size(217, 17);
			this.ckbHideModUpdateWarningIcon.TabIndex = 8;
			this.ckbHideModUpdateWarningIcon.Text = "Hide Mod Update Warning Icon ";
			this.ckbHideModUpdateWarningIcon.UseVisualStyleBackColor = true;
			// 
			// lblTraceLogDirectory
			// 
			this.lblTraceLogDirectory.AutoSize = true;
			this.lblTraceLogDirectory.Location = new System.Drawing.Point(16, 205);
			this.lblTraceLogDirectory.Name = "lblTraceLogDirectory";
			this.lblTraceLogDirectory.Size = new System.Drawing.Size(73, 13);
			this.lblTraceLogDirectory.TabIndex = 3;
			this.lblTraceLogDirectory.Text = "TraceLog Directory:";
			// 
			// tbxTraceLogDirectory
			// 
			this.tbxTraceLogDirectory.Location = new System.Drawing.Point(16, 220);
			this.tbxTraceLogDirectory.Name = "tbxTraceLogDirectory";
			this.tbxTraceLogDirectory.Size = new System.Drawing.Size(290, 20);
			this.tbxTraceLogDirectory.TabIndex = 1;
			// 
			// butSelectTraceLogDirectory
			// 
			this.butSelectTraceLogDirectory.AutoSize = true;
			this.butSelectTraceLogDirectory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.butSelectTraceLogDirectory.Location = new System.Drawing.Point(320, 220);
			this.butSelectTraceLogDirectory.Name = "butSelectTraceLogDirectory";
			this.butSelectTraceLogDirectory.Size = new System.Drawing.Size(26, 23);
			this.butSelectTraceLogDirectory.TabIndex = 2;
			this.butSelectTraceLogDirectory.Text = "...";
			this.butSelectTraceLogDirectory.UseVisualStyleBackColor = true;
			this.butSelectTraceLogDirectory.Click += new System.EventHandler(this.butSelectTraceLogDirectory_Click);
			// 
			// butSelectTempPathDirectory
			// 
			this.butSelectTempPathDirectory.AutoSize = true;
			this.butSelectTempPathDirectory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.butSelectTempPathDirectory.Location = new System.Drawing.Point(320, 275);
			this.butSelectTempPathDirectory.Name = "butSelectTempPathDirectory";
			this.butSelectTempPathDirectory.Size = new System.Drawing.Size(26, 23);
			this.butSelectTempPathDirectory.TabIndex = 2;
			this.butSelectTempPathDirectory.Text = "...";
			this.butSelectTempPathDirectory.UseVisualStyleBackColor = true;
			this.butSelectTempPathDirectory.Click += new System.EventHandler(this.butSelectTempPathDirectory_Click);
			// 
			// lblTempPathDirectory
			// 
			this.lblTempPathDirectory.AutoSize = true;
			this.lblTempPathDirectory.Location = new System.Drawing.Point(16, 245);
			this.lblTempPathDirectory.Name = "lblTempPathDirectory";
			this.lblTempPathDirectory.Size = new System.Drawing.Size(73, 13);
			this.lblTempPathDirectory.TabIndex = 3;
			this.lblTempPathDirectory.Text = "Temporary Path Directory: (Folder must be named \"Temp\")";
			// 
			// lblTempPathWarning
			// 
			this.lblTempPathWarning.AutoSize = true;
			this.lblTempPathWarning.Location = new System.Drawing.Point(16, 260);
			this.lblTempPathWarning.Name = "lblTempPathDirectory";
			this.lblTempPathWarning.Size = new System.Drawing.Size(73, 13);
			this.lblTempPathWarning.TabIndex = 4;
			this.lblTempPathWarning.Text = "* Requires a restart to be applied!";
			// 
			// tbxTempPathDirectory
			// 
			this.tbxTempPathDirectory.Location = new System.Drawing.Point(16, 275);
			this.tbxTempPathDirectory.Name = "tbxTempPathDirectory";
			this.tbxTempPathDirectory.Size = new System.Drawing.Size(290, 20);
			this.tbxTempPathDirectory.TabIndex = 1;
			this.tbxTempPathDirectory.LostFocus += new System.EventHandler(tbxTempPathDirectory_LostFocus);
			this.tbxTempPathDirectory.Enabled = false;
			// 
			// GeneralSettingsPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.flpGeneral);
			this.Name = "GeneralSettingsPage";
			this.Size = new System.Drawing.Size(398, 294);
			this.flpGeneral.ResumeLayout(false);
			this.flpGeneral.PerformLayout();
			this.gbxAssociations.ResumeLayout(false);
			this.gbxAssociations.PerformLayout();
			this.flpFileAssociations.ResumeLayout(false);
			this.flpFileAssociations.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flpGeneral;
		private System.Windows.Forms.GroupBox gbxAssociations;
		private System.Windows.Forms.FlowLayoutPanel flpFileAssociations;
		private System.Windows.Forms.CheckBox ckbShellExtensions;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.CheckBox ckbAddMissingInfo;
		private System.Windows.Forms.ToolTip ttpTip;
		private System.Windows.Forms.Label lblTraceLogDirectory;
		private System.Windows.Forms.TextBox tbxTraceLogDirectory;
		private System.Windows.Forms.Button butSelectTraceLogDirectory;
		private System.Windows.Forms.Label lblTempPathDirectory;
		private System.Windows.Forms.Label lblTempPathWarning;
		private System.Windows.Forms.TextBox tbxTempPathDirectory;
		private System.Windows.Forms.Button butSelectTempPathDirectory;
		private System.Windows.Forms.FolderBrowserDialog fbdTraceLogDirectory;
		private System.Windows.Forms.FolderBrowserDialog fbdTempPathDirectory;
		private System.Windows.Forms.CheckBox ckbAssociateURL;
		private System.Windows.Forms.CheckBox ckbCheckForUpdates;
		private System.Windows.Forms.CheckBox ckbScanSubfolders;
		private System.Windows.Forms.CheckBox ckbOverrideLocalNames;
		private System.Windows.Forms.CheckBox ckbCloseManagerAfterGameLaunch;
		private System.Windows.Forms.CheckBox ckbShowSidePanel;
		private System.Windows.Forms.CheckBox ckbSkipReadmeFiles;
		private System.Windows.Forms.CheckBox ckbHideModUpdateWarningIcon;
		private System.Windows.Forms.ComboBox cbxProgramUpdateCheckInterval;
	}
}
