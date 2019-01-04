namespace Internship_Employees.Presentation
{
    partial class ProjectAdd
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
            this.ProjectAddTitle = new System.Windows.Forms.Label();
            this.ProjectAddName = new System.Windows.Forms.Label();
            this.ProjectAddStart = new System.Windows.Forms.Label();
            this.ProjectAddFinish = new System.Windows.Forms.Label();
            this.ProjectAddEmployeeAddButton = new System.Windows.Forms.Button();
            this.ProjectAddBackBttton = new System.Windows.Forms.Button();
            this.ProjectAddDateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.ProjectAddDateTimeFinisch = new System.Windows.Forms.DateTimePicker();
            this.ProjectAddNameTextBox = new System.Windows.Forms.TextBox();
            this.ProjectAddSaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProjectAddTitle
            // 
            this.ProjectAddTitle.AutoSize = true;
            this.ProjectAddTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectAddTitle.Location = new System.Drawing.Point(116, 61);
            this.ProjectAddTitle.Name = "ProjectAddTitle";
            this.ProjectAddTitle.Size = new System.Drawing.Size(388, 37);
            this.ProjectAddTitle.TabIndex = 0;
            this.ProjectAddTitle.Text = "Dodavanje novog projekta";
            // 
            // ProjectAddName
            // 
            this.ProjectAddName.AutoSize = true;
            this.ProjectAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectAddName.Location = new System.Drawing.Point(118, 201);
            this.ProjectAddName.Name = "ProjectAddName";
            this.ProjectAddName.Size = new System.Drawing.Size(129, 25);
            this.ProjectAddName.TabIndex = 1;
            this.ProjectAddName.Text = "Ime projekta: ";
            this.ProjectAddName.Click += new System.EventHandler(this.label2_Click);
            // 
            // ProjectAddStart
            // 
            this.ProjectAddStart.AutoSize = true;
            this.ProjectAddStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectAddStart.Location = new System.Drawing.Point(119, 265);
            this.ProjectAddStart.Name = "ProjectAddStart";
            this.ProjectAddStart.Size = new System.Drawing.Size(149, 25);
            this.ProjectAddStart.TabIndex = 2;
            this.ProjectAddStart.Text = "Datum početka:";
            // 
            // ProjectAddFinish
            // 
            this.ProjectAddFinish.AutoSize = true;
            this.ProjectAddFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectAddFinish.Location = new System.Drawing.Point(119, 328);
            this.ProjectAddFinish.Name = "ProjectAddFinish";
            this.ProjectAddFinish.Size = new System.Drawing.Size(164, 25);
            this.ProjectAddFinish.TabIndex = 3;
            this.ProjectAddFinish.Text = "Datum završetka:";
            // 
            // ProjectAddEmployeeAddButton
            // 
            this.ProjectAddEmployeeAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectAddEmployeeAddButton.Location = new System.Drawing.Point(186, 423);
            this.ProjectAddEmployeeAddButton.Name = "ProjectAddEmployeeAddButton";
            this.ProjectAddEmployeeAddButton.Size = new System.Drawing.Size(244, 51);
            this.ProjectAddEmployeeAddButton.TabIndex = 4;
            this.ProjectAddEmployeeAddButton.Text = "Dodaj sudionika";
            this.ProjectAddEmployeeAddButton.UseVisualStyleBackColor = true;
            this.ProjectAddEmployeeAddButton.Click += new System.EventHandler(this.ProjectAddEmployeeAddButton_Click);
            // 
            // ProjectAddBackBttton
            // 
            this.ProjectAddBackBttton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectAddBackBttton.Location = new System.Drawing.Point(148, 550);
            this.ProjectAddBackBttton.Name = "ProjectAddBackBttton";
            this.ProjectAddBackBttton.Size = new System.Drawing.Size(135, 50);
            this.ProjectAddBackBttton.TabIndex = 5;
            this.ProjectAddBackBttton.Text = "Nazad";
            this.ProjectAddBackBttton.UseVisualStyleBackColor = true;
            this.ProjectAddBackBttton.Click += new System.EventHandler(this.ProjectAddBackBttton_Click);
            // 
            // ProjectAddDateTimeStart
            // 
            this.ProjectAddDateTimeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectAddDateTimeStart.Location = new System.Drawing.Point(162, 293);
            this.ProjectAddDateTimeStart.Name = "ProjectAddDateTimeStart";
            this.ProjectAddDateTimeStart.Size = new System.Drawing.Size(323, 28);
            this.ProjectAddDateTimeStart.TabIndex = 6;
            // 
            // ProjectAddDateTimeFinisch
            // 
            this.ProjectAddDateTimeFinisch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectAddDateTimeFinisch.Location = new System.Drawing.Point(162, 356);
            this.ProjectAddDateTimeFinisch.Name = "ProjectAddDateTimeFinisch";
            this.ProjectAddDateTimeFinisch.Size = new System.Drawing.Size(323, 28);
            this.ProjectAddDateTimeFinisch.TabIndex = 7;
            // 
            // ProjectAddNameTextBox
            // 
            this.ProjectAddNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectAddNameTextBox.Location = new System.Drawing.Point(158, 236);
            this.ProjectAddNameTextBox.Name = "ProjectAddNameTextBox";
            this.ProjectAddNameTextBox.Size = new System.Drawing.Size(327, 28);
            this.ProjectAddNameTextBox.TabIndex = 8;
            // 
            // ProjectAddSaveButton
            // 
            this.ProjectAddSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectAddSaveButton.Location = new System.Drawing.Point(355, 550);
            this.ProjectAddSaveButton.Name = "ProjectAddSaveButton";
            this.ProjectAddSaveButton.Size = new System.Drawing.Size(130, 50);
            this.ProjectAddSaveButton.TabIndex = 9;
            this.ProjectAddSaveButton.Text = "Spremi";
            this.ProjectAddSaveButton.UseVisualStyleBackColor = true;
            // 
            // ProjectAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 718);
            this.Controls.Add(this.ProjectAddSaveButton);
            this.Controls.Add(this.ProjectAddNameTextBox);
            this.Controls.Add(this.ProjectAddDateTimeFinisch);
            this.Controls.Add(this.ProjectAddDateTimeStart);
            this.Controls.Add(this.ProjectAddBackBttton);
            this.Controls.Add(this.ProjectAddEmployeeAddButton);
            this.Controls.Add(this.ProjectAddFinish);
            this.Controls.Add(this.ProjectAddStart);
            this.Controls.Add(this.ProjectAddName);
            this.Controls.Add(this.ProjectAddTitle);
            this.Name = "ProjectAdd";
            this.Text = "ProjectAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProjectAddTitle;
        private System.Windows.Forms.Label ProjectAddName;
        private System.Windows.Forms.Label ProjectAddStart;
        private System.Windows.Forms.Label ProjectAddFinish;
        private System.Windows.Forms.Button ProjectAddEmployeeAddButton;
        private System.Windows.Forms.Button ProjectAddBackBttton;
        private System.Windows.Forms.DateTimePicker ProjectAddDateTimeStart;
        private System.Windows.Forms.DateTimePicker ProjectAddDateTimeFinisch;
        private System.Windows.Forms.TextBox ProjectAddNameTextBox;
        private System.Windows.Forms.Button ProjectAddSaveButton;
    }
}