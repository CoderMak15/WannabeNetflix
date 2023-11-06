using WannabeNetflix.src.roles;

namespace WannabeNetflix.src.movies
{
    public class Movie
    {
        public Movie(string name, float length, string synopsis, List<Actor>? actors = null, List<Category>? categories = null)
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

        public string Name => _name;
        public float Length => _length;
        public string Synopsis => _synopsis;
        public List<Actor> GetMovieActors() => _actors;

        public string GetMovieCategories()
        {
            string categories = "";
            for (int i = 0; i < _categories.Count; ++i)
            {
                Category c = _categories[i];
                (string cName, _) = c.GetCategoryInfo();
                categories += cName + (i == _categories.Count - 1 ? "" : ", ");
            }

            return categories;
        }

    }
}
