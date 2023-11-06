namespace WannabeNetflix.src.roles
{
    public class Employee
    {
        public Employee(DateTime start, string userName, string password, bool readOnly)
        {
            _start = start;
            _userName = userName;
            _password = password;
            _readOnly = readOnly;
        }

        private DateTime _start;
        private string _userName;
        private string _password;
        private bool _readOnly;

        public DateTime JobDebut => _start;
        public string UserName => _userName;
        public string Password => _password;
        public bool IsReadOnly => _readOnly;
    }
}
