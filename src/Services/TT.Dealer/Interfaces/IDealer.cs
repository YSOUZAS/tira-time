using TT.Models;

namespace TT.Dealer.Interfaces
{
    public interface IDealer
    {
        public Dictionary<int, Team> SortTeams(List<Player> players, int numberOfTeams);
    }
}
