using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba12
{
    internal interface Book: Publishing
    {
        object Publications();
        string NumberPages();
    }
}
