﻿namespace EvaluationSystem
{
    partial class frmStudent
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
            this.cboYearLevel = new System.Windows.Forms.ComboBox();
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.dtg_ABorrowLists = new System.Windows.Forms.DataGridView();
            this.txt_sid = new System.Windows.Forms.TextBox();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.rdio_female = new System.Windows.Forms.RadioButton();
            this.txt_mname = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.rch_address = new System.Windows.Forms.RichTextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.rdio_male = new System.Windows.Forms.RadioButton();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPhoto = new System.Windows.Forms.TextBox();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ABorrowLists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboYearLevel
            // 
            this.cboYearLevel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboYearLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboYearLevel.FormattingEnabled = true;
            this.cboYearLevel.Items.AddRange(new object[] {
            "First",
            "Second",
            "Third",
            "Fourth"});
            this.cboYearLevel.Location = new System.Drawing.Point(490, 241);
            this.cboYearLevel.Name = "cboYearLevel";
            this.cboYearLevel.Size = new System.Drawing.Size(100, 24);
            this.cboYearLevel.TabIndex = 126;
            this.cboYearLevel.Text = "Выбрать";
            // 
            // cboCourse
            // 
            this.cboCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCourse.FormattingEnabled = true;
            this.cboCourse.Location = new System.Drawing.Point(223, 241);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(260, 24);
            this.cboCourse.TabIndex = 125;
            this.cboCourse.Text = "Выбрать";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(936, 206);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 36);
            this.btnClose.TabIndex = 121;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btn_last
            // 
            this.btn_last.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_last.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_last.Location = new System.Drawing.Point(932, 248);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(51, 24);
            this.btn_last.TabIndex = 119;
            this.btn_last.Text = ">>|";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_next
            // 
            this.btn_next.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_next.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(875, 248);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(51, 24);
            this.btn_next.TabIndex = 118;
            this.btn_next.Text = ">>";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_first
            // 
            this.btn_first.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_first.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_first.Location = new System.Drawing.Point(761, 248);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(51, 24);
            this.btn_first.TabIndex = 120;
            this.btn_first.Text = "|<<";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(863, 206);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(68, 36);
            this.btn_delete.TabIndex = 115;
            this.btn_delete.Text = "Удалить";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(758, 206);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(90, 36);
            this.btn_save.TabIndex = 113;
            this.btn_save.Text = "Сохранить";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_prev.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prev.Location = new System.Drawing.Point(818, 248);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(51, 24);
            this.btn_prev.TabIndex = 117;
            this.btn_prev.Text = "<<";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // Label6
            // 
            this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(138, 245);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(78, 20);
            this.Label6.TabIndex = 112;
            this.Label6.Text = "Курс/Год :";
            // 
            // dtg_ABorrowLists
            // 
            this.dtg_ABorrowLists.AllowUserToAddRows = false;
            this.dtg_ABorrowLists.AllowUserToDeleteRows = false;
            this.dtg_ABorrowLists.AllowUserToResizeColumns = false;
            this.dtg_ABorrowLists.AllowUserToResizeRows = false;
            this.dtg_ABorrowLists.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtg_ABorrowLists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_ABorrowLists.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_ABorrowLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ABorrowLists.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_ABorrowLists.Location = new System.Drawing.Point(13, 278);
            this.dtg_ABorrowLists.Name = "dtg_ABorrowLists";
            this.dtg_ABorrowLists.RowHeadersVisible = false;
            this.dtg_ABorrowLists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_ABorrowLists.Size = new System.Drawing.Size(1059, 249);
            this.dtg_ABorrowLists.TabIndex = 111;
            this.dtg_ABorrowLists.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ABorrowLists_CellClick);
            // 
            // txt_sid
            // 
            this.txt_sid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_sid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sid.Location = new System.Drawing.Point(235, 31);
            this.txt_sid.Name = "txt_sid";
            this.txt_sid.Size = new System.Drawing.Size(278, 25);
            this.txt_sid.TabIndex = 97;
            this.txt_sid.TextChanged += new System.EventHandler(this.txt_sid_TextChanged);
            // 
            // txt_fname
            // 
            this.txt_fname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_fname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fname.Location = new System.Drawing.Point(235, 64);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(278, 25);
            this.txt_fname.TabIndex = 98;
            // 
            // rdio_female
            // 
            this.rdio_female.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdio_female.AutoSize = true;
            this.rdio_female.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdio_female.Location = new System.Drawing.Point(299, 214);
            this.rdio_female.Name = "rdio_female";
            this.rdio_female.Size = new System.Drawing.Size(57, 24);
            this.rdio_female.TabIndex = 109;
            this.rdio_female.TabStop = true;
            this.rdio_female.Text = "Жен";
            this.rdio_female.UseVisualStyleBackColor = true;
            // 
            // txt_mname
            // 
            this.txt_mname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_mname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mname.Location = new System.Drawing.Point(235, 122);
            this.txt_mname.Name = "txt_mname";
            this.txt_mname.Size = new System.Drawing.Size(278, 25);
            this.txt_mname.TabIndex = 100;
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(124, 34);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(96, 20);
            this.Label1.TabIndex = 103;
            this.Label1.Text = "ID Студента :";
            // 
            // txt_lname
            // 
            this.txt_lname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_lname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lname.Location = new System.Drawing.Point(235, 94);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(278, 25);
            this.txt_lname.TabIndex = 99;
            // 
            // Label2
            // 
            this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(124, 67);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(46, 20);
            this.Label2.TabIndex = 106;
            this.Label2.Text = "Имя :";
            // 
            // rch_address
            // 
            this.rch_address.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rch_address.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rch_address.Location = new System.Drawing.Point(235, 150);
            this.rch_address.Name = "rch_address";
            this.rch_address.Size = new System.Drawing.Size(278, 58);
            this.rch_address.TabIndex = 102;
            this.rch_address.Text = "";
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(125, 97);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(80, 20);
            this.Label3.TabIndex = 104;
            this.Label3.Text = "Фамилия :";
            // 
            // rdio_male
            // 
            this.rdio_male.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdio_male.AutoSize = true;
            this.rdio_male.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdio_male.Location = new System.Drawing.Point(235, 214);
            this.rdio_male.Name = "rdio_male";
            this.rdio_male.Size = new System.Drawing.Size(58, 24);
            this.rdio_male.TabIndex = 108;
            this.rdio_male.TabStop = true;
            this.rdio_male.Text = "Муж";
            this.rdio_male.UseVisualStyleBackColor = true;
            // 
            // Label4
            // 
            this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(129, 125);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(79, 20);
            this.Label4.TabIndex = 105;
            this.Label4.Text = "Отчество :";
            // 
            // Label5
            // 
            this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(130, 153);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(58, 20);
            this.Label5.TabIndex = 107;
            this.Label5.Text = "Адрес :";
            // 
            // Label9
            // 
            this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(183, 216);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(44, 20);
            this.Label9.TabIndex = 101;
            this.Label9.Text = "Пол :";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox1.Location = new System.Drawing.Point(748, 31);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(256, 169);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 110;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // txtPhoto
            // 
            this.txtPhoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPhoto.Location = new System.Drawing.Point(748, 69);
            this.txtPhoto.Name = "txtPhoto";
            this.txtPhoto.Size = new System.Drawing.Size(209, 20);
            this.txtPhoto.TabIndex = 122;
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 539);
            this.Controls.Add(this.cboYearLevel);
            this.Controls.Add(this.cboCourse);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.dtg_ABorrowLists);
            this.Controls.Add(this.txt_sid);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.rdio_female);
            this.Controls.Add(this.txt_mname);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.rch_address);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.rdio_male);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.txtPhoto);
            this.Name = "frmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Form";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ABorrowLists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cboYearLevel;
        internal System.Windows.Forms.ComboBox cboCourse;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btn_last;
        internal System.Windows.Forms.Button btn_next;
        internal System.Windows.Forms.Button btn_first;
        internal System.Windows.Forms.Button btn_delete;
        internal System.Windows.Forms.Button btn_save;
        internal System.Windows.Forms.Button btn_prev;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.DataGridView dtg_ABorrowLists;
        internal System.Windows.Forms.TextBox txt_sid;
        internal System.Windows.Forms.TextBox txt_fname;
        internal System.Windows.Forms.RadioButton rdio_female;
        internal System.Windows.Forms.TextBox txt_mname;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txt_lname;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.RichTextBox rch_address;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.RadioButton rdio_male;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.TextBox txtPhoto;
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
    }
}