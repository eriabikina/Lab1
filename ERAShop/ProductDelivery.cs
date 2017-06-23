using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERAShop {

    public enum Types {
        Fragile,
        ShortTermStorage,
        NoTermStorage,
        FastDelivery
    };
    public enum ProductDealers {
        Ikea,
        Zara,
        Nestle,
        Nike
    };
    public enum Deliveries {
        Cargo,
        Plane,
        Truck,
        Drone,
        SantaClauseSledge
    };
    public enum Routes {
        Chisinau,
        Bucharest,
        Paris,
        Istanbul
    };

    public abstract class ProductDelivery {

        public int Id;
        public string ProductName;
        public Routes route;
        public Types type;
        public ProductDealers producer;
        public Deliveries delivery;

    }
}
