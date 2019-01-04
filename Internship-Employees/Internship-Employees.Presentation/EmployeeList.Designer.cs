namespace Internship_Employees.Presentation
{
    partial class EmployeeList
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
            this.EmployeeListTitle = new System.Windows.Forms.Label();
            this.EmployeeListlistBox = new System.Windows.Forms.ListBox();
            this.EmployeListBasckButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeeListTitle
            // 
            this.EmployeeListTitle.AutoSize = true;
            this.EmployeeListTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeListTitle.Location = new System.Drawing.Point(293, 59);
            this.EmployeeListTitle.Name = "EmployeeListTitle";
            this.EmployeeListTitle.Size = new System.Drawing.Size(312, 37);
            this.EmployeeListTitle.TabIndex = 0;
            this.EmployeeListTitle.Text = "Lista svih zaposlenih";
            // 
            // EmployeeListlistBox
            // 
            this.EmployeeListlistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeListlistBox.FormattingEnabled = true;
            this.EmployeeListlistBox.ItemHeight = 25;
            this.EmployeeListlistBox.Location = new System.Drawing.Point(106, 122);
            this.EmployeeListlistBox.Name = "EmployeeListlistBox";
            this.EmployeeListlistBox.Size = new System.Drawing.Size(741, 454);
            this.EmployeeListlistBox.TabIndex = 1;
            // 
            // EmployeListBasckButton
            // 
            this.EmployeListBasckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeListBasckButton.Location = new System.Drawing.Point(411, 630);
            this.EmployeListBasckButton.Name = "EmployeListBasckButton";
            this.EmployeListBasckButton.Size = new System.Drawing.Size(118, 44);
            this.EmployeListBasckButton.TabIndex = 2;
            this.EmployeListBasckButton.Text = "Nazad";
            this.EmployeListBasckButton.UseVisualStyleBackColor = true;
            this.EmployeListBasckButton.Click += new System.EventHandler(this.EmployeListBasckButton_Click);
            // 
            // EmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 707);
            this.Controls.Add(this.EmployeListBasckButton);
            this.Controls.Add(this.EmployeeListlistBox);
            this.Controls.Add(this.EmployeeListTitle);
            this.Name = "EmployeeList";
            this.Text = "EmployeeList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeeListTitle;
        private System.Windows.Forms.ListBox EmployeeListlistBox;
        private System.Windows.Forms.Button EmployeListBasckButton;
    }
}