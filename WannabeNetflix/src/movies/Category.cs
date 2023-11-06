namespace WannabeNetflix.src.movies
{
    public class Category
    {
        public Category(string name, string description)
        {
            _name = name;
            _description = description;
        }

        private string _name;
        private string _description;

        public (string, string) GetCategoryInfo() => (_name, _description);
    }
}
