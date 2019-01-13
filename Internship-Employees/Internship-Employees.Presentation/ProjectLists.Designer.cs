namespace Internship_Employees.Presentation
{
    partial class ProjectLists
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
            this.ProjectListTitle = new System.Windows.Forms.Label();
            this.ProjectListListBox = new System.Windows.Forms.ListBox();
            this.ProjectListBack = new System.Windows.Forms.Button();
            this.ProjectListChangeeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProjectListTitle
            // 
            this.ProjectListTitle.AutoSize = true;
            this.ProjectListTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectListTitle.Location = new System.Drawing.Point(424, 69);
            this.ProjectListTitle.Name = "ProjectListTitle";
            this.ProjectListTitle.Size = new System.Drawing.Size(303, 37);
            this.ProjectListTitle.TabIndex = 0;
            this.ProjectListTitle.Text = "Nešto d.o.o. projekti";
            // 
            // ProjectListListBox
            // 
            this.ProjectListListBox.FormattingEnabled = true;
            this.ProjectListListBox.ItemHeight = 20;
            this.ProjectListListBox.Location = new System.Drawing.Point(51, 149);
            this.ProjectListListBox.Name = "ProjectListListBox";
            this.ProjectListListBox.Size = new System.Drawing.Size(1024, 324);
            this.ProjectListListBox.TabIndex = 1;
            // 
            // ProjectListBack
            // 
            this.ProjectListBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectListBack.Location = new System.Drawing.Point(335, 549);
            this.ProjectListBack.Name = "ProjectListBack";
            this.ProjectListBack.Size = new System.Drawing.Size(170, 67);
            this.ProjectListBack.TabIndex = 2;
            this.ProjectListBack.Text = "Nazad";
            this.ProjectListBack.UseVisualStyleBackColor = true;
            this.ProjectListBack.Click += new System.EventHandler(this.ProjectListBack_Click);
            // 
            // ProjectListChangeeButton
            // 
            this.ProjectListChangeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectListChangeeButton.Location = new System.Drawing.Point(632, 549);
            this.ProjectListChangeeButton.Name = "ProjectListChangeeButton";
            this.ProjectListChangeeButton.Size = new System.Drawing.Size(161, 67);
            this.ProjectListChangeeButton.TabIndex = 3;
            this.ProjectListChangeeButton.Text = "Promijeni";
            this.ProjectListChangeeButton.UseVisualStyleBackColor = true;
            this.ProjectListChangeeButton.Click += new System.EventHandler(this.ProjectListChangeeButton_Click);
            // 
            // ProjectList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 658);
            this.Controls.Add(this.ProjectListChangeeButton);
            this.Controls.Add(this.ProjectListBack);
            this.Controls.Add(this.ProjectListListBox);
            this.Controls.Add(this.ProjectListTitle);
            this.Name = "ProjectList";
            this.Text = "ProjectList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProjectListTitle;
        private System.Windows.Forms.ListBox ProjectListListBox;
        private System.Windows.Forms.Button ProjectListBack;
        private System.Windows.Forms.Button ProjectListChangeeButton;
    }
}