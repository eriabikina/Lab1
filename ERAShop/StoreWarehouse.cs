using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERAShop {
    class StoreWarehouse : ProductDelivery {
        public int Section {
            get {
                int section;

                if (char.Parse (ProductName.Substring (0, 1)) <= 'E') {
                    section = 1;
                } else if (char.Parse (ProductName.Substring (0, 1)) <= 'K') {
                    section = 2;
                } else if (char.Parse (ProductName.Substring (0, 1)) <= 'P') {
                    section = 3;
                } else if (char.Parse (ProductName.Substring (0, 1)) <= 'U') {
                    section = 4;
                } else {
                    section = 5;
                }
                return section;

            }
        }

        public string Department {
            get {
                string department;

                if (type == Types.NoTermStorage && delivery == Deliveries.Cargo) {
                    department = "Whale";
                } else if (type == Types.FastDelivery && delivery == Deliveries.Cargo) {
                    department = "Dolphine";
                } else if (type == Types.FastDelivery && delivery == Deliveries.Plane) {
                    department = "Eagle";
                } else if (type == Types.Fragile && delivery == Deliveries.Truck) {
                    department = "Turtle";
                } else {
                    department = "Unicorn";
                }
                return department;

            }
        }

    }
}
