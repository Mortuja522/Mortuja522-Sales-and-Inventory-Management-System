namespace Sales_and_Inventory_Management_System.Presentation_Layer
{
    partial class HomeForUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForUser));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customerManagementButton = new System.Windows.Forms.Button();
            this.orderManagementButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.EmployeeNameLinkLabel = new System.Windows.Forms.LinkLabel();
            this.logOutButton1 = new System.Windows.Forms.Button();
            this.CategoryButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.CategoryButton);
            this.groupBox1.Controls.Add(this.customerManagementButton);
            this.groupBox1.Controls.Add(this.orderManagementButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(78, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(932, 451);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Panel";
            // 
            // customerManagementButton
            // 
            this.customerManagementButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerManagementButton.Location = new System.Drawing.Point(694, 196);
            this.customerManagementButton.Name = "customerManagementButton";
            this.customerManagementButton.Size = new System.Drawing.Size(199, 92);
            this.customerManagementButton.TabIndex = 12;
            this.customerManagementButton.Text = "Customer Management";
            this.customerManagementButton.UseVisualStyleBackColor = true;
            this.customerManagementButton.Click += new System.EventHandler(this.customerManagementButton_Click);
            // 
            // orderManagementButton
            // 
            this.orderManagementButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderManagementButton.Location = new System.Drawing.Point(466, 196);
            this.orderManagementButton.Name = "orderManagementButton";
            this.orderManagementButton.Size = new System.Drawing.Size(204, 92);
            this.orderManagementButton.TabIndex = 11;
            this.orderManagementButton.Text = "Order Management";
            this.orderManagementButton.UseVisualStyleBackColor = true;
            this.orderManagementButton.Click += new System.EventHandler(this.orderManagementButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(815, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Employee,";
            // 
            // EmployeeNameLinkLabel
            // 
            this.EmployeeNameLinkLabel.AutoSize = true;
            this.EmployeeNameLinkLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeNameLinkLabel.Location = new System.Drawing.Point(892, 36);
            this.EmployeeNameLinkLabel.Name = "EmployeeNameLinkLabel";
            this.EmployeeNameLinkLabel.Size = new System.Drawing.Size(51, 19);
            this.EmployeeNameLinkLabel.TabIndex = 5;
            this.EmployeeNameLinkLabel.TabStop = true;
            this.EmployeeNameLinkLabel.Text = "Name";
            this.EmployeeNameLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EmployeeNameLinkLabel_LinkClicked);
            // 
            // logOutButton1
            // 
            this.logOutButton1.FlatAppearance.BorderSize = 0;
            this.logOutButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton1.ForeColor = System.Drawing.Color.Red;
            this.logOutButton1.Image = ((System.Drawing.Image)(resources.GetObject("logOutButton1.Image")));
            this.logOutButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOutButton1.Location = new System.Drawing.Point(971, 24);
            this.logOutButton1.Name = "logOutButton1";
            this.logOutButton1.Size = new System.Drawing.Size(101, 31);
            this.logOutButton1.TabIndex = 6;
            this.logOutButton1.Text = "Log Out";
            this.logOutButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logOutButton1.UseVisualStyleBackColor = true;
            this.logOutButton1.Click += new System.EventHandler(this.logOutButton1_Click);
            // 
            // CategoryButton
            // 
            this.CategoryButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryButton.Location = new System.Drawing.Point(26, 196);
            this.CategoryButton.Name = "CategoryButton";
            this.CategoryButton.Size = new System.Drawing.Size(199, 92);
            this.CategoryButton.TabIndex = 13;
            this.CategoryButton.Text = "Category Management";
            this.CategoryButton.UseVisualStyleBackColor = true;
            this.CategoryButton.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(249, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 92);
            this.button2.TabIndex = 14;
            this.button2.Text = "Product Management";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(706, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // HomeForUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1084, 640);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logOutButton1);
            this.Controls.Add(this.EmployeeNameLinkLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "HomeForUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForUser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeForUser_FormClosing);
            this.Load += new System.EventHandler(this.HomeForUser_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel EmployeeNameLinkLabel;
        private System.Windows.Forms.Button customerManagementButton;
        private System.Windows.Forms.Button orderManagementButton;
        private System.Windows.Forms.Button logOutButton1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button CategoryButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}