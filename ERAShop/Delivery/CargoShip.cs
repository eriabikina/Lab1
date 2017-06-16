using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERAShop {
    public class CargoShip : DeliveryService {

        public static int capacity= 1000;
        public static int maxDistance = 3000;

        public override string Description () {
            string how = base.Description ();
            how += "by sea";

            return how;
        }
    }
}
