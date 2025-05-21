using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationSystem
{
    public partial class frmFinstudents : Form
    {
        public frmFinstudents()
        {
            InitializeComponent();
        }
        SQLConfig SC = new SQLConfig();
        usableFunction UF = new usableFunction();
        string sql;
        int maxrow, inc;
        string idno; // Changed to string
        int courseid;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFinstudents_Load(object sender, EventArgs e)
        {
            TextBox1_TextChanged(sender, e);
        }

        private void btnAddGrades_Click(object sender, EventArgs e)
        {
            if (dtgList.CurrentRow != null)
            {
                idno = dtgList.CurrentRow.Cells[0].Value.ToString(); // Keep as string
                courseid = int.Parse(dtgList.CurrentRow.Cells[8].Value.ToString());
                MessageBox.Show(idno); // Debug: Show idno as string

                Form frm = new frmPrintCurriculumn(courseid, idno); // Pass idno as string
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a student.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT `IdNo`, `Firstname`, `Lastname`, `MI`, `HomeAddress`, `Sex`, `Course`, `YearLevel`, c.CourseId " +
                  "FROM `tblstudent` s, `tblcourse` c " +
                  "WHERE s.`CourseId`=c.`CourseId` AND (`Firstname` LIKE @Search OR `Lastname` LIKE @Search OR `IdNo` LIKE @Search)";
            SC.Load_DTG(sql, dtgList, new MySqlParameter("@Search", "%" + TextBox1.Text + "%"));
            dtgList.Columns[8].Visible = false;
        }
    }
}