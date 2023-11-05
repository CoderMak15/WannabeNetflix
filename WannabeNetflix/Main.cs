using System.CodeDom;
using WannabeNetflix.src.core;
using WannabeNetflix.src.movies;
using WannabeNetflix.src.roles;
using WannabeNetflix.src.ui;

namespace WannabeNetflix
{
    public partial class Main : Form
    {
        private int _currentRow = -1;

        public Main()
        {
            bool isReadOnly = AppManager.Instance.IsReadOnly;
            InitializeComponent();
            PopulateClientGrid();
            PopulateMovieGrid();
            create_btn.Enabled = !isReadOnly;
            modify_btn.Enabled = !isReadOnly;
            delete_btn.Enabled = !isReadOnly;
        }

        private void PopulateClientGrid()
        {
            DataGridView dt = clientDataGrid;
            List<Client> clients = AppManager.Instance.ClientManager.GetClients();
            for (int i = 0; i < clients.Count; i++)
            {
                Client c = clients[i];
                object[] content = { c.FirstName, c.LastName, c.Mail };
                dt.Rows.Add(content);
            }
        }

        private void PopulateMovieGrid()
        {
            DataGridView dt = moviesDataGrid;
            List<Movie> movies = AppManager.Instance.MovieManager.GetMovies();
            for (int i = 0; i < movies.Count; i++)
            {
                Movie m = movies[i];
                object[] content = { m.Name, m.Length, m.GetMovieCategories() };
                dt.Rows.Add(content);
            }
        }

        private void dc_btn_Click(object sender, EventArgs e)
        {
            UI.TryOpenForm<Login>();
            UI.CloseForm(this);
        }

        private void clientDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _currentRow = e.RowIndex;
        }

        private void create_btn_Click(object sender, EventArgs e)
        {

        }

        private void modify_btn_Click(object sender, EventArgs e)
        {

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (_currentRow == -1)
                return;

            Delete popup = UI.TryOpenForm<Delete>();
            if (popup != null)
            {
                popup.SetCloseEvent(() =>
                {
                    clientDataGrid.Rows.RemoveAt(_currentRow);
                    AppManager.Instance.ClientManager.RemoveClientAt(_currentRow);
                    _currentRow = -1;
                });
            }
        }
    }
}
