using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codecool.CodecoolShop.Models
{
    [Serializable]
    public class CartItem: BaseModel
    {
        
        public int Quantity { get; set; }
        
        public virtual Product Product { get; set; }

        public CartItem(Product pro)
        {
            
        }
    }
}
