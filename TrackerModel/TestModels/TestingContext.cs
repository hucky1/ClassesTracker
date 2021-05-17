using Microsoft.EntityFrameworkCore;

namespace TrackerModel.TestModels
{
    public class TestingContext : DbContext
    {
        public DbSet<MethodsTest> MethodsTest { get; set; }
        public DbSet<ClassesTest> ClassesTest { get; set; }
        
        public DbSet<InheritanceTest> InheritanceTest { get; set; }

        public DbSet<PassedTestsModel> PassedTests { get; set; }
        public DbSet<TaskModel> Tasks { get; set; }
        public TestingContext()
        {
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\testingDB.mdf; Integrated Security = True; " +
                "Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

        }
    }
}