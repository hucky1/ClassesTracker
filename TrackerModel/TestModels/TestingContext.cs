using Microsoft.EntityFrameworkCore;

namespace TrackerModel.TestModels
{
    public class TestingContext : DbContext
    {

        public DbSet<TestModel> TestModel { get; set; }
       


        public DbSet<PassedTestsModel> PassedTests { get; set; }
        public DbSet<TaskModel> Tasks { get; set; }
        public TestingContext()
        {

            Database.EnsureCreated();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Testing.mdf; Integrated Security = True; " +
                "Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

        }//AttachDbFilename=|DataDirectory|\testingDB.mdf

    }
}