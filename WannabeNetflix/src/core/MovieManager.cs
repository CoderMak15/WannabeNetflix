using WannabeNetflix.src.movies;

namespace WannabeNetflix.src.core
{
    public class MovieManager
    {
        public List<Movie> GetMovies() => _movies;
        private List<Movie> _movies;

        public MovieManager()
        {
            _movies = PopulateMovies();
        }

        public List<Movie> PopulateMovies()
        {
            Category thriller = new("Thriller", "Suspense");
            Category action = new("Action", "Fast Pace");
            Category adventure = new("Adventure", "Story Telling");
            Category fantastic = new("Fantastic", "Wizards");
            Category sf = new("SF", "Space Aliens");

            Movie m1 = new("Jaws", 124, "When a killer shark unleashes chaos on a beach community off Cape Cod, it's up to a local sheriff, a marine biologist, and an old seafarer to hunt the beast down.", categories: new List<Category>() { thriller, adventure });
            Movie m2 = new("Raiders of the Lost Ark", 115, "The year is 1936 and the intrepid archaeologist Indiana Jones sets out in search of the fabled Lost Ark of the Covenant, racing a bitter rival and his Nazi cohorts to the prize.", categories: new List<Category>() { action, adventure });
            Movie m3 = new("Lord of the Rings", 178, "A hobbit named Frodo inherits the One Ring, which can destroy the entire world. Frodo joins with eight others to destroy the Ring and defeat Sauron.", categories: new List<Category> { fantastic, adventure });
            Movie m4 = new("Star Wars Episode IV: A New Hope", 121, "The fate of the galaxy is forever changed when Luke Skywalker discovers his powerful connection to a mysterious Force.", categories: new List<Category> { fantastic, sf });
            return new List<Movie>() { m1, m2, m3, m4 };
        }
    }
}
