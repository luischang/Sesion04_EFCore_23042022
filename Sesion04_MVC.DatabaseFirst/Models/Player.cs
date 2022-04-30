using System;
using System.Collections.Generic;

namespace Sesion04_MVC.DatabaseFirst.Models
{
    public partial class Player
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public int Dorsal { get; set; }
        public int Age { get; set; }
    }
}
