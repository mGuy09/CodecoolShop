using System;
using System.Collections.Generic;
using System.Drawing;

namespace Codecool.CodecoolShop.Models;

public class Client: BaseModel
{
    //public Guid Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public Dictionary<string, string> ClientsInfo;
    private Client()
    {
        ClientsInfo = new Dictionary<string, string>();
    }
    private static Client instance = null;
    public static Client Instance
    {
        get
        {
            instance ??= new Client();

            return instance;
        }
    }

}