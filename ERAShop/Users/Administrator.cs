using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERAShop {
    public class Administrator : IGeneralUser {

       static Dictionary<string, List<User>> user = new Dictionary<string, List<User>> ();

        public void Login () {
            user.Add ("Admin", new List<User> () { new User { Activity = "Logged in" } });
        }
        public void LogOut () {
            user.Add ("Admin", new List<User> () { new User { Activity = "Logged out" } });
        }
        public void Register () {
            user.Add ("Admin", new List<User> () { new User { Activity = "Registered" } });
        }
        public void ChangeData () {
            user.Add ("Admin", new List<User> () { new User { Activity = "Createed  new Employee record" } });
        }
    }
}
