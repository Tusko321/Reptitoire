namespace Reptitoire.ReptitoireManager.Reptile
{
    /// <summary>
    /// Serializable array of reptiles for JSON conversion
    /// </summary>
    [System.Serializable]
    public class ReptileList
    {
        public List<ReptileInfo> List { get; set; }

        public ReptileList() { List = new List<ReptileInfo>(); }

        public void Add(ReptileInfo reptileInfo) { List.Add(reptileInfo); }

        public void RemoveAt(int index) { List.RemoveAt(index); }

        public ReptileInfo this[int index]
        {
            get => List[index]; 
            set => List[index] = value;
        }

        public void Clear() { List.Clear(); }
    }
}
