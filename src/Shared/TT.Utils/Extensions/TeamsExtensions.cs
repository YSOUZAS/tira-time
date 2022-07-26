using TT.Models;

namespace Utils.Extensions
{
    public static class TeamsExtensions
    {
        public static void AddPlayerAndUpdateScore(this Team team, Player player)
        {
            team.Players.Add(player);
            team.Score += player.Score;
        }
    }
}
