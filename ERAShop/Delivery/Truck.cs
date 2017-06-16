using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERAShop {
   public class Truck : DeliveryService {

        public static int capacity = 100;
        public static int maxDistance = 500;

        public string how;
        public override string Description () {
            how = base.Description ();
            how += "by land";

            return how;

        }
    }
}
