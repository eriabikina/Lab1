using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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

                    order.Add (new Order { OrderId = int.Parse (input[0]), ProductName = input[1], Department = input[6], Section = int.Parse (input[7]) });

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

        private void srchButton_Click (object sender, EventArgs e) {

            List<Order> foundDepOrder = new List<Order> { };
            List<Order> foundSecOrder = new List<Order> { };

            for (int i = 0; i < order.Count; i++) {
               /* if (comboBox2.SelectedItem != null && comboBox3.SelectedItem != null) {
                    if (order[i].Department == comboBox2.Text && order[i].Section == int.Parse (comboBox3.Text)) {
                        foundDepOrder.Add (new Order { OrderId = order[i].OrderId, ProductName = order[i].ProductName, Department = order[i].Department, Section = order[i].Section });
                    }

                } else*/
                   if (comboBox2.SelectedItem != null) {
                    if (order[i].Department == comboBox2.Text) {
                        foundDepOrder.Add (new Order { OrderId = order[i].OrderId, ProductName = order[i].ProductName, Department = order[i].Department, Section = order[i].Section });
                    }

                if (comboBox3.SelectedItem != null) {
                    if (order[i].Section == int.Parse (comboBox3.Text)) {
                        foundSecOrder.Add (new Order { OrderId = order[i].OrderId, ProductName = order[i].ProductName, Department = order[i].Department, Section = order[i].Section });
                    }
                }
            }
        }
    

            for (int i = 0; i<foundDepOrder.Count; i++) {
                richTextBox1.Text += "Order #" + foundDepOrder[i].OrderId.ToString () + ": " + foundDepOrder[i].ProductName + Environment.NewLine;
            }


        }
    }

}
