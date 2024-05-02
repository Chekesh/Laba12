using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba12
{
    internal class Bookstore : Book, User
    {
        string login;
        string password;
        string avtor;
        string numberpages;
        string name;
        string publications;

        public Bookstore(string login, string password, string avtor, string numberpages, string name, string publications)
        {
            this.login = login;
            this.password = password;
            this.avtor = avtor;
            this.numberpages = numberpages;
            this.name = name;
            this.publications = publications;
        }

        public string Avtor()
        {
            return avtor;
        }

        public string Name()
        {
            return name;
        }

        public string NumberPages()
        {
            return numberpages;
        }

        public object Publications()
        {
            return publications;
        }
        public object Login()
        {
            return login;
        }

        public string Password()
        {
            return password;
        }

        public void Print()
        {
            Console.WriteLine($"{login} купил {name}");
        }
    }
}
