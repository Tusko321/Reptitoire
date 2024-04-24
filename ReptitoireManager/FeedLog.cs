using System.Text;
using System.Text.Json;

namespace Reptitoire.ReptitoireManager
{
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

        public void Log(string reptileName, string feederSpecies, int amount)
        {
            log.Add(new FeedLogInfo(DateTime.Now.ToString(), reptileName, feederSpecies, amount));
        }

        public void Save(string logPath)
        {
            string logJSON = JsonSerializer.Serialize(log);

            FileStream fs = File.Create(logPath);
            fs.Write(Encoding.ASCII.GetBytes(logJSON), 0, Encoding.ASCII.GetByteCount(logJSON));

            fs.Close();
        }
    }
}
