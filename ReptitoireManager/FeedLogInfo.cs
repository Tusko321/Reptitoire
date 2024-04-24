using Reptitoire.ReptitoireManager.Feeder;
using Reptitoire.ReptitoireManager.Reptile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reptitoire.ReptitoireManager
{
    [System.Serializable]
    public class FeedLogInfo
    {
        public string datetime;
        public string reptileName;
        public string feederSpecies;
        public int amount;

        public FeedLogInfo(string datetime, string reptileName, string feederSpecies, int amount)
        {
            this.datetime = datetime;
            this.reptileName = reptileName;
            this.feederSpecies = feederSpecies;
            this.amount = amount;
        }
    }
}
