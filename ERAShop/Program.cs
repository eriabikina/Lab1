using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERAShop {
    class Program {
        static void Main (string[] args) {
            /*
           string message;

           SpeechSynthesizer synth = new SpeechSynthesizer ();

           Employee employee = new Employee ();
           employee.FirstName = "Ben";
           employee.LastName = "Brown";
           employee.deliveryMethod = Deliveries.Plane;
           message = $"Hi! My name is {employee.FullName}\n";
           message += $"{employee.DeliveryMethod}\n";

           StoreWarehouse storage = new StoreWarehouse ();
           
           storage.Id = 1;
           storage.ProductName = "Ashton3900 sneakers";
           storage.producer = ProductDealers.Nike;
           storage.type = Types.NoTermStorage;
           storage.route = Routes.Paris;
           storage.delivery = employee.deliveryMethod;

           OrderCalc calc = new OrderCalc ();
           calc.Distance = Route.Distance (storage.route);
           calc.Quantity = 10;
           calc.producer = storage.producer;
           calc.delivery = employee.deliveryMethod;
           if (calc.CapacityCheck () && calc.MaxDistance ()) {
               message += $"Today's pick up location is {storage.Department} department: section #{storage.Section}\n";
               message += $"Current order is for {calc.producer} and costs {calc.Cost:C} (including {calc.Tax} VAT)\n";

           } else {
               message += $"Sorry, not enough source to complete delivery\n";
           }

           Console.WriteLine (message);
           synth.Speak (message);
           */

            Application.Run (new MenuForm ());
        }
    }
}
