using Microsoft.EntityFrameworkCore;

namespace Sesion04_MVC.CodeFirst.Models
{
    public class Qatar2022DbContext: DbContext
    {
        //Create constructor
        public Qatar2022DbContext(DbContextOptions<Qatar2022DbContext> options) : base(options)
        {
            
        }

        public virtual DbSet<Player> Player { get; set; }

        
    }
}
