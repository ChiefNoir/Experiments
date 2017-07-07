using System.Data.Entity;
using DataModel;

namespace DataService
{
    class ClientsContext : DbContext
    {
        public DbSet<Passport> Passports { get; set; }
        public DbSet<BirthCertificate> BirthCertificates { get; set; }
    }
}
