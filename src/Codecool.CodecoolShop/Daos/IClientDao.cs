using Codecool.CodecoolShop.Models;
using System.Collections.Generic;

namespace Codecool.CodecoolShop.Daos;

public interface IClientDao
{
    IEnumerable<Client> Get(Client client);
    
}