﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Entities
{
    public class Buyer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public int SellerId { get; set; }
        public  Seller  Seller{ get; set; }
 
      


    }
}
