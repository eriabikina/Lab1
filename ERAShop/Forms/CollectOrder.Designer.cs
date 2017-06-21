using System;

namespace ERAShop {
    partial class CollectOrder {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.orderId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.storageProductName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cost = new System.Windows.Forms.TextBox();
            this.collectButton = new System.Windows.Forms.Button();
            this.destination = new System.Windows.Forms.TextBox();
            this.typeOfDelivery = new System.Windows.Forms.TextBox();
            this.producer = new System.Windows.Forms.TextBox();
            this.fullName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.deliveryMethod = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.orderId.FormattingEnabled = true;
            this.orderId.Location = new System.Drawing.Point(15, 40);
            this.orderId.Name = "comboBox1";
            this.orderId.Size = new System.Drawing.Size(136, 21);
            this.orderId.TabIndex = 0;
            this.orderId.TextChanged += new System.EventHandler(this.orderId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order(s) to collect";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Type of delivery";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Producer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Product Name";
            // 
            // storageProductName
            // 
            this.storageProductName.Location = new System.Drawing.Point(16, 95);
            this.storageProductName.Name = "storageProductName";
            this.storageProductName.ReadOnly = true;
            this.storageProductName.Size = new System.Drawing.Size(201, 20);
            this.storageProductName.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.collectButton);
            this.groupBox1.Controls.Add(this.destination);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.typeOfDelivery);
            this.groupBox1.Controls.Add(this.orderId);
            this.groupBox1.Controls.Add(this.producer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.storageProductName);
            this.groupBox1.Location = new System.Drawing.Point(12, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 226);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cost);
            this.groupBox2.Location = new System.Drawing.Point(131, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 42);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cost";
            // 
            // textBox4
            // 
            this.cost.Location = new System.Drawing.Point(12, 14);
            this.cost.Name = "textBox4";
            this.cost.ReadOnly = true;
            this.cost.Size = new System.Drawing.Size(162, 20);
            this.cost.TabIndex = 19;
            // 
            // button1
            // 
            this.collectButton.Location = new System.Drawing.Point(204, 24);
            this.collectButton.Name = "button1";
            this.collectButton.Size = new System.Drawing.Size(90, 37);
            this.collectButton.TabIndex = 17;
            this.collectButton.Text = "Collect";
            this.collectButton.UseVisualStyleBackColor = true;
            this.collectButton.Click += new System.EventHandler(this.collectButton_Click);
            // 
            // textBox3
            // 
            this.destination.Location = new System.Drawing.Point(20, 185);
            this.destination.Name = "textBox3";
            this.destination.ReadOnly = true;
            this.destination.Size = new System.Drawing.Size(89, 20);
            this.destination.TabIndex = 18;
            // 
            // textBox2
            // 
            this.typeOfDelivery.Location = new System.Drawing.Point(131, 141);
            this.typeOfDelivery.Name = "textBox2";
            this.typeOfDelivery.ReadOnly = true;
            this.typeOfDelivery.Size = new System.Drawing.Size(85, 20);
            this.typeOfDelivery.TabIndex = 17;
            // 
            // producer
            // 
            this.producer.Location = new System.Drawing.Point(20, 140);
            this.producer.Name = "producer";
            this.producer.ReadOnly = true;
            this.producer.Size = new System.Drawing.Size(90, 20);
            this.producer.TabIndex = 16;
            // 
            // comboBox2
            // 
            this.fullName.FormattingEnabled = true;
            this.fullName.Location = new System.Drawing.Point(15, 85);
            this.fullName.Name = "comboBox2";
            this.fullName.Size = new System.Drawing.Size(204, 21);
            this.fullName.TabIndex = 17;
            this.fullName.TextChanged += new System.EventHandler(this.fullName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Employee";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Delivery method";
            // 
            // comboBox3
            // 
            this.deliveryMethod.FormattingEnabled = true;
            this.deliveryMethod.Location = new System.Drawing.Point(16, 37);
            this.deliveryMethod.Name = "comboBox3";
            this.deliveryMethod.Size = new System.Drawing.Size(202, 21);
            this.deliveryMethod.TabIndex = 21;
            this.deliveryMethod.TextChanged += new System.EventHandler(this.deliveryMethod_TextChanged);
            // 
            // CollectOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 376);
            this.Controls.Add(this.deliveryMethod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.groupBox1);
            this.Name = "CollectOrder";
            this.Text = "Collect Order";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox orderId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox storageProductName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox destination;
        private System.Windows.Forms.TextBox typeOfDelivery;
        private System.Windows.Forms.TextBox producer;
        private System.Windows.Forms.Button collectButton;
        private System.Windows.Forms.ComboBox fullName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox deliveryMethod;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox cost;
    }
}