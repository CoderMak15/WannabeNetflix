namespace WannabeNetflix.src.roles
{
    public class Person
    {
        public Person() { }

        public Person(string fName, string lName, string gender)
        {
            _firstName = fName;
            _lastName = lName;
            _gender = gender;
        }

        protected string _firstName;
        protected string _lastName;
        protected string _gender;

        public string FirstName => _firstName;
        public string LastName => _lastName;
        public string Gender => _gender;

        public void SetFirstName(string fName) { _firstName = fName; }
        public void SetLastName(string lName) { _lastName = lName; }
        public void SetGender(string gender) { _gender = gender; }
    }
}
