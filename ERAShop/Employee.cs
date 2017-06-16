using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERAShop {
    public class Employee {

        private string lastName;

        public string LastName {
            get {
                return lastName;
            }
            set {
                lastName = value;
            }
        }

        public string FirstName { get; set; }

        public Deliveries deliveryMethod;
        public string greetings;

        public string DeliveryMethod {

            get {

                switch (deliveryMethod) {
                    case Deliveries.Cargo:
                        CargoShip cargo = new CargoShip ();
                        greetings = "I am a Captain" + System.Environment.NewLine + "My job is " + cargo.Description ();
                        break;
                    case Deliveries.Plane:
                        Plane plane = new Plane ();
                        greetings = "I am a Pilot" + System.Environment.NewLine + "My job is " + plane.Description ();
                        break;
                    case Deliveries.Truck:
                        Truck truck = new Truck ();
                        greetings = "I am a Driver" + System.Environment.NewLine + "My job is " + truck.Description ();
                        break;
                    case Deliveries.Drone:
                        Drone drone = new Drone ();
                        greetings = "I am a Drone operator" + System.Environment.NewLine + "My job is " + drone.Description ();
                        break;
                    default:
                        SantaClausSledge santaClause = new SantaClausSledge ();
                        greetings = "I am Santa" + System.Environment.NewLine + "My job is " + santaClause.Description ();
                        break;
                }
                return greetings;
            }
            set {
                greetings = value;
            }

        }

        public string FullName {
            get {
                string fullName = FirstName;
                if (!string.IsNullOrWhiteSpace (LastName)) {
                    if (!string.IsNullOrWhiteSpace (fullName)) {
                        fullName += " ";
                    }
                    fullName += LastName;
                }
                return fullName;
            }
        }

        public bool Save () {
            return true;
        }

        public bool Validate () {
            var isValid = true;
            if (string.IsNullOrWhiteSpace (FirstName))
                isValid = false;
            if (string.IsNullOrWhiteSpace (DeliveryMethod))
                isValid = false;

            return isValid;
        }
    }
}




