namespace Reptitoire
{
    partial class ReptitoireForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReptitoireForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.reptileInfoTab = new System.Windows.Forms.TabPage();
            this.deleteReptileButton = new System.Windows.Forms.Button();
            this.deleteReptileCombo = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.feedButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.feedAmount = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.feedFeederSpeciesCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.feedReptileNameCombo = new System.Windows.Forms.ComboBox();
            this.newReptileButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.newReptileSpeciesText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.newReptileSexCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.newReptileBirthdate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.newReptileNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ReptileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Species = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FedToday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feederInfoTab = new System.Windows.Forms.TabPage();
            this.deleteFeederButton = new System.Windows.Forms.Button();
            this.deleteFeederCombo = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.addFeeders = new System.Windows.Forms.Button();
            this.addFeedersAmount = new System.Windows.Forms.NumericUpDown();
            this.addFeedersCombo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.addNewFeeder = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.newFeederAmount = new System.Windows.Forms.NumericUpDown();
            this.newFeederSpecies = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.FeederSpecies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.feedLogLoadProgress = new System.Windows.Forms.ProgressBar();
            this.logClearButton = new System.Windows.Forms.Button();
            this.logExportButton = new System.Windows.Forms.Button();
            this.logGrid = new System.Windows.Forms.DataGridView();
            this.logDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedLogReptileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedLogFeederSpecies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedLogAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.feedLogReptileCombo = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.reptileInfoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feedAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.feederInfoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addFeedersAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newFeederAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.reptileInfoTab);
            this.tabControl1.Controls.Add(this.feederInfoTab);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // reptileInfoTab
            // 
            this.reptileInfoTab.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.reptileInfoTab.Controls.Add(this.deleteReptileButton);
            this.reptileInfoTab.Controls.Add(this.deleteReptileCombo);
            this.reptileInfoTab.Controls.Add(this.label17);
            this.reptileInfoTab.Controls.Add(this.label16);
            this.reptileInfoTab.Controls.Add(this.feedButton);
            this.reptileInfoTab.Controls.Add(this.label9);
            this.reptileInfoTab.Controls.Add(this.feedAmount);
            this.reptileInfoTab.Controls.Add(this.label8);
            this.reptileInfoTab.Controls.Add(this.feedFeederSpeciesCombo);
            this.reptileInfoTab.Controls.Add(this.label7);
            this.reptileInfoTab.Controls.Add(this.feedReptileNameCombo);
            this.reptileInfoTab.Controls.Add(this.newReptileButton);
            this.reptileInfoTab.Controls.Add(this.label6);
            this.reptileInfoTab.Controls.Add(this.newReptileSpeciesText);
            this.reptileInfoTab.Controls.Add(this.label5);
            this.reptileInfoTab.Controls.Add(this.newReptileSexCombo);
            this.reptileInfoTab.Controls.Add(this.label4);
            this.reptileInfoTab.Controls.Add(this.newReptileBirthdate);
            this.reptileInfoTab.Controls.Add(this.label3);
            this.reptileInfoTab.Controls.Add(this.newReptileNameText);
            this.reptileInfoTab.Controls.Add(this.label2);
            this.reptileInfoTab.Controls.Add(this.label1);
            this.reptileInfoTab.Controls.Add(this.dataGridView1);
            this.reptileInfoTab.Location = new System.Drawing.Point(4, 24);
            this.reptileInfoTab.Name = "reptileInfoTab";
            this.reptileInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.reptileInfoTab.Size = new System.Drawing.Size(768, 398);
            this.reptileInfoTab.TabIndex = 0;
            this.reptileInfoTab.Text = "Reptile Info";
            // 
            // deleteReptileButton
            // 
            this.deleteReptileButton.Location = new System.Drawing.Point(408, 281);
            this.deleteReptileButton.Name = "deleteReptileButton";
            this.deleteReptileButton.Size = new System.Drawing.Size(75, 23);
            this.deleteReptileButton.TabIndex = 22;
            this.deleteReptileButton.Text = "Delete";
            this.deleteReptileButton.UseVisualStyleBackColor = true;
            this.deleteReptileButton.Click += new System.EventHandler(this.deleteReptileButton_Click);
            // 
            // deleteReptileCombo
            // 
            this.deleteReptileCombo.FormattingEnabled = true;
            this.deleteReptileCombo.Location = new System.Drawing.Point(324, 281);
            this.deleteReptileCombo.Name = "deleteReptileCombo";
            this.deleteReptileCombo.Size = new System.Drawing.Size(78, 23);
            this.deleteReptileCombo.TabIndex = 21;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(324, 263);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 15);
            this.label17.TabIndex = 20;
            this.label17.Text = "Reptile Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(320, 242);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 21);
            this.label16.TabIndex = 19;
            this.label16.Text = "Delete Reptile";
            // 
            // feedButton
            // 
            this.feedButton.Location = new System.Drawing.Point(556, 184);
            this.feedButton.Name = "feedButton";
            this.feedButton.Size = new System.Drawing.Size(75, 23);
            this.feedButton.TabIndex = 18;
            this.feedButton.Text = "Feed";
            this.feedButton.UseVisualStyleBackColor = true;
            this.feedButton.Click += new System.EventHandler(this.feedButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(492, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Amount";
            // 
            // feedAmount
            // 
            this.feedAmount.Location = new System.Drawing.Point(492, 186);
            this.feedAmount.Name = "feedAmount";
            this.feedAmount.Size = new System.Drawing.Size(58, 23);
            this.feedAmount.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(408, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Feeder Species";
            // 
            // feedFeederSpeciesCombo
            // 
            this.feedFeederSpeciesCombo.FormattingEnabled = true;
            this.feedFeederSpeciesCombo.Location = new System.Drawing.Point(408, 186);
            this.feedFeederSpeciesCombo.Name = "feedFeederSpeciesCombo";
            this.feedFeederSpeciesCombo.Size = new System.Drawing.Size(78, 23);
            this.feedFeederSpeciesCombo.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Reptile Name";
            // 
            // feedReptileNameCombo
            // 
            this.feedReptileNameCombo.FormattingEnabled = true;
            this.feedReptileNameCombo.Location = new System.Drawing.Point(324, 186);
            this.feedReptileNameCombo.Name = "feedReptileNameCombo";
            this.feedReptileNameCombo.Size = new System.Drawing.Size(78, 23);
            this.feedReptileNameCombo.TabIndex = 12;
            // 
            // newReptileButton
            // 
            this.newReptileButton.Location = new System.Drawing.Point(475, 89);
            this.newReptileButton.Name = "newReptileButton";
            this.newReptileButton.Size = new System.Drawing.Size(75, 23);
            this.newReptileButton.TabIndex = 11;
            this.newReptileButton.Text = "Add";
            this.newReptileButton.UseVisualStyleBackColor = true;
            this.newReptileButton.Click += new System.EventHandler(this.newReptileButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Species";
            // 
            // newReptileSpeciesText
            // 
            this.newReptileSpeciesText.Location = new System.Drawing.Point(369, 89);
            this.newReptileSpeciesText.Name = "newReptileSpeciesText";
            this.newReptileSpeciesText.Size = new System.Drawing.Size(100, 23);
            this.newReptileSpeciesText.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sex";
            // 
            // newReptileSexCombo
            // 
            this.newReptileSexCombo.FormattingEnabled = true;
            this.newReptileSexCombo.Items.AddRange(new object[] {
            "M",
            "F",
            "X"});
            this.newReptileSexCombo.Location = new System.Drawing.Point(324, 89);
            this.newReptileSexCombo.Name = "newReptileSexCombo";
            this.newReptileSexCombo.Size = new System.Drawing.Size(39, 23);
            this.newReptileSexCombo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Birthday";
            // 
            // newReptileBirthdate
            // 
            this.newReptileBirthdate.Location = new System.Drawing.Point(430, 45);
            this.newReptileBirthdate.Name = "newReptileBirthdate";
            this.newReptileBirthdate.Size = new System.Drawing.Size(200, 23);
            this.newReptileBirthdate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(324, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Feed Reptile";
            // 
            // newReptileNameText
            // 
            this.newReptileNameText.Location = new System.Drawing.Point(324, 45);
            this.newReptileNameText.Name = "newReptileNameText";
            this.newReptileNameText.Size = new System.Drawing.Size(100, 23);
            this.newReptileNameText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(324, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Reptile";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReptileName,
            this.Age,
            this.Sex,
            this.Species,
            this.FedToday});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(312, 386);
            this.dataGridView1.TabIndex = 0;
            // 
            // ReptileName
            // 
            this.ReptileName.HeaderText = "Name";
            this.ReptileName.Name = "ReptileName";
            this.ReptileName.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Width = 40;
            // 
            // Sex
            // 
            this.Sex.HeaderText = "Sex";
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            this.Sex.Width = 30;
            // 
            // Species
            // 
            this.Species.HeaderText = "Species";
            this.Species.Name = "Species";
            this.Species.ReadOnly = true;
            // 
            // FedToday
            // 
            this.FedToday.HeaderText = "Fed Today?";
            this.FedToday.Name = "FedToday";
            this.FedToday.ReadOnly = true;
            this.FedToday.Width = 40;
            // 
            // feederInfoTab
            // 
            this.feederInfoTab.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.feederInfoTab.Controls.Add(this.deleteFeederButton);
            this.feederInfoTab.Controls.Add(this.deleteFeederCombo);
            this.feederInfoTab.Controls.Add(this.label18);
            this.feederInfoTab.Controls.Add(this.label19);
            this.feederInfoTab.Controls.Add(this.addFeeders);
            this.feederInfoTab.Controls.Add(this.addFeedersAmount);
            this.feederInfoTab.Controls.Add(this.addFeedersCombo);
            this.feederInfoTab.Controls.Add(this.label14);
            this.feederInfoTab.Controls.Add(this.label13);
            this.feederInfoTab.Controls.Add(this.addNewFeeder);
            this.feederInfoTab.Controls.Add(this.label12);
            this.feederInfoTab.Controls.Add(this.newFeederAmount);
            this.feederInfoTab.Controls.Add(this.newFeederSpecies);
            this.feederInfoTab.Controls.Add(this.label11);
            this.feederInfoTab.Controls.Add(this.label10);
            this.feederInfoTab.Controls.Add(this.dataGridView2);
            this.feederInfoTab.Location = new System.Drawing.Point(4, 24);
            this.feederInfoTab.Name = "feederInfoTab";
            this.feederInfoTab.Size = new System.Drawing.Size(768, 398);
            this.feederInfoTab.TabIndex = 1;
            this.feederInfoTab.Text = "Feeder Info";
            // 
            // deleteFeederButton
            // 
            this.deleteFeederButton.Location = new System.Drawing.Point(319, 228);
            this.deleteFeederButton.Name = "deleteFeederButton";
            this.deleteFeederButton.Size = new System.Drawing.Size(75, 23);
            this.deleteFeederButton.TabIndex = 26;
            this.deleteFeederButton.Text = "Delete";
            this.deleteFeederButton.UseVisualStyleBackColor = true;
            this.deleteFeederButton.Click += new System.EventHandler(this.deleteFeederButton_Click);
            // 
            // deleteFeederCombo
            // 
            this.deleteFeederCombo.FormattingEnabled = true;
            this.deleteFeederCombo.Location = new System.Drawing.Point(213, 228);
            this.deleteFeederCombo.Name = "deleteFeederCombo";
            this.deleteFeederCombo.Size = new System.Drawing.Size(100, 23);
            this.deleteFeederCombo.TabIndex = 25;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(217, 210);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 15);
            this.label18.TabIndex = 24;
            this.label18.Text = "Species";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(213, 189);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(105, 21);
            this.label19.TabIndex = 23;
            this.label19.Text = "Delete Feeder";
            // 
            // addFeeders
            // 
            this.addFeeders.Location = new System.Drawing.Point(389, 135);
            this.addFeeders.Name = "addFeeders";
            this.addFeeders.Size = new System.Drawing.Size(75, 23);
            this.addFeeders.TabIndex = 11;
            this.addFeeders.Text = "Add";
            this.addFeeders.UseVisualStyleBackColor = true;
            this.addFeeders.Click += new System.EventHandler(this.addFeeders_Click);
            // 
            // addFeedersAmount
            // 
            this.addFeedersAmount.Location = new System.Drawing.Point(319, 135);
            this.addFeedersAmount.Name = "addFeedersAmount";
            this.addFeedersAmount.Size = new System.Drawing.Size(64, 23);
            this.addFeedersAmount.TabIndex = 10;
            // 
            // addFeedersCombo
            // 
            this.addFeedersCombo.FormattingEnabled = true;
            this.addFeedersCombo.Location = new System.Drawing.Point(213, 134);
            this.addFeedersCombo.Name = "addFeedersCombo";
            this.addFeedersCombo.Size = new System.Drawing.Size(100, 23);
            this.addFeedersCombo.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(213, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 15);
            this.label14.TabIndex = 8;
            this.label14.Text = "Species";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(213, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 21);
            this.label13.TabIndex = 7;
            this.label13.Text = "Add Feeders";
            // 
            // addNewFeeder
            // 
            this.addNewFeeder.Location = new System.Drawing.Point(389, 40);
            this.addNewFeeder.Name = "addNewFeeder";
            this.addNewFeeder.Size = new System.Drawing.Size(75, 23);
            this.addNewFeeder.TabIndex = 6;
            this.addNewFeeder.Text = "Add";
            this.addNewFeeder.UseVisualStyleBackColor = true;
            this.addNewFeeder.Click += new System.EventHandler(this.addNewFeeder_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(319, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 15);
            this.label12.TabIndex = 5;
            this.label12.Text = "Amount";
            // 
            // newFeederAmount
            // 
            this.newFeederAmount.Location = new System.Drawing.Point(319, 40);
            this.newFeederAmount.Name = "newFeederAmount";
            this.newFeederAmount.Size = new System.Drawing.Size(64, 23);
            this.newFeederAmount.TabIndex = 4;
            // 
            // newFeederSpecies
            // 
            this.newFeederSpecies.Location = new System.Drawing.Point(213, 39);
            this.newFeederSpecies.Name = "newFeederSpecies";
            this.newFeederSpecies.Size = new System.Drawing.Size(100, 23);
            this.newFeederSpecies.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(213, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Species";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(213, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 21);
            this.label10.TabIndex = 1;
            this.label10.Text = "New Feeder";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FeederSpecies,
            this.Amount});
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(204, 392);
            this.dataGridView2.TabIndex = 0;
            // 
            // FeederSpecies
            // 
            this.FeederSpecies.HeaderText = "Species";
            this.FeederSpecies.Name = "FeederSpecies";
            this.FeederSpecies.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tabPage1.Controls.Add(this.feedLogLoadProgress);
            this.tabPage1.Controls.Add(this.logClearButton);
            this.tabPage1.Controls.Add(this.logExportButton);
            this.tabPage1.Controls.Add(this.logGrid);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.feedLogReptileCombo);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 398);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Feed Log";
            // 
            // feedLogLoadProgress
            // 
            this.feedLogLoadProgress.Location = new System.Drawing.Point(133, 21);
            this.feedLogLoadProgress.Name = "feedLogLoadProgress";
            this.feedLogLoadProgress.Size = new System.Drawing.Size(113, 23);
            this.feedLogLoadProgress.Step = 1;
            this.feedLogLoadProgress.TabIndex = 6;
            // 
            // logClearButton
            // 
            this.logClearButton.Location = new System.Drawing.Point(333, 20);
            this.logClearButton.Name = "logClearButton";
            this.logClearButton.Size = new System.Drawing.Size(75, 23);
            this.logClearButton.TabIndex = 5;
            this.logClearButton.Text = "Clear";
            this.logClearButton.UseVisualStyleBackColor = true;
            this.logClearButton.Click += new System.EventHandler(this.logClearButton_Click);
            // 
            // logExportButton
            // 
            this.logExportButton.Location = new System.Drawing.Point(252, 20);
            this.logExportButton.Name = "logExportButton";
            this.logExportButton.Size = new System.Drawing.Size(75, 23);
            this.logExportButton.TabIndex = 4;
            this.logExportButton.Text = "Export";
            this.logExportButton.UseVisualStyleBackColor = true;
            this.logExportButton.Click += new System.EventHandler(this.logExportButton_Click);
            // 
            // logGrid
            // 
            this.logGrid.AllowUserToAddRows = false;
            this.logGrid.AllowUserToDeleteRows = false;
            this.logGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.logGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.logDate,
            this.feedLogReptileName,
            this.feedLogFeederSpecies,
            this.feedLogAmount});
            this.logGrid.Location = new System.Drawing.Point(6, 58);
            this.logGrid.Name = "logGrid";
            this.logGrid.ReadOnly = true;
            this.logGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.logGrid.RowHeadersVisible = false;
            this.logGrid.RowTemplate.Height = 25;
            this.logGrid.Size = new System.Drawing.Size(402, 334);
            this.logGrid.TabIndex = 3;
            // 
            // logDate
            // 
            this.logDate.HeaderText = "Date";
            this.logDate.Name = "logDate";
            this.logDate.ReadOnly = true;
            // 
            // feedLogReptileName
            // 
            this.feedLogReptileName.HeaderText = "Reptile";
            this.feedLogReptileName.Name = "feedLogReptileName";
            this.feedLogReptileName.ReadOnly = true;
            // 
            // feedLogFeederSpecies
            // 
            this.feedLogFeederSpecies.HeaderText = "Feeder";
            this.feedLogFeederSpecies.Name = "feedLogFeederSpecies";
            this.feedLogFeederSpecies.ReadOnly = true;
            // 
            // feedLogAmount
            // 
            this.feedLogAmount.HeaderText = "Amount";
            this.feedLogAmount.Name = "feedLogAmount";
            this.feedLogAmount.ReadOnly = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 15);
            this.label15.TabIndex = 1;
            this.label15.Text = "Reptile";
            // 
            // feedLogReptileCombo
            // 
            this.feedLogReptileCombo.FormattingEnabled = true;
            this.feedLogReptileCombo.Location = new System.Drawing.Point(6, 21);
            this.feedLogReptileCombo.Name = "feedLogReptileCombo";
            this.feedLogReptileCombo.Size = new System.Drawing.Size(121, 23);
            this.feedLogReptileCombo.TabIndex = 0;
            this.feedLogReptileCombo.SelectedIndexChanged += new System.EventHandler(this.feedLogReptileCombo_SelectedIndexChanged);
            // 
            // ReptitoireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReptitoireForm";
            this.Text = "Reptitoire";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReptitoireForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.reptileInfoTab.ResumeLayout(false);
            this.reptileInfoTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feedAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.feederInfoTab.ResumeLayout(false);
            this.feederInfoTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addFeedersAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newFeederAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage reptileInfoTab;
        private DataGridView dataGridView1;
        private TabPage feederInfoTab;
        private Label label1;
        private Label label4;
        private DateTimePicker newReptileBirthdate;
        private Label label3;
        private TextBox newReptileNameText;
        private Label label2;
        private Button newReptileButton;
        private Label label6;
        private TextBox newReptileSpeciesText;
        private Label label5;
        private ComboBox newReptileSexCombo;
        private Button feedButton;
        private Label label9;
        private NumericUpDown feedAmount;
        private Label label8;
        private ComboBox feedFeederSpeciesCombo;
        private Label label7;
        private ComboBox feedReptileNameCombo;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn FeederSpecies;
        private DataGridViewTextBoxColumn Amount;
        private Button addNewFeeder;
        private Label label12;
        private NumericUpDown newFeederAmount;
        private TextBox newFeederSpecies;
        private Label label11;
        private Label label10;
        private NumericUpDown addFeedersAmount;
        private ComboBox addFeedersCombo;
        private Label label14;
        private Label label13;
        private Button addFeeders;
        private DataGridViewTextBoxColumn ReptileName;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Sex;
        private DataGridViewTextBoxColumn Species;
        private DataGridViewTextBoxColumn FedToday;
        private TabPage tabPage1;
        private DataGridView logGrid;
        private Label label15;
        private ComboBox feedLogReptileCombo;
        private DataGridViewTextBoxColumn logDate;
        private DataGridViewTextBoxColumn feedLogReptileName;
        private DataGridViewTextBoxColumn feedLogFeederSpecies;
        private DataGridViewTextBoxColumn feedLogAmount;
        private Button deleteReptileButton;
        private ComboBox deleteReptileCombo;
        private Label label17;
        private Label label16;
        private Button deleteFeederButton;
        private ComboBox deleteFeederCombo;
        private Label label18;
        private Label label19;
        private Button logClearButton;
        private Button logExportButton;
        private ProgressBar feedLogLoadProgress;
    }
}