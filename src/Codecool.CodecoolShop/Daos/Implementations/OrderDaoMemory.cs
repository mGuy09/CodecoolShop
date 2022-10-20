using Codecool.CodecoolShop.Models;
using System.Collections.Generic;

namespace Codecool.CodecoolShop.Daos.Implementations
{
    public class OrderDaoMemory : IOrderDao 
    {
        private static OrderDaoMemory instance = null;

        private OrderDaoMemory()
        {
        }

        public static OrderDaoMemory GetInstance()
        {
            instance ??= new OrderDaoMemory();
            return instance;
        }

        public IEnumerable<Order> GetBy(Order order)
        {
            throw new System.NotImplementedException();
        }
    }
}
