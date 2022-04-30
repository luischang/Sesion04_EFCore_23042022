using System;
using System.Collections.Generic;

namespace Sesion04_ConsoleEF.DatabaseFirst.Models
{
    public partial class Team
    {
        public Team()
        {
            PlayerTeam = new HashSet<PlayerTeam>();
        }

        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public string Country { get; set; } = null!;

        public virtual ICollection<PlayerTeam> PlayerTeam { get; set; }
    }
}
