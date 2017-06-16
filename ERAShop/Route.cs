using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERAShop {
    public static class Route {

        public static string departure = "Odessa";
        
        public static int Distance ( string destination) {
            int distance = 0;
            switch (destination) {

                case ("Paris"):
                    distance = 2669;
                    break;
                case ("Chisinau"):
                    distance = 173;
                    break;
                case ("Bucharest"):
                    distance = 608;
                    break;
                case ("Istanbul"):
                    distance = 829;
                    break;
                default:
                    break;
            }
            return distance;
        }

    }
}
