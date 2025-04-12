using DataLayer;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingLayer
{
    [TestFixture]
    public class ClientsContextTests
    {
        static ClientsContext clientsContext;

         static ClientsContextTests()
         {
            clientsContext = new ClientsContext(TestManager.dbContext);
         }

        [Test]
        public void CreateClient()
        {
            Client client = new Client("Petar", "Dimitrov", "Stoyanov", 23, "VIP");

            clientsContext.Create(client);

            Client lastClient = TestManager.dbContext.Clients.Last();
            Assert.That(lastClient.Name, Is.EqualTo(client.Name), "Names are not the same!!!!");
        }

        [Test]
        public void ReadClient()
        {
            Client newClient = new Client("Petar", "Dimitrov", "Stoyanov", 23, "VIP");
            clientsContext.Create(newClient);

            Client client = clientsContext.Read(1);

            Assert.That(client.Name == "Petar", "Read() does not work!!!!!");
        }

        [Test]

        public void ReadAllClients()
        {
            int ClientsBefore = TestManager.dbContext.Clients.Count();

            int ClientsAfter = clientsContext.ReadAll().Count;

            Assert.That(ClientsBefore == ClientsAfter, "The ReadAll() method doees not work properly!");
        }

        [Test]

        public void UpdateClient()
        {
            Client newClient = new Client("Petar", "Dimitrov", "Stoyanov", 23, "VIP");
            clientsContext.Create(newClient);

            Client lastClient = clientsContext.ReadAll().Last();
            lastClient.Name = "Martin";

            clientsContext.Update(lastClient, false);

            Assert.That(clientsContext.Read(lastClient.ClientId).Name == "Martin", "The Update() does not work!!!");

        }

        [Test]
        
        public void DeleteClient()
        {
            Client newClient = new Client("Petar", "Dimitrov", "Stoyanov", 23, "VIP");
            clientsContext.Create(newClient);

            List<Client> clients = clientsContext.ReadAll();
            int clientsBefore = clients.Count();
            Client lastClient = clients.Last();

            clientsContext.Delete(lastClient.ClientId);

            int clientsAfter = clientsContext.ReadAll().Count;
            Assert.That(clientsBefore == clientsAfter + 1, "The Delete() method does not work!! :(");
        }
    }
}
