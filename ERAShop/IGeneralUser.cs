using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERAShop {
    public interface IGeneralUser {

        void Login ();
        void LogOut ();
        void Register ();
        void ChangeData ();

    }
}
