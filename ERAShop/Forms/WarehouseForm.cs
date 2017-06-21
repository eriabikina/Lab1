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

            int count = Directory.GetFiles (@Environment.CurrentDirectory + "/Warehouse").Length;

            int a = 0, b = 0, c = 0, d = 0, e = 0;
            foreach (string path in Directory.GetFiles (@Environment.CurrentDirectory + "/Warehouse", "*.txt")) {
                {
                    string[] input = File.ReadAllLines (path);

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
        }

        private bool Search (Order order) {

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

        private bool Report (Order order) {

            if (order.OrderId == int.Parse (textBox1.Text)) {
                return true;
            } else {
                return false;
            }
        }

        private void srchButton_Click (object sender, EventArgs e) {

            richTextBox1.Clear ();

            List<Order> results = order.FindAll (Search);

            if (results.Count != 0) {

                results.Sort ((x, y) => x.Section.CompareTo (y.Section));

                foreach (Order result in results) {
                    richTextBox1.Text += $"\nDep.:{result.Department};\t Sect.:{result.Section};\t Order Id:{result.OrderId}";
                }

            } else {
                richTextBox1.Text += ("\nNo orders found.");
            }
        }

        private void button1_Click (object sender, EventArgs e) {
            richTextBox1.Clear ();

            string message;
            SpeechSynthesizer synth = new SpeechSynthesizer ();

            Order result = order.FindLast (Report);

            if (result != null) {
                Employee employee = new Employee ();

                employee.deliveryMethod = (Deliveries)(Enum.Parse (typeof (Deliveries), result.DeliveryMethod));
                message = $"Hi! My name is {result.FullName}\n";
                message += $"{employee.DeliveryMethod}\n";

                message += $"Today's pick up location is {result.Department} department: section #{result.Section}\n";
                message += $"Current order is for {result.Producer} and costs {result.Cost:C} \n";

            } else {
                message = "No order found";
            }
            richTextBox1.Text = message;
            synth.Speak (message);
        }
    }

}
