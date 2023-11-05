using WannabeNetflix.src.ui;

namespace WannabeNetflix
{
    public partial class Delete : Form
    {
        internal void SetCloseEvent(Action a) { _onCloseEvent = a; }
        private Action _onCloseEvent;

        public Delete()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            UI.CloseForm(this);
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            _onCloseEvent?.Invoke();
            Close();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
