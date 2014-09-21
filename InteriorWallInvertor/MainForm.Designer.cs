namespace InteriorWallInvertor
{
	partial class MainForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnBrowse = new System.Windows.Forms.Button();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnGo = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.ofdLoadSandbox = new System.Windows.Forms.OpenFileDialog();
			this.ofdGamePath = new System.Windows.Forms.OpenFileDialog();
			this.sfdSaveSandbox = new System.Windows.Forms.SaveFileDialog();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.pgrProgress = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// btnBrowse
			// 
			this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowse.Location = new System.Drawing.Point(407, 26);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnBrowse.TabIndex = 0;
			this.btnBrowse.Text = "Browse...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// txtPath
			// 
			this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPath.Location = new System.Drawing.Point(12, 28);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new System.Drawing.Size(389, 20);
			this.txtPath.TabIndex = 1;
			this.txtPath.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtPath_MouseDoubleClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Select your save file:";
			// 
			// btnGo
			// 
			this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGo.Location = new System.Drawing.Point(407, 55);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(75, 23);
			this.btnGo.TabIndex = 3;
			this.btnGo.Text = "Go";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label2.Location = new System.Drawing.Point(12, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(389, 31);
			this.label2.TabIndex = 4;
			this.label2.Text = "This script will invert the top orientation of ALL interior wall inside the save " +
    "file. Please make a backup of your savefile.";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label3.Location = new System.Drawing.Point(115, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 12);
			this.label3.TabIndex = 5;
			this.label3.Text = "(SANDBOX_0_0_0_.sbs)";
			// 
			// ofdLoadSandbox
			// 
			this.ofdLoadSandbox.DefaultExt = "sbc";
			this.ofdLoadSandbox.FileName = "SANDBOX_0_0_0_.sbs";
			this.ofdLoadSandbox.Filter = "Save File|*.sbs";
			this.ofdLoadSandbox.Title = "Load a save file";
			// 
			// ofdGamePath
			// 
			this.ofdGamePath.AddExtension = false;
			this.ofdGamePath.DefaultExt = "exe";
			this.ofdGamePath.FileName = "SpaceEngineers.exe";
			this.ofdGamePath.Filter = "Game executable|*.exe";
			// 
			// sfdSaveSandbox
			// 
			this.sfdSaveSandbox.DefaultExt = "sbc";
			this.sfdSaveSandbox.FileName = "SANDBOX_0_0_0_.sbs";
			this.sfdSaveSandbox.Filter = "Save File|*.sbs";
			this.sfdSaveSandbox.Title = "Save...";
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
			// 
			// pgrProgress
			// 
			this.pgrProgress.Location = new System.Drawing.Point(12, 54);
			this.pgrProgress.MarqueeAnimationSpeed = 30;
			this.pgrProgress.Name = "pgrProgress";
			this.pgrProgress.Size = new System.Drawing.Size(389, 25);
			this.pgrProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
			this.pgrProgress.TabIndex = 6;
			this.pgrProgress.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(494, 91);
			this.Controls.Add(this.pgrProgress);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnGo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtPath);
			this.Controls.Add(this.btnBrowse);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Interior Wall Invertor";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnGo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.OpenFileDialog ofdLoadSandbox;
		private System.Windows.Forms.OpenFileDialog ofdGamePath;
		private System.Windows.Forms.SaveFileDialog sfdSaveSandbox;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.ProgressBar pgrProgress;
	}
}

