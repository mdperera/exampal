using Microsoft.EntityFrameworkCore;

namespace exampal.Infrastructure
{
    public class exampalContext : DbContext
    {
        public exampalContext(DbContextOptions<exampalContext> options)
            :base(options)
        {

        }
    }
}
