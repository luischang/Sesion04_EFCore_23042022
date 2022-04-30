using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Sesion04_ConsoleEF.DatabaseFirst.Models
{
    public partial class SoccerDbContext : DbContext
    {
        public SoccerDbContext()
        {
        }

        public SoccerDbContext(DbContextOptions<SoccerDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Player> Player { get; set; } = null!;
        public virtual DbSet<PlayerTeam> PlayerTeam { get; set; } = null!;
        public virtual DbSet<Team> Team { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-S1DROK0\\SQLEXPRESS;Database=SoccerDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>(entity =>
            {
                entity.Property(e => e.FullName).HasMaxLength(100);
            });

            modelBuilder.Entity<PlayerTeam>(entity =>
            {
                entity.HasKey(e => new { e.PlayerId, e.TeamId });

                entity.HasIndex(e => e.PlayerId, "IX_PlayerTeam_PlayerId");

                entity.HasIndex(e => new { e.PlayerId, e.TeamId }, "IX_PlayerTeam_PlayerId_TeamId")
                    .IsUnique();

                entity.HasIndex(e => e.TeamId, "IX_PlayerTeam_TeamId");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PlayerTeam)
                    .HasForeignKey(d => d.PlayerId);

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.PlayerTeam)
                    .HasForeignKey(d => d.TeamId);
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(80);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
