using Reptitoire.ReptitoireManager;
using Reptitoire.ReptitoireManager.Feeder;
using Reptitoire.ReptitoireManager.FeedEvents;
using Reptitoire.ReptitoireManager.Reptile;
using System.Reflection;

namespace Reptitoire
{
    public partial class ReptitoireForm : Form
    {
        // Manager
        private MReptitoire manager;

        // Log
        private FeedLogChart logChart;
        private string currentReptileLog;
        private Thread logThread;

        // Init form
        public ReptitoireForm()
        {
            manager = new MReptitoire();
            InitializeComponent();
            this.Text = this.Text + " " + Assembly.GetExecutingAssembly().GetName().Version;
            logChart = new FeedLogChart(feedLogChart);

            // Force refresh of all grids and combos
            UpdateReptileGridList();
            UpdateFeederGridList();
            UpdateFeederComboBoxes();
            UpdateReptileComboBoxes();
            UpdateFileSizes();
        }

        private void UpdateFileSizes()
        {
            string appDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string reptileSaveDir = Path.Combine(appDataDir, MReptitoire.FOLDER_NAME, MReptitoire.REPTILE_FILENAME);
            string feederSaveDir = Path.Combine(appDataDir, MReptitoire.FOLDER_NAME, MReptitoire.FEEDER_FILENAME);
            string logSaveDir = Path.Combine(appDataDir, MReptitoire.FOLDER_NAME, MReptitoire.FEED_LOG_FILENAME);

            FileStream reptileFile = File.Open(reptileSaveDir, FileMode.OpenOrCreate);
            FileStream feederFile = File.Open(feederSaveDir, FileMode.OpenOrCreate);
            FileStream logFile = File.Open(logSaveDir, FileMode.OpenOrCreate);

            long reptileSize = reptileFile.Length;
            long feederSize = feederFile.Length;
            long logSize = logFile.Length;
            long total = reptileSize + feederSize + logSize;

            reptileFile.Close();
            feederFile.Close();
            logFile.Close();

            reptileSaveMBText.Text = "Reptile Save: " + (reptileSize / 1024 / 1024).ToString() + "MB";
            feederSaveMBText.Text = "Feeder Save: " + (feederSize / 1024 / 1024).ToString() + "MB";
            logSaveMBText.Text = "Log Save: " + (logSize / 1024 / 1024).ToString() + "MB";
            totalSaveMBText.Text = "Total: " + (total / 1024 / 1024).ToString() + "MB";
        }

        #region Reptile
        // Create a new reptile
        private void newReptileButton_Click(object sender, EventArgs e)
        {
            // Check for null entries
            if(newReptileNameText.Text == String.Empty ||
                newReptileSpeciesText.Text == String.Empty ||
                newReptileSexCombo.Text == String.Empty)
            {
                return;
            }

            manager.AddReptile(newReptileNameText.Text, newReptileBirthdate.Value.Date.ToString(), newReptileSpeciesText.Text, newReptileSexCombo.Text, DateTime.Now.Date.ToString());

            newReptileNameText.ResetText();
            newReptileSpeciesText.ResetText();
            newReptileSexCombo.ResetText();

            UpdateReptileComboBoxes();
            UpdateReptileGridList();
        }

        // Feed a reptile
        private void feedButton_Click(object sender, EventArgs e)
        {
            // Check for null entries
            if (feedReptileNameCombo.Text == String.Empty ||
                feedFeederSpeciesCombo.Text == String.Empty ||
                feedAmount.Value == 0) { return; }

            manager.FeedReptile(manager.GetReptileIndex(feedReptileNameCombo.Text), manager.GetFeederIndex(feedFeederSpeciesCombo.Text), (int)feedAmount.Value);

            // If fed reptile is in log view, just add the event to the grid view
            if (feedLogReptileCombo.Text.Equals(feedReptileNameCombo.Text))
            {
                logGrid.Rows.Add(DateTime.Now.ToString(), feedReptileNameCombo.Text, feedFeederSpeciesCombo.Text, (int)feedAmount.Value);
                logChart.AddFeeder(feedFeederSpeciesCombo.Text, (int)feedAmount.Value);
                logChart.UpdatePercentages();
            }

            feedReptileNameCombo.ResetText();
            feedFeederSpeciesCombo.ResetText();
            feedAmount.Value = 0;

            UpdateFeederGridList();
            UpdateReptileGridList();
        }

