using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product<string> product_1 = new Product<string>("Толстой", "1234", "Война и мир", "12.09/2020");
            Product<int> product_2 = new Product<int>("Роулииг", "345", "Гарри Потер", 23042006);

            Reader<string> reader_1 = new Reader<string>("Chekesh", "0987654321");
            Reader<int> reader_2 = new Reader<int>(894, "1234567890");

            Bookstore bookstore = new Bookstore("Chekesh", "0987654321", "Толстой", "1234", "Война и мир", "12.09/2020");
            bookstore.Print();
            Console.Read();
        }
    }
}
