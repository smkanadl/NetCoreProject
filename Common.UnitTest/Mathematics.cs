using NUnit.Framework;
using System;

namespace Leybold.Common
{
    [TestFixture]
    public class MathematicsTest
    {
        [Test]
        public void Sum_3And4_Is7()
        {
            Assert.That(Mathematics.Sum(3, 4), Is.EqualTo(7));
        }
    }
}
