namespace WannabeNetflix.src.roles
{
    internal class Employee
    {
        internal Employee(DateTime start, string userName, string password, bool readOnly)
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

        internal DateTime JobDebut => _start;
        internal string UserName => _userName;
        internal string Password => _password;
        internal bool IsReadOnly => _readOnly;
    }
}
