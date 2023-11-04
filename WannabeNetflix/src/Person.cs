namespace Netflix.src
{
    internal class Person
    {
        internal Person(string fName, string lName, string gender)
        {
            _firstName = fName;
            _lastName = lName;
            _gender = gender;
        }

        protected string _firstName;
        protected string _lastName;
        protected string _gender;

        internal string FirstName => _firstName;
        internal string LastName => _lastName;
        internal string Gender => _gender;

        internal void SetFirstName(string fName) { _firstName = fName; }
        internal void SetLastName(string lName) { _lastName = lName; }
        internal void SetGender(string gender) { _gender = gender; }
    }
}
