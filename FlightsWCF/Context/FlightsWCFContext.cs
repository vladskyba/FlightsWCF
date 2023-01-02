using FlightsWCF.Models;
using System.Data.Entity;

namespace FlightsWCF.Context
{
    public class FlightsWCFContext : DbContext
    {
        public FlightsWCFContext() : base("FlightsWCFContextConnection") 
        {
        
        }

        public DbSet<User> Users { get; set; }
    }
}