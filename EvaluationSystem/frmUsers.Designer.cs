namespace EvaluationSystem
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.dtg_listUser = new System.Windows.Forms.DataGridView();
            this.Label5 = new System.Windows.Forms.Label();
            this.btn_saveuser = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.cbo_type = new System.Windows.Forms.ComboBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_listUser
            // 
            this.dtg_listUser.AllowUserToAddRows = false;
            this.dtg_listUser.AllowUserToDeleteRows = false;
            this.dtg_listUser.AllowUserToResizeColumns = false;
            this.dtg_listUser.AllowUserToResizeRows = false;
            this.dtg_listUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_listUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_listUser.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_listUser.Location = new System.Drawing.Point(13, 200);
            this.dtg_listUser.Name = "dtg_listUser";
            this.dtg_listUser.RowHeadersVisible = false;
            this.dtg_listUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_listUser.Size = new System.Drawing.Size(622, 250);
            this.dtg_listUser.TabIndex = 59;
            this.dtg_listUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_listUser_CellClick);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(113, 10);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(529, 42);
            this.Label5.TabIndex = 58;
            this.Label5.Text = "Управление пользователями";
            // 
            // btn_saveuser
            // 
            this.btn_saveuser.BackColor = System.Drawing.Color.Transparent;
            this.btn_saveuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_saveuser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveuser.Location = new System.Drawing.Point(13, 456);
            this.btn_saveuser.Name = "btn_saveuser";
            this.btn_saveuser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_saveuser.Size = new System.Drawing.Size(84, 30);
            this.btn_saveuser.TabIndex = 50;
            this.btn_saveuser.Text = "Сохранить";
            this.btn_saveuser.UseVisualStyleBackColor = false;
            this.btn_saveuser.Click += new System.EventHandler(this.btn_saveuser_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update.Enabled = false;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(98, 456);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(76, 30);
            this.btn_update.TabIndex = 52;
            this.btn_update.Text = "Обновить";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(341, 456);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 30);
            this.btnClose.TabIndex = 54;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btn_New
            // 
            this.btn_New.BackColor = System.Drawing.Color.Transparent;
            this.btn_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_New.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.Location = new System.Drawing.Point(260, 456);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(76, 30);
            this.btn_New.TabIndex = 55;
            this.btn_New.Text = "Новый";
            this.btn_New.UseVisualStyleBackColor = false;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.White;
            this.Label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Image = ((System.Drawing.Image)(resources.GetObject("Label4.Image")));
            this.Label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label4.Location = new System.Drawing.Point(106, 162);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(42, 20);
            this.Label4.TabIndex = 53;
            this.Label4.Text = "Тип :";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(187, 81);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(322, 25);
            this.txt_name.TabIndex = 44;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.White;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Image = ((System.Drawing.Image)(resources.GetObject("Label3.Image")));
            this.Label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label3.Location = new System.Drawing.Point(104, 136);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(69, 20);
            this.Label3.TabIndex = 51;
            this.Label3.Text = "Пароль :";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(187, 108);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(322, 25);
            this.txt_username.TabIndex = 45;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.White;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Image = ((System.Drawing.Image)(resources.GetObject("Label2.Image")));
            this.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label2.Location = new System.Drawing.Point(45, 110);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(146, 20);
            this.Label2.TabIndex = 48;
            this.Label2.Text = "Имя пользователя :";
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(187, 136);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(322, 25);
            this.txt_pass.TabIndex = 46;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.White;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label1.Location = new System.Drawing.Point(107, 84);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(46, 20);
            this.Label1.TabIndex = 47;
            this.Label1.Text = "Имя :";
            // 
            // cbo_type
            // 
            this.cbo_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_type.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_type.FormattingEnabled = true;
            this.cbo_type.Items.AddRange(new object[] {
            "Administrator",
            "Faculty"});
            this.cbo_type.Location = new System.Drawing.Point(187, 164);
            this.cbo_type.Name = "cbo_type";
            this.cbo_type.Size = new System.Drawing.Size(173, 25);
            this.cbo_type.TabIndex = 49;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(182, 60);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(22, 20);
            this.lbl_id.TabIndex = 56;
            this.lbl_id.Text = "id";
            this.lbl_id.Visible = false;
            // 
            // btn_delete
            // 
            this.btn_delete.Enabled = false;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(178, 456);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(76, 30);
            this.btn_delete.TabIndex = 57;
            this.btn_delete.Text = "Удалить";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 497);
            this.Controls.Add(this.dtg_listUser);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.btn_saveuser);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cbo_type);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_delete);
            this.Name = "frmUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users Form";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dtg_listUser;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button btn_saveuser;
        internal System.Windows.Forms.Button btn_update;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btn_New;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txt_name;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txt_username;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txt_pass;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cbo_type;
        internal System.Windows.Forms.Label lbl_id;
        internal System.Windows.Forms.Button btn_delete;
    }
}