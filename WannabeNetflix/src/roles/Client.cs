using Netflix.src;

namespace WannabeNetflix.src.roles
{
    internal class Client : Person
    {
        internal Client(string fName, string lName, string gender, DateTime time, string mail, string password) : base(fName, lName, gender)
        {
            _time = time;
            _mail = mail;
            _password = password;
            _creditCards = new List<CreditCard>();
        }

        internal Client(Client client) : base(client.FirstName, client.LastName, client.Gender)
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

        internal DateTime Date => _time;
        internal string Mail => _mail;
        internal string Password => _password;

        internal void SetDate(DateTime date) { _time = date; }
        internal void SetMail(string mail) { _mail = mail; }
        internal void SetPassword(string pw) { _password = pw; }

        internal void AddCreditCards(CreditCard c) { _creditCards.Add(c); }
        internal List<CreditCard> GetCreditCards() => _creditCards;

        internal void OverrideClientInfo(Client client)
        {
            _firstName = client.FirstName;
            _lastName = client.LastName;
            _gender = client.Gender;
            _mail = client.Mail;
            _password = client.Password;
        }

    }
}
