using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERAShop {
    public partial class WarehouseForm : Form {

        List<Order> order = new List<Order> { };
        Queue<int> conveyor = new Queue<int> { };


        public WarehouseForm () {
            InitializeComponent ();

            string[] departments = {
                "Whale",
                "Dolphine",
                "Eagle",
                "Turtle",
                "Unicorn"
            };

            string[] sections = {
                "1",
                "2",
                "3",
                "4",
                "5"
            };

            comboBox2.Items.AddRange (departments);
            comboBox3.Items.AddRange (sections);

            string[] input;
            int count = Directory.GetFiles (@Environment.CurrentDirectory + "/Warehouse").Length;

            int a = 0, b = 0, c = 0, d = 0, e = 0;
            foreach (string path in Directory.GetFiles (@Environment.CurrentDirectory + "/Warehouse", "*.txt")) {
                {
                    input = File.ReadAllLines (path);

                    order.Add (new Order {
                        OrderId = int.Parse (input[0]), ProductName = input[1], Producer = input[2], Department = input[6], Section = int.Parse (input[7]),
                        FullName = input[8], Cost = int.Parse (input[9]), DeliveryMethod = input[10]
                    });

                    switch (input[6]) {
                        case "Whale":

                            if (this.dataGridView1.Rows[a].Cells[int.Parse (input[7]) - 1].Value != null) {
                                this.dataGridView1.Rows.Add ();
                            }
                            this.dataGridView1.Rows[a].Cells[int.Parse (input[7]) - 1].Value = "Order #" + input[0] + ": " + input[1] + " by " + input[8];

                            break;
                        case "Dolphine":
                            if (this.dataGridView2.Rows[b].Cells[int.Parse (input[7]) - 1].Value != null) {
                                this.dataGridView2.Rows.Add ();
                            }
                            this.dataGridView2.Rows[b].Cells[int.Parse (input[7]) - 1].Value = "Order #" + input[0] + ": " + input[1] + " by " + input[8];
                            break;
                        case "Eagle":
                            if (this.dataGridView3.Rows[c].Cells[int.Parse (input[7]) - 1].Value != null) {
                                this.dataGridView3.Rows.Add ();
                            }
                            this.dataGridView3.Rows[c].Cells[int.Parse (input[7]) - 1].Value = "Order #" + input[0] + ": " + input[1] + " by " + input[8];
                            break;
                        case "Turtle":
                            if (this.dataGridView4.Rows[d].Cells[int.Parse (input[7]) - 1].Value != null) {
                                this.dataGridView4.Rows.Add ();
                            }
                            this.dataGridView4.Rows[d].Cells[int.Parse (input[7]) - 1].Value = "Order #" + input[0] + ": " + input[1] + " by " + input[8];
                            break;
                        default:
                            if (this.dataGridView5.Rows[e].Cells[int.Parse (input[7]) - 1].Value != null) {
                                this.dataGridView5.Rows.Add ();
                            }
                            this.dataGridView5.Rows[e].Cells[int.Parse (input[7]) - 1].Value = "Order #" + input[0] + ": " + input[1] + " by " + input[8];
                            break;
                    }
                }
            }
            string convPath = ConveyorFilePath ();
            StreamWriter stream = new StreamWriter (convPath);
            stream.Write ("");
            stream.Close ();// start conveyor with a cleared file
        }

        private static string ConveyorFilePath () {
            Repository repository = new Repository ();
            string conveyorPath = repository.BuildPath ("/Conveyor", "conveyor");
            if (!File.Exists (conveyorPath)) {
                File.Create (conveyorPath);
            }
            return conveyorPath;
        }

        private bool SearchByDepSec (Order order) {

            if (comboBox2.Text != "" && comboBox3.Text != "") {
                if (order.Department == comboBox2.Text && order.Section == int.Parse (comboBox3.Text)) {
                    return true;
                } else {
                    return false;
                }

            } else if (comboBox2.Text != "") {
                if (order.Department == comboBox2.Text) {
                    return true;
                } else {
                    return false;
                }

            } else if (comboBox3.Text != "") {
                if (order.Section == int.Parse (comboBox3.Text)) {
                    return true;
                } else {
                    return false;
                }
            } else {
                return false;
            }
        }

        private bool SearchByOrder (Order order) {
            if (textBox1.Text != "") {
                if (order.OrderId == int.Parse (textBox1.Text)) {
                    return true;
                } else {
                    return false;
                }
            } else {
                return false;
            }
        }

        private void SearchOrdersByDepartmentSection () {
            richTextBox1.Clear ();

            List<Order> results = order.FindAll (SearchByDepSec);

            if (results.Count != 0) {

                results.Sort ((x, y) => x.Section.CompareTo (y.Section));

                foreach (Order result in results) {
                    richTextBox1.Text += $"\nDep.:{result.Department};\tSect.:{result.Section};\tOrder Id:{result.OrderId}";
                }

            } else {
                richTextBox1.Text += ("No orders found.");
            }
        }

        private void GenerateReportForOrder () {
            richTextBox1.Clear ();

            StringBuilder sb = new StringBuilder ();
            string message;

            Order result = order.FindLast (SearchByOrder);

            if (result != null) {
                Employee employee = new Employee ();

                employee.deliveryMethod = (Deliveries)(Enum.Parse (typeof (Deliveries), result.DeliveryMethod));
                sb.Append( $"Hi! My name is {result.FullName}\n");
                sb.Append ($"{employee.DeliveryMethod}\n");

                sb.Append ($"Today's pick up location is {result.Department} department: section #{result.Section}\n");
                sb.Append ($"Current order is for {result.Producer} and costs {result.Cost:C} \n");
                message = sb.ToString ();

            } else {
                message = "No order found";
            }
            richTextBox1.Text = message;
        }

        private void PushOrderToConveyor () {
            richTextBox1.Clear ();

            if (CheckConveyorCapacity ()) {
                string path = ConveyorFilePath ();

                foreach (string item in File.ReadAllLines (path)) {
                    conveyor.Enqueue (int.Parse (item));// rebuild conveyor from user input
                }

                Order foundOrder = order.FindLast (SearchByOrder);// find order that user wants to push to conveyor
                try {
                    if (foundOrder != null) {
                        if (!conveyor.Contains (foundOrder.OrderId)) {//do not push already pushed orders
                            conveyor.Enqueue (foundOrder.OrderId);
                            richTextBox2.Text += foundOrder.OrderId.ToString () + Environment.NewLine;
                            richTextBox1.Text = "Order pushed to conveyor";

                            using (StreamWriter stream = new StreamWriter (path)) {// write new conveyor queue to file
                                while (conveyor.Count > 0) {
                                    int fifo = conveyor.Dequeue ();
                                    stream.WriteLine (fifo.ToString ());
                                }
                            }

                        } else {
                            richTextBox1.Text = "This order has been already pushed to conveyor";
                        }
                    } else {
                        richTextBox1.Text = "No order found";
                        throw new CustomException ();
                    }
                } catch (CustomException e) {
                    e.NullReference ();
                }
            }
        }

        private void PullOrderFromConveyor () {
            richTextBox1.Clear ();

            List<int> ordersOnConveyor = ListOrdersOnConveyor ();

            Order foundOrder = order.FindLast (SearchByOrder);// find order that user wants to push to conveyor
            try {
                if (foundOrder != null) {
                    if (ordersOnConveyor.Contains (foundOrder.OrderId)) {
                        ordersOnConveyor.Remove (foundOrder.OrderId);
                        richTextBox1.Text = "Order pulled from conveyor";

                        richTextBox2.Clear ();
                        string path = ConveyorFilePath ();
                        using (StreamWriter stream = new StreamWriter (path)) {// write new conveyor queue to file
                            foreach (int item in ordersOnConveyor) {
                                richTextBox2.Text += item.ToString () + Environment.NewLine;
                                stream.WriteLine (item.ToString ());
                            }
                        }
                    } else {
                        richTextBox1.Text = "This order has not been pushed to conveyor";
                    }
                } else {
                    richTextBox1.Text = "No order found";
                    throw new CustomException ();
                }
            } catch (CustomException e) {
                e.NullReference ();
            }

        }

        private static List<int> ListOrdersOnConveyor () {
            string convPath = ConveyorFilePath ();
            List<int> ordersOnConveyor = new List<int> { };

            foreach (string item in File.ReadAllLines (convPath)) {
                ordersOnConveyor.Add (int.Parse (item));// rebuild conveyor list from user input that was saved in file
            }

            return ordersOnConveyor;
        }

        private bool CheckConveyorCapacity () {
            List<int> ordersOnConveyor = ListOrdersOnConveyor ();

            int capacity = 5;

            try {
                if (ordersOnConveyor.Count < capacity) {
                    return true;
                } else {
                    throw new CustomException ();
                }
            } catch (CustomException e) {
                e.CapacityOutOfLimit ();
                return false;
            }
        }

        private void srchButton_Click (object sender, EventArgs e) {
            SearchOrdersByDepartmentSection ();
        }

        private void reportBbutton_Click (object sender, EventArgs e) {
            GenerateReportForOrder ();
        }
        private void pushButton_Click (object sender, EventArgs e) {
            PushOrderToConveyor ();
        }

        private void pullButton_Click (object sender, EventArgs e) {
            PullOrderFromConveyor ();
        }
    }

}
