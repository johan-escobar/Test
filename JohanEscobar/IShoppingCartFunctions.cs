namespace JohanEscobar
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public interface IShoppingCartFunctions
    {

        Dictionary<int, int> AddItem(Dictionary<int, int> FruitList, int product);

        void RemoveItem(Dictionary<int, int> basket, int id);

        decimal CalculateTotal(Dictionary<int, int> basket);


    }
}
