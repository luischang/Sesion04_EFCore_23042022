// See https://aka.ms/new-console-template for more information
using Sesion04_ConsoleEF.DatabaseFirst.Models;

Console.WriteLine("Hello, World!");
//Insert Player 

var context = new SoccerDbContext();
//Insert player
//var player = new Player()
//{
//    FullName = "Messi",
//    Age = 34,
//    Dorsal=10    
//};

//context.Add(player);
//context.SaveChanges();

//var player2 = new Player()
//{
//    FullName = "Cristiano Ronaldo",
//    Age = 36,
//    Dorsal = 7
//};

//var player3 = new Player()
//{
//    FullName = "Paolo Guerrero",
//    Age = 38,
//    Dorsal = 9
//};

//var player4 = new Player()
//{
//    FullName = "Gianluca Lapadula",
//    Age = 32,
//    Dorsal = 14
//};

//var playerList = new List<Player>();
//playerList.Add(player2);
//playerList.Add(player3);
//playerList.Add(player4);

////Insert All in SoccerDbContext
//context.AddRange(playerList);
//context.SaveChanges();

//Remove Player
//var playerToRemove2 = context.Player.Where(x => x.Id == 4).FirstOrDefault();
// to Lambda expressions
//var playerToRemove = context
//                .Player
//                .FirstOrDefault(p => p.Id == 4);
//context.Player.Remove(playerToRemove);
//context.SaveChanges();
//LINQ query expressions
//var playerToRemove2 = (from p in context.Player
//                       where p.Id == 4
//                       select p).FirstOrDefault();

//context.Player.Remove(playerToRemove2);
//context.SaveChanges();

//Query with Lambda expressions

var playerAll = context.Player.ToList();

//Print in console
foreach (var item in playerAll)
{
    Console.WriteLine($"{item.FullName} - {item.Age} - {item.Dorsal}");
    //Console.WriteLine("Fullname" + item.FullName)
}

//Insert a new team
//var team = new Team()
//{
//    Description = "Barcelona",
//    Country = "ESPAÑA"
//};

//var team2 = new Team()
//{
//    Description = "Real Madrid",
//    Country = "ESPAÑA"
//};

//var team3 = new Team()
//{
//    Description = "PSG",
//    Country = "FRANCIA"
//};

////Create a list of teams
//var teamList = new List<Team>();
//teamList.Add(team);
//teamList.Add(team2);
//teamList.Add(team3);

//Insert all in SoccerDbContext
//context.Team.AddRange(teamList);
//context.SaveChanges();

//Create PlayerTeam
//var playerTeam = new PlayerTeam()
//{
//    PlayerId = 1,
//    TeamId = 1,
//    InitalDate = DateTime.Now,
//};

//var playerTeam2 = new PlayerTeam()
//{
//    PlayerId = 2,
//    TeamId = 2,
//    InitalDate = DateTime.Now,
//};

//var playerTeam3 = new PlayerTeam()
//{
//    PlayerId = 3,
//    TeamId = 3,
//    InitalDate = DateTime.Now,
//};

////Create a list of PlayerTeam
//var playerTeamList = new List<PlayerTeam>();
//playerTeamList.Add(playerTeam);
//playerTeamList.Add(playerTeam2);
//playerTeamList.Add(playerTeam3);
////Insert all in SoccerDbContext
//context.PlayerTeam.AddRange(playerTeamList);
//context.SaveChanges();

//Search in player
var player = context.Player.Where(x => x.Id == 3).FirstOrDefault();
player.Age = 37;
context.SaveChanges();
