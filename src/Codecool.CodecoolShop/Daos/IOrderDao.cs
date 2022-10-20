using Codecool.CodecoolShop.Models;
using System.Collections.Generic;

namespace Codecool.CodecoolShop.Daos;

public interface IOrderDao
{
    IEnumerable<Order> GetBy(Order order);
}