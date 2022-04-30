
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion04_ConsoleEF.CodeFirst.Models
{
    public class SoccerDbContext: DbContext
    {
        //Create OnConfiguring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Auth Sql
            //string cnx = "Server=DESKTOP-S1DROK0\\SQLEXPRESS;Database=SoccerDb;User Id=sa;Password=12345;";            
            string cnx = "Server=DESKTOP-S1DROK0\\SQLEXPRESS;Database=SoccerDb;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(cnx).LogTo(Console.WriteLine, LogLevel.Information);
        }
        //Create OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Create Table
            modelBuilder.Entity<Team>().ToTable("Team");
            modelBuilder.Entity<Player>().ToTable("Player");
            modelBuilder.Entity<PlayerTeam>().ToTable("PlayerTeam");
            //Create Primary Key
            modelBuilder.Entity<PlayerTeam>().HasKey(pt => new { pt.PlayerId, pt.TeamId });
            //Create Foreign Key
            modelBuilder.Entity<PlayerTeam>().HasOne(pt => pt.Player).WithMany().HasForeignKey(pt => pt.PlayerId);
            modelBuilder.Entity<PlayerTeam>().HasOne(pt => pt.Team).WithMany().HasForeignKey(pt => pt.TeamId);
            //Create Index
            modelBuilder.Entity<PlayerTeam>().HasIndex(pt => pt.PlayerId);
            modelBuilder.Entity<PlayerTeam>().HasIndex(pt => pt.TeamId);
            //Create Unique
            modelBuilder.Entity<PlayerTeam>().HasIndex(pt => new { pt.PlayerId, pt.TeamId }).IsUnique();
        }


        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<PlayerTeam> PlayerTeam { get; set; }
    }
}
