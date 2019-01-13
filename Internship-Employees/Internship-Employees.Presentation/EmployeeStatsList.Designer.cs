namespace Internship_Employees.Presentation
{
    partial class EmployeeStatsList
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
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeStatsListView = new System.Windows.Forms.ListView();
            this.EmployeeStatsBckButton = new System.Windows.Forms.Button();
            this.EmployeeStatsEditButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(598, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nešto d.o.o.  -   Pregled svih zaposlenika";
            // 
            // EmployeeStatsListView
            // 
            this.EmployeeStatsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeStatsListView.Location = new System.Drawing.Point(37, 146);
            this.EmployeeStatsListView.Name = "EmployeeStatsListView";
            this.EmployeeStatsListView.Size = new System.Drawing.Size(935, 495);
            this.EmployeeStatsListView.TabIndex = 1;
            this.EmployeeStatsListView.UseCompatibleStateImageBehavior = false;
            // 
            // EmployeeStatsBckButton
            // 
            this.EmployeeStatsBckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeStatsBckButton.Location = new System.Drawing.Point(358, 680);
            this.EmployeeStatsBckButton.Name = "EmployeeStatsBckButton";
            this.EmployeeStatsBckButton.Size = new System.Drawing.Size(165, 44);
            this.EmployeeStatsBckButton.TabIndex = 2;
            this.EmployeeStatsBckButton.Text = "Nazad";
            this.EmployeeStatsBckButton.UseVisualStyleBackColor = true;
            this.EmployeeStatsBckButton.Click += new System.EventHandler(this.EmployeeStatsBckButton_Click);
            // 
            // EmployeeStatsEditButton
            // 
            this.EmployeeStatsEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeStatsEditButton.Location = new System.Drawing.Point(561, 680);
            this.EmployeeStatsEditButton.Name = "EmployeeStatsEditButton";
            this.EmployeeStatsEditButton.Size = new System.Drawing.Size(130, 44);
            this.EmployeeStatsEditButton.TabIndex = 3;
            this.EmployeeStatsEditButton.Text = "Uredi";
            this.EmployeeStatsEditButton.UseVisualStyleBackColor = true;
            this.EmployeeStatsEditButton.Click += new System.EventHandler(this.EmployeeStatsEditButton_Click);
            // 
            // EmployeeStatsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 753);
            this.Controls.Add(this.EmployeeStatsEditButton);
            this.Controls.Add(this.EmployeeStatsBckButton);
            this.Controls.Add(this.EmployeeStatsListView);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeStatsList";
            this.Text = "EmployeeStatsList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView EmployeeStatsListView;
        private System.Windows.Forms.Button EmployeeStatsBckButton;
        private System.Windows.Forms.Button EmployeeStatsEditButton;
    }
}