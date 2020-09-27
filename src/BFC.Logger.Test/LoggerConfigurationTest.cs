using BFC.Logger.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BFC.Logger.Test
{
    [TestClass]
    public class LoggerConfigurationTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var target = LoggerConfiguration.Setup(LogTarget.Database);

            Assert.AreEqual(target, LogTarget.Database);
        }
    }
}
