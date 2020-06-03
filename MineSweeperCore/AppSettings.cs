namespace MinesweeperCore
{
    public class AppSettings
    {
        public string BeginnerPlayerName { get; set; }
        public int BeginnerBestTime { get; set; }
        public string IntermediatePlayerName { get; set; }
        public int IntermediateBestTime { get; set; }
        public string ExpertPlayerName { get; set; }
        public int ExpertBestTime { get; set; }
        public string LatestLevel { get; set; }
        public int LatestColumns { get; set; }
        public int LatestRows { get; set; }
        public int LatestMines { get; set; }
        public bool Mark { get; set; }

        public AppSettings()
        {
            BeginnerPlayerName = IntermediatePlayerName = ExpertPlayerName = "Anonymous";
            BeginnerBestTime = IntermediateBestTime = ExpertBestTime = 999;
            LatestLevel = "Beginner";
            LatestColumns = 9;
            LatestRows = 9;
            LatestMines = 10;
            Mark = true;
        }
    }
}