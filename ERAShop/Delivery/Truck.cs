using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERAShop {
   public class Truck : DeliveryService, IGeneralDeliveryMethod {

        public static int capacity = 100;
        public static int maxDistance = 500;

        public string how;
        public override string Description () {
            StringBuilder sb = new StringBuilder ();

            how = base.Description ();
            sb.Append (how).Append ("by land");

            return sb.ToString ();

        }
    }
}
