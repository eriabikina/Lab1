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

            var users = new Dictionary<string, List<User>> ();
            users.Add ("Vlad", new List<User> () { new User { Name = "Vlad", Password = "boss111" } });
            users.Add ("Olga", new List<User> () { new User { Name = "Olga", Password = "qwerty" } });
            users.Add ("Ivan", new List<User> () { new User { Name = "Ivan", Password = "123456" } });

            string tryagain = "Y";

            do {
                bool correct = false;

                Console.WriteLine ("Enter your name and password to run the application");
                Console.WriteLine ("Name:");
                string name = Console.ReadLine ();
                Console.WriteLine ("Password:");
                string pass = Console.ReadLine ();

                foreach (var item in users) {
                    if (item.Key == name) {
                        foreach (var user in item.Value) {
                            if (user.Password == pass) {
                                correct = true;
                            }
                        }
                    }
                }

                if (correct) {

                    var validUser = new Dictionary<string, List<User>> ();
                    validUser.Add (name, new List<User> () { new User { Activity = DateTime.Now.ToString () + "  Logged in" } });

                    Console.WriteLine ("Correct credentials\n");

                    validUser[name].Add (new User () { Activity = DateTime.Now.ToString () + "  Opened Pay Money Sir Delivery application" });

                    Application.Run (new MenuForm ());

                    validUser[name].Add (new User () { Activity = DateTime.Now.ToString () + "  Closed Pay Money Sir Delivery application" });

                    validUser[name].Add (new User () { Activity = DateTime.Now.ToString () + "  Logged out" });

                    Console.WriteLine ("***User log recorded:\n");

                    foreach (var item in validUser) {
                        foreach (var inItem in item.Value) {
                            Console.WriteLine ("{0}", inItem.Activity);
                        }
                    }
                    Console.ReadLine ();
                    tryagain = "N";
                } else {
                    Console.WriteLine ("Wrong credentials");
                    Console.WriteLine ("Would you like to try again: Y/N?");
                    tryagain = Console.ReadLine ();
                }
            } while (string.Compare (tryagain, "Y", true) == 0);

        }
    }
}