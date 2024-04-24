using Reptitoire.ReptitoireManager;
using Reptitoire.ReptitoireManager.Feeder;
using Reptitoire.ReptitoireManager.Reptile;

namespace Reptitoire
{
    public partial class ReptitoireForm : Form
    {
        private const string VERSION = "v0.10";

        private MReptitoire manager;

        public ReptitoireForm()
        {
            manager = new MReptitoire();
            InitializeComponent();
            this.Text = this.Text + " " + VERSION;

            UpdateReptileGridList();
            UpdateFeederGridList();
            UpdateFeederComboBoxes();
            UpdateReptileComboBoxes();
        }

        private void newReptileButton_Click(object sender, EventArgs e)
        {
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

        private void feedButton_Click(object sender, EventArgs e)
        {
            if(feedReptileNameCombo.Text == String.Empty ||
                feedFeederSpeciesCombo.Text == String.Empty ||
                feedAmount.Value == 0) { return; }

            manager.FeedReptile(manager.GetReptileIndex(feedReptileNameCombo.Text), manager.GetFeederIndex(feedFeederSpeciesCombo.Text), (int)feedAmount.Value);

            feedReptileNameCombo.ResetText();
            feedFeederSpeciesCombo.ResetText();
            feedAmount.ResetText();

            UpdateFeederGridList();
        }

        private void addNewFeeder_Click(object sender, EventArgs e)
        {
            if (newFeederSpecies.Text == string.Empty) return;

            manager.CreateFeeder(newFeederSpecies.Text, (int)newFeederAmount.Value);

            newFeederSpecies.ResetText();
            newFeederAmount.Value = 0;

            UpdateFeederComboBoxes();
            UpdateFeederGridList();
        }

        private void addFeeders_Click(object sender, EventArgs e)
        {
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

            foreach(FeederInfo feeder in manager.GetFeeders())
            {
                feedFeederSpeciesCombo.Items.Add(feeder.species);
                addFeedersCombo.Items.Add(feeder.species);
            }
        }

        private void UpdateReptileComboBoxes()
        {
            feedReptileNameCombo.Items.Clear();
            feedLogReptileCombo.Items.Clear();

            foreach(ReptileInfo reptile in manager.GetReptiles())
            {
                feedReptileNameCombo.Items.Add(reptile.name);
                feedLogReptileCombo.Items.Add(reptile.name);
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

        private void feedLogReptileCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            logGrid.Rows.Clear();

            foreach (FeedLogInfo logInfo in manager.GetLog().GetReptileLogs(feedLogReptileCombo.Text))
            {
                logGrid.Rows.Add(logInfo.datetime, logInfo.reptileName, logInfo.feederSpecies, logInfo.amount);
            }
        }
    }
}