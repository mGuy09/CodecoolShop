using Codecool.CodecoolShop.Models;
using System.Collections.Generic;

namespace Codecool.CodecoolShop.Daos
{
    public class ICheckoutDao: IDao<Checkout>
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public List<Client> ClientInfo { get; set; }
        public void Add(Checkout item)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        public Checkout Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Checkout> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
