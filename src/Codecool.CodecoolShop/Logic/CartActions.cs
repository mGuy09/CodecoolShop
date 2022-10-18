using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Codecool.CodecoolShop.Daos;
using Codecool.CodecoolShop.Daos.Implementations;

namespace Codecool.CodecoolShop.Logic
{
    public class CartActions: IDisposable
    {
        public string CartId { get; set; }
        private ProductDaoMemory productDao;
        public const string CartSessionKey = "CartId";

        public void AddToCart(int id)
        {
            //get the item from the DB.
            CartId = GetCartId();
            var cartItem = productDao.GetBy(id);
        }


    }
}
