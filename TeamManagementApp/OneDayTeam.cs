namespace TeamManagementApp
{
    public class OneDayTeam : ITeam
    {
        public static List<Player> oneDayTeam = new List<Player>();
        public OneDayTeam()
        {
            oneDayTeam.Capacity = 11;
        }
        public void Add(Player player)
        {
            oneDayTeam.Add(player);
        }
        public List<Player> GetAllPlayers()
        {
            return oneDayTeam;
        }
        public Player GetPlayerById(int playerId)
        {
            return oneDayTeam.First(player => player.PlayerId == playerId);
        }
        public Player GetPlayerByName(string name)
        {
            return oneDayTeam.First(player => player.PlayerName == name);
        }
        public void Remove(int playerId)
        {
            var index = oneDayTeam.FindIndex(player => player.PlayerId == playerId);
            oneDayTeam.RemoveAt(index);
        }
    }
}
