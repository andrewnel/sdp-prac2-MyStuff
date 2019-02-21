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
        public void bi()
        {
            string result = Program.Prefix("hello");
            Assert.AreEqual("5,1:hello", result);
        }
        [Test]
        public void bii()
        {
            string result = Program.Prefix("");
            Assert.AreEqual("0,0:", result);
        }
        [Test]
        public void biii()
        {
            string result = Program.Prefix("what    ...  did you say?? ");
            Assert.AreEqual("27,5:what    ...  did you say?? ", result);
        }

    }
}