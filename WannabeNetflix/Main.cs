using Microsoft.VisualBasic.Devices;
using System.CodeDom;
using WannabeNetflix.src.core;
using WannabeNetflix.src.movies;
using WannabeNetflix.src.roles;
using WannabeNetflix.src.ui;

namespace WannabeNetflix
{
    public partial class Main : Form
    {
        private int _currentRow = 0;
        private int _currentMovieRow = -1;

        public Main()
        {
            bool isReadOnly = AppManager.Instance.IsReadOnly;
            InitializeComponent();
            UpdateClientGrid();
            PopulateMovieGrid();
            create_btn.Enabled = !isReadOnly;
            modify_btn.Enabled = !isReadOnly;
            delete_btn.Enabled = !isReadOnly;
            moviesDataGrid.MouseHover += movieDataGrid_mouseHover;
            moviesDataGrid.CellMouseEnter += movieDataGrid_CellMouseEnter;
            moviesDataGrid.CellMouseLeave += movieDataGrid_CellMouseLeave;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (UI.GetForm<Login>() == null)
            {
                UI.TryOpenForm<Login>();
            }
            UI.CloseForm(this);
        }

        private void UpdateClientGrid()
        {
            DataGridView dt = clientDataGrid;
            for (int i = dt.Rows.Count - 1; i >= 0; i--)
            {
                dt.Rows.RemoveAt(i);
            }

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

        private void movieDataGrid_mouseHover(object sender, EventArgs e)
        {
            if (_currentMovieRow == -1)
                return;

            foreach (Movie movie in AppManager.Instance.MovieManager.GetMovies())
            {
                if (movie.Name == (string)moviesDataGrid.Rows[_currentMovieRow].Cells[0].Value)
                {
                    tooltip.Show(movie?.Synopsis, moviesDataGrid);
                }
            }

        }

        //when mouse is over cell
        private void movieDataGrid_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                _currentMovieRow = e.RowIndex;
            }
        }
        //when mouse is leaving cell
        private void movieDataGrid_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == _currentMovieRow)
                return;

            _currentMovieRow = -1;
            tooltip.Hide(moviesDataGrid);
        }

        private void clientDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _currentRow = e.RowIndex;
        }

        private void dc_btn_Click(object sender, EventArgs e)
        {
            UI.TryOpenForm<Login>();
            Close();
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            Creation popup = UI.TryOpenForm<Creation>();
            popup?.Init(UpdateClientGrid);
        }

        private void modify_btn_Click(object sender, EventArgs e)
        {
            if (_currentRow == -1)
                return;

            string mail = (string)clientDataGrid.Rows[_currentRow].Cells[2].Value;
            Client client = AppManager.Instance.ClientManager.GetClientByMail(mail);
            
            if (client == null)
                return;

            Modify popup = UI.TryOpenForm<Modify>();
            popup?.Init(UpdateClientGrid, client);
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
                    string mail  = (string)clientDataGrid.Rows[_currentRow].Cells[2].Value;
                    AppManager.Instance.ClientManager.RemoveClient(mail);
                    clientDataGrid.Rows.RemoveAt(_currentRow);
                    _currentRow = -1;
                });
            }
        }
    }
}
