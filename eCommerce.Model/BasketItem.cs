using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Model
{
    public class BasketItem
    {
        public int BasketItemId { get; set; }
        public int BasketId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
