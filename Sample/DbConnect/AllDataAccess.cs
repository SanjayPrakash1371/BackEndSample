using Microsoft.EntityFrameworkCore;
using Sample.Models;
using Sample.Models.OtherRewards;
using Sample.Models.P2P;
using Sample.Models.Rewards;

namespace Sample.DbConnect
{
    public class AllDataAccess:DbContext
    {
        public AllDataAccess(DbContextOptions<AllDataAccess> options):base(options) { }

        public DbSet<Employee> Employees { get; set; }  

        /*public DbSet<Employee_login> Employees_login { get; set;}*/

        public DbSet<Roles> Roles { get; set; }


        public DbSet<RewardsTypes> RewardsTypes { get; set; }

        public DbSet<Campaigns> Campaigns { get; set; }
        public DbSet<PeerToPeer> PeerToPeer { get; set; }

        public DbSet<PeerToPeerResults> PeerToPeerResults { get; set;}

        public DbSet<LeadRewards> LeadRewards { get; set;}

        public DbSet<LeadRewardResults> LeadRewardResults { get; set;}


        
    }
}
