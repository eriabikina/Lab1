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
            users.Add ("Admin", new List<User> () { new User { Name = "Vlad", Password = "boss111" } });

            users.Add ("Partner", new List<User> () { new User { Name = "Olga", Password = "qwerty" } });
            users["Partner"].Add(  new User { Name = "Ivan", Password = "123456"  });
            users["Partner"].Add ( new User { Name = "James", Password = "password" } );
            
            users.Add ("WarehouseAdmin", new List<User> () { new User { Name = "Kim", Password = "kimkimkim" } });
            users["WarehouseAdmin"].Add (new User () {  Name = "Oliver", Password = "oliver123"  });

            string tryagain = "Y";

            do {
                bool correct = false;

                Console.WriteLine ("Enter your name and password to run the application");
                Console.WriteLine ("Name:");
                string name = Console.ReadLine ();
                Console.WriteLine ("Password:");
                string pass = Console.ReadLine ();

                foreach (var item in users) {
                    foreach (var user in item.Value) {
                        if (user.Name == name && user.Password == pass) {
                            correct = true;
                        }
                    }
                }

                if (correct) {
                    Console.WriteLine ("Correct credentials");
                    Application.Run (new MenuForm ());
                    tryagain = "N";
                } else {
                    Console.WriteLine ("Wrong credentials");
                    Console.WriteLine ("Would you like to try again: Y/N?");
                    tryagain = Console.ReadLine ();
                }
            } while (string.Compare( tryagain, "Y",true)==0);

        }
    }
}