namespace Reptitoire.ReptitoireManager
{
    /// <summary>
    /// Holds the information for a feed log event
    /// </summary>
    [System.Serializable]
    public class FeedLogInfo
    {
        public string datetime { get; set; }
        public string reptileName { get; set; }
        public string feederSpecies { get; set; }
        public int amount { get; set; }

        public FeedLogInfo(string datetime, string reptileName, string feederSpecies, int amount)
        {
            this.datetime = datetime;
            this.reptileName = reptileName;
            this.feederSpecies = feederSpecies;
            this.amount = amount;
        }
    }
}
