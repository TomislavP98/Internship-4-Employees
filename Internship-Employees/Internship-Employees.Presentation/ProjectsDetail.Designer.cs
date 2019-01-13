namespace Internship_Employees.Presentation
{
    partial class ProjectsDetail
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
            this.ProjectDetailTitleLabel = new System.Windows.Forms.Label();
            this.ProjectDetailslistBox = new System.Windows.Forms.ListBox();
            this.ProjectDetailBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProjectDetailTitleLabel
            // 
            this.ProjectDetailTitleLabel.AutoSize = true;
            this.ProjectDetailTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectDetailTitleLabel.Location = new System.Drawing.Point(188, 29);
            this.ProjectDetailTitleLabel.Name = "ProjectDetailTitleLabel";
            this.ProjectDetailTitleLabel.Size = new System.Drawing.Size(255, 37);
            this.ProjectDetailTitleLabel.TabIndex = 0;
            this.ProjectDetailTitleLabel.Text = "Detalji o projektu";
            // 
            // ProjectDetailslistBox
            // 
            this.ProjectDetailslistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectDetailslistBox.FormattingEnabled = true;
            this.ProjectDetailslistBox.ItemHeight = 22;
            this.ProjectDetailslistBox.Location = new System.Drawing.Point(12, 78);
            this.ProjectDetailslistBox.Name = "ProjectDetailslistBox";
            this.ProjectDetailslistBox.Size = new System.Drawing.Size(728, 312);
            this.ProjectDetailslistBox.TabIndex = 1;
            // 
            // ProjectDetailBackButton
            // 
            this.ProjectDetailBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectDetailBackButton.Location = new System.Drawing.Point(301, 422);
            this.ProjectDetailBackButton.Name = "ProjectDetailBackButton";
            this.ProjectDetailBackButton.Size = new System.Drawing.Size(113, 42);
            this.ProjectDetailBackButton.TabIndex = 2;
            this.ProjectDetailBackButton.Text = "Nazad";
            this.ProjectDetailBackButton.UseVisualStyleBackColor = true;
            this.ProjectDetailBackButton.Click += new System.EventHandler(this.ProjectDetailBackButton_Click);
            // 
            // ProjectsDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 487);
            this.Controls.Add(this.ProjectDetailBackButton);
            this.Controls.Add(this.ProjectDetailslistBox);
            this.Controls.Add(this.ProjectDetailTitleLabel);
            this.Name = "ProjectsDetail";
            this.Text = "ProjectsDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProjectDetailTitleLabel;
        private System.Windows.Forms.ListBox ProjectDetailslistBox;
        private System.Windows.Forms.Button ProjectDetailBackButton;
    }
}