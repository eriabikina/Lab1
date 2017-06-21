using System;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace ERAShop {
    public partial class MenuForm : Form {
        public MenuForm () {
            InitializeComponent ();
           
            string message;
            SpeechSynthesizer synth = new SpeechSynthesizer ();
            message = "Welcome to Pay Money Sir delivery!";
            synth.Speak (message);

        }

        private void button1_Click (object sender, System.EventArgs e) {
            OrderEntryForm orderEtryForm = new OrderEntryForm ();
            orderEtryForm.ShowDialog();      
        }

        private void button2_Click (object sender, System.EventArgs e) {
            InputEmployeeForm inputEmployeeForm = new InputEmployeeForm ();
            inputEmployeeForm.ShowDialog ();
        }

        private void button3_Click (object sender, EventArgs e) {
            CollectOrder collectOrder = new CollectOrder ();
            collectOrder.ShowDialog ();
        }

        private void button4_Click (object sender, EventArgs e) {
            WarehouseForm warehouseForm = new WarehouseForm ();
            warehouseForm.ShowDialog ();
        }
    }
}

