namespace WannabeNetflix.src.roles
{
    public struct MovieInfo
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

    public class Actor : Person
    {
        public Actor(string fName, string lName, string gender, List<MovieInfo>? movies = null) : base(fName, lName, gender)
        {
            if (movies != null)
                _movies = movies;
            else
                _movies = new List<MovieInfo>();
        }

        private List<MovieInfo> _movies;

        public List<MovieInfo> GetActorMovies() => _movies;
    }
}
