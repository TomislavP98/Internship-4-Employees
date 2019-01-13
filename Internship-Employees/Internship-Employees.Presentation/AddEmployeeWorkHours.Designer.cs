namespace Internship_Employees.Presentation
{
    partial class AddEmployeeWorkHours
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
            this.TitleLableEmployeeAddWorkhours = new System.Windows.Forms.Label();
            this.EmployeeLabel = new System.Windows.Forms.Label();
            this.ProjectLableEmployeeWorkhours = new System.Windows.Forms.Label();
            this.EmployeeAddWorkHourstextBox = new System.Windows.Forms.TextBox();
            this.WorkhoursAddLabel = new System.Windows.Forms.Label();
            this.workhoursEmployeeBackButton = new System.Windows.Forms.Button();
            this.CofnrimButtonWorkhours = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLableEmployeeAddWorkhours
            // 
            this.TitleLableEmployeeAddWorkhours.AutoSize = true;
            this.TitleLableEmployeeAddWorkhours.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLableEmployeeAddWorkhours.Location = new System.Drawing.Point(101, 48);
            this.TitleLableEmployeeAddWorkhours.Name = "TitleLableEmployeeAddWorkhours";
            this.TitleLableEmployeeAddWorkhours.Size = new System.Drawing.Size(505, 37);
            this.TitleLableEmployeeAddWorkhours.TabIndex = 0;
            this.TitleLableEmployeeAddWorkhours.Text = "Dodavanje radnih sati zaposleniku";
            // 
            // EmployeeLabel
            // 
            this.EmployeeLabel.AutoSize = true;
            this.EmployeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeLabel.Location = new System.Drawing.Point(234, 173);
            this.EmployeeLabel.Name = "EmployeeLabel";
            this.EmployeeLabel.Size = new System.Drawing.Size(107, 25);
            this.EmployeeLabel.TabIndex = 1;
            this.EmployeeLabel.Text = "Zaposlenik";
            // 
            // ProjectLableEmployeeWorkhours
            // 
            this.ProjectLableEmployeeWorkhours.AutoSize = true;
            this.ProjectLableEmployeeWorkhours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectLableEmployeeWorkhours.Location = new System.Drawing.Point(31, 169);
            this.ProjectLableEmployeeWorkhours.Name = "ProjectLableEmployeeWorkhours";
            this.ProjectLableEmployeeWorkhours.Size = new System.Drawing.Size(89, 29);
            this.ProjectLableEmployeeWorkhours.TabIndex = 2;
            this.ProjectLableEmployeeWorkhours.Text = "Projekt";
            this.ProjectLableEmployeeWorkhours.Click += new System.EventHandler(this.ProjectLableEmployeeWorkhours_Click);
            // 
            // EmployeeAddWorkHourstextBox
            // 
            this.EmployeeAddWorkHourstextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeAddWorkHourstextBox.Location = new System.Drawing.Point(239, 234);
            this.EmployeeAddWorkHourstextBox.Name = "EmployeeAddWorkHourstextBox";
            this.EmployeeAddWorkHourstextBox.Size = new System.Drawing.Size(203, 28);
            this.EmployeeAddWorkHourstextBox.TabIndex = 3;
            this.EmployeeAddWorkHourstextBox.TextChanged += new System.EventHandler(this.EmployeeAddWorkHourstextBox_TextChanged);
            this.EmployeeAddWorkHourstextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmployeeAddWorkHourstextBox_KeyPress);
            // 
            // WorkhoursAddLabel
            // 
            this.WorkhoursAddLabel.AutoSize = true;
            this.WorkhoursAddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkhoursAddLabel.Location = new System.Drawing.Point(12, 234);
            this.WorkhoursAddLabel.Name = "WorkhoursAddLabel";
            this.WorkhoursAddLabel.Size = new System.Drawing.Size(221, 25);
            this.WorkhoursAddLabel.TabIndex = 4;
            this.WorkhoursAddLabel.Text = "Dodajte broj radnih  sati:";
            // 
            // workhoursEmployeeBackButton
            // 
            this.workhoursEmployeeBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workhoursEmployeeBackButton.Location = new System.Drawing.Point(160, 353);
            this.workhoursEmployeeBackButton.Name = "workhoursEmployeeBackButton";
            this.workhoursEmployeeBackButton.Size = new System.Drawing.Size(111, 47);
            this.workhoursEmployeeBackButton.TabIndex = 5;
            this.workhoursEmployeeBackButton.Text = "Nazad";
            this.workhoursEmployeeBackButton.UseVisualStyleBackColor = true;
            this.workhoursEmployeeBackButton.Click += new System.EventHandler(this.workhoursEmployeeBackButton_Click);
            // 
            // CofnrimButtonWorkhours
            // 
            this.CofnrimButtonWorkhours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CofnrimButtonWorkhours.Location = new System.Drawing.Point(340, 353);
            this.CofnrimButtonWorkhours.Name = "CofnrimButtonWorkhours";
            this.CofnrimButtonWorkhours.Size = new System.Drawing.Size(113, 47);
            this.CofnrimButtonWorkhours.TabIndex = 6;
            this.CofnrimButtonWorkhours.Text = "Potvrdi";
            this.CofnrimButtonWorkhours.UseVisualStyleBackColor = true;
            this.CofnrimButtonWorkhours.Click += new System.EventHandler(this.CofnrimButtonWorkhours_Click);
            // 
            // AddEmployeeWorkHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 428);
            this.Controls.Add(this.CofnrimButtonWorkhours);
            this.Controls.Add(this.workhoursEmployeeBackButton);
            this.Controls.Add(this.WorkhoursAddLabel);
            this.Controls.Add(this.EmployeeAddWorkHourstextBox);
            this.Controls.Add(this.ProjectLableEmployeeWorkhours);
            this.Controls.Add(this.EmployeeLabel);
            this.Controls.Add(this.TitleLableEmployeeAddWorkhours);
            this.Name = "AddEmployeeWorkHours";
            this.Text = "AddEmployeeWorkHours";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLableEmployeeAddWorkhours;
        private System.Windows.Forms.Label EmployeeLabel;
        private System.Windows.Forms.Label ProjectLableEmployeeWorkhours;
        private System.Windows.Forms.TextBox EmployeeAddWorkHourstextBox;
        private System.Windows.Forms.Label WorkhoursAddLabel;
        private System.Windows.Forms.Button workhoursEmployeeBackButton;
        private System.Windows.Forms.Button CofnrimButtonWorkhours;
    }
}