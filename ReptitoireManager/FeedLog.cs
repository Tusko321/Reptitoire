﻿using System.Text;
using System.Text.Json;

namespace Reptitoire.ReptitoireManager
{
    /// <summary>
    /// Serializable log info list for JSON conversion-
    /// </summary>
    public class FeedLog
    {
        private List<FeedLogInfo> log;

        public FeedLog(string logPath)
        {
            log = new List<FeedLogInfo>();

            if (File.Exists(logPath))
            {
                FileStream fs = File.Open(logPath, FileMode.Open);
                FeedLogInfo[]? fArr = JsonSerializer.Deserialize<FeedLogInfo[]>(fs);
                foreach (FeedLogInfo feed in fArr)
                {
                    log.Add(feed);
                }
                fs.Close();
            }
        }

        /// <summary>
        /// Gets the feed logs for a specified reptile
        /// </summary>
        /// <param name="reptileName"></param>
        /// <returns></returns>
        public List<FeedLogInfo> GetReptileLogs(string reptileName)
        {
            List<FeedLogInfo> list = new List<FeedLogInfo>();

            for(int i = 0; i < log.Count; i++)
            {
                if (reptileName.Equals(log[i].reptileName))
                {
                    list.Add(log[i]);
                }
            }

            return list;
        }

        /// <summary>
        /// Log a new feed event
        /// </summary>
        /// <param name="reptileName"></param>
        /// <param name="feederSpecies"></param>
        /// <param name="amount"></param>
        public void Log(string reptileName, string feederSpecies, int amount)
        {
            log.Add(new FeedLogInfo(DateTime.Now.ToString(), reptileName, feederSpecies, amount));
        }

        /// <summary>
        /// Save the logs
        /// </summary>
        /// <param name="logPath"></param>
        public void Save(string logPath)
        {
            string logJSON = JsonSerializer.Serialize(log);

            FileStream fs = File.Create(logPath);
            fs.Write(Encoding.ASCII.GetBytes(logJSON), 0, Encoding.ASCII.GetByteCount(logJSON));

            fs.Close();
        }
    }
}
