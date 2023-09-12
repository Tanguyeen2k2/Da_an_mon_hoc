using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTHUVIEN
{
    public class LoginAccount
    {
        private string _username;
        private int _password;
        public string _maTT;
        public LoginAccount()
        {
            _username = "";
            _password = 0;
        }
        public LoginAccount(string username, int password, string maTT)
        {
            _username = username;
            _password = password;
            _maTT = maTT;

        }
        public string Username { get { return _username; } set { _username = value; } }
        public int Password { get { return _password; } set { _password = value; } }
        public bool CheckLoginState()
        {
            if (!String.IsNullOrEmpty(_username))
            {
                return true;
            }
            return false;
        }
    }
}
