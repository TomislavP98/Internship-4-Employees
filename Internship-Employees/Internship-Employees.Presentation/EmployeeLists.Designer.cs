namespace Internship_Employees.Presentation
{
    partial class EmployeeLists
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
            this.EmployeeListsTitle = new System.Windows.Forms.Label();
            this.EmployeeeListsBackButton = new System.Windows.Forms.Button();
            this.EmployeeListsChangeButton = new System.Windows.Forms.Button();
            this.EmployeeListslistView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // EmployeeListsTitle
            // 
            this.EmployeeListsTitle.AutoSize = true;
            this.EmployeeListsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeListsTitle.Location = new System.Drawing.Point(220, 45);
            this.EmployeeListsTitle.Name = "EmployeeListsTitle";
            this.EmployeeListsTitle.Size = new System.Drawing.Size(358, 37);
            this.EmployeeListsTitle.TabIndex = 0;
            this.EmployeeListsTitle.Text = "Nešto d.o.o. zaposlenici";
            // 
            // EmployeeeListsBackButton
            // 
            this.EmployeeeListsBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeeListsBackButton.Location = new System.Drawing.Point(172, 455);
            this.EmployeeeListsBackButton.Name = "EmployeeeListsBackButton";
            this.EmployeeeListsBackButton.Size = new System.Drawing.Size(161, 47);
            this.EmployeeeListsBackButton.TabIndex = 2;
            this.EmployeeeListsBackButton.Text = "Nazad";
            this.EmployeeeListsBackButton.UseVisualStyleBackColor = true;
            this.EmployeeeListsBackButton.Click += new System.EventHandler(this.EmployeeeListsBackButton_Click);
            // 
            // EmployeeListsChangeButton
            // 
            this.EmployeeListsChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeListsChangeButton.Location = new System.Drawing.Point(449, 455);
            this.EmployeeListsChangeButton.Name = "EmployeeListsChangeButton";
            this.EmployeeListsChangeButton.Size = new System.Drawing.Size(129, 47);
            this.EmployeeListsChangeButton.TabIndex = 3;
            this.EmployeeListsChangeButton.Text = "Promijeni";
            this.EmployeeListsChangeButton.UseVisualStyleBackColor = true;
            this.EmployeeListsChangeButton.Click += new System.EventHandler(this.EmployeeListsChangeButton_Click);
            // 
            // EmployeeListslistView
            // 
            this.EmployeeListslistView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeListslistView.Location = new System.Drawing.Point(59, 127);
            this.EmployeeListslistView.Name = "EmployeeListslistView";
            this.EmployeeListslistView.Size = new System.Drawing.Size(643, 298);
            this.EmployeeListslistView.TabIndex = 4;
            this.EmployeeListslistView.UseCompatibleStateImageBehavior = false;
            // 
            // EmployeeLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 538);
            this.Controls.Add(this.EmployeeListslistView);
            this.Controls.Add(this.EmployeeListsChangeButton);
            this.Controls.Add(this.EmployeeeListsBackButton);
            this.Controls.Add(this.EmployeeListsTitle);
            this.Name = "EmployeeLists";
            this.Text = "EmployeeLists";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeeListsTitle;
        private System.Windows.Forms.Button EmployeeeListsBackButton;
        private System.Windows.Forms.Button EmployeeListsChangeButton;
        private System.Windows.Forms.ListView EmployeeListslistView;
    }
}