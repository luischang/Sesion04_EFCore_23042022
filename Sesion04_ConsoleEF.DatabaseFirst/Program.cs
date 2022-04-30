// See https://aka.ms/new-console-template for more information
using Sesion04_ConsoleEF.DatabaseFirst.Models;

Console.WriteLine("Hello, World!");
//Insert Player 

var context = new SoccerDbContext();
//Insert player
var player = new Player()
{
    FullName = "Messi",
    Age = 34,
    Dorsal=10    
};

context.Add(player);
context.SaveChanges();

