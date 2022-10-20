namespace Codecool.CodecoolShop.Models;

public class OrderProduct: BaseModel
{
    public int Quantity { get; set; }
    public Product Product { get; set; }
}