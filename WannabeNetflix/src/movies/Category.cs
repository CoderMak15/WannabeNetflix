namespace WannabeNetflix.src.movies
{
    internal class Category
    {
        internal Category(string name, string description)
        {
            _name = name;
            _description = description;
        }

        private string _name;
        private string _description;

        internal (string, string) GetCategoryInfo() => (_name, _description);
    }
}
