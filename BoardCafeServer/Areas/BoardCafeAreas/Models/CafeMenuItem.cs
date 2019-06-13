using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoardCafeServer.Objects
{
    public class CafeMenuItem
    {
        public CafeMenuItem()
        {
        }

        public int itemId { get; set; }
        public string itemName { get; set; }
        public string itemDesc { get; set; }
        public double itemPrice { get; set; }

        public Boolean peanut { get; set; }
        public Boolean shellfish { get; set; }
        public Boolean gluten { get; set; }

        public byte[] itemBlob { get; set; }
    }
}
