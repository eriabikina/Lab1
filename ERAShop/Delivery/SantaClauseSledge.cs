using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERAShop {
   public class SantaClausSledge : DeliveryService, IGeneralDeliveryMethod {

        public static int capacity = 9999999;
        public static int maxDistance = 999999999;

        public string how;
        public override string Description () {
            StringBuilder sb = new StringBuilder ();

            how = base.Description ();
            sb.Append (how).Append ("by magic");

            return sb.ToString ();

        }
    }
}
