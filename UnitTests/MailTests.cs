using WannabeNetflix.src.core;
using WannabeNetflix.src.utils;

namespace UnitTests
{
    [TestClass]
    public class MailTests
    {
        [TestMethod]
        public void TestEmailExists()
        {
            string error = ValidatorUtil.ValidateMail("dem.mak@gmail.com");
            Assert.AreEqual(Error.MAIL_EXISTS, error);
        }


        [TestMethod]
        public void TestEmailInvalid()
        {
            string error = ValidatorUtil.ValidateMail("@gmail.com");
            Assert.AreEqual(Error.INVALID_MAIL, error);

            error = ValidatorUtil.ValidateMail("max@gmail");
            Assert.AreEqual(Error.INVALID_MAIL, error);

            error = ValidatorUtil.ValidateMail("maxgmail.com");
            Assert.AreEqual(Error.INVALID_MAIL, error);

            error = ValidatorUtil.ValidateMail("max@.com");
            Assert.AreEqual(Error.INVALID_MAIL, error);
        }

        [TestMethod]
        public void TestEmailValid()
        {
            string error = ValidatorUtil.ValidateMail("maxence.demers@gmail.com");
            Assert.AreEqual(Error.NONE, error);
        }
    }
}