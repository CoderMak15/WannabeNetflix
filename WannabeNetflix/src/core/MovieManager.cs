using WannabeNetflix.src.movies;

namespace WannabeNetflix.src.core
{
    internal class MovieManager
    {
        internal List<Movie> GetMovies() => _movies;
        private List<Movie> _movies;

        internal MovieManager()
        {
            _movies = PopulateMovies();
        }

        private List<Movie> PopulateMovies()
        {
            Category thriller = new ("Thriller", "Suspense");
            Category action = new ("Action", "Fast Pace");
            Category adventure = new ("Adventure", "Story Telling");

            Movie m1 = new ("Jaws", 124, "Duh duh, duh duh", categories: new List<Category>() { thriller, adventure });
            Movie m2 = new ("Raiders of the Lost Ark", 115, "Indiana Jones", categories: new List<Category>() { action, adventure });
            return new List<Movie>() { m1, m2 };
        }
    }
}
