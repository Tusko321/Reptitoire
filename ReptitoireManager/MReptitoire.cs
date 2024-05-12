using Reptitoire.ReptitoireManager.Reptile;
using Reptitoire.ReptitoireManager.Feeder;
using System.Text;
using System.Text.Json;
using Reptitoire.ReptitoireManager.FeedEvents;

namespace Reptitoire.ReptitoireManager
{
    public class MReptitoire
    {
        // Consts
        public const string REPTILE_FILENAME = "reptiles.dat";
        public const string FEEDER_FILENAME = "feeders.dat";
        public const string FEED_LOG_FILENAME = "log.dat";
        public const string FOLDER_NAME = "Reptitoire";
        // Consts

        // Data
        private ReptileList reptiles;
        private FeederList feeders;
        private FeedLog feedLog;
        // Data

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
                ReptileList rArr = JsonSerializer.Deserialize<ReptileList>(fs);
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
                FeederList fArr = JsonSerializer.Deserialize<FeederList>(fs);
                foreach(FeederInfo feeder in fArr.List)
                {
                    feeders.Add(feeder);
                }
                fs.Close();
            }

            feedLog = new FeedLog(logSaveDir);
        }

        public void DeleteAll()
        {
            reptiles.Clear();
            feeders.Clear();
            feedLog.Clear();
        }

        /// <summary>
        /// Returns path to save files
        /// </summary>
        /// <returns></returns>
        public string GetSaveFilesPath()
        {
            string appDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            return Path.Combine(appDataDir, FOLDER_NAME);
        }

        public string GetReptileSavePath()
        {
            return Path.Combine(GetSaveFilesPath(), REPTILE_FILENAME);
        }

        public string GetFeederSavePath()
        {
            return Path.Combine(GetSaveFilesPath(), FEEDER_FILENAME);
        }

        public string GetLogSavePath()
        {
            return Path.Combine(GetSaveFilesPath(), FEED_LOG_FILENAME);
        }

        /// <summary>
        /// Get feed log
        /// </summary>
        /// <returns></returns>
        public FeedLog GetLog() { return feedLog; }

        /// <summary>
        /// Get all reptiles
        /// </summary>
        /// <returns></returns>
        public List<ReptileInfo> GetReptiles() { return reptiles.List; }

        /// <summary>
        /// Get all feeders
        /// </summary>
        /// <returns></returns>
        public List<FeederInfo> GetFeeders() { return feeders.List; }

        /// <summary>
        /// Returns index of specified reptile
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Returns index of specified feeder
        /// </summary>
        /// <param name="species"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Feed a reptile and log it
        /// </summary>
        /// <param name="reptileIndex"></param>
        /// <param name="feederIndex"></param>
        /// <param name="amount"></param>
        public void FeedReptile(int reptileIndex, int feederIndex, int amount)
        {
            if (reptileIndex == -1 || feederIndex == -1) return;

            reptiles[reptileIndex].lastDayFed = DateTime.Now.Date.ToString();
            feeders[feederIndex].amount -= amount;

            feedLog.Log(reptiles[reptileIndex].name, feeders[feederIndex].species, amount);
        }

        /// <summary>
        /// Create a new reptile
        /// </summary>
        /// <param name="name"></param>
        /// <param name="birthday"></param>
        /// <param name="species"></param>
        /// <param name="sex"></param>
        /// <param name="lastDayFed"></param>
        public void AddReptile(string name, string birthday, string species, string sex, string lastDayFed)
        {
            if (GetReptileIndex(name) != -1) return;

            reptiles.Add(new ReptileInfo(name, birthday, species, sex, lastDayFed));
        }

        /// <summary>
        /// Delete a reptile from the program aswell as their data from the feed log
        /// </summary>
        /// <param name="name"></param> 
        public void DeleteReptile(string name)
        {
            reptiles.RemoveAt(GetReptileIndex(name));

            ClearReptileLog(name);
        }

        /// <summary>
        /// Clears a reptiles feed log
        /// </summary>
        /// <param name="name"></param>
        public void ClearReptileLog(string name)
        {
            foreach (FeedLogInfo e in feedLog.GetReptileLogs(name))
            {
                feedLog.Remove(e);
            }
        }

        /// <summary>
        /// Create a new feeder species
        /// </summary>
        /// <param name="species"></param>
        /// <param name="amount"></param>
        public void CreateFeeder(string species, int amount)
        {
            if(GetFeederIndex(species) != -1) return;

            feeders.Add(new FeederInfo(species, amount));
        }

        /// <summary>
        /// Delete a feeder from the program
        /// </summary>
        /// <param name="species"></param>
        public void DeleteFeeder(string species)
        {
            feeders.RemoveAt(GetFeederIndex(species));
        }

        /// <summary>
        /// Add amount to a specified feeder
        /// </summary>
        /// <param name="index"></param>
        /// <param name="amount"></param>
        public void AddFeeders(int index, int amount)
        {
            if (index != -1) return;

            feeders[index].amount += amount;
        }

        /// <summary>
        /// Saves all data
        /// </summary>
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
