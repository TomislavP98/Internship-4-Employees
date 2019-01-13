namespace Internship_Employees.Presentation
{
    partial class EmployeeDeleteError
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
            this.ErrorTitleLabel = new System.Windows.Forms.Label();
            this.ErrorDescriptionLabel = new System.Windows.Forms.Label();
            this.ErrorOkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ErrorTitleLabel
            // 
            this.ErrorTitleLabel.AutoSize = true;
            this.ErrorTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorTitleLabel.Location = new System.Drawing.Point(395, 42);
            this.ErrorTitleLabel.Name = "ErrorTitleLabel";
            this.ErrorTitleLabel.Size = new System.Drawing.Size(169, 32);
            this.ErrorTitleLabel.TabIndex = 0;
            this.ErrorTitleLabel.Text = "Upozorenje!";
            // 
            // ErrorDescriptionLabel
            // 
            this.ErrorDescriptionLabel.AutoSize = true;
            this.ErrorDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorDescriptionLabel.Location = new System.Drawing.Point(12, 99);
            this.ErrorDescriptionLabel.Name = "ErrorDescriptionLabel";
            this.ErrorDescriptionLabel.Size = new System.Drawing.Size(928, 29);
            this.ErrorDescriptionLabel.TabIndex = 1;
            this.ErrorDescriptionLabel.Text = "Ne možete izbrisati odabranog zaposlenika jer trenutno radi sam na nekim projekti" +
    "ma!";
            // 
            // ErrorOkButton
            // 
            this.ErrorOkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorOkButton.Location = new System.Drawing.Point(431, 190);
            this.ErrorOkButton.Name = "ErrorOkButton";
            this.ErrorOkButton.Size = new System.Drawing.Size(133, 49);
            this.ErrorOkButton.TabIndex = 2;
            this.ErrorOkButton.Text = "Uredu";
            this.ErrorOkButton.UseVisualStyleBackColor = true;
            this.ErrorOkButton.Click += new System.EventHandler(this.ErrorOkButton_Click);
            // 
            // EmployeeDeleteError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 288);
            this.Controls.Add(this.ErrorOkButton);
            this.Controls.Add(this.ErrorDescriptionLabel);
            this.Controls.Add(this.ErrorTitleLabel);
            this.Name = "EmployeeDeleteError";
            this.Text = "EmployeeDeleteError";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ErrorTitleLabel;
        private System.Windows.Forms.Label ErrorDescriptionLabel;
        private System.Windows.Forms.Button ErrorOkButton;
    }
}