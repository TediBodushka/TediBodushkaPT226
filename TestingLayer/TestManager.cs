using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using Microsoft.EntityFrameworkCore.InMemory;
using NUnit.Framework;

namespace TestingLayer
{
        [TestFixture]
        public class TestManager
        {
        
            internal static GamesDbContext dbContext;

            static TestManager()
            {
                DbContextOptionsBuilder builder = new DbContextOptionsBuilder();
                builder.UseInMemoryDatabase("DbForTest");
                dbContext = new GamesDbContext(builder.Options);
            }

            [OneTimeTearDown]
            public void Dispose()
            {
                dbContext.Dispose();
            }

            [Test]
            public void Test1()
            {
                Assert.Pass();
            }
        }
}
