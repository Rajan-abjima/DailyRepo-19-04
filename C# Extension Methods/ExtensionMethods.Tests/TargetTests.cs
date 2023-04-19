using ExtensionMethods.Library;
using NUnit.Framework;

namespace ExtensionMethods.Tests
{
    class TargetTests
    {
        [Test]
        public void StandardizedId()
        {
            var obj = new Target("id01");
            Assert.AreEqual("ID01", obj.GetStandardized());
        }
    }
}