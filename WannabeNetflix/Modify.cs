using WannabeNetflix.src.core;
using WannabeNetflix.src.roles;
using WannabeNetflix.src.ui;
using WannabeNetflix.src.utils;

namespace WannabeNetflix
{
    public partial class Modify : Creation
    {
        private Client _client;

        public Modify()
        {
            InitializeComponent();
        }

        internal override void Init(Action onClose, Client client = null)
        {
            _onClose = onClose;
            _client = client;
            _mockClient = new Client(client);

            fName_txt.Text = _client.FirstName;
            lName_txt.Text = _client.LastName;
            gender_txt.Text = _client.Gender;
            mail_txt.Text = _client.Mail;

            fName_txt.Leave += (_, _) => { CheckForInputChange(fName_txt.Text, _mockClient.FirstName, _mockClient.SetFirstName, (int)CreationField.firstName); };
            lName_txt.Leave += (_, _) => { CheckForInputChange(lName_txt.Text, _mockClient.LastName, _mockClient.SetLastName, (int)CreationField.lastName); };
            gender_txt.Leave += (_, _) => { CheckForInputChange(gender_txt.Text, _mockClient.Gender, _mockClient.SetGender, (int)CreationField.gender); };

            mail_txt.Leave += CheckForEmailChange;
            pw_txt.Leave += CheckForPasswordChange;

            create_btn.Text = "Save";
            exit_btn.Text = "Cancel";

            _creationFlags = new bool[] { true, true, true, true, true };
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            UI.CloseForm(this);
            _onClose?.Invoke();
            _client = null;
            _mockClient = null;
        }

        protected override void CheckForInputChange(string input, string oldValue, Action<string> onValueChanged, int index)
        {
            if (input != oldValue && input != "")
            {
                onValueChanged?.Invoke(input);
                _creationFlags[index] = true;
            }
            else if(input == "")
            {
                _creationFlags[index] = false;
            }
        }

        protected override void create_btn_Click(object sender, EventArgs e)
        {
            string error = Error.NONE;
            if (!_creationFlags[(int)CreationField.mail] && !_creationFlags[(int)CreationField.password])
            {
                error = Error.SAVE_UNAVAILABLE;
            }
            else if (!_creationFlags[(int)CreationField.mail])
            {
                error = Error.NO_SAVE_MAIL;
            }
            else if (!_creationFlags[(int)CreationField.password])
            {
                error = Error.NO_SAVE_PW;
            }

            error_lbl.Text = error;
            if (error != Error.NONE)
            {
                return;
            }

            string oldMail = _client.Mail;
            string newMail = _mockClient.Mail;
            _client.OverrideClientInfo(_mockClient);
            if (oldMail != newMail)
            {
                AppManager.Instance.ClientManager.UpdateClientMail(_client, oldMail);
            }

            Close();
        }

        protected override void exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void CheckForEmailChange(object sender, EventArgs e)
        {
            if (mail_txt.Text == _client.Mail)
            {
                _creationFlags[(int)CreationField.mail] = true;
                return;
            }

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

        protected override void CheckForPasswordChange(object sender, EventArgs e)
        {
            if (pw_txt.Text == "")
                return;

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
