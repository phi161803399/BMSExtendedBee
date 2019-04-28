namespace BeehiveManagementSystemExtendWithBeeClass
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbWorkerBeeJob = new System.Windows.Forms.ComboBox();
            this.btnWorkNextShift = new System.Windows.Forms.Button();
            this.txtReport = new System.Windows.Forms.TextBox();
            this.lblJob = new System.Windows.Forms.Label();
            this.shifts = new System.Windows.Forms.NumericUpDown();
            this.lblShifts = new System.Windows.Forms.Label();
            this.btnAssignJob = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAssignJob);
            this.groupBox1.Controls.Add(this.lblShifts);
            this.groupBox1.Controls.Add(this.shifts);
            this.groupBox1.Controls.Add(this.lblJob);
            this.groupBox1.Controls.Add(this.cmbWorkerBeeJob);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Bee Assignments";
            // 
            // cmbWorkerBeeJob
            // 
            this.cmbWorkerBeeJob.FormattingEnabled = true;
            this.cmbWorkerBeeJob.Items.AddRange(new object[] {
            "Nectar collector",
            "Honey manufacturing",
            "Egg care",
            "Baby bee tutoring",
            "Hive maintenance",
            "Sting patrol"});
            this.cmbWorkerBeeJob.Location = new System.Drawing.Point(29, 38);
            this.cmbWorkerBeeJob.Name = "cmbWorkerBeeJob";
            this.cmbWorkerBeeJob.Size = new System.Drawing.Size(305, 21);
            this.cmbWorkerBeeJob.TabIndex = 1;
            // 
            // btnWorkNextShift
            // 
            this.btnWorkNextShift.Location = new System.Drawing.Point(666, 12);
            this.btnWorkNextShift.Name = "btnWorkNextShift";
            this.btnWorkNextShift.Size = new System.Drawing.Size(206, 148);
            this.btnWorkNextShift.TabIndex = 0;
            this.btnWorkNextShift.Text = "Work the next shift";
            this.btnWorkNextShift.UseVisualStyleBackColor = true;
            this.btnWorkNextShift.Click += new System.EventHandler(this.btnWorkNextShift_Click);
            // 
            // txtReport
            // 
            this.txtReport.Location = new System.Drawing.Point(12, 166);
            this.txtReport.Multiline = true;
            this.txtReport.Name = "txtReport";
            this.txtReport.Size = new System.Drawing.Size(860, 383);
            this.txtReport.TabIndex = 1;
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(26, 16);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(24, 13);
            this.lblJob.TabIndex = 2;
            this.lblJob.Text = "Job";
            // 
            // shifts
            // 
            this.shifts.Location = new System.Drawing.Point(340, 38);
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(120, 20);
            this.shifts.TabIndex = 3;
            // 
            // lblShifts
            // 
            this.lblShifts.AutoSize = true;
            this.lblShifts.Location = new System.Drawing.Point(337, 16);
            this.lblShifts.Name = "lblShifts";
            this.lblShifts.Size = new System.Drawing.Size(33, 13);
            this.lblShifts.TabIndex = 4;
            this.lblShifts.Text = "Shifts";
            // 
            // btnAssignJob
            // 
            this.btnAssignJob.Location = new System.Drawing.Point(29, 66);
            this.btnAssignJob.Name = "btnAssignJob";
            this.btnAssignJob.Size = new System.Drawing.Size(431, 23);
            this.btnAssignJob.TabIndex = 5;
            this.btnAssignJob.Text = "Assign this job to a bee";
            this.btnAssignJob.UseVisualStyleBackColor = true;
            this.btnAssignJob.Click += new System.EventHandler(this.btnAssignJob_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.txtReport);
            this.Controls.Add(this.btnWorkNextShift);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Beehive Management System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbWorkerBeeJob;
        private System.Windows.Forms.Button btnWorkNextShift;
        private System.Windows.Forms.TextBox txtReport;
        private System.Windows.Forms.Button btnAssignJob;
        private System.Windows.Forms.Label lblShifts;
        private System.Windows.Forms.NumericUpDown shifts;
        private System.Windows.Forms.Label lblJob;
    }
}