        // Delete a reptile
        private void deleteReptileButton_Click(object sender, EventArgs e)
        {
            if (deleteReptileCombo.Text == string.Empty) return;

            manager.DeleteReptile(deleteReptileCombo.Text);

            // Reset log view if selected reptile got deleted
            if (feedLogReptileCombo.Text.Equals(deleteReptileCombo.Text))
            {
                logGrid.Rows.Clear();
                logChart.Clear();
                feedLogReptileCombo.ResetText();
            }

            deleteReptileCombo.ResetText();

            UpdateReptileComboBoxes();
            UpdateReptileGridList();
        }
        #endregion

        #region Feeder
        // Add new feeder species
        private void addNewFeeder_Click(object sender, EventArgs e)
        {
            // Check for null entries
            if (newFeederSpecies.Text == string.Empty) return;

            manager.CreateFeeder(newFeederSpecies.Text, (int)newFeederAmount.Value);

            newFeederSpecies.ResetText();
            newFeederAmount.Value = 0;

            UpdateFeederComboBoxes();
            UpdateFeederGridList();
        }

        // Add feeder amounts
        private void addFeeders_Click(object sender, EventArgs e)
        {
            // Check for null entries
            if (addFeedersCombo.Text == string.Empty ||
                addFeedersAmount.Value == 0) return;

            manager.AddFeeders(manager.GetFeederIndex(addFeedersCombo.Text), (int)addFeedersAmount.Value);

            addFeedersCombo.ResetText();
            addFeedersAmount.Value = 0;

            UpdateFeederGridList();
        }

        // Delete a feeder
        private void deleteFeederButton_Click(object sender, EventArgs e) 
        {
            if(deleteFeederCombo.Text == string.Empty) return;

            manager.DeleteFeeder(deleteFeederCombo.Text);

            deleteFeederCombo.ResetText();

            UpdateFeederComboBoxes();
            UpdateFeederGridList();
        }
        #endregion

        #region Feed Log
        // When we change the selected reptile in the log tab, we need to refresh the log grid
        private void feedLogReptileCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            logGrid.Rows.Clear();
            logChart.Clear();
            currentReptileLog = feedLogReptileCombo.Text;
            logThread = new Thread(new ThreadStart(LoadFeedLog));

            try
            {
                logThread.Start();
            }
            catch (Exception ex)
            {
                logThread.Interrupt(); // If this thread got hung anywhere just interrupt to be safe
            }
        }

        // Clear a reptiles feed history
        private void logClearButton_Click(object sender, EventArgs e)
        {
            if (feedLogReptileCombo.Text == string.Empty) return;

            manager.ClearReptileLog(feedLogReptileCombo.Text);
            logChart.Clear();

            feedLogReptileCombo.ResetText();
        }

