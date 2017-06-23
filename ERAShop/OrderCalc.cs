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

                switch (delivery) {
                    case Deliveries.Cargo:
                        cost = 100;
                        break;
                    case Deliveries.Plane:
                        cost = 500;
                        break;
                    case Deliveries.Truck:
                        cost = 200;
                        break;
                    case Deliveries.Drone:
                        cost = 50;
                        break;
                    default:
                        cost = 0;
                        break;
                }
                return cost;
            }
        }

        public int Cost {

            get {
                int cost;
                switch (producer) {
                    case ProductDealers.Ikea:
                        ProductIkea ikea = new ProductIkea ();
                        cost = ikea.Cost (Distance, Quantity, CostPerKg);
                        break;
                    case ProductDealers.Zara:
                        ProductZara zara = new ProductZara ();
                        cost = zara.Cost (Distance, Quantity, CostPerKg);
                        break;
                    case ProductDealers.Nestle:
                        ProductNestle nestle = new ProductNestle ();
                        cost = nestle.Cost (Distance, Quantity, CostPerKg);
                        break;
                    case ProductDealers.Nike:
                        ProductNike nike = new ProductNike ();
                        cost = nike.Cost (Distance, Quantity, CostPerKg);
                        break;
                    default:
                        cost = 0;
                        break;
                }
                return cost;
            }
        }

        public bool CapacityCheck () {

            bool result;
            switch (delivery) {
                case Deliveries.Cargo:
                    result = Quantity <= CargoShip.capacity;
                    break;
                case Deliveries.Plane:
                    result = Quantity <= Plane.capacity;
                    break;
                case Deliveries.Truck:
                    result = Quantity <= Truck.capacity;
                    break;
                case Deliveries.Drone:
                    result = Quantity <= Drone.capacity;
                    break;
                case Deliveries.SantaClauseSledge:
                    result = Quantity <= SantaClausSledge.capacity;
                    break;
                default:
                    result = false;
                    break;
            }
            return result;
        }

        public bool MaxDistance () {

            bool result;
            switch (delivery) {
                case Deliveries.Cargo:
                    result = Distance <= CargoShip.maxDistance;
                    break;
                case Deliveries.Plane:
                    result = Distance <= Plane.maxDistance;
                    break;
                case Deliveries.Truck:
                    result = Distance <= Truck.maxDistance;
                    break;
                case Deliveries.Drone:
                    result = Distance <= Drone.maxDistance;
                    break;
                case Deliveries.SantaClauseSledge:
                    result = Distance <= Truck.maxDistance;
                    break;
                default:
                    result = false;
                    break;
            }
            return result;
        }

        public bool ValidDestination (Routes destination) {

            bool result;
            switch (delivery) {
                case Deliveries.Cargo:
                    result = destination == Routes.Istanbul;
                    break;
                case Deliveries.Plane:
                    result = true;
                    break;
                case Deliveries.Truck:
                    result = destination != Routes.Istanbul;
                    break;
                case Deliveries.Drone:
                    result = destination == Routes.Chisinau;
                    break;
                case Deliveries.SantaClauseSledge:
                    result = true;
                    break;
                default:
                    result = false;
                    break;
            }
            return result;

        }
    }
}



