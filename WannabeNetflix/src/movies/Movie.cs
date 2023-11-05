using WannabeNetflix.src.roles;

namespace WannabeNetflix.src.movies
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
        internal List<Actor> GetMovieActors() => _actors;
        
        internal string GetMovieCategories()
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
