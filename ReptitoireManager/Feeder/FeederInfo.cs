namespace Reptitoire.ReptitoireManager.Feeder
{
    /// <summary>
    /// Holds the information for feeders
    /// </summary>
    [System.Serializable]
    public class FeederInfo
    {
        public string species { get; set; }
        public int amount { get; set; }

        public FeederInfo(string species, int amount)
        {
            this.species = species;
            this.amount = amount;
        }
    }
}
