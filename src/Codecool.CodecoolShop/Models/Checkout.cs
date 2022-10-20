﻿using System;
using System.Collections.Generic;

namespace Codecool.CodecoolShop.Models
{
    public class Checkout: BaseModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
       
        public List<Client> ClientInfo { get; set; }


    }
}
