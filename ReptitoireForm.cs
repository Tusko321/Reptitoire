using Reptitoire.ReptitoireManager;
using Reptitoire.ReptitoireManager.Feeder;
using Reptitoire.ReptitoireManager.FeedEvents;
using Reptitoire.ReptitoireManager.Reptile;
using System.Reflection;

namespace Reptitoire
{
    public partial class ReptitoireForm : Form
    {
        private MReptitoire manager;

        // Init form
        public ReptitoireForm()
        {
            manager = new MReptitoire();
            InitializeComponent();
            this.Text = this.Text + " " + Assembly.GetExecutingAssembly().GetName().Version;

            // Force refresh of all grids and combos
            UpdateReptileGridList();
            UpdateFeederGridList();
            UpdateFeederComboBoxes();
            UpdateReptileComboBoxes();
        }

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
            }

            feedReptileNameCombo.ResetText();
            feedFeederSpeciesCombo.ResetText();
            feedAmount.Value = 0;

            UpdateFeederGridList();
            UpdateReptileGridList();
        }

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

        private void UpdateFeederComboBoxes()
        {
            feedFeederSpeciesCombo.Items.Clear();
            addFeedersCombo.Items.Clear();
            deleteFeederCombo.Items.Clear();

            foreach(FeederInfo feeder in manager.GetFeeders())
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

            foreach(ReptileInfo reptile in manager.GetReptiles())
            {
                feedReptileNameCombo.Items.Add(reptile.name);
                feedLogReptileCombo.Items.Add(reptile.name);
                deleteReptileCombo.Items.Add(reptile.name);
            }
        }

        private void UpdateReptileGridList()
        {
            dataGridView1.Rows.Clear();
            
            foreach(ReptileInfo reptile in manager.GetReptiles())
            {
                dataGridView1.Rows.Add(reptile.name, reptile.GetAge(), reptile.sex, reptile.species, reptile.WasFedToday());
            }
        }

        private void UpdateFeederGridList()
        {
            dataGridView2.Rows.Clear();

            foreach(FeederInfo feeder in manager.GetFeeders())
            {
                dataGridView2.Rows.Add(feeder.species, feeder.amount);
            }
        }

        // When we change the selected reptile in the log tab, we need to refresh the log grid
        private void feedLogReptileCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            logGrid.Rows.Clear();

            List<FeedLogInfo> list = manager.GetLog().GetReptileLogs(feedLogReptileCombo.Text);
            feedLogLoadProgress.Maximum = list.Count;
            feedLogLoadProgress.Value = 0;

            foreach (FeedLogInfo logInfo in list)
            {
                logGrid.Rows.Add(logInfo.datetime, logInfo.reptileName, logInfo.feederSpecies, logInfo.amount);
                feedLogLoadProgress.PerformStep();
            }
        }

        // Save before close
        private void ReptitoireForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            manager.Save();
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
                feedLogReptileCombo.ResetText();
            }

            deleteReptileCombo.ResetText();

            UpdateReptileComboBoxes();
            UpdateReptileGridList();
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

        // Clear a reptiles feed history
        private void logClearButton_Click(object sender, EventArgs e)
        {
            if (feedLogReptileCombo.Text == string.Empty) return;

            manager.ClearReptileLog(feedLogReptileCombo.Text);

            feedLogReptileCombo.ResetText();
        }

        // Export a reptiles feed history to a txt
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
    }
}