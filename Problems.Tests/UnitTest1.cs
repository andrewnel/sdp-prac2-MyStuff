using NUnit.Framework;
using Problems;
namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void tests()
        {
            //Test 1 - 3
            Assert.AreEqual("5,1:hello", Program.Prefix("hello"));
            Assert.AreEqual("0,0:", Program.Prefix(""));
            Assert.AreEqual("27,5:what    ...  did you say?? ", Program.Prefix("what    ...  did you say?? "));

            //My Tests
            Assert.AreEqual("11,2:Two words! ", Program.Prefix("Two words! "));
            Assert.AreEqual("10,3:123 456  1", Program.Prefix("123 456  1"));
            Assert.AreEqual(null, Program.Prefix(null));
        }
    }
}