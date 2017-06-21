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

        public int Id;

        public Deliveries deliveryMethod;
        public string greetings;

        public string DeliveryMethod {

            get {

                switch (deliveryMethod) {
                    case Deliveries.Cargo:
                        CargoShip cargo = new CargoShip ();
                        greetings = "I am a Captain" + Environment.NewLine + "My job is " + cargo.Description ();
                        break;
                    case Deliveries.Plane:
                        Plane plane = new Plane ();
                        greetings = "I am a Pilot" + Environment.NewLine + "My job is " + plane.Description ();
                        break;
                    case Deliveries.Truck:
                        Truck truck = new Truck ();
                        greetings = "I am a Driver" + Environment.NewLine + "My job is " + truck.Description ();
                        break;
                    case Deliveries.Drone:
                        Drone drone = new Drone ();
                        greetings = "I am a Drone operator" + Environment.NewLine + "My job is " + drone.Description ();
                        break;
                    default:
                        SantaClausSledge santaClause = new SantaClausSledge ();
                        greetings = "I am Santa" + Environment.NewLine + "My job is " + santaClause.Description ();
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
}
}




