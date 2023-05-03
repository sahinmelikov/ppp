using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task04._28._23.Services.BaseeNTITY;

namespace Task04._28._23.Models
{
    internal class Product : BaseEntity
    {
        public Product()
        {
        }

        public Product(string name)
        {
            Name = name;
        }
    }
}
