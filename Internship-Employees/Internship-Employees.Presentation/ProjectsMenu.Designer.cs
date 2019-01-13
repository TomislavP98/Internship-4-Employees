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
            this.ProjectDetailsButton = new System.Windows.Forms.Button();
            this.NewProjectButton = new System.Windows.Forms.Button();
            this.ProjectMenuBack = new System.Windows.Forms.Button();
            this.ProjectHistroylistBox = new System.Windows.Forms.CheckedListBox();
            this.ProjectMenuDetailsButton = new System.Windows.Forms.Button();
            this.ProjectMenuDeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProjectMenuTitle
            // 
            this.ProjectMenuTitle.AutoSize = true;
            this.ProjectMenuTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectMenuTitle.Location = new System.Drawing.Point(260, 27);
            this.ProjectMenuTitle.Name = "ProjectMenuTitle";
            this.ProjectMenuTitle.Size = new System.Drawing.Size(383, 40);
            this.ProjectMenuTitle.TabIndex = 0;
            this.ProjectMenuTitle.Text = "Nešto d.o.o.  -  Projekti";
            // 
            // ProjectDetailsButton
            // 
            this.ProjectDetailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectDetailsButton.Location = new System.Drawing.Point(411, 543);
            this.ProjectDetailsButton.Name = "ProjectDetailsButton";
            this.ProjectDetailsButton.Size = new System.Drawing.Size(129, 65);
            this.ProjectDetailsButton.TabIndex = 2;
            this.ProjectDetailsButton.Text = "Uredi projekt";
            this.ProjectDetailsButton.UseVisualStyleBackColor = true;
            this.ProjectDetailsButton.Click += new System.EventHandler(this.ProjectDetailsButton_Click);
            // 
            // NewProjectButton
            // 
            this.NewProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewProjectButton.Location = new System.Drawing.Point(205, 544);
            this.NewProjectButton.Name = "NewProjectButton";
            this.NewProjectButton.Size = new System.Drawing.Size(180, 64);
            this.NewProjectButton.TabIndex = 3;
            this.NewProjectButton.Text = "Dodavanje novog projekta";
            this.NewProjectButton.UseVisualStyleBackColor = true;
            this.NewProjectButton.Click += new System.EventHandler(this.NewProjectButton_Click);
            // 
            // ProjectMenuBack
            // 
            this.ProjectMenuBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectMenuBack.Location = new System.Drawing.Point(726, 543);
            this.ProjectMenuBack.Name = "ProjectMenuBack";
            this.ProjectMenuBack.Size = new System.Drawing.Size(118, 64);
            this.ProjectMenuBack.TabIndex = 4;
            this.ProjectMenuBack.Text = "Nazad";
            this.ProjectMenuBack.UseVisualStyleBackColor = true;
            this.ProjectMenuBack.Click += new System.EventHandler(this.ProjectMenuBack_Click);
            // 
            // ProjectHistroylistBox
            // 
            this.ProjectHistroylistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectHistroylistBox.FormattingEnabled = true;
            this.ProjectHistroylistBox.Location = new System.Drawing.Point(85, 177);
            this.ProjectHistroylistBox.Name = "ProjectHistroylistBox";
            this.ProjectHistroylistBox.Size = new System.Drawing.Size(744, 304);
            this.ProjectHistroylistBox.TabIndex = 6;
            this.ProjectHistroylistBox.SelectedIndexChanged += new System.EventHandler(this.ProjectHistroylistBox_SelectedIndexChanged);
            // 
            // ProjectMenuDetailsButton
            // 
            this.ProjectMenuDetailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectMenuDetailsButton.Location = new System.Drawing.Point(568, 543);
            this.ProjectMenuDetailsButton.Name = "ProjectMenuDetailsButton";
            this.ProjectMenuDetailsButton.Size = new System.Drawing.Size(125, 64);
            this.ProjectMenuDetailsButton.TabIndex = 7;
            this.ProjectMenuDetailsButton.Text = "Detalji projekta";
            this.ProjectMenuDetailsButton.UseVisualStyleBackColor = true;
            this.ProjectMenuDetailsButton.Click += new System.EventHandler(this.ProjectMenuDetailsButton_Click);
            // 
            // ProjectMenuDeleteButton
            // 
            this.ProjectMenuDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectMenuDeleteButton.Location = new System.Drawing.Point(63, 544);
            this.ProjectMenuDeleteButton.Name = "ProjectMenuDeleteButton";
            this.ProjectMenuDeleteButton.Size = new System.Drawing.Size(116, 63);
            this.ProjectMenuDeleteButton.TabIndex = 8;
            this.ProjectMenuDeleteButton.Text = "Brisanje projekta";
            this.ProjectMenuDeleteButton.UseVisualStyleBackColor = true;
            this.ProjectMenuDeleteButton.Click += new System.EventHandler(this.ProjectMenuDeleteButton_Click);
            // 
            // ProjectsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 629);
            this.Controls.Add(this.ProjectMenuDeleteButton);
            this.Controls.Add(this.ProjectMenuDetailsButton);
            this.Controls.Add(this.ProjectHistroylistBox);
            this.Controls.Add(this.ProjectMenuBack);
            this.Controls.Add(this.NewProjectButton);
            this.Controls.Add(this.ProjectDetailsButton);
            this.Controls.Add(this.ProjectMenuTitle);
            this.Name = "ProjectsMenu";
            this.Text = "ProjectsMenu";
            this.Load += new System.EventHandler(this.ProjectsMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProjectMenuTitle;
        private System.Windows.Forms.Button ProjectHistoryButton;
        private System.Windows.Forms.Button ProjectDetailsButton;
        private System.Windows.Forms.Button NewProjectButton;
        private System.Windows.Forms.Button ProjectMenuBack;
        private System.Windows.Forms.CheckedListBox ProjectHistroylistBox;
        private System.Windows.Forms.Button ProjectMenuDetailsButton;
        private System.Windows.Forms.Button ProjectMenuDeleteButton;
    }
}