using WannabeNetflix.src.core;
using WannabeNetflix.src.roles;
using WannabeNetflix.src.ui;
using WannabeNetflix.src.utils;

namespace WannabeNetflix
{
    internal enum CreationField
    {
        firstName = 0,
        lastName = 1,
        gender = 2,
        mail = 3,
        password = 4,
    }

    public partial class Creation : Form
    {
        internal Client _mockClient;
        protected bool[] _creationFlags = new bool[5];
        protected Action _onClose;

        public Creation()
        {
            InitializeComponent();
        }

        internal virtual void Init(Action onClose, Client client = null)
        {
            _onClose = onClose;
            _mockClient = new Client();

            fName_txt.Leave += (_, _) => { CheckForInputChange(fName_txt.Text, "", _mockClient.SetFirstName, (int)CreationField.firstName); };
            lName_txt.Leave += (_, _) => { CheckForInputChange(lName_txt.Text, "", _mockClient.SetLastName, (int)CreationField.lastName); };
            gender_txt.Leave += (_, _) => { CheckForInputChange(gender_txt.Text, "", _mockClient.SetGender, (int)CreationField.gender); };

            mail_txt.Leave += CheckForEmailChange;
            pw_txt.Leave += CheckForPasswordChange;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            UI.CloseForm(this);
            _mockClient = null;
            _onClose?.Invoke();
        }

        protected virtual void create_btn_Click(object sender, EventArgs e)
        {
            if(_creationFlags.Any(f => !f))
            {
                error_lbl.Text = Error.MISSING_PARAM;
                return;
            }

            AppManager.Instance.ClientManager.CreateClient(_mockClient);
            _mockClient = null;

            for (int i = 0; i < _creationFlags.Length; i++)
            {
                _creationFlags[i] = false;
            }

            fName_txt.Text = "";
            lName_txt.Text = "";
            gender_txt.Text = "";
            mail_txt.Text = "";
            pw_txt.Text = "";
            error_lbl.Text = "";

            UI.TryOpenForm<Confirmation>();
        }

        protected virtual void exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected virtual void CheckForInputChange(string input, string oldValue, Action<string> onValueChanged, int index)
        {
            if (input != oldValue)
            {
                onValueChanged?.Invoke(input);
                _creationFlags[index] = true;
            }
            else
            {
                _creationFlags[index] = false;
            }
        }

        protected virtual void CheckForEmailChange(object sender, EventArgs e)
        {
            if (mail_txt.Text != _mockClient.Mail)
            {
                string error = ValidatorUtil.ValidateMail(mail_txt.Text);
                if (error != "")
                {
                    error_lbl.Text = error;
                    _creationFlags[(int)CreationField.mail] = false;
                }
                else
                {
                    _mockClient.SetMail(mail_txt.Text);
                    _creationFlags[(int)CreationField.mail] = true;
                }
            }
        }

        protected virtual void CheckForPasswordChange(object sender, EventArgs e)
        {
            if (pw_txt.Text == "")
            {
                error_lbl.Text = Error.PW_TOO_SHORT;
                _creationFlags[(int)CreationField.password] = false;
                return;
            }

            string encryptedPw = Encryption.MD5Hash(pw_txt.Text);
            if (encryptedPw != _mockClient.Password)
            {
                string error = ValidatorUtil.ValidatePassword(pw_txt.Text);
                if (error != "")
                {
                    error_lbl.Text = error;
                    _creationFlags[(int)CreationField.password] = false;
                }
                else
                {
                    _mockClient.SetPassword(Encryption.MD5Hash(encryptedPw));
                    _creationFlags[(int)CreationField.password] = true;
                }
            }
        }
    }
}
