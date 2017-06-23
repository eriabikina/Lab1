using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERAShop {
    public class CargoShip : DeliveryService,IGeneralDeliveryMethod {

        public static int capacity= 1000;
        public static int maxDistance = 3000;

        public override string Description () {
            StringBuilder sb = new StringBuilder ();

            string how = base.Description ();
            sb.Append (how).Append ("by sea");

            return sb.ToString ();
       }
    }
}
