using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace EvaluationSystem
{
    public partial class frmPrintCurriculumn : Form
    {
        private readonly int courseid;
        private readonly string idno;
        private readonly SQLConfig SC = new SQLConfig();

        public frmPrintCurriculumn(int courseid, string idno)
        {
            InitializeComponent();
            this.courseid = courseid;
            this.idno = idno;

            // Debug constructor inputs
            MessageBox.Show($"Constructor: IdNo={idno}, CourseId={courseid}", "Debug");
            LoadReport();
        }

        private void LoadReport()
        {
            try
            {
                string reportPath = @"reports\StudentCurriculum.rdlc";
                if (!File.Exists(reportPath))
                {
                    MessageBox.Show($"RDLC file not found at: {Path.GetFullPath(reportPath)}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                reportViewer1.LocalReport.ReportPath = reportPath;
                reportViewer1.LocalReport.DataSources.Clear();

                string sql = "SELECT s.Subject, s.DescriptiveTitle, s.LecUnit, s.LabUnit, s.PreRequisite, s.YearLevel, s.Semester, g.Grades, " +
                             "st.Firstname, st.Lastname, st.MI, st.HomeAddress, st.Sex, c.Course " +
                             "FROM tblsubject s, tblgrades g, tblstudent st, tblcourse c " +
                             "WHERE s.SubjectId=g.SubjectId AND g.IdNo=st.IdNo AND g.CourseId=c.CourseId " +
                             "AND c.CourseId=@CourseId AND g.IdNo=@IdNo";

                // Debug parameters
                MessageBox.Show($"SQL Parameters: CourseId={courseid}, IdNo={idno}", "Debug");

                DataTable dt = SC.Load_Data(sql,
                    new MySqlParameter("@CourseId", courseid),
                    new MySqlParameter("@IdNo", idno));

                MessageBox.Show($"Rows returned: {dt?.Rows.Count ?? 0}", "Debug");

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("No data found for selected student.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ReportDataSource rds = new ReportDataSource("DataSet1", dt);
                reportViewer1.LocalReport.DataSources.Add(rds);

                // Set report parameters with debug
                ReportParameter courseIdParam = new ReportParameter("CourseId", courseid.ToString());
                ReportParameter idNoParam = new ReportParameter("IdNo", idno);
                reportViewer1.LocalReport.SetParameters(new[] { courseIdParam, idNoParam });

                MessageBox.Show($"Parameters set: CourseId={courseid}, IdNo={idno}", "Debug");

                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading report: {ex.Message}\nStack Trace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPrintCurriculumn_Load(object sender, EventArgs e)
        {
        }
    }
}