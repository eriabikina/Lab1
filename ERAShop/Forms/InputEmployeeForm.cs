using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ERAShop {
    public partial class InputEmployeeForm : Form {
        public InputEmployeeForm () {
            InitializeComponent ();

            deliveryMethod.Items.AddRange (Enum.GetNames (typeof (Deliveries)));
        }

        public bool ValidateEmployeeFormInput () {

            var isValid = true;
            string message = "";

            if (!Regex.IsMatch (firstName.Text, @"^[a-zA-Z]+$") && Regex.IsMatch (lastName.Text, @"^[a-zA-Z]+$")) {
                message += "Employee name must consist of alphabet letters only\n";
                isValid = false;
            }
            if (!Enum.IsDefined (typeof (Deliveries), deliveryMethod.Text)) {
                message += "- Delivery method value does not belong to values from dropdown list\n";
                isValid = false;
            }
            if (0 > int.Parse (employeeId.Text)) {
                message += "- Id value must be an unsigned integer\n";
                isValid = false;
            }
            if (message != "") {
                message = "Please correct error(s) before proceeding:\n" + message;
                MessageBox.Show (message);
            }
            return isValid;
        }

        public void WriteEmployeeDataToFile (string filePath) {
            
            using (StreamWriter stream = new StreamWriter (filePath)) {
                stream.WriteLine (employeeId.Text);
                stream.WriteLine (firstName.Text);
                stream.WriteLine (lastName.Text);
                stream.WriteLine (deliveryMethod.Text);
            }
        }

        public void ReadEmloyeeDataFromFile (string filePath) {
            if (filePath != null || filePath != string.Empty) {
                if (File.Exists (filePath)) {
                    var lines = File.ReadAllLines (filePath);
                    employeeId.Text = lines[0];
                    firstName.Text = lines[1];
                    lastName.Text = lines[2];
                    deliveryMethod.Text = lines[3];
                }
            }
        }

        private void createButton_Click (object sender, EventArgs e) {
           
            try {

                int.Parse (employeeId.Text);

                Repository repository = new Repository ();
                string path = repository.BuildPath ("/Employees", employeeId.Text);

                if (ValidateEmployeeFormInput ()) {
                    if (path != null || path != string.Empty) {
                        if (!File.Exists (path)) {
                            WriteEmployeeDataToFile (path);
                            MessageBox.Show ("Entered data has been saved");

                        } else {
                            MessageBox.Show ("Record already exists" + Environment.NewLine + "Please click Update or change input data");
                        }
                    }
                }
            } catch (ArgumentNullException) {
                MessageBox.Show ("Check if all fields are filled in");
            } catch (FormatException) {
                MessageBox.Show ("Check if all fields are filled using correct format");
            }
        }

        private void readButton_Click (object sender, EventArgs e) {

            Repository repository = new Repository ();
            string path = repository.BuildPath ("/Employees", employeeId.Text);

            ReadEmloyeeDataFromFile (path);
        }

        private void updateButton_Click (object sender, EventArgs e) {
            try {

                int.Parse (employeeId.Text);

                Repository repository = new Repository ();
                string path = repository.BuildPath ("/Employees", employeeId.Text);

                if (ValidateEmployeeFormInput ()) {
                    if (path != null || path != string.Empty) {
                        if (File.Exists (path)) {
                            WriteEmployeeDataToFile (path);
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
            string path = repository.BuildPath ("/Employees", employeeId.Text);

            if (path != null || path != string.Empty) {
                if (File.Exists (path)) {
                    File.Delete (path);

                    employeeId.Clear ();
                    firstName.Clear ();
                    lastName.Clear ();
                    deliveryMethod.ResetText ();

                    MessageBox.Show ("Existing data has been deleted");
                }
            }
        }
    }


}

