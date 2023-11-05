using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WannabeNetflix.src.core
{
    internal class Error
    {
        internal const string WRONG_USERNAME = "Username chosen is not associated to any account.";
        internal const string WRONG_PASSWORD = "Entered password is incorrect";
        internal const string USER_EXISTS = "User with that name already exists";
        internal const string INVALID_MAIL = "Provided mail address is invalid";
        internal const string PW_TOO_SHORT = "Provided password needs at least 8 characters";
        internal const string MAIL_EXISTS = "Provided mail address is already in use";
        internal const string SAVE_UNAVAILABLE = "Too many unresolved issues to save changes";
        internal const string NO_SAVE_MAIL = "Fix mail address before saving changes";
        internal const string NO_SAVE_PW = "Fix password before saving changes";
        internal const string NONE = "";
    }
}
