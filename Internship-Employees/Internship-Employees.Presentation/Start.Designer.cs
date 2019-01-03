namespace Internship_Employees.Presentation
{
    partial class Start
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
            this.StartTitle = new System.Windows.Forms.Label();
            this.StartProjectButton = new System.Windows.Forms.Button();
            this.StartEmployeesButton = new System.Windows.Forms.Button();
            this.StartExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartTitle
            // 
            this.StartTitle.AutoSize = true;
            this.StartTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTitle.Location = new System.Drawing.Point(315, 103);
            this.StartTitle.Name = "StartTitle";
            this.StartTitle.Size = new System.Drawing.Size(223, 40);
            this.StartTitle.TabIndex = 0;
            this.StartTitle.Text = "Nešto d.o.o.";
            // 
            // StartProjectButton
            // 
            this.StartProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartProjectButton.Location = new System.Drawing.Point(310, 234);
            this.StartProjectButton.Name = "StartProjectButton";
            this.StartProjectButton.Size = new System.Drawing.Size(242, 77);
            this.StartProjectButton.TabIndex = 1;
            this.StartProjectButton.Text = "Projekti";
            this.StartProjectButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.StartProjectButton.UseVisualStyleBackColor = true;
            this.StartProjectButton.Click += new System.EventHandler(this.StartProjectButton_Click);
            // 
            // StartEmployeesButton
            // 
            this.StartEmployeesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartEmployeesButton.Location = new System.Drawing.Point(310, 362);
            this.StartEmployeesButton.Name = "StartEmployeesButton";
            this.StartEmployeesButton.Size = new System.Drawing.Size(242, 89);
            this.StartEmployeesButton.TabIndex = 2;
            this.StartEmployeesButton.Text = "Zaposlenici";
            this.StartEmployeesButton.UseVisualStyleBackColor = true;
            this.StartEmployeesButton.Click += new System.EventHandler(this.StartEmployeesButton_Click);
            // 
            // StartExitButton
            // 
            this.StartExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartExitButton.Location = new System.Drawing.Point(380, 600);
            this.StartExitButton.Name = "StartExitButton";
            this.StartExitButton.Size = new System.Drawing.Size(106, 50);
            this.StartExitButton.TabIndex = 3;
            this.StartExitButton.Text = "Izlaz";
            this.StartExitButton.UseVisualStyleBackColor = true;
            this.StartExitButton.Click += new System.EventHandler(this.StartExitButton_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 721);
            this.Controls.Add(this.StartExitButton);
            this.Controls.Add(this.StartEmployeesButton);
            this.Controls.Add(this.StartProjectButton);
            this.Controls.Add(this.StartTitle);
            this.Name = "Start";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StartTitle;
        private System.Windows.Forms.Button StartProjectButton;
        private System.Windows.Forms.Button StartEmployeesButton;
        private System.Windows.Forms.Button StartExitButton;
    }
}