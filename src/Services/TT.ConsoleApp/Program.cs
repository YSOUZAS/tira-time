using TT.Dealer.Services;
using TT.Models;
using TT.Reader.Services;

var numberOfTeams = 3;
var reader = new Reader();
var dealer = new Dealer();

var players = reader.Read<Player>("resources/segunda.csv", predicate: p => p.Available);
var dic = dealer.SortTeams(players, numberOfTeams);

Random rng = new();

var teams = dic.Values.OrderBy(a => rng.Next()).ToList();

for (int i = 0; i < numberOfTeams; i++)
{
    Console.WriteLine($"Time {i + 1} - Score: {teams[i].Score:N2}");

    foreach (var player in teams[i].Players.OrderByDescending(p => p.Score))
    {
        Console.WriteLine($"{player.Name} - {player.Score:N2}");
    }
    Console.WriteLine("-------------");
}