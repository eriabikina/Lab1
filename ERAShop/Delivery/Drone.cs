using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERAShop {
   public class Drone : DeliveryService {

        public static int capacity = 10;
        public static int maxDistance = 50;

        public string how;
        public override string Description () {
            how = base.Description ();
            how += "by air";

            return how;

        }
    }
}
