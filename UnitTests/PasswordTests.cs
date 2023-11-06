using WannabeNetflix.src.core;
using WannabeNetflix.src.utils;

namespace UnitTests
{
    [TestClass]
    public class PasswordTests
    {
        [TestMethod]
        public void TestShortPassword()
        {
            string error = ValidatorUtil.ValidatePassword("1234");
            Assert.AreEqual(Error.PW_TOO_SHORT, error);
        }

        [TestMethod]
        public void TestGoodPassword()
        {
            string error = ValidatorUtil.ValidatePassword("12345678");
            Assert.AreEqual(Error.NONE, error);
        }
    }
}
