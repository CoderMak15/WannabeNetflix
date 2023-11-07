using WannabeNetflix.src.core;
using WannabeNetflix.src.ui;

namespace WannabeNetflix
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            UI.CloseForm(this);
        }

        private void log_btn_Click(object sender, EventArgs e)
        {
            string username = user_field.Text;
            string password = pw_field.Text;

            EmployeePayload wrapper = AppManager.Instance.EmployeeManager.TryGetEmployee(username, password);
            error_lbl.Text = wrapper._error;

            if (wrapper._employee != null)
            {
                AppManager.Instance.IsReadOnly = wrapper._employee.IsReadOnly;
                UI.TryOpenForm<Main>();
                Close();
            }
        }
    }
}