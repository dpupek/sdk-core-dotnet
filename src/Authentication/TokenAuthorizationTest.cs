using System;
using PayPal.Authentication;

#if NUnit
/* NuGet Install
 * Visual Studio 2005
    * Install NUnit -OutputDirectory .\packages
    * Add reference from NUnit.2.6.2
 */
using NUnit.Framework;

namespace PayPal.NUnitTest
{
    [TestFixture]
    class TokenAuthorizationTest
    {
        [Test, ExpectedException(typeof(ArgumentException))]
        public void ArgumentExceptionTest()
        {
            TokenAuthorization toknAuthorization = new TokenAuthorization(null, null);
        }
    }
}
#else
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PayPal.UnitTest
{
    [TestClass]
    public class TokenAuthorizationTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ArgumentExceptionTest()
        {
            try
            {
                TokenAuthorization toknAuthorization = new TokenAuthorization(null, null);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("TokenAuthorization arguments cannot be empty", ex.Message);
                throw;
            }
        }
    }
}
#endif