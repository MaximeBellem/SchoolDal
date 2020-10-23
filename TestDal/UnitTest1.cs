using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using SchoolDal;

namespace TestDal
{
    public class Tests
    {
        private SchoolContext _schoolContext;
        
        [SetUp]
        public void Setup()
        {
            DbContextOptionsBuilder<SchoolContext> optionsBuilder = new DbContextOptionsBuilder<SchoolContext>();
            optionsBuilder.UseSqlite(
                "Data Source=/Users/Max/OneDrive - Enseignement de la Province de Liège/1. COURS DE 3e/.NET/Projets/Solution1/schoolSqlite.db cache=shared");
            
            
            
            _schoolContext = new SchoolContext(optionsBuilder.Options);
            _schoolContext.Database.EnsureDeleted();
            _schoolContext.Database.EnsureCreated();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();

        }
        
        [Test]
        public void Test2()
        {
            Assert.Pass();
            
        }
        
    }
}