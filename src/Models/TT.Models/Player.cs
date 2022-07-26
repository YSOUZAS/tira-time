namespace TT.Models
{
    public class Player:IComparable
    {
        public string Name { get; set; } = string.Empty;
        public double Score { get; set; }
        public bool Available { get; set; }
        public int CompareTo(object? obj)
        {
            if (obj is null) return 1;

            Player otherPlayer = (Player)obj;

            if (otherPlayer is not null)
                return this.Score.CompareTo(otherPlayer.Score);
            else
                throw new ArgumentException("Object is not a Player");
        }
    }
}