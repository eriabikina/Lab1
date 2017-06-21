using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERAShop {
    public class ProductIkea : Object, IGeneralProductDealer {
        public int Tax { get; set; }

        public ProductIkea () {
            Tax = 10;
        }

        public int Cost (int distance, int quantity, int costPerKg) {
            return Tax * distance + quantity * costPerKg;
        }
    }
}

