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


        private void delete_btn_Click(object sender, EventArgs e)
        {
            _onCloseEvent?.Invoke();
            UI.CloseForm(this);
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            UI.CloseForm(this);
        }
    }
}
