using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERAShop {
    public interface IGeneralProductDealer {

        int Tax { get; set; }
        int Cost (int distance, int quantity, int costPerKg);

    }
}
