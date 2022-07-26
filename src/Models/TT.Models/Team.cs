namespace TT.Models
{
    public class Team : IComparable
    {
        public double Score { get; set; }
        public List<Player> Players { get; set; }

        public Team()
        {
            Score = 0;
            Players = new();
        }

        public int CompareTo(object? obj)
        {
            if (obj is null) return 1;

            Team otherTeam = (Team)obj;

            if (otherTeam is not null)
            {
                if (this.Score == otherTeam.Score)
                {
                    var bestPlayer = this.Players.OrderByDescending(p => p.Score).FirstOrDefault() ?? new();
                    var bestPlayerFromOtherTeam = otherTeam.Players.OrderByDescending(p => p.Score).FirstOrDefault();
                    var result = bestPlayer.CompareTo(bestPlayerFromOtherTeam);

                    return result;
                }

                return this.Score.CompareTo(otherTeam.Score);
            }
            else
                throw new ArgumentException("Object is not a Team");
        }
    }
}