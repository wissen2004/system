using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace EvaluationSystem
{
    public partial class frmViewCurriculum : Form
    {
        private readonly string idno;
        private readonly int courseid;
        private readonly SQLConfig SC = new SQLConfig();
        private readonly usableFunction UF = new usableFunction();
        private string sql;
        private int maxrow;

        public frmViewCurriculum(string idno, int courseid)
        {
            InitializeComponent();
            this.idno = idno;
            this.courseid = courseid;

            MessageBox.Show($"Constructor: IdNo={idno}, CourseId={courseid}", "Debug");

            if (!ValidateStudent(idno, courseid))
            {
                MessageBox.Show($"Invalid student ID {idno} or course {courseid}.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            load_data(idno, courseid);
        }

        private bool ValidateStudent(string idno, int courseid)
        {
            sql = "SELECT * FROM `tblstudent` s, `tblcourse` c WHERE s.`CourseId`=c.`CourseId` AND s.IdNo=@IdNo AND s.CourseId=@CourseId";
            maxrow = SC.maxrow(sql, new MySqlParameter("@IdNo", idno), new MySqlParameter("@CourseId", courseid));
            MessageBox.Show($"ValidateStudent: IdNo={idno}, CourseId={courseid}, Rows={maxrow}", "Debug");
            return maxrow > 0;
        }

        private void update_Grades(DataGridView dtg)
        {
            foreach (DataGridViewRow row in dtg.Rows)
            {
                if (row.Cells[0].Value == null || row.Cells[6].Value == null) continue;

                sql = "SELECT * FROM `tblgrades` WHERE `GradesId`=@GradesId";
                maxrow = SC.maxrow(sql, new MySqlParameter("@GradesId", row.Cells[0].Value));
                if (maxrow > 0)
                {
                    sql = "UPDATE `tblgrades` SET `Grades`=@Grades WHERE `GradesId`=@GradesId";
                    SC.Execute_Query(sql,
                        new MySqlParameter("@Grades", row.Cells[6].Value),
                        new MySqlParameter("@GradesId", row.Cells[0].Value));
                }
            }
        }

        private void btnViewCurriculum_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(lblcoursId.Text) || !int.TryParse(lblcoursId.Text, out int parsedCourseId))
                {
                    MessageBox.Show("Invalid course ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(idno))
                {
                    MessageBox.Show("Student ID is not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show($"Opening frmPrintCurriculumn: IdNo={idno}, CourseId={parsedCourseId}", "Debug");
                new frmPrintCurriculumn(parsedCourseId, idno).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening curriculum: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtg_enable_cell(DataGridView dtg, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dtg.CurrentCell.ColumnIndex == 6)
            {
                e.Handled = true;
                DataGridViewCell cell = dtg.CurrentRow.Cells[6];
                dtg.CurrentCell = cell;
                dtg.BeginEdit(true);

                sql = "SELECT * FROM `tblgrades` g, `tblsubject` s WHERE g.`SubjectId`=s.`SubjectId` AND g.IdNo=@IdNo AND s.PreRequisite=@PreRequisite AND g.Grades NOT BETWEEN 1 AND 3";
                maxrow = SC.maxrow(sql,
                    new MySqlParameter("@IdNo", idno),
                    new MySqlParameter("@PreRequisite", dtg.CurrentRow.Cells[1].Value ?? ""));
                if (maxrow > 0)
                {
                    MessageBox.Show("You must take the prerequisite of this subject before adding grades.", "Prerequisite Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtg.CurrentRow.Cells[6].Value = "";
                }
            }
        }

        private void dtgFirstYearFirst_KeyDown(object sender, KeyEventArgs e)
        {
            dtg_enable_cell(dtgFirstYearFirst, e);
        }

        private void dtgFirstYearSecond_KeyDown(object sender, KeyEventArgs e)
        {
            dtg_enable_cell(dtgFirstYearSecond, e);
        }

        private void dtgSecondYearFirst_KeyDown(object sender, KeyEventArgs e)
        {
            dtg_enable_cell(dtgSecondYearFirst, e);
        }

        private void dtgSecondYearSecond_KeyDown(object sender, KeyEventArgs e)
        {
            dtg_enable_cell(dtgSecondYearSecond, e);
        }

        private void dtgThirdYearFirst_KeyDown(object sender, KeyEventArgs e)
        {
            dtg_enable_cell(dtgThirdYearFirst, e);
        }

        private void dtgThirdYearSecond_KeyDown(object sender, KeyEventArgs e)
        {
            dtg_enable_cell(dtgThirdYearSecond, e);
        }

        private void dtgFourthYearFirst_KeyDown(object sender, KeyEventArgs e)
        {
            dtg_enable_cell(dtgFourthYearFirst, e);
        }

        private void dtgFourthYearSecond_KeyDown(object sender, KeyEventArgs e)
        {
            dtg_enable_cell(dtgFourthYearSecond, e);
        }

        private void dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 1) // Click on CourseNo. (Subject) column
            {
                DataGridView dtg = sender as DataGridView;
                string yearLevel = GetYearLevelFromGrid(dtg);
                string semester = GetSemesterFromGrid(dtg);

                MessageBox.Show($"Opening frmAddGrades: IdNo={idno}, CourseId={courseid}, YearLevel={yearLevel}, Semester={semester}", "Debug");
                frmAddGrades addGradesForm = new frmAddGrades(idno, courseid, yearLevel, semester);
                addGradesForm.ShowDialog();
                load_data(idno, courseid); // Refresh data after adding grade
            }
        }

        private string GetYearLevelFromGrid(DataGridView dtg)
        {
            if (dtg == dtgFirstYearFirst || dtg == dtgFirstYearSecond) return "First";
            if (dtg == dtgSecondYearFirst || dtg == dtgSecondYearSecond) return "Second";
            if (dtg == dtgThirdYearFirst || dtg == dtgThirdYearSecond) return "Third";
            if (dtg == dtgFourthYearFirst || dtg == dtgFourthYearSecond) return "Fourth";
            return "First"; // Fallback
        }

        private string GetSemesterFromGrid(DataGridView dtg)
        {
            if (dtg == dtgFirstYearFirst || dtg == dtgSecondYearFirst || dtg == dtgThirdYearFirst || dtg == dtgFourthYearFirst) return "First";
            if (dtg == dtgFirstYearSecond || dtg == dtgSecondYearSecond || dtg == dtgThirdYearSecond || dtg == dtgFourthYearSecond) return "Second";
            return "First"; // Fallback
        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            string yearLevel = lblYearLevel.Text;
            string semester = "First";
            MessageBox.Show($"Opening frmAddGrades: IdNo={idno}, CourseId={courseid}, YearLevel={yearLevel}, Semester={semester}", "Debug");
            frmAddGrades addGradesForm = new frmAddGrades(idno, courseid, yearLevel, semester);
            addGradesForm.ShowDialog();
            load_data(idno, courseid);
        }

        private void btnSubjectEnroll_Click(object sender, EventArgs e)
        {
            try
            {
                string yearLevel = lblYearLevel.Text;
                string semester = "First";
                MessageBox.Show($"Opening frmAddGrades for enrollment: IdNo={idno}, CourseId={courseid}, YearLevel={yearLevel}, Semester={semester}", "Debug");
                frmAddGrades addGradesForm = new frmAddGrades(idno, courseid, yearLevel, semester);
                addGradesForm.ShowDialog();
                load_data(idno, courseid);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error enrolling subject: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                update_Grades(dtgFirstYearFirst);
                update_Grades(dtgFirstYearSecond);
                update_Grades(dtgSecondYearFirst);
                update_Grades(dtgSecondYearSecond);
                update_Grades(dtgThirdYearFirst);
                update_Grades(dtgThirdYearSecond);
                update_Grades(dtgFourthYearFirst);
                update_Grades(dtgFourthYearSecond);
                MessageBox.Show("Grades updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MessageBox.Show($"Reloading data: IdNo={idno}, CourseId={courseid}", "Debug");
                load_data(idno, courseid);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating grades: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void load_data(string idno, int courseid)
        {
            try
            {
                MessageBox.Show($"load_data: IdNo={idno}, CourseId={courseid}", "Debug");
                sql = "SELECT * FROM `tblstudent` s, `tblcourse` c WHERE s.`CourseId`=c.`CourseId` AND s.IdNo=@IdNo AND s.CourseId=@CourseId";
                maxrow = SC.maxrow(sql, new MySqlParameter("@IdNo", idno), new MySqlParameter("@CourseId", courseid));
                if (maxrow > 0)
                {
                    lblName.Text = $"{SC.dt.Rows[0].Field<string>("Firstname")} {SC.dt.Rows[0].Field<string>("Lastname")}";
                    lblCourse.Text = SC.dt.Rows[0].Field<string>("Course");
                    lblYearLevel.Text = SC.dt.Rows[0].Field<string>("YearLevel");
                    lblIdNo.Text = SC.dt.Rows[0].Field<string>("IdNo");
                    lblSemester.Text = SC.dt.Rows[0].Field<string>("YearLevel"); // Consider using actual Semester if available
                    lblcoursId.Text = courseid.ToString();

                    LoadGridData(dtgFirstYearFirst, "First", "First");
                    LoadGridData(dtgFirstYearSecond, "First", "Second");
                    LoadGridData(dtgSecondYearFirst, "Second", "First");
                    LoadGridData(dtgSecondYearSecond, "Second", "Second");
                    LoadGridData(dtgThirdYearFirst, "Third", "First");
                    LoadGridData(dtgThirdYearSecond, "Third", "Second");
                    LoadGridData(dtgFourthYearFirst, "Fourth", "First");
                    LoadGridData(dtgFourthYearSecond, "Fourth", "Second");
                }
                else
                {
                    MessageBox.Show($"Id number {idno} is not registered for course {courseid}.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadGridData(DataGridView dtg, string yearLevel, string semester)
        {
            sql = "SELECT g.GradesId, s.`Subject` as 'CourseNo.', s.`DescriptiveTitle`, s.`LecUnit`, s.`LabUnit`, s.`PreRequisite`, g.Grades " +
                  "FROM `tblsubject` s, `tblgrades` g WHERE s.`SubjectId`=g.`SubjectId` " +
                  "AND g.`CourseId`=@CourseId AND g.YearLevel=@YearLevel AND g.Sem=@Sem AND g.IdNo=@IdNo";
            SC.Load_DTG(sql, dtg,
                new MySqlParameter("@CourseId", courseid),
                new MySqlParameter("@YearLevel", yearLevel),
                new MySqlParameter("@Sem", semester),
                new MySqlParameter("@IdNo", idno));
            if (dtg.Columns.Count > 0)
                dtg.Columns[0].Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmViewCurriculum_Load(object sender, EventArgs e)
        {
            dtgFirstYearFirst.CellContentClick += dtg_CellContentClick;
            dtgFirstYearSecond.CellContentClick += dtg_CellContentClick;
            dtgSecondYearFirst.CellContentClick += dtg_CellContentClick;
            dtgSecondYearSecond.CellContentClick += dtg_CellContentClick;
            dtgThirdYearFirst.CellContentClick += dtg_CellContentClick;
            dtgThirdYearSecond.CellContentClick += dtg_CellContentClick;
            dtgFourthYearFirst.CellContentClick += dtg_CellContentClick;
            dtgFourthYearSecond.CellContentClick += dtg_CellContentClick;
        }
    }
}