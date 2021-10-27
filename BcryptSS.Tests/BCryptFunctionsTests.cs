using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BCryptSS.Tests
{
    [TestClass]
    public class BCryptFunctionsUnitTests
    {
        [TestMethod]
        public void HashPasswordTest()
        {
            string h = BCryptFunctions.HashPassword("pass");

            // (Hash should be different every time)
            Assert.AreNotEqual(BCryptFunctions.HashPassword("pass"), h);

            Assert.AreNotEqual(BCryptFunctions.HashPassword("abc"), h);

            Assert.IsTrue(BCryptFunctions.CheckPassword("pass", h));

            Assert.IsFalse(BCryptFunctions.CheckPassword("abc", h));
        }

        [TestMethod]
        public void CheckPasswordTest()
        {
            Assert.IsTrue(BCryptFunctions.CheckPassword("pass", "$2a$10$5V88J4tFtfeouzkjwRiFL.kx.eerDR2T.78pt1dQ7WtBncNnUn5Tm"));

            Assert.IsFalse(BCryptFunctions.CheckPassword("abc", "$2a$10$5V88J4tFtfeouzkjwRiFL.kx.eerDR2T.78pt1dQ7WtBncNnUn5Tm"));
        }
    }
}

