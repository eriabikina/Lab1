using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERAShop {
    public class Authorization {

        static Dictionary<string, List<User>> user = new Dictionary<string, List<User>> ();

        public Authorization () {
            user.Add ("Admin", new List<User> () { new User { Name = "Tomas" , Password = "admin111" } });
            user.Add ("Partner", new List<User> () { new User { Name = "Olga", Password = "qwerty" } });
            user.Add ("Partner", new List<User> () { new User { Name = "Ivan", Password = "123456" } });
            user.Add ("Partner", new List<User> () { new User { Name = "James", Password = "password" } });
            user.Add ("WarehouseAdmin", new List<User> () { new User { Name = "Oliver", Password = "oliver123" } });
            user.Add ("WarehouseAdmin", new List<User> () { new User { Name = "Kim", Password = "kimkimkim" } });
        }
    }
}
