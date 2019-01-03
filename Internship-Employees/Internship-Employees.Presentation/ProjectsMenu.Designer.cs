namespace Internship_Employees.Presentation
{
    partial class ProjectsMenu
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
            this.ProjectMenuTitle = new System.Windows.Forms.Label();
            this.ProjectHistoryButton = new System.Windows.Forms.Button();
            this.ProjectDetailsButton = new System.Windows.Forms.Button();
            this.NewProjectButton = new System.Windows.Forms.Button();
            this.ProjectMenuBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProjectMenuTitle
            // 
            this.ProjectMenuTitle.AutoSize = true;
            this.ProjectMenuTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectMenuTitle.Location = new System.Drawing.Point(269, 58);
            this.ProjectMenuTitle.Name = "ProjectMenuTitle";
            this.ProjectMenuTitle.Size = new System.Drawing.Size(383, 40);
            this.ProjectMenuTitle.TabIndex = 0;
            this.ProjectMenuTitle.Text = "Nešto d.o.o.  -  Projekti";
            // 
            // ProjectHistoryButton
            // 
            this.ProjectHistoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectHistoryButton.Location = new System.Drawing.Point(309, 159);
            this.ProjectHistoryButton.Name = "ProjectHistoryButton";
            this.ProjectHistoryButton.Size = new System.Drawing.Size(253, 72);
            this.ProjectHistoryButton.TabIndex = 1;
            this.ProjectHistoryButton.Text = "Povijest tvrtke";
            this.ProjectHistoryButton.UseVisualStyleBackColor = true;
            // 
            // ProjectDetailsButton
            // 
            this.ProjectDetailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectDetailsButton.Location = new System.Drawing.Point(309, 267);
            this.ProjectDetailsButton.Name = "ProjectDetailsButton";
            this.ProjectDetailsButton.Size = new System.Drawing.Size(253, 71);
            this.ProjectDetailsButton.TabIndex = 2;
            this.ProjectDetailsButton.Text = "Detalji projekata";
            this.ProjectDetailsButton.UseVisualStyleBackColor = true;
            // 
            // NewProjectButton
            // 
            this.NewProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewProjectButton.Location = new System.Drawing.Point(309, 378);
            this.NewProjectButton.Name = "NewProjectButton";
            this.NewProjectButton.Size = new System.Drawing.Size(259, 70);
            this.NewProjectButton.TabIndex = 3;
            this.NewProjectButton.Text = "Dodavanje novog projekta";
            this.NewProjectButton.UseVisualStyleBackColor = true;
            // 
            // ProjectMenuBack
            // 
            this.ProjectMenuBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectMenuBack.Location = new System.Drawing.Point(375, 520);
            this.ProjectMenuBack.Name = "ProjectMenuBack";
            this.ProjectMenuBack.Size = new System.Drawing.Size(118, 55);
            this.ProjectMenuBack.TabIndex = 4;
            this.ProjectMenuBack.Text = "Nazad";
            this.ProjectMenuBack.UseVisualStyleBackColor = true;
            this.ProjectMenuBack.Click += new System.EventHandler(this.ProjectMenuBack_Click);
            // 
            // ProjectsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 629);
            this.Controls.Add(this.ProjectMenuBack);
            this.Controls.Add(this.NewProjectButton);
            this.Controls.Add(this.ProjectDetailsButton);
            this.Controls.Add(this.ProjectHistoryButton);
            this.Controls.Add(this.ProjectMenuTitle);
            this.Name = "ProjectsMenu";
            this.Text = "ProjectsMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProjectMenuTitle;
        private System.Windows.Forms.Button ProjectHistoryButton;
        private System.Windows.Forms.Button ProjectDetailsButton;
        private System.Windows.Forms.Button NewProjectButton;
        private System.Windows.Forms.Button ProjectMenuBack;
    }
}