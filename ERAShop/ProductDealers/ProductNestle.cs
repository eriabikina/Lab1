using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERAShop {
    public class ProductNestle : Object, IGeneralProductDealer {
        public int Tax { get; set; }

        public ProductNestle () {
            Tax = 2;
                    }

        public int Cost (int distance, int quantity, int costPerKg) {
            return Tax * distance + quantity * costPerKg ;
        }
    }
}
