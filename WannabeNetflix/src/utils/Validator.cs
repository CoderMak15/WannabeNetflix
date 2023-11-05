using System.Text.RegularExpressions;
using WannabeNetflix.src.core;
using WannabeNetflix.src.roles;

namespace WannabeNetflix.src.utils
{
    internal class ValidatorUtil
    {
        internal static string ValidateMail(string mail)
        {
            if (AppManager.Instance.ClientManager.DoesMailExists(mail))
                return Error.MAIL_EXISTS;

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(mail);
            return match.Success ? Error.NONE : Error.INVALID_MAIL;
        }

        internal static string ValidatePassword(string password)
        {
            return password.Length >= 8 ? Error.NONE : Error.PW_TOO_SHORT;
        }
    }
}
