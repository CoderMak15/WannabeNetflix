using Netflix.src;

namespace WannabeNetflix.src.roles
{
    public class Client : Person
    {
        public Client() : base() { }

        public Client(string fName, string lName, string gender, DateTime time, string mail, string password) : base(fName, lName, gender)
        {
            _time = time;
            _mail = mail;
            _password = password;
            _creditCards = new List<CreditCard>();
        }

        public Client(Client client) : base(client.FirstName, client.LastName, client.Gender)
        {
            _time = client.Date;
            _mail = client.Mail;
            _password = client.Password;
            _creditCards = new List<CreditCard>();
        }


        private DateTime _time;
        private string _mail;
        private string _password;
        private List<CreditCard> _creditCards;

        public DateTime Date => _time;
        public string Mail => _mail;
        public string Password => _password;

        public void SetDate(DateTime date) { _time = date; }
        public void SetMail(string mail) { _mail = mail; }
        public void SetPassword(string pw) { _password = pw; }

        public void AddCreditCards(CreditCard c) { _creditCards.Add(c); }
        public List<CreditCard> GetCreditCards() => _creditCards;

        public void OverrideClientInfo(Client client)
        {
            _firstName = client.FirstName;
            _lastName = client.LastName;
            _gender = client.Gender;
            _mail = client.Mail;
            _password = client.Password;
        }

    }
}
