namespace Internship_Employees.Presentation
{
    partial class ProjectHistory
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
            this.ProjectsHistoryTitle = new System.Windows.Forms.Label();
            this.ProjectHistoryAnnouncer = new System.Windows.Forms.Label();
            this.ProjectHistoryBackButton = new System.Windows.Forms.Button();
            this.ProjectHistoryDeleteButton = new System.Windows.Forms.Button();
            this.ProjectHistroylistBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // ProjectsHistoryTitle
            // 
            this.ProjectsHistoryTitle.AutoSize = true;
            this.ProjectsHistoryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectsHistoryTitle.Location = new System.Drawing.Point(534, 67);
            this.ProjectsHistoryTitle.Name = "ProjectsHistoryTitle";
            this.ProjectsHistoryTitle.Size = new System.Drawing.Size(268, 37);
            this.ProjectsHistoryTitle.TabIndex = 0;
            this.ProjectsHistoryTitle.Text = "Povijest projekata";
            // 
            // ProjectHistoryAnnouncer
            // 
            this.ProjectHistoryAnnouncer.AutoSize = true;
            this.ProjectHistoryAnnouncer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectHistoryAnnouncer.Location = new System.Drawing.Point(45, 189);
            this.ProjectHistoryAnnouncer.Name = "ProjectHistoryAnnouncer";
            this.ProjectHistoryAnnouncer.Size = new System.Drawing.Size(331, 29);
            this.ProjectHistoryAnnouncer.TabIndex = 1;
            this.ProjectHistoryAnnouncer.Text = "Svi projekti tvrtke Nešto d.o.o.";
            // 
            // ProjectHistoryBackButton
            // 
            this.ProjectHistoryBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectHistoryBackButton.Location = new System.Drawing.Point(403, 679);
            this.ProjectHistoryBackButton.Name = "ProjectHistoryBackButton";
            this.ProjectHistoryBackButton.Size = new System.Drawing.Size(138, 54);
            this.ProjectHistoryBackButton.TabIndex = 3;
            this.ProjectHistoryBackButton.Text = "Nazad";
            this.ProjectHistoryBackButton.UseVisualStyleBackColor = true;
            this.ProjectHistoryBackButton.Click += new System.EventHandler(this.ProjectHistoryBackButton_Click);
            // 
            // ProjectHistoryDeleteButton
            // 
            this.ProjectHistoryDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectHistoryDeleteButton.Location = new System.Drawing.Point(649, 679);
            this.ProjectHistoryDeleteButton.Name = "ProjectHistoryDeleteButton";
            this.ProjectHistoryDeleteButton.Size = new System.Drawing.Size(153, 54);
            this.ProjectHistoryDeleteButton.TabIndex = 4;
            this.ProjectHistoryDeleteButton.Text = "Obriši";
            this.ProjectHistoryDeleteButton.UseVisualStyleBackColor = true;
            this.ProjectHistoryDeleteButton.Click += new System.EventHandler(this.ProjectHistoryDeleteButton_Click);
            // 
            // ProjectHistroylistBox
            // 
            this.ProjectHistroylistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectHistroylistBox.FormattingEnabled = true;
            this.ProjectHistroylistBox.Location = new System.Drawing.Point(12, 253);
            this.ProjectHistroylistBox.Name = "ProjectHistroylistBox";
            this.ProjectHistroylistBox.Size = new System.Drawing.Size(1131, 379);
            this.ProjectHistroylistBox.TabIndex = 5;
            this.ProjectHistroylistBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // ProjectHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 792);
            this.Controls.Add(this.ProjectHistroylistBox);
            this.Controls.Add(this.ProjectHistoryDeleteButton);
            this.Controls.Add(this.ProjectHistoryBackButton);
            this.Controls.Add(this.ProjectHistoryAnnouncer);
            this.Controls.Add(this.ProjectsHistoryTitle);
            this.Name = "ProjectHistory";
            this.Text = "ProjectHistory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProjectsHistoryTitle;
        private System.Windows.Forms.Label ProjectHistoryAnnouncer;
        private System.Windows.Forms.Button ProjectHistoryBackButton;
        private System.Windows.Forms.Button ProjectHistoryDeleteButton;
        private System.Windows.Forms.CheckedListBox ProjectHistroylistBox;
    }
}