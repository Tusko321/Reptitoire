using Reptitoire.ReptitoireManager.Reptile;
using Reptitoire.ReptitoireManager.Feeder;
using System.Text;
using System.Text.Json;

namespace Reptitoire.ReptitoireManager
{
    public class MReptitoire
    {
        private const string REPTILE_FILENAME = "reptiles.dat";
        private const string FEEDER_FILENAME = "feeders.dat";
        private const string FEED_LOG_FILENAME = "log.dat";
        private const string FOLDER_NAME = "Reptitoire";

        private ReptileList reptiles;
        private FeederList feeders;
        private FeedLog feedLog;

        public MReptitoire() 
        {
            // Get persistent data paths
            string appDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string reptileSaveDir = Path.Combine(appDataDir, FOLDER_NAME, REPTILE_FILENAME);
            string feederSaveDir = Path.Combine(appDataDir, FOLDER_NAME, FEEDER_FILENAME);
            string logSaveDir = Path.Combine(appDataDir, FOLDER_NAME, FEED_LOG_FILENAME);

            // Load reptiles
            reptiles = new ReptileList();
            if (File.Exists(reptileSaveDir))
            {
                FileStream fs = File.Open(reptileSaveDir, FileMode.Open);
                ReptileList? rArr = JsonSerializer.Deserialize<ReptileList>(fs);
                foreach (ReptileInfo reptile in rArr.List)
                {
                    reptiles.Add(reptile);
                }
                fs.Close();
            }

            // Load feeders
            feeders = new FeederList();
            if (File.Exists(feederSaveDir))
            {
                FileStream fs = File.Open(feederSaveDir, FileMode.Open);
                FeederList? fArr = JsonSerializer.Deserialize<FeederList>(fs);
                foreach(FeederInfo feeder in fArr.List)
                {
                    feeders.Add(feeder);
                }
                fs.Close();
            }

            feedLog = new FeedLog(logSaveDir);
        }

        public FeedLog GetLog() { return feedLog; }

        public List<ReptileInfo> GetReptiles() { return reptiles.List; }

        public List<FeederInfo> GetFeeders() { return feeders.List; }

        public int GetReptileIndex(string name)
        {
            int index = -1;
            for(int i = 0; i < reptiles.List.Count; i++)
            {
                if (name.Equals(reptiles[i].name))
                {
                    index = i; break;
                }
            }

            return index;
        }

        public int GetFeederIndex(string species)
        {
            int index = -1;
            for(int i = 0; i < feeders.List.Count; i++)
            {
                if (feeders[i].species.Equals(species))
                {
                    index = i; break;
                }
            }

            return index;
        }

        public void FeedReptile(int reptileIndex, int feederIndex, int amount)
        {
            if (reptileIndex == -1 || feederIndex == -1) return;

            reptiles[reptileIndex].lastDayFed = DateTime.Now.Date.ToString();
            feeders[feederIndex].amount -= amount;

            feedLog.Log(reptiles[reptileIndex].name, feeders[feederIndex].species, amount);
        }

        public void AddReptile(string name, string birthday, string species, string sex, string lastDayFed)
        {
            if (GetReptileIndex(name) != -1) return;

            reptiles.Add(new ReptileInfo(name, birthday, species, sex, lastDayFed));
        }

        public void CreateFeeder(string species, int amount)
        {
            if(GetFeederIndex(species) != -1) return;

            feeders.Add(new FeederInfo(species, amount));
        }

        public void AddFeeders(int index, int amount)
        {
            if (index != -1) return;

            feeders[index].amount += amount;
        }

        public string[] GetFeederSpecies()
        {
            string[] fArr = new string[feeders.List.Count];
            for(int i = 0; i < feeders.List.Count; i++)
            {
                fArr[i] = feeders[i].species;
            }

            return fArr;
        }

        public int[] GetFeederCounts()
        {
            int[] feederCounts = new int[feeders.List.Count];
            for(int i = 0; i < feeders.List.Count; i++)
            {
                feederCounts[i] = feeders[i].amount;
            }

            return feederCounts;
        }

        public void Save()
        {
            // Get appdata path
            string appDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string reptileSaveDir = Path.Combine(appDataDir, FOLDER_NAME, REPTILE_FILENAME);
            string feederSaveDir = Path.Combine(appDataDir, FOLDER_NAME, FEEDER_FILENAME);
            string logSaveDir = Path.Combine(appDataDir, FOLDER_NAME, FEED_LOG_FILENAME);

            // Convert data to JSON
            string reptileJSON = JsonSerializer.Serialize(reptiles);
            string feederJSON = JsonSerializer.Serialize(feeders);

            // Overwrite or create save files and write their appropriate JSON
            string reptileSavePath = Path.Combine(appDataDir, FOLDER_NAME);
            string feederSavePath = Path.Combine(appDataDir, FOLDER_NAME);
            Directory.CreateDirectory(reptileSavePath);
            Directory.CreateDirectory(feederSavePath);
            FileStream rfs = File.Create(reptileSaveDir);
            FileStream ffs = File.Create(feederSaveDir);
            rfs.Write(Encoding.ASCII.GetBytes(reptileJSON), 0, Encoding.ASCII.GetByteCount(reptileJSON));
            ffs.Write(Encoding.ASCII.GetBytes(feederJSON), 0, Encoding.ASCII.GetByteCount(feederJSON));

            // Close streams
            rfs.Close();
            ffs.Close();

            feedLog.Save(logSaveDir);
        }
    }
}
