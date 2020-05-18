using DataAccess.Logic;
using DataAccess.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using System;
using System.Linq;

namespace UnitTests
{
    [TestClass]
    public class DataAccessTests
    {
        [TestMethod]
        public void TestDataAccessAndDatabase()
        {
            var log = new Log()
            {
                UserId = "test:userid",
                Date = DateTime.UtcNow,
                Info = "This is a test log."
            };

            SQLHelper.SaveLog(log);

            var logs = SQLHelper.GetLogs();

            Assert.IsTrue(logs.Any(a => a.Date.Date.Equals(log.Date.Date)));
        }

        [TestMethod]
        public void TestSQLInjectionVulnerability()
        {
            var log = new Log()
            {
                UserId = "injection) -- ",
                Date = DateTime.UtcNow,
                Info = "This is a test log."
            };

            SQLHelper.SaveLog(log);

            var logs = SQLHelper.GetLogs();

            Assert.IsTrue(logs.Any(a => a.UserId.Equals(log.UserId)));
        }
    }
}
