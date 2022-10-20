using Codecool.CodecoolShop.Daos;
using Codecool.CodecoolShop.Models;

namespace Codecool.CodecoolShop.Services;

public class ClientService
{
    private readonly IClientDao clientDao;
    

    public ClientService(IClientDao clientDao)
    {
        this.clientDao = clientDao;
        
    }
    public Client GetClientById(int id)
    {
        return clientDao.Get(id);
    }
}