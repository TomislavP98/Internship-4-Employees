namespace Internship_Employees.Presentation
{
    partial class EmployeeMenu
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
            this.EmployeeMenuTitle = new System.Windows.Forms.Label();
            this.EmployeeListEditButton = new System.Windows.Forms.Button();
            this.EmployeeAddButton = new System.Windows.Forms.Button();
            this.EmployeeDeleteButton = new System.Windows.Forms.Button();
            this.EmployeeMenuBackButton = new System.Windows.Forms.Button();
            this.EmployeeMenucheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // EmployeeMenuTitle
            // 
            this.EmployeeMenuTitle.AutoSize = true;
            this.EmployeeMenuTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeMenuTitle.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.EmployeeMenuTitle.Location = new System.Drawing.Point(210, 54);
            this.EmployeeMenuTitle.Name = "EmployeeMenuTitle";
            this.EmployeeMenuTitle.Size = new System.Drawing.Size(425, 40);
            this.EmployeeMenuTitle.TabIndex = 0;
            this.EmployeeMenuTitle.Text = "Nešto d.o.o. - Zaposlenici";
            // 
            // EmployeeListEditButton
            // 
            this.EmployeeListEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeListEditButton.Location = new System.Drawing.Point(217, 486);
            this.EmployeeListEditButton.Name = "EmployeeListEditButton";
            this.EmployeeListEditButton.Size = new System.Drawing.Size(179, 51);
            this.EmployeeListEditButton.TabIndex = 1;
            this.EmployeeListEditButton.Text = "Uredi";
            this.EmployeeListEditButton.UseVisualStyleBackColor = true;
            this.EmployeeListEditButton.Click += new System.EventHandler(this.EmployeeListButton_Click);
            // 
            // EmployeeAddButton
            // 
            this.EmployeeAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeAddButton.Location = new System.Drawing.Point(12, 479);
            this.EmployeeAddButton.Name = "EmployeeAddButton";
            this.EmployeeAddButton.Size = new System.Drawing.Size(185, 62);
            this.EmployeeAddButton.TabIndex = 2;
            this.EmployeeAddButton.Text = "Dodavanje novog zaposlenika";
            this.EmployeeAddButton.UseVisualStyleBackColor = true;
            this.EmployeeAddButton.Click += new System.EventHandler(this.EmployeeAddButton_Click);
            // 
            // EmployeeDeleteButton
            // 
            this.EmployeeDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeDeleteButton.Location = new System.Drawing.Point(418, 484);
            this.EmployeeDeleteButton.Name = "EmployeeDeleteButton";
            this.EmployeeDeleteButton.Size = new System.Drawing.Size(230, 52);
            this.EmployeeDeleteButton.TabIndex = 4;
            this.EmployeeDeleteButton.Text = "Otpustanje zaposlenika";
            this.EmployeeDeleteButton.UseVisualStyleBackColor = true;
            this.EmployeeDeleteButton.Click += new System.EventHandler(this.EmployeeDeleteButton_Click);
            // 
            // EmployeeMenuBackButton
            // 
            this.EmployeeMenuBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeMenuBackButton.Location = new System.Drawing.Point(664, 486);
            this.EmployeeMenuBackButton.Name = "EmployeeMenuBackButton";
            this.EmployeeMenuBackButton.Size = new System.Drawing.Size(165, 50);
            this.EmployeeMenuBackButton.TabIndex = 5;
            this.EmployeeMenuBackButton.Text = "Nazad";
            this.EmployeeMenuBackButton.UseVisualStyleBackColor = true;
            this.EmployeeMenuBackButton.Click += new System.EventHandler(this.EmployeeMenuBackButton_Click);
            // 
            // EmployeeMenucheckedListBox
            // 
            this.EmployeeMenucheckedListBox.FormattingEnabled = true;
            this.EmployeeMenucheckedListBox.Location = new System.Drawing.Point(58, 124);
            this.EmployeeMenucheckedListBox.Name = "EmployeeMenucheckedListBox";
            this.EmployeeMenucheckedListBox.Size = new System.Drawing.Size(745, 340);
            this.EmployeeMenucheckedListBox.TabIndex = 6;
            // 
            // EmployeeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 574);
            this.Controls.Add(this.EmployeeMenucheckedListBox);
            this.Controls.Add(this.EmployeeMenuBackButton);
            this.Controls.Add(this.EmployeeDeleteButton);
            this.Controls.Add(this.EmployeeAddButton);
            this.Controls.Add(this.EmployeeListEditButton);
            this.Controls.Add(this.EmployeeMenuTitle);
            this.Name = "EmployeeMenu";
            this.Text = "EmployeeMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeeMenuTitle;
        private System.Windows.Forms.Button EmployeeListEditButton;
        private System.Windows.Forms.Button EmployeeAddButton;
        private System.Windows.Forms.Button EmployeeDeleteButton;
        private System.Windows.Forms.Button EmployeeMenuBackButton;
        private System.Windows.Forms.CheckedListBox EmployeeMenucheckedListBox;
    }
}