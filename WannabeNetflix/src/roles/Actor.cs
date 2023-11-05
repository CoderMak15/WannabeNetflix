namespace WannabeNetflix.src.roles
{
    internal struct MovieInfo
    {
        public MovieInfo(string character, DateTime start, DateTime end, float salary) : this()
        {
            _character = character;
            _start = start;
            _end = end;
            _salary = salary;
        }

        public string _character;
        public DateTime _start;
        public DateTime _end;
        public float _salary;
    }

    internal class Actor : Person
    {
        internal Actor(string fName, string lName, string gender, List<MovieInfo>? movies = null) : base(fName, lName, gender)
        {
            if (movies != null)
                _movies = movies;
            else
                _movies = new List<MovieInfo>();
        }

        private List<MovieInfo> _movies;

        internal List<MovieInfo> GetActorMovies() => _movies;
    }
}
