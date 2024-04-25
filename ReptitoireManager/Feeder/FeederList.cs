namespace Reptitoire.ReptitoireManager.Feeder
{
    /// <summary>
    /// Serializable array of feeders for JSON conversion
    /// </summary>
    [System.Serializable]
    public class FeederList
    {
        public List<FeederInfo> List { get; set; }

        public FeederList() { List = new List<FeederInfo>(); }

        public void Add(FeederInfo feederInfo)
        {
            List.Add(feederInfo);
        }

        public FeederInfo this[int index]
        {
            get => List[index];
            set => List[index] = value;
        }
    }
}
