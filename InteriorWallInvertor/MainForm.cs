using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SEModAPI.API;
using SEModAPI.Support;
using System.IO;
using SEModAPIInternal.API.Entity;
using SEModAPIInternal.API.Entity.Sector.SectorObject.CubeGrid;


using Sandbox.Common.ObjectBuilders;
using VRageMath;
namespace InteriorWallInvertor
{
	public partial class MainForm : Form
	{
		private SectorManager m_sectorManager;

		#region Constructor

		public MainForm()
		{
			InitializeComponent();

			try
			{
				new GameInstallationInfo();
			}
			catch (AutoException)
			{
				MessageBox.Show("The game could not be found on your computer! Please select your game executable.", "Error: Game not found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				string gamePath = GetGamePath();
				if (gamePath == null || gamePath == "")
				{
					//If the game path was not found, we skip all initialisation
					this.Visible = false;
					this.Close();
					return;
				}
				new GameInstallationInfo(gamePath);
			}
			m_sectorManager = new SectorManager();
		}

		#endregion

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			SelectSaveFile();
		}

		private void txtPath_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			SelectSaveFile();
		}

		private void SelectSaveFile()
		{
			DialogResult result = ofdLoadSandbox.ShowDialog();
			if (result == DialogResult.OK) // Test result.
			{
				txtPath.Text = ofdLoadSandbox.FileName;
			}
		}

		private void Execute()
		{

		}

		#region Get game installation method

		/// <summary>
		/// Try to find manually the SpaceEngineers game path
		/// </summary>
		/// <returns>The game path, or null if not found</returns>
		private string GetGamePath()
		{
			bool continueLoad = true;

			string steamPath = GameInstallationInfo.GetGameSteamPath();
			if (steamPath != null)
				ofdGamePath.InitialDirectory = Path.Combine(steamPath, "SteamApps", "common");

			while (continueLoad)
			{
				DialogResult resultOpen = ofdGamePath.ShowDialog();
				if (resultOpen == DialogResult.OK)
				{
					string selectedPath = Path.GetDirectoryName(ofdGamePath.FileName);
					string gamePath = Path.Combine(selectedPath, "..");
					if (GameInstallationInfo.IsValidGamePath(gamePath))
						return gamePath;
					else
					{
						DialogResult resultRetry = MessageBox.Show("The selected location is an invalid SpaceEngineers installation.",
							"Invalid installation", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

						if (resultRetry != DialogResult.Retry)
							continueLoad = false;
					}
				}
				else
					continueLoad = false;
			}

			//If this point is reached, then the user must have cancelled it.
			MessageBox.Show("The game installation location could not be found. The application can not run without it.",
				"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			return null;
		}
		#endregion

		private void btnGo_Click(object sender, EventArgs e)
		{
			btnBrowse.Enabled = false;
			btnGo.Enabled = false;
			txtPath.Enabled = false;
			pgrProgress.Visible = true;
			backgroundWorker1.RunWorkerAsync();
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			m_sectorManager.Load(new FileInfo(ofdLoadSandbox.FileName));
			bool changed = false;

			foreach (var ship in m_sectorManager.Sector.CubeGrids)
			{
				foreach (var cube in ship.CubeBlocks)
				{
					Type cubeType = cube.GetType();

					if (cubeType == typeof(CubeBlockEntity))
					{
						CubeBlockEntity cubeBlock = (CubeBlockEntity)cube;

						if (cubeBlock.Name == "LargeBlockInteriorWall")
						{
							MyBlockOrientation orientation = cubeBlock.BlockOrientation;

							if (orientation.Up == Base6Directions.Direction.Up)
							{
								orientation.Up = Base6Directions.Direction.Down;
								changed = true;
							}
							else if (orientation.Up == Base6Directions.Direction.Down)
							{
								orientation.Up = Base6Directions.Direction.Up;
								changed = true;
							}
							cubeBlock.BlockOrientation = orientation;
						}
					}
				}
			}

			if (changed)
			{
				m_sectorManager.Save();
				MessageBox.Show("Save completed!");
			}
			else
			{
				MessageBox.Show("Nothing needs to be changed (No Interior wall was found)");
			}
		}

		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			pgrProgress.Visible = false;
			this.Close();
		}

	}
}
