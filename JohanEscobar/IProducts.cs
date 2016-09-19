using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JohanEscobar
{
    public interface IProducts
    {
        int id { get; set; }
        string ProductName { get; set; }
        int Price { get; set; }
        int Stock { get; set; }
    }
}
