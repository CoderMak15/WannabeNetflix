using WannabeNetflix.src.roles;
using WannabeNetflix.src.utils;

namespace WannabeNetflix.src.core
{
    internal class ClientManager
    {      
        internal List<Client> GetClients() => _clients;
        private List<Client> _clients = new List<Client>();

        public ClientManager()
        {
            _clients = PopulateClients();
        }

        private List<Client> PopulateClients()
        {
            Client c1 = new("Seb", "Gagn", "gender", DateTime.Now, "seb.gagn@gmail.com", Encryption.MD5Hash("12345678"));
            Client c2 = new("Mak", "Dem", "gender", DateTime.Now, "mak.dem@gmail.com", Encryption.MD5Hash("password"));
            return new List<Client> { c1, c2 };
        }

        internal void RemoveClient(Client c)
        {
            for (int i = _clients.Count - 1; i >= 0; i--)
            {
                if (_clients[i] == c)
                {
                    _clients.RemoveAt(i);
                    return;
                }
            }
        }

        internal void RemoveClientAt(int index)
        {
            _clients.RemoveAt(index);
        }
    }
}
