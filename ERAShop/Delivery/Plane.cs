using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERAShop {
    public class Plane : DeliveryService, IGeneralDeliveryMethod {

        public static int capacity = 300;
        public static int maxDistance = 5000;

        public override string Description () {
            StringBuilder sb = new StringBuilder ();

            string how = base.Description ();
            sb.Append (how).Append ("by air");

            return sb.ToString ();

        }
    }
}
