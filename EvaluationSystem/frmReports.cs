using Microsoft.Reporting.WinForms;
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
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }
        SQLConfig SC = new SQLConfig();
        usableFunction UF = new usableFunction();
        string sql;
        int maxrow, inc, idno, courseid;

        private void btnCurriculum_Click(object sender, EventArgs e)
        {
            sql = "SELECT s.*, c.Course FROM tblsubject s, tblcourse c WHERE s.CourseId=c.CourseId AND c.Course LIKE @Course";
            reports(sql, "Curriculum", new MySqlParameter("@Course", "%" + txtCourse.Text + "%"));
        }

        private void btnListStudents_Click(object sender, EventArgs e)
        {
            sql = "SELECT s.`IdNo`, s.`Firstname`, s.`Lastname`, s.`MI`, s.`HomeAddress`, s.`Sex`, c.Course, s.`YearLevel` " +
                  "FROM `tblstudent` s, tblcourse c WHERE s.`CourseId`=c.`CourseId`";
            reports(sql, "ListStudents");
        }

        private void reports(string sql, string rptname, params MySqlParameter[] parameters)
        {
            try
            {
                // Load data using SQLConfig
                SC.loadReports(sql, parameters);
                if (SC.dt == null || SC.dt.Rows.Count == 0)
                {
                    MessageBox.Show("No data found for the report.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Reset ReportViewer
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.ReportPath = System.IO.Path.Combine(Application.StartupPath, "reports", rptname + ".rdlc");

                // Set data source for the report
                ReportDataSource rds = new ReportDataSource
                {
                    Name = rptname + "Data", // Matches the dataset name in the RDLC file
                    Value = SC.dt
                };
                reportViewer1.LocalReport.DataSources.Add(rds);

                // Refresh the report
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading report: {ex.Message}", "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            // Ensure the ReportViewer is in local mode
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            this.reportViewer1.RefreshReport();
        }
    }
}