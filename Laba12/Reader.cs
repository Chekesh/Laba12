using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba12
{
    internal class Reader<T> : User
    {
        T login;
        string password;

        public Reader(T login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public object Login()
        {
            return login;
        }

        public string Password()
        {
            return password;
        }
    }
}
