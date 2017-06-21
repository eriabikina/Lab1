using System;

namespace ERAShop {
    partial class OrderEntryForm {
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
            this.storageProductName = new System.Windows.Forms.TextBox();
            this.storageProducer = new System.Windows.Forms.ComboBox();
            this.storageType = new System.Windows.Forms.ComboBox();
            this.storageRoute = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.storageId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // storageProductName
            // 
            this.storageProductName.Location = new System.Drawing.Point(48, 91);
            this.storageProductName.Name = "storageProductName";
            this.storageProductName.Size = new System.Drawing.Size(201, 20);
            this.storageProductName.TabIndex = 0;
            // 
            // storageProducer
            // 
            this.storageProducer.FormattingEnabled = true;
            this.storageProducer.Location = new System.Drawing.Point(47, 136);
            this.storageProducer.Name = "storageProducer";
            this.storageProducer.Size = new System.Drawing.Size(91, 21);
            this.storageProducer.TabIndex = 1;
            // 
            // storageType
            // 
            this.storageType.FormattingEnabled = true;
            this.storageType.Location = new System.Drawing.Point(158, 136);
            this.storageType.Name = "storageType";
            this.storageType.Size = new System.Drawing.Size(91, 21);
            this.storageType.TabIndex = 2;
            // 
            // storageRoute
            // 
            this.storageRoute.FormattingEnabled = true;
            this.storageRoute.Location = new System.Drawing.Point(48, 180);
            this.storageRoute.Name = "storageRoute";
            this.storageRoute.Size = new System.Drawing.Size(89, 21);
            this.storageRoute.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Producer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type of delivery";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Destination";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(337, 41);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(97, 26);
            this.createButton.TabIndex = 8;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new EventHandler (this.createButton_Click);
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(335, 88);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(98, 23);
            this.readButton.TabIndex = 9;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new EventHandler (this.readButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(336, 127);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(96, 24);
            this.updateButton.TabIndex = 10;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new EventHandler (this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(339, 169);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(92, 30);
            this.deleteButton.TabIndex = 11;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new EventHandler (this.deleteButton_Click);
            // 
            // storageId
            // 
            this.storageId.Location = new System.Drawing.Point(47, 41);
            this.storageId.Name = "storageId";
            this.storageId.Size = new System.Drawing.Size(130, 20);
            this.storageId.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Order Id";
            // 
            // textBox5
            // 
            this.quantity.Location = new System.Drawing.Point(158, 180);
            this.quantity.Name = "textBox5";
            this.quantity.Size = new System.Drawing.Size(91, 20);
            this.quantity.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Quantity";
            // 
            // OrderEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 251);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.storageId);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.storageRoute);
            this.Controls.Add(this.storageType);
            this.Controls.Add(this.storageProducer);
            this.Controls.Add(this.storageProductName);
            this.Name = "OrderEntryForm";
            this.Text = "Oder Entry Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox storageProductName;
        private System.Windows.Forms.ComboBox storageProducer;
        private System.Windows.Forms.ComboBox storageType;
        private System.Windows.Forms.ComboBox storageRoute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox storageId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label label6;
    }
}