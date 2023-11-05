using System.Runtime.Intrinsics.Arm;
using WannabeNetflix.src.roles;
using WannabeNetflix.src.utils;

namespace WannabeNetflix.src.core
{
    internal class ClientManager
    {      
        internal List<Client> GetClients() => _clients;
        private List<Client> _clients = new List<Client>();
        private Dictionary<string, Client> _uniqueAddressesMap = new Dictionary<string, Client>();

        public ClientManager()
        {
            _clients = PopulateClients();
        }

        private List<Client> PopulateClients()
        {
            Client c1 = new("Seb", "Gagn", "gender", DateTime.Now, "seb.gagn@gmail.com", Encryption.MD5Hash("12345678"));
            Client c2 = new("Gagn", "Seb", "gender", DateTime.Now, "gagn.seb@gmail.com", Encryption.MD5Hash("12345678"));
            Client c3 = new("Mak", "Dem", "gender", DateTime.Now, "mak.dem@gmail.com", Encryption.MD5Hash("password"));
            Client c4 = new("Dem", "Mak", "gender", DateTime.Now, "dem.mak@gmail.com", Encryption.MD5Hash("password"));
            List<Client> clients = new List<Client> { c1, c2, c3, c4 };

            foreach (Client client in clients)
            {
                _uniqueAddressesMap.Add(client.Mail, client);
            }

            return new List<Client> { c1, c2, c3, c4 };
        }

        internal void RemoveClient(string mail)
        {
            for (int i = _clients.Count - 1; i >= 0; i--)
            {
                Client client = _clients[i];
                if (client.Mail == mail)
                {
                    _clients.RemoveAt(i);
                    return;
                }
            }
        }

        internal bool DoesMailExists(string mail)
        {
            return _uniqueAddressesMap.ContainsKey(mail);
        }

        internal Client GetClientByMail(string mail)
        {
            Client client;
            _uniqueAddressesMap.TryGetValue(mail, out client);
            return client;
        }

        internal string CreateClient(Client client)
        {
            return Error.NONE;
        }

        internal string ModifyClient(Client client)
        {
            return Error.NONE;
        }

        internal void UpdateClientMail(Client client, string oldMail)
        {
            _uniqueAddressesMap.Add(client.Mail, client);
            _uniqueAddressesMap.Remove(oldMail);
        }
    }
}
