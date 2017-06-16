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

        public int Tax {
            get {
                int tax;

                if (producer == ProductDealers.Ikea) {
                    tax = 10;
                } else if (producer == ProductDealers.Zara) {
                    tax = 5;
                } else if (producer == ProductDealers.Nestle) {
                    tax = 2;
                } else if (producer == ProductDealers.Nike) {
                    tax = 20;
                } else {
                    tax = 0;
                }
                return tax;
            }
        }

        public int Cost {

            get {
                int cost;
                int tax = Tax;
                int distance = Distance;
                cost = Tax * Distance + Quantity * CostPerKg;

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

        public bool ValidDestination (string destination) {

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
    }
}



