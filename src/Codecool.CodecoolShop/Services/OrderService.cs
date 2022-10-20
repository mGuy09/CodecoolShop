using Codecool.CodecoolShop.Daos;

namespace Codecool.CodecoolShop.Services;

public class OrderService
{
    private readonly IOrderDao iOrderDao;

	public OrderService(IOrderDao orderDao)
	{
		iOrderDao = orderDao;
	}
}