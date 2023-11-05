using WannabeNetflix.src.core;
using WannabeNetflix.src.roles;
using WannabeNetflix.src.ui;
using WannabeNetflix.src.utils;

namespace WannabeNetflix
{
    public partial class Modify : Form
    {
        private Client _client;
        private Client _mockClient;
        private bool _invalidMail = false;
        private bool _invalidPW = false;
        private Action _onClose;

        public Modify()
        {
            InitializeComponent();
        }

        internal void Init(Client client, Action onClose)
        {
            _onClose = onClose;
            _client = client;
            _mockClient = new Client(client);

            fName_txt.Text = _client.FirstName;
            lName_txt.Text = _client.LastName;
            gender_txt.Text = _client.Gender;
            mail_txt.Text = _client.Mail;

            fName_txt.Leave += (_, _) => { CheckForInputChange(fName_txt.Text, _mockClient.FirstName, _mockClient.SetFirstName); };
            lName_txt.Leave += (_, _) => { CheckForInputChange(lName_txt.Text, _mockClient.LastName, _mockClient.SetLastName); };
            gender_txt.Leave += (_, _) => { CheckForInputChange(gender_txt.Text, _mockClient.Gender, _mockClient.SetGender); };
            mail_txt.Leave += CheckForEmailChange;
            pw_txt.Leave += CheckForPasswordChange;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            UI.CloseForm(this);
            _onClose?.Invoke();
            _client = null;
            _mockClient = null;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            string error = Error.NONE;
            if (_invalidMail && _invalidPW)
            {
                error = Error.SAVE_UNAVAILABLE;
            }
            else if (_invalidMail)
            {
                error = Error.NO_SAVE_MAIL;
            }
            else if (_invalidPW)
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

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CheckForInputChange(string input, string oldValue, Action<string> onValueChanged)
        {
            if (input != oldValue)
                onValueChanged?.Invoke(input);
        }

        private void CheckForEmailChange(object sender, EventArgs e)
        {
            if (mail_txt.Text != _mockClient.Mail)
            {
                string error = ValidatorUtil.ValidateMail(mail_txt.Text);
                if (error != "")
                {
                    error_lbl.Text = error;
                    _invalidMail = true;
                }
                else
                {
                    _mockClient.SetMail(mail_txt.Text);
                    _invalidMail = false;
                }
            }
        }

        private void CheckForPasswordChange(object sender, EventArgs e)
        {
            if (pw_txt.Text == "")
            {
                error_lbl.Text = Error.NONE;
                _invalidPW = false;
                return;
            }

            string encryptedPw = Encryption.MD5Hash(pw_txt.Text);
            if (encryptedPw != _mockClient.Password)
            {
                string error = ValidatorUtil.ValidatePassword(pw_txt.Text);
                if (error != "")
                {
                    error_lbl.Text = error;
                    _invalidPW = true;
                }
                else
                {
                    _mockClient.SetPassword(Encryption.MD5Hash(encryptedPw));
                    _invalidPW = false;
                }
            }
        }
    }
}
