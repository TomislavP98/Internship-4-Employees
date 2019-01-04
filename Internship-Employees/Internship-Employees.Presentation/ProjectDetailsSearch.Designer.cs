namespace Internship_Employees.Presentation
{
    partial class ProjectDetailsSearch
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
            this.ProjectDetailsSearchTitle = new System.Windows.Forms.Label();
            this.ProjectSearchSearchButton = new System.Windows.Forms.Button();
            this.ProjectSearchBackButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProjectDetailsSearchTitle
            // 
            this.ProjectDetailsSearchTitle.AutoSize = true;
            this.ProjectDetailsSearchTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectDetailsSearchTitle.Location = new System.Drawing.Point(309, 81);
            this.ProjectDetailsSearchTitle.Name = "ProjectDetailsSearchTitle";
            this.ProjectDetailsSearchTitle.Size = new System.Drawing.Size(343, 37);
            this.ProjectDetailsSearchTitle.TabIndex = 0;
            this.ProjectDetailsSearchTitle.Text = "Projekti  -  Nešto d.o.o.";
            // 
            // ProjectSearchSearchButton
            // 
            this.ProjectSearchSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectSearchSearchButton.Location = new System.Drawing.Point(351, 456);
            this.ProjectSearchSearchButton.Name = "ProjectSearchSearchButton";
            this.ProjectSearchSearchButton.Size = new System.Drawing.Size(194, 59);
            this.ProjectSearchSearchButton.TabIndex = 1;
            this.ProjectSearchSearchButton.Text = "Traži projekt";
            this.ProjectSearchSearchButton.UseVisualStyleBackColor = true;
            this.ProjectSearchSearchButton.Click += new System.EventHandler(this.ProjectSearchSearchButton_Click);
            // 
            // ProjectSearchBackButton
            // 
            this.ProjectSearchBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectSearchBackButton.Location = new System.Drawing.Point(351, 554);
            this.ProjectSearchBackButton.Name = "ProjectSearchBackButton";
            this.ProjectSearchBackButton.Size = new System.Drawing.Size(194, 68);
            this.ProjectSearchBackButton.TabIndex = 2;
            this.ProjectSearchBackButton.Text = "Nazad";
            this.ProjectSearchBackButton.UseVisualStyleBackColor = true;
            this.ProjectSearchBackButton.Click += new System.EventHandler(this.ProjectSearchBackButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(214, 241);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(365, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Upišite ime projekta čije detalje želite:";
            // 
            // ProjectDetailsSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 706);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ProjectSearchBackButton);
            this.Controls.Add(this.ProjectSearchSearchButton);
            this.Controls.Add(this.ProjectDetailsSearchTitle);
            this.Name = "ProjectDetailsSearch";
            this.Text = "ProjectDetailsSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProjectDetailsSearchTitle;
        private System.Windows.Forms.Button ProjectSearchSearchButton;
        private System.Windows.Forms.Button ProjectSearchBackButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}