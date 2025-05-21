using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace EvaluationSystem
{
    public partial class frmAddGrades : Form
    {
        private readonly string idno;
        private readonly int courseid;
        private readonly string yearLevel;
        private readonly string semester;
        private readonly SQLConfig SC = new SQLConfig();

        public frmAddGrades()
        {
            InitializeComponent();
        }

        public frmAddGrades(string idno, int courseid, string yearLevel, string semester)
        {
            InitializeComponent();
            this.idno = idno;
            this.courseid = courseid;
            this.yearLevel = yearLevel;
            this.semester = semester;

            MessageBox.Show($"frmAddGrades: IdNo={idno}, CourseId={courseid}, YearLevel={yearLevel}, Semester={semester}", "Debug");
            LoadSubjects();
        }

        private void LoadSubjects()
        {
            try
            {
                string sql = "SELECT SubjectId, Subject FROM tblsubject WHERE CourseId=@CourseId AND YearLevel=@YearLevel AND Semester=@Semester";
                SC.singleResult(sql,
                    new MySqlParameter("@CourseId", courseid),
                    new MySqlParameter("@YearLevel", yearLevel),
                    new MySqlParameter("@Semester", semester));

                if (SC.dt != null && SC.dt.Rows.Count > 0)
                {
                    cboSubject.DataSource = SC.dt;
                    cboSubject.ValueMember = "SubjectId";
                    cboSubject.DisplayMember = "Subject";
                }
                else
                {
                    MessageBox.Show("No subjects found for the selected course, year, and semester.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cboSubject.Enabled = false;
                    btnSave.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading subjects: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidatePrerequisite(int subjectId)
        {
            string sql = "SELECT s.PreRequisite FROM tblsubject s WHERE s.SubjectId=@SubjectId";
            SC.singleResult(sql, new MySqlParameter("@SubjectId", subjectId));
            if (SC.dt != null && SC.dt.Rows.Count > 0)
            {
                string prerequisite = SC.dt.Rows[0].Field<string>("PreRequisite");
                if (!string.IsNullOrEmpty(prerequisite) && prerequisite != "None")
                {
                    sql = "SELECT * FROM tblgrades g, tblsubject s WHERE g.SubjectId=s.SubjectId AND g.IdNo=@IdNo AND s.Subject=@PreRequisite AND g.Grades BETWEEN 1 AND 3";
                    int maxrow = SC.maxrow(sql,
                        new MySqlParameter("@IdNo", idno),
                        new MySqlParameter("@PreRequisite", prerequisite));
                    if (maxrow == 0)
                    {
                        MessageBox.Show($"You must pass the prerequisite subject '{prerequisite}' before adding a grade for this subject.", "Prerequisite Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
            }
            return true;
        }

        private void txtaddgrades_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtaddgrades.Text))
                return;

            if (!double.TryParse(txtaddgrades.Text, out double grades) || grades > 5 || grades < 0)
            {
                MessageBox.Show("Grade must be between 0 and 3.", "Invalid Grade", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtaddgrades.Clear();
            }
        }

        private void txtaddgrades_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
        }

        private void txtaddgrades_KeyDown(object sender, KeyEventArgs e)
        {
            // Оставлено пустым, так как не используется
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboSubject.SelectedValue == null)
                {
                    MessageBox.Show("Please select a subject.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtaddgrades.Text))
                {
                    MessageBox.Show("Please enter a grade.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(txtaddgrades.Text, out double grade) || grade < 0 || grade > 5)
                {
                    MessageBox.Show("Grade must be between 0 and 3.", "Invalid Grade", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int subjectId = Convert.ToInt32(cboSubject.SelectedValue);
                if (!ValidatePrerequisite(subjectId))
                {
                    txtaddgrades.Clear();
                    return;
                }

                string sql = "SELECT * FROM tblgrades WHERE CourseId=@CourseId AND IdNo=@IdNo AND SubjectId=@SubjectId AND YearLevel=@YearLevel AND Sem=@Sem";
                int maxrow = SC.maxrow(sql,
                    new MySqlParameter("@CourseId", courseid),
                    new MySqlParameter("@IdNo", idno),
                    new MySqlParameter("@SubjectId", subjectId),
                    new MySqlParameter("@YearLevel", yearLevel),
                    new MySqlParameter("@Sem", semester));

                if (maxrow > 0)
                {
                    MessageBox.Show("A grade for this subject already exists. Use the update function to modify it.", "Duplicate Grade", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                sql = "INSERT INTO tblgrades (CourseId, IdNo, SubjectId, YearLevel, Sem, Grades) " +
                      "VALUES (@CourseId, @IdNo, @SubjectId, @YearLevel, @Sem, @Grades)";
                SC.Execute_CUD(sql, "Error adding grade.", "Grade added successfully.",
                    new MySqlParameter("@CourseId", courseid),
                    new MySqlParameter("@IdNo", idno),
                    new MySqlParameter("@SubjectId", subjectId),
                    new MySqlParameter("@YearLevel", yearLevel),
                    new MySqlParameter("@Sem", semester),
                    new MySqlParameter("@Grades", grade));

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving grade: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}