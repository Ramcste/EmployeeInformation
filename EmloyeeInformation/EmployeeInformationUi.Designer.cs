namespace EmloyeeInformation
{
    partial class EmployeeInformationUi
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
            this.employeeInformatioShowButton = new System.Windows.Forms.Button();
            this.employeeRetrieveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.employeeIdTextBox = new System.Windows.Forms.TextBox();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeSalaryTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // employeeInformatioShowButton
            // 
            this.employeeInformatioShowButton.Location = new System.Drawing.Point(87, 209);
            this.employeeInformatioShowButton.Name = "employeeInformatioShowButton";
            this.employeeInformatioShowButton.Size = new System.Drawing.Size(75, 23);
            this.employeeInformatioShowButton.TabIndex = 0;
            this.employeeInformatioShowButton.Text = "Show";
            this.employeeInformatioShowButton.UseVisualStyleBackColor = true;
            this.employeeInformatioShowButton.Click += new System.EventHandler(this.employeeInformatioShowButton_Click);
            // 
            // employeeRetrieveButton
            // 
            this.employeeRetrieveButton.Location = new System.Drawing.Point(228, 209);
            this.employeeRetrieveButton.Name = "employeeRetrieveButton";
            this.employeeRetrieveButton.Size = new System.Drawing.Size(75, 23);
            this.employeeRetrieveButton.TabIndex = 1;
            this.employeeRetrieveButton.Text = "Retrieve";
            this.employeeRetrieveButton.UseVisualStyleBackColor = true;
            this.employeeRetrieveButton.Click += new System.EventHandler(this.employeeRetrieveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Salary";
            // 
            // employeeIdTextBox
            // 
            this.employeeIdTextBox.Location = new System.Drawing.Point(112, 45);
            this.employeeIdTextBox.Name = "employeeIdTextBox";
            this.employeeIdTextBox.Size = new System.Drawing.Size(112, 20);
            this.employeeIdTextBox.TabIndex = 5;
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(112, 89);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(191, 20);
            this.employeeNameTextBox.TabIndex = 6;
            // 
            // employeeSalaryTextBox
            // 
            this.employeeSalaryTextBox.Location = new System.Drawing.Point(112, 141);
            this.employeeSalaryTextBox.Name = "employeeSalaryTextBox";
            this.employeeSalaryTextBox.Size = new System.Drawing.Size(191, 20);
            this.employeeSalaryTextBox.TabIndex = 7;
            // 
            // EmployeeInformationUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 278);
            this.Controls.Add(this.employeeSalaryTextBox);
            this.Controls.Add(this.employeeNameTextBox);
            this.Controls.Add(this.employeeIdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeeRetrieveButton);
            this.Controls.Add(this.employeeInformatioShowButton);
            this.Name = "EmployeeInformationUi";
            this.Text = "Employee Information UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button employeeInformatioShowButton;
        private System.Windows.Forms.Button employeeRetrieveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox employeeIdTextBox;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.TextBox employeeSalaryTextBox;
    }
}

