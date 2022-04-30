using System;
using System.Collections.Generic;

namespace Sesion04_ConsoleEF.DatabaseFirst.Models
{
    public partial class Player
    {
        public Player()
        {
            PlayerTeam = new HashSet<PlayerTeam>();
        }

        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public int Dorsal { get; set; }
        public int Age { get; set; }

        public virtual ICollection<PlayerTeam> PlayerTeam { get; set; }
    }
}
