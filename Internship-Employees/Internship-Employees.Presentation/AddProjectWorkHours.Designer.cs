namespace Internship_Employees.Presentation
{
    partial class AddProjectWorkHours
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
            this.WorkhoursProjectTitleLabel = new System.Windows.Forms.Label();
            this.ProjectNameLabel = new System.Windows.Forms.Label();
            this.EmployeeNameWorkHoursLabel = new System.Windows.Forms.Label();
            this.ProjectWorkHoursBackButton = new System.Windows.Forms.Button();
            this.ProjectWorkHoursConfirmButton = new System.Windows.Forms.Button();
            this.ProjectWorkHourstextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WorkhoursProjectTitleLabel
            // 
            this.WorkhoursProjectTitleLabel.AutoSize = true;
            this.WorkhoursProjectTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkhoursProjectTitleLabel.Location = new System.Drawing.Point(164, 58);
            this.WorkhoursProjectTitleLabel.Name = "WorkhoursProjectTitleLabel";
            this.WorkhoursProjectTitleLabel.Size = new System.Drawing.Size(477, 37);
            this.WorkhoursProjectTitleLabel.TabIndex = 0;
            this.WorkhoursProjectTitleLabel.Text = "Dodavanje radnih sati na projekt";
            // 
            // ProjectNameLabel
            // 
            this.ProjectNameLabel.AutoSize = true;
            this.ProjectNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectNameLabel.Location = new System.Drawing.Point(294, 196);
            this.ProjectNameLabel.Name = "ProjectNameLabel";
            this.ProjectNameLabel.Size = new System.Drawing.Size(72, 25);
            this.ProjectNameLabel.TabIndex = 1;
            this.ProjectNameLabel.Text = "Projekt";
            // 
            // EmployeeNameWorkHoursLabel
            // 
            this.EmployeeNameWorkHoursLabel.AutoSize = true;
            this.EmployeeNameWorkHoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeNameWorkHoursLabel.Location = new System.Drawing.Point(104, 196);
            this.EmployeeNameWorkHoursLabel.Name = "EmployeeNameWorkHoursLabel";
            this.EmployeeNameWorkHoursLabel.Size = new System.Drawing.Size(117, 26);
            this.EmployeeNameWorkHoursLabel.TabIndex = 2;
            this.EmployeeNameWorkHoursLabel.Text = "Zaposlenik";
            // 
            // ProjectWorkHoursBackButton
            // 
            this.ProjectWorkHoursBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectWorkHoursBackButton.Location = new System.Drawing.Point(205, 415);
            this.ProjectWorkHoursBackButton.Name = "ProjectWorkHoursBackButton";
            this.ProjectWorkHoursBackButton.Size = new System.Drawing.Size(127, 59);
            this.ProjectWorkHoursBackButton.TabIndex = 3;
            this.ProjectWorkHoursBackButton.Text = "Nazad";
            this.ProjectWorkHoursBackButton.UseVisualStyleBackColor = true;
            this.ProjectWorkHoursBackButton.Click += new System.EventHandler(this.ProjectWorkHoursBackButton_Click);
            // 
            // ProjectWorkHoursConfirmButton
            // 
            this.ProjectWorkHoursConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectWorkHoursConfirmButton.Location = new System.Drawing.Point(447, 415);
            this.ProjectWorkHoursConfirmButton.Name = "ProjectWorkHoursConfirmButton";
            this.ProjectWorkHoursConfirmButton.Size = new System.Drawing.Size(101, 59);
            this.ProjectWorkHoursConfirmButton.TabIndex = 4;
            this.ProjectWorkHoursConfirmButton.Text = "Potvrdi";
            this.ProjectWorkHoursConfirmButton.UseVisualStyleBackColor = true;
            this.ProjectWorkHoursConfirmButton.Click += new System.EventHandler(this.ProjectWorkHoursConfirmButton_Click);
            // 
            // ProjectWorkHourstextBox
            // 
            this.ProjectWorkHourstextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectWorkHourstextBox.Location = new System.Drawing.Point(315, 257);
            this.ProjectWorkHourstextBox.Name = "ProjectWorkHourstextBox";
            this.ProjectWorkHourstextBox.Size = new System.Drawing.Size(210, 28);
            this.ProjectWorkHourstextBox.TabIndex = 5;
            this.ProjectWorkHourstextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProjectWorkHourstextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dodajte broj radnih sati:";
            // 
            // AddProjectWorkHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 547);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProjectWorkHourstextBox);
            this.Controls.Add(this.ProjectWorkHoursConfirmButton);
            this.Controls.Add(this.ProjectWorkHoursBackButton);
            this.Controls.Add(this.EmployeeNameWorkHoursLabel);
            this.Controls.Add(this.ProjectNameLabel);
            this.Controls.Add(this.WorkhoursProjectTitleLabel);
            this.Name = "AddProjectWorkHours";
            this.Text = "AddProjectWorkHours";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WorkhoursProjectTitleLabel;
        private System.Windows.Forms.Label ProjectNameLabel;
        private System.Windows.Forms.Label EmployeeNameWorkHoursLabel;
        private System.Windows.Forms.Button ProjectWorkHoursBackButton;
        private System.Windows.Forms.Button ProjectWorkHoursConfirmButton;
        private System.Windows.Forms.TextBox ProjectWorkHourstextBox;
        private System.Windows.Forms.Label label1;
    }
}