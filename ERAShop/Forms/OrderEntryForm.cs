using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ERAShop {
    public partial class OrderEntryForm : Form {

        public OrderEntryForm () {
            InitializeComponent ();

            storageProducer.Items.AddRange (Enum.GetNames (typeof (ProductDealers)));
            storageType.Items.AddRange (Enum.GetNames (typeof (Types)));
            storageRoute.Items.AddRange (Enum.GetNames (typeof (Routes)));
        }

        public bool ValidateOrderFormInput () {

            var isValid = true;
            string message = "";

            if (!Enum.IsDefined (typeof (ProductDealers), storageProducer.Text)) {
                message += "- Producer value does not belong to values from dropdown list\n";
                isValid = false;
            }
            if (!Enum.IsDefined (typeof (Types), storageType.Text)) {
                message += "- Type of delivery value does not belong to values from dropdown list\n";
                isValid = false;
            }
            if (!Enum.IsDefined (typeof (Routes), storageRoute.Text)) {
                message += "- Destination value does not belong to values from dropdown list\n";
                isValid = false;
            }
            if (0 > int.Parse (storageId.Text)) {
                message += "- Id value must be an unsigned integer\n";
                isValid = false;
            }
            if (0 > int.Parse (quantity.Text)) {
                message += "- Quantity value must be an unsigned integer\n";
                isValid = false;
            }
            if (message != "") {
                message = "Please correct error(s) before proceeding:\n" + message;
                MessageBox.Show (message);
            }
            return isValid;
        }

        public void WriteOrderDataToFile (string filePath) {

            using (StreamWriter stream = new StreamWriter (filePath)) {
                stream.WriteLine (storageId.Text);
                stream.WriteLine (storageProductName.Text);
                stream.WriteLine (storageProducer.Text);
                stream.WriteLine (storageType.Text);
                stream.WriteLine (storageRoute.Text);
                stream.WriteLine (quantity.Text);
            }
        }

        public void ReadOrderDataFromFile (string filePath) {
            if (filePath != null || filePath != string.Empty) {
                if (File.Exists (filePath)) {
                    var lines = File.ReadAllLines (filePath);
                    storageId.Text = lines[0];
                    storageProductName.Text = lines[1];
                    storageProducer.Text = lines[2];
                    storageType.Text = lines[3];
                    storageRoute.Text = lines[4];
                    quantity.Text = lines[5];
                }
            }
        }

        private void createButton_Click (object sender, EventArgs e) {
            try {

                int.Parse (storageId.Text);
                int.Parse (quantity.Text);

                Repository repository = new Repository ();
                string path = repository.BuildPath ("/Orders", storageId.Text);
                if (ValidateOrderFormInput ()) {
                    if (path != null || path != string.Empty) {
                        if (!File.Exists (path)) {
                            WriteOrderDataToFile (path);
                            MessageBox.Show ("Entered data has been saved");

                        } else {
                            MessageBox.Show ("Record with this Id already exists." + Environment.NewLine + "Please click Update or change Id number");
                        }
                    }
                }

            } catch (ArgumentNullException) {
                MessageBox.Show ("Check if all fields are filled in");
            } catch (FormatException) {
                MessageBox.Show ("Check if fields are filled using correct format");
            }
        }

        private void readButton_Click (object sender, EventArgs e) {

            Repository repository = new Repository ();
            string path = repository.BuildPath ("/Orders", storageId.Text);

            ReadOrderDataFromFile (path);

        }

        private void updateButton_Click (object sender, EventArgs e) {
            try {

                int.Parse (storageId.Text);
                int.Parse (quantity.Text);

                Repository repository = new Repository ();
                string path = repository.BuildPath ("/Orders", storageId.Text);
                if (ValidateOrderFormInput ()) {
                    if (path != null || path != string.Empty) {
                        if (File.Exists (path)) {
                            WriteOrderDataToFile (path);
                            MessageBox.Show ("Existing data has been updated");

                        } else {
                            createButton_Click (sender, e);
                        }
                    }
                }
            } catch (ArgumentNullException) {
                MessageBox.Show ("Check if all fields are filled in");
            } catch (FormatException) {
                MessageBox.Show ("Check if all fields are filled using correct format");
            }
        }

        private void deleteButton_Click (object sender, EventArgs e) {

            Repository repository = new Repository ();
            string path = repository.BuildPath ("/Orders", storageId.Text);

            if (path != null || path != string.Empty) {
                if (File.Exists (path)) {
                    File.Delete (path);

                    storageProductName.Clear ();
                    storageId.Clear ();
                    quantity.Clear ();

                    storageProducer.ResetText ();
                    storageType.ResetText ();
                    storageRoute.ResetText ();

                    MessageBox.Show ("Existing data has been deleted");
                }
            }
        }
    }
}
