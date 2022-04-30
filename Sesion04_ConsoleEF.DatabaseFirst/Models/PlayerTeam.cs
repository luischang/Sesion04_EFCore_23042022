using System;
using System.Collections.Generic;

namespace Sesion04_ConsoleEF.DatabaseFirst.Models
{
    public partial class PlayerTeam
    {
        public int PlayerId { get; set; }
        public int TeamId { get; set; }
        public DateTime InitalDate { get; set; }

        public virtual Player Player { get; set; } = null!;
        public virtual Team Team { get; set; } = null!;
    }
}
