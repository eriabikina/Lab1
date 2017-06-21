using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERAShop {

    public class OrderCalc : ProductDelivery {

        public int Distance { get; set; }
        public int Quantity { get; set; }

        public int CostPerKg {
            get {
                int cost;

                if (delivery == Deliveries.Cargo) {
                    cost = 100;
                } else if (delivery == Deliveries.Plane) {
                    cost = 500;
                } else if (delivery == Deliveries.Truck) {
                    cost = 200;
                } else if (delivery == Deliveries.Drone) {
                    cost = 50;
                } else {
                    cost = 0;
                }
                return cost;
            }
        }

        public int Cost {

            get {
                int cost;
                if (producer == ProductDealers.Ikea) {
                    ProductIkea ikea = new ProductIkea ();
                    cost = ikea.Cost (Distance,Quantity,CostPerKg);
                } else if (producer == ProductDealers.Zara) {
                    ProductZara zara = new ProductZara ();
                    cost = zara.Cost (Distance, Quantity, CostPerKg);
                } else if (producer == ProductDealers.Nestle) {
                    ProductNestle nestle = new ProductNestle ();
                    cost = nestle.Cost (Distance, Quantity, CostPerKg);
                } else if (producer == ProductDealers.Nike) {
                    ProductNike nike = new ProductNike ();
                    cost = nike.Cost (Distance, Quantity, CostPerKg);
                } else {
                    cost = 0;
                }
                return cost;
            }
        }

        public bool CapacityCheck () {

            bool result;
            if (delivery == Deliveries.Cargo) {
                result = Quantity <= CargoShip.capacity;
            } else if (delivery == Deliveries.Plane) {
                result = Quantity <= Plane.capacity;
            } else if (delivery == Deliveries.Truck) {
                result = Quantity <= Truck.capacity;
            } else if (delivery == Deliveries.Drone) {
                result = Quantity <= Drone.capacity;
            } else if (delivery == Deliveries.SantaClauseSledge) {
                result = Quantity <= SantaClausSledge.capacity;
            } else {
                result = false;
            }
            return result;
        }

        public bool MaxDistance () {

            bool result;
            if (delivery == Deliveries.Cargo) {
                result = Distance <= CargoShip.maxDistance;
            } else if (delivery == Deliveries.Plane) {
                result = Distance <= Plane.maxDistance;
            } else if (delivery == Deliveries.Truck) {
                result = Distance <= Truck.maxDistance;
            } else if (delivery == Deliveries.Drone) {
                result = Distance <= Drone.maxDistance;
            } else if (delivery == Deliveries.SantaClauseSledge) {
                result = Distance <= Truck.maxDistance;
            } else {
                result = false;
            }
            return result;
        }

        public bool ValidDestination (Routes destination) {

            bool result;
            if (delivery == Deliveries.Cargo) {
                result = destination== Routes.Istanbul;
            } else if (delivery == Deliveries.Plane) {
                result = true;
            } else if (delivery == Deliveries.Truck) {
                result = destination != Routes.Istanbul;
            } else if (delivery == Deliveries.Drone) {
                result = destination == Routes.Chisinau;
            } else if (delivery == Deliveries.SantaClauseSledge) {
                result = true;
            } else {
                result = false;
            }
            return result;

        }
    }
}



