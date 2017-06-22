using System;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace ERAShop {
    [Serializable]
    internal class CustomException : Exception {

        public void CapacityOutOfLimit () {
            MessageBox.Show ("Conveyor capacity reached.Try to pull orders from conveyor to free space");
        }
        public void NullReference () {
            MessageBox.Show ("No value entered");
        }
    }
}