using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WannabeNetflix.src.core
{
    public class Error
    {
        public const string WRONG_USERNAME = "Username chosen is not associated to any account.";
        public const string WRONG_PASSWORD = "Entered password is incorrect";
        public const string INVALID_MAIL = "Provided mail address is invalid";
        public const string PW_TOO_SHORT = "Provided password needs at least 8 characters";
        public const string MAIL_EXISTS = "Provided mail address is already in use";
        public const string SAVE_UNAVAILABLE = "Too many unresolved issues to save changes";
        public const string NO_SAVE_MAIL = "Fix mail address before saving changes";
        public const string NO_SAVE_PW = "Fix password before saving changes";
        public const string MISSING_PARAM = "You must fill all fields in order to create a new Client";
        public const string NONE = "";
    }
}
