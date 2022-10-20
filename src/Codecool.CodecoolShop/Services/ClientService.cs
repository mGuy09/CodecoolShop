using Codecool.CodecoolShop.Daos;
using Codecool.CodecoolShop.Models;
using System;

namespace Codecool.CodecoolShop.Services;

public class ClientService
{
    private readonly IClientDao clientDao;
    

    public ClientService(IClientDao clientDao)
    {
        this.clientDao = clientDao;
        
    }
    public Client GetClientById(Guid id)
    {
        throw new NotImplementedException();
    }
}