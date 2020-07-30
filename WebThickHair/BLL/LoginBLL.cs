using System.Web;
using System.Web.Security;

namespace BLL
{
    public class LoginBLL
    {
        public int LoginDo(string username, string password)
        {
            if (!string.IsNullOrWhiteSpace(username) || !string.IsNullOrWhiteSpace(password))
            {
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(username, false, 10);
                string ticString = FormsAuthentication.Encrypt(ticket);
                HttpContext.Current.Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, HttpUtility.UrlEncode(ticString)));
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
