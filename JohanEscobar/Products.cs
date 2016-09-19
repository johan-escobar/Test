namespace JohanEscobar
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Products : IProducts
    {
        public int id { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Stock { get; set;}

        public  Products (int id)
        {
            this.id = id;
            switch (this.id)
            {
                case 1:
                    this.ProductName = "apples";
                    this.Price = 60;
                    this.Stock = 12;
                    return;
                case 2:
                    this.ProductName = "oranges";
                    this.Price = 25;
                    this.Stock = 12;
                    return;
            }
        }


        public Products(string name)
        {
            this.ProductName = name;
            switch (this.ProductName)
            {
                case "apples":
                    this.id = 1;
                    this.Price = 60;
                    this.Stock = 12;
                    return;
                case "oranges":
                    this.id = 2;
                    this.Price = 25;
                    this.Stock = 12;
                    return;
            }

        }
    }
}
