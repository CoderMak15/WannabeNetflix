using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WannabeNetflix.src.ui;

namespace WannabeNetflix
{
    public partial class Confirmation : Form
    {
        public Confirmation()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            UI.CloseForm(this);
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
