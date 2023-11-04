using Netflix.src;

namespace WannabeNetflix.src
{
    internal class Movie
    {
        internal Movie(string name, float length, string synopsis, List<Actor>? actors = null, List<Category>? categories = null)
        {
            _name = name;
            _length = length;
            _synopsis = synopsis;
            _actors = actors == null ? new List<Actor>() : actors;
            _categories = categories == null ? new List<Category>() : categories;
        }

        private string _name;
        private float _length;
        private string _synopsis;
        private List<Actor> _actors;
        private List<Category> _categories;

        internal string Name => _name;
        internal float Length => _length;
        internal string Synopsis => _synopsis;
        internal List<Category> GetMovieCategories() => _categories;
        internal List<Actor> GetMovieActors() => _actors;
    }
}
