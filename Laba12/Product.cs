using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Laba12
{
    internal class Product<T> : Book
    {
        string avtor;
        string numberpages;
        string name;
        private T publications;

        public Product(string avtor, string numberpages, string name, T publications)
        {
            this.name = name;
            this.publications = publications;
            this.avtor = avtor;
            this.numberpages = numberpages;
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
    }
}
