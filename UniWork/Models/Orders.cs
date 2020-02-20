using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniWork.Models
{
    public class Orders
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int OrderID { get; set; }

        public string UserID { get; set; }

        public List<OrderItem> OrderItems { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal OrderTotal { get; set; }

    }
}
