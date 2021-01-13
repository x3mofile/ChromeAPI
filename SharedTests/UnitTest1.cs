using Microsoft.VisualStudio.TestTools.UnitTesting;
using x3.Chrome;

namespace SharedTests
{
    [TestClass]
    public class CreateNewInactiveTabMessage_Test
    {
        [TestMethod]
        public void StaticFromMessage_returnsTypeWithCorrectUrl()
        {
            var url = "TheUrl";
            var pre = new CreateNewInactiveTabMessage(url);
            var message = pre.ToString();

            var tested = CreateNewInactiveTabMessage.FromMessage(message);
            
            Assert.AreEqual(tested.Url, url);

        }


        [TestMethod]
        public void ToString_returnsUrlPrefixedByTitle()
        {
            var url = "TheUrl";
            var tested = new CreateNewInactiveTabMessage(url);
            var expected = $"{CreateNewInactiveTabMessage.Title}{url}";
            var message = tested.ToString();

            Assert.AreEqual( expected,message);

        }

        [TestMethod]
        public void StaticSharesTitle()
        {
            var url = "TheUrl";
            var tested = new CreateNewInactiveTabMessage(url);
            var message = tested.ToString();
            var sharesTitle = CreateNewInactiveTabMessage.SharesTitle(message);
            Assert.IsTrue(sharesTitle);
            
            message = url;
            sharesTitle = CreateNewInactiveTabMessage.SharesTitle(message);
            Assert.IsFalse(sharesTitle,"Matching Urls message doesn't ShareTitle");

            message = "Random";
            sharesTitle = CreateNewInactiveTabMessage.SharesTitle(message);
            Assert.IsFalse(sharesTitle,"Random message doesn't ShareTitle");


            message="";
            sharesTitle=CreateNewInactiveTabMessage.SharesTitle(message);
            Assert.IsFalse(sharesTitle,"Empty message doesn't ShareTitle");
        }
    }
}
