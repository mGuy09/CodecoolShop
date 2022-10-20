using System;
using System.Collections.Generic;
using Codecool.CodecoolShop.Models;

namespace Codecool.CodecoolShop.Daos.Implementations;

public class ClientDaoMemory: IClientDao
{
    private List<Client> data = new();
    private static ClientDaoMemory instance = null;
    public Client Get(int id)
    {
        throw new System.NotImplementedException();
    }

    public IEnumerable<Client> Get(Client client)
    {
        throw new System.NotImplementedException();
    }
    public static ClientDaoMemory GetInstance()
    {
        if (instance == null)
        {
            instance = new ClientDaoMemory();
        }

        return instance;
    }

    public void Add(Client client)
    {
        client.Id = Guid.NewGuid();
        data.Add(client);
    }
}