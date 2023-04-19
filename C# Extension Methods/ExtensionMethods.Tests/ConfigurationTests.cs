using ExtensionMethods.Library;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;

namespace ExtensionMethods.Tests
{
    class ConfigurationTests
    {
        [Test]
        public void IsLoaded()
        {
            IConfiguration config = null;
            Assert.IsFalse(config.IsLoaded());
        }
    }
}
