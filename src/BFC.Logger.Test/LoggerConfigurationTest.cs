using BFC.Logger.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BFC.Logger.Test
{
    [TestClass]
    public class LoggerConfigurationTest
    {
        [TestMethod]
        public void LoggerConfiguration_SetupCorrectly_Database_Test()
        {
            var target = LoggerConfiguration.Setup(LogTarget.Database);

            Assert.AreEqual(target, LogTarget.Database);
        }

        [TestMethod]
        public void LoggerConfiguration_SetupCorrectly_File_Test()
        {
            var target = LoggerConfiguration.Setup(LogTarget.File);

            Assert.AreEqual(target, LogTarget.File);
        }

        [TestMethod]
        public void LoggerConfiguration_SetupWithDifferentTargets_Test()
        {
            var target = LoggerConfiguration.Setup(LogTarget.File);

            Assert.AreNotEqual(target, LogTarget.Database);
        }
    }
}
