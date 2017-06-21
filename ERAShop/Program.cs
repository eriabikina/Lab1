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

            var usersByName = new Dictionary<string, Administrator>();

            Application.Run (new MenuForm ());
        }
    }
}
