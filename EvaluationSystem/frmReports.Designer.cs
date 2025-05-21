namespace EvaluationSystem
{
    partial class frmReports
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnCurriculum = new System.Windows.Forms.Button();
            this.btnListStudents = new System.Windows.Forms.Button();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(954, 476);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnCurriculum
            // 
            this.btnCurriculum.Location = new System.Drawing.Point(12, 482);
            this.btnCurriculum.Name = "btnCurriculum";
            this.btnCurriculum.Size = new System.Drawing.Size(100, 30);
            this.btnCurriculum.TabIndex = 1;
            this.btnCurriculum.Text = "Curriculum";
            this.btnCurriculum.UseVisualStyleBackColor = true;
            this.btnCurriculum.Click += new System.EventHandler(this.btnCurriculum_Click);
            // 
            // btnListStudents
            // 
            this.btnListStudents.Location = new System.Drawing.Point(118, 482);
            this.btnListStudents.Name = "btnListStudents";
            this.btnListStudents.Size = new System.Drawing.Size(100, 30);
            this.btnListStudents.TabIndex = 2;
            this.btnListStudents.Text = "List Students";
            this.btnListStudents.UseVisualStyleBackColor = true;
            this.btnListStudents.Click += new System.EventHandler(this.btnListStudents_Click);
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(224, 486);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(200, 20);
            this.txtCourse.TabIndex = 3;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 518);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.btnListStudents);
            this.Controls.Add(this.btnCurriculum);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnCurriculum;
        private System.Windows.Forms.Button btnListStudents;
        private System.Windows.Forms.TextBox txtCourse;
    }
}