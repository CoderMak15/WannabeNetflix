using WannabeNetflix.src.core;
using WannabeNetflix.src.roles;

namespace UnitTests
{
    [TestClass]
    public class ClientsTests
    {
        AppManager app = new AppManager(true);
        Client c = new Client("Steve", "Jobs", "gender", DateTime.Now, "steve.jobs@apple.com", "apple123");


        [TestMethod]
        public void CreateClientTest()
        {
            int clientCount = AppManager.Instance.ClientManager.GetClients().Count;
            AppManager.Instance.ClientManager.CreateClient(c);
            Assert.AreEqual(clientCount + 1, AppManager.Instance.ClientManager.GetClients().Count);
        }

        [TestMethod]
        public void ModifyClientTest()
        {
            AppManager.Instance.ClientManager.CreateClient(c);
            Client client = AppManager.Instance.ClientManager.GetClientByMail("steve.jobs@apple.com");
            Client overrideClient = new Client(client.FirstName, client.LastName, client.Gender, DateTime.Now, "test@gmail.com", client.Password);
            client.OverrideClientInfo(overrideClient);
            AppManager.Instance.ClientManager.UpdateClientMail(client, "steve.jobs@apple.com");
            Client client3 = AppManager.Instance.ClientManager.GetClientByMail("steve.jobs@apple.com");
            Assert.IsTrue(client != null && client3 == null);
        }

        [TestMethod]
        public void RemoveClientTest()
        {
            AppManager.Instance.ClientManager.CreateClient(c);
            AppManager.Instance.ClientManager.RemoveClient(c.Mail);
            Client client = AppManager.Instance.ClientManager.GetClientByMail("steve.jobs@apple.com");
            Assert.AreEqual(null, client);
        }

        [TestMethod]
        public void GetClientByMail()
        {
            Client client = AppManager.Instance.ClientManager.GetClientByMail("qwerty");
            Assert.AreEqual(null, client);

            CreateClientTest();

            client = AppManager.Instance.ClientManager.GetClientByMail("steve.jobs@apple.com");
            Assert.AreEqual(c, client);
        }
    }
}
