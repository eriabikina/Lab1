using System;

namespace ERAShop {
    partial class InputEmployeeForm {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.deliveryMethod = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.employeeId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lastName);
            this.groupBox1.Controls.Add(this.firstName);
            this.groupBox1.Controls.Add(this.deliveryMethod);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 131);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(163, 39);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(132, 20);
            this.lastName.TabIndex = 1;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(11, 39);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(132, 20);
            this.firstName.TabIndex = 0;
            // 
            // deliveryMethod
            // 
            this.deliveryMethod.FormattingEnabled = true;
            this.deliveryMethod.Location = new System.Drawing.Point(11, 94);
            this.deliveryMethod.Name = "deliveryMethod";
            this.deliveryMethod.Size = new System.Drawing.Size(284, 21);
            this.deliveryMethod.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Delivery method";
            
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(355, 32);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(108, 25);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new EventHandler (this.createButton_Click);
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(353, 79);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(109, 28);
            this.readButton.TabIndex = 4;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new EventHandler (this.readButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(354, 123);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(107, 27);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new EventHandler (this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(355, 169);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(105, 25);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new EventHandler (this.deleteButton_Click);
            // 
            // employeeId
            // 
            this.employeeId.Location = new System.Drawing.Point(20, 33);
            this.employeeId.Name = "employeeId";
            this.employeeId.Size = new System.Drawing.Size(75, 20);
            this.employeeId.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Personal Id";
            // 
            // InputEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 242);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.employeeId);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "InputEmployeeForm";
            this.Text = "Employee";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ComboBox deliveryMethod;
        private System.Windows.Forms.TextBox employeeId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}