using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion04_ConsoleEF.CodeFirst.Models
{
    [Table("PlayerTeam")]
    public  class PlayerTeam
    {
        public int PlayerId { get; set; }
        public int TeamId { get; set; }

        public DateTime InitalDate { get; set; }

        public virtual Player Player { get; set; }
        public virtual Team Team { get; set; }

    }
}
