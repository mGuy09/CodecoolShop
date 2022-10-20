using System.Collections.Generic;
using System;

namespace Codecool.CodecoolShop.Models;

public class Order: BaseModel
{
    public Client Client { get; set; }
    public Cart Cart { get; set; }

    public Guid Id;

    public Order(Client client, Cart cart)
    {
        Client = client;
        Cart = cart;
    }
}