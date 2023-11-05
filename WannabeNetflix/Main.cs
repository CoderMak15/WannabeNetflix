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

        public Main()
        {
            bool isReadOnly = AppManager.Instance.IsReadOnly;
            InitializeComponent();
            UpdateClientGrid();
            PopulateMovieGrid();
            create_btn.Enabled = !isReadOnly;
            modify_btn.Enabled = !isReadOnly;
            delete_btn.Enabled = !isReadOnly;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if(UI.GetForm<Login>() == null)
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

        private void dc_btn_Click(object sender, EventArgs e)
        {
            UI.TryOpenForm<Login>();
            Close();
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
            if (_currentRow == -1)
                return;

            string mail = (string)clientDataGrid.Rows[_currentRow].Cells[2].Value;
            Client client = AppManager.Instance.ClientManager.GetClientByMail(mail);
            
            if (client == null)
                return;

            Modify popup = UI.TryOpenForm<Modify>();
            popup?.Init(client, UpdateClientGrid);
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
