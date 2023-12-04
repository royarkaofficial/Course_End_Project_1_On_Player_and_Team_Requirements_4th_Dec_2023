namespace TeamManagementApp
{
    public interface ITeam
    {
        void Add(Player player);
        void Remove(int playerId);
        Player GetPlayerById(int playerId);
        Player GetPlayerByName(string name);
        List<Player> GetAllPlayers();
    }
}
