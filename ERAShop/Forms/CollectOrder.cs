using System;
using System.IO;
using System.Windows.Forms;

namespace ERAShop {
    public partial class CollectOrder : Form {


        public CollectOrder () {
            InitializeComponent ();
            deliveryMethod.Items.AddRange (Enum.GetNames (typeof (Deliveries)));
        }

        public void FindEmployeeByDeliveryMethod (string filePath) {
            if (filePath != null || filePath != string.Empty) {
                if (File.Exists (filePath)) {
                    string[] input = File.ReadAllLines (filePath);

                    Employee employee = new Employee ();
                    employee.FirstName = input[1];
                    employee.LastName = input[2];
                    if (input[3] == deliveryMethod.Text) {
                        fullName.Items.Add (employee.FullName);
                    }
                }
            }
        }

        public void FindOrdersToDeliver (string filePath) {
            if (filePath != null || filePath != string.Empty) {
                if (File.Exists (filePath)) {
                    string[] input = File.ReadAllLines (filePath);

                    OrderCalc calc = new OrderCalc ();
                    calc.Distance = Route.Distance ((Routes)Enum.Parse (typeof (Routes), input[4]));
                    calc.Quantity = int.Parse (input[5]);
                    calc.producer = (ProductDealers)Enum.Parse (typeof (ProductDealers), input[2]);
                    calc.delivery = (Deliveries)Enum.Parse (typeof (Deliveries), deliveryMethod.Text);
                    if (calc.CapacityCheck ()) {
                        if (calc.MaxDistance ()) {
                            if (calc.ValidDestination ((Routes)Enum.Parse (typeof (Routes), input[4]))) {
                                orderId.Items.Add (input[0]);
                            }
                        }
                    }
                }
            }
        }


        public void ShowOrderStaticData (string filePath) {
            if (filePath != null || filePath != string.Empty) {
                if (File.Exists (filePath)) {
                    string[] input = File.ReadAllLines (filePath);

                    OrderCalc calc = new OrderCalc ();
                    storageProductName.Text = input[1];
                    producer.Text = input[2];
                    typeOfDelivery.Text = input[3];
                    destination.Text = input[4];

                    calc.Distance = Route.Distance ((Routes)Enum.Parse (typeof (Routes), input[4]));
                    calc.Quantity = int.Parse (input[5]);
                    cost.Text = calc.Cost.ToString ();
                }
            }
        }

        public void CollectOrderSaveToFile (string filePathFrom, string filePathTo) {
            if (filePathFrom != null || filePathFrom != string.Empty) {
                if (File.Exists (filePathFrom)) {
                    if (!File.Exists (filePathTo)) {

                        StoreWarehouse storage = new StoreWarehouse ();

                        storage.ProductName = storageProductName.Text;
                        storage.type = (Types)Enum.Parse (typeof (Types), typeOfDelivery.Text);
                        storage.delivery = (Deliveries)Enum.Parse (typeof (Deliveries), deliveryMethod.Text);

                        using (StreamWriter stream = File.AppendText (filePathFrom)) {
                            stream.WriteLine (storage.Department);
                            stream.WriteLine (storage.Section);
                            stream.WriteLine (fullName.Text);
                            stream.WriteLine (cost.Text);
                            stream.WriteLine (deliveryMethod.Text);
                        }

                        File.Move (filePathFrom, filePathTo);

                        string message = "Order has been collected and placed into the warehouse\n";
                        message += $"Pick up location is {storage.Department} department: section #{storage.Section}";
                        MessageBox.Show (message);
                    } else {
                        MessageBox.Show ("Order with the same Id has been collected already");
                    }
                } else {
                    MessageBox.Show ("Order does not exist");
                }
            }
        }

        private void deliveryMethod_TextChanged (object sender, EventArgs e) {
            fullName.Items.Clear ();
            fullName.ResetText ();

            foreach (string path in Directory.GetFiles (@Environment.CurrentDirectory + "/Employees", "*.txt")) {
                FindEmployeeByDeliveryMethod (path);
            }
        }

        private void fullName_TextChanged (object sender, EventArgs e) {
            orderId.Items.Clear ();
            orderId.ResetText ();

            OrderCalc calc = new OrderCalc ();

            foreach (string path in Directory.GetFiles (@Environment.CurrentDirectory + "/Orders", "*.txt")) {
                FindOrdersToDeliver (path);
            }
        }

        private void orderId_TextChanged (object sender, EventArgs e) {
            storageProductName.Clear ();
            producer.Clear ();
            typeOfDelivery.Clear ();
            destination.Clear ();
            cost.Clear ();

            string path = Environment.CurrentDirectory + "/Orders" + "/" + $"{orderId.Text}.txt";

            ShowOrderStaticData (path);
        }

        private void collectButton_Click (object sender, EventArgs e) {

            string pathFrom = Environment.CurrentDirectory + "/Orders" + "/" + $"{orderId.Text}.txt";

            Repository repository = new Repository ();
            string pathTo = repository.BuildPath ("Warehouse", orderId.Text);

            CollectOrderSaveToFile (pathFrom, pathTo);

        }
    }
}