        // Export a reptiles feed history to a TXT
        private void logExportButton_Click(object sender, EventArgs e)
        {
            if (feedLogReptileCombo.Text == string.Empty) return;

            using(SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "txt files (*.txt)|*.txt";
                sfd.FilterIndex = 0;

                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, manager.GetLog().ToTXT(manager.GetLog().GetReptileLogs(feedLogReptileCombo.Text)));
                }
            }
        }

        // Export a reptiles feed history to a CSV
        private void exportCSVButton_Click(object sender, EventArgs e)
        {
            if (feedLogReptileCombo.Text == string.Empty) return;

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "csv files (*.csv)|*.csv";
                sfd.FilterIndex = 0;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, manager.GetLog().ToCSV(manager.GetLog().GetReptileLogs(feedLogReptileCombo.Text)));
                }
            }
        }

        private void openSaveFilePathButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(manager.GetSaveFilesPath()) { UseShellExecute = true });
        }
        #endregion

        #region Order
        // Open dubia.com
        private void dubiaLinkButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("https://www.dubia.com") { UseShellExecute = true });
        }

        // Open flukerfarms.com
        private void flukersLinkButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("https://www.flukerfarms.com") { UseShellExecute = true });
        }
        #endregion

        #region Form Updates
        private void UpdateFeederComboBoxes()
        {
            feedFeederSpeciesCombo.Items.Clear();
            addFeedersCombo.Items.Clear();
            deleteFeederCombo.Items.Clear();

            foreach (FeederInfo feeder in manager.GetFeeders())
            {
                feedFeederSpeciesCombo.Items.Add(feeder.species);
                addFeedersCombo.Items.Add(feeder.species);
                deleteFeederCombo.Items.Add(feeder.species);
            }
        }

        private void UpdateReptileComboBoxes()
        {
            feedReptileNameCombo.Items.Clear();
            feedLogReptileCombo.Items.Clear();
            deleteReptileCombo.Items.Clear();

            foreach (ReptileInfo reptile in manager.GetReptiles())
            {
                feedReptileNameCombo.Items.Add(reptile.name);
                feedLogReptileCombo.Items.Add(reptile.name);
                deleteReptileCombo.Items.Add(reptile.name);
            }
        }

        private void UpdateReptileGridList()
        {
            dataGridView1.Rows.Clear();

            foreach (ReptileInfo reptile in manager.GetReptiles())
            {
                dataGridView1.Rows.Add(reptile.name, reptile.GetAge(), reptile.sex, reptile.species, reptile.WasFedToday());
            }
        }

        private void UpdateFeederGridList()
        {
            dataGridView2.Rows.Clear();

            foreach (FeederInfo feeder in manager.GetFeeders())
            {
                dataGridView2.Rows.Add(feeder.species, feeder.amount);
            }
        }

        private void LoadFeedLog()
        {
            try
            {
                List<FeedLogInfo> list = manager.GetLog().GetReptileLogs(currentReptileLog);
                Invoke(new EventHandler(delegate (object sender, EventArgs e)
                {
                    feedLogLoadProgress.Maximum = list.Count;
                    feedLogLoadProgress.Value = 0;
                }), new object[2] { this, null });

                for (int i = 0; i < list.Count; i++)
                {
                    Invoke(new EventHandler(delegate (object sender, EventArgs e)
                    {
                        logGrid.Rows.Add(list[i].datetime, list[i].reptileName, list[i].feederSpecies, list[i].amount);
                        logChart.AddFeeder(list[i].feederSpecies, list[i].amount);

                        feedLogLoadProgress.PerformStep();
                    }), new object[2] { this, null });
                    //Thread.Sleep(1);
                }
                Invoke(new EventHandler(delegate (object sender, EventArgs e)
                {
                    logChart.UpdatePercentages();
                }), new object[2] { this, null });
            }
            catch (Exception ex)
            {

            }
        }
        #endregion

        // Save before close
        private void ReptitoireForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (logThread != null && logThread.IsAlive)
                logThread.Interrupt(); // We cant save if this thread is spooled
            manager.Save();
        }

        private void deleteAllDataButton_Click(object sender, EventArgs e)
        {
            var form = new DeleteDialog(DeleteAllDataCallback);
            form.ShowDialog(this);
        }

        private void DeleteAllDataCallback()
        {
            string appDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string reptileSaveDir = Path.Combine(appDataDir, MReptitoire.FOLDER_NAME, MReptitoire.REPTILE_FILENAME);
            string feederSaveDir = Path.Combine(appDataDir, MReptitoire.FOLDER_NAME, MReptitoire.FEEDER_FILENAME);
            string logSaveDir = Path.Combine(appDataDir, MReptitoire.FOLDER_NAME, MReptitoire.FEED_LOG_FILENAME);

            File.Delete(reptileSaveDir);
            File.Delete(feederSaveDir);
            File.Delete(logSaveDir);

            manager.DeleteAll();

            UpdateReptileGridList();
            UpdateFeederGridList();
            UpdateFeederComboBoxes();
            UpdateReptileComboBoxes();
            UpdateFileSizes();
        }
    }
}