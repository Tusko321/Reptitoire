using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reptitoire.ReptitoireManager.Feeder
{
    [System.Serializable]
    public class FeederInfo
    {
        public string species;
        public int amount;

        public FeederInfo(string species, int amount)
        {
            this.species = species;
            this.amount = amount;
        }
    }
}
