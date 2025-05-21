namespace EvaluationSystem
{
    partial class frmAddGrades
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtaddgrades = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.cboSubject = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtaddgrades
            // 
            this.txtaddgrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddgrades.Location = new System.Drawing.Point(12, 80);
            this.txtaddgrades.MaxLength = 3;
            this.txtaddgrades.Name = "txtaddgrades";
            this.txtaddgrades.Size = new System.Drawing.Size(378, 45);
            this.txtaddgrades.TabIndex = 14;
            this.txtaddgrades.TextChanged += new System.EventHandler(this.txtaddgrades_TextChanged);
            this.txtaddgrades.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtaddgrades_KeyDown);
            this.txtaddgrades.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtaddgrades_KeyPress);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(12, 30);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(83, 20);
            this.lblSubject.TabIndex = 15;
            this.lblSubject.Text = "Предмет:";
            // 
            // cboSubject
            // 
            this.cboSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubject.Location = new System.Drawing.Point(90, 30);
            this.cboSubject.Name = "cboSubject";
            this.cboSubject.Size = new System.Drawing.Size(310, 21);
            this.cboSubject.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(210, 130);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(300, 130);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 170);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.txtaddgrades);
            this.Name = "frmAddGrades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Grades Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal System.Windows.Forms.TextBox txtaddgrades;
        internal System.Windows.Forms.Label lblSubject;
        internal System.Windows.Forms.ComboBox cboSubject;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Button btnCancel;
    }
}