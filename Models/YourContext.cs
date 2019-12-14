using Microsoft.EntityFrameworkCore;

namespace Via3Codeathon.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }
    }
}

