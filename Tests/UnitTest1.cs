using App;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class CatTests
    {
        [Test]
        public void Meow()
        {
            var cat = new Cat();

            var result = cat.Meow();

            Assert.That(result, Is.EqualTo("woof"));
        }
    }
}
