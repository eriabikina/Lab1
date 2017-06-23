using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERAShop {
    public class Employee {
        StringBuilder sb = new StringBuilder ();

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
                        sb.Append ("My job is ").Append (cargo.Description ());
                        greetings = "I am a Captain"+Environment.NewLine + sb.ToString();
                        break;
                    case Deliveries.Plane:
                        Plane plane = new Plane ();
                        sb.Append ("My job is ").Append (plane.Description ());
                        greetings = "I am a Pilot" + Environment.NewLine + sb.ToString ();
                        break;
                    case Deliveries.Truck:
                        Truck truck = new Truck ();
                        sb.Append ("My job is ").Append (truck.Description ());
                        greetings = "I am a Driver" + Environment.NewLine + sb.ToString ();
                        break;
                    case Deliveries.Drone:
                        Drone drone = new Drone ();
                        sb.Append ("My job is ").Append (drone.Description ());
                        greetings = "I am a Drone operator" + Environment.NewLine + sb.ToString ();
                        break;
                    default:
                        SantaClausSledge santaClause = new SantaClausSledge ();
                        sb.Append ("My job is ").Append (santaClause.Description ());
                        greetings = "I am Santa" + Environment.NewLine + sb.ToString ();
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




