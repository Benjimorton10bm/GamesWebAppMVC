using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniWork.Models
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }

        public int OrderID { get; set; }

        public int GameID { get; set; }

        public Game Games { get; set; }

        public Orders Orders { get; set; }

    }
}
