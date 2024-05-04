using C24015375.Implementations;
using C24015375.Models;
using System;
using System.Windows.Forms;

namespace C24015375
{
    public partial class Form1 : Form
    {
        private readonly University _university = University.Instance;

        public Form1()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            // Add internal students
            _university.AddStudent(new InternalStudent(1, "John", new InClassAttendance(), new MasseyLabType()));
            _university.AddStudent(new InternalStudent(2, "Mary", new InClassAttendance(), new MasseyLabType()));

            // Add distance students
            _university.AddStudent(new DistanceStudent(3, "Tom", new OnlineAttendance(), new CloudLabType()));
            _university.AddStudent(new DistanceStudent(4, "Kate", new OnlineAttendance(), new CloudLabType()));
        }
        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            // Clear existing rows in DataGridView
            dataGridView1.Rows.Clear();

            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("colStudentID", "Student ID");
                dataGridView1.Columns.Add("colStudentName", "Student Name");
                dataGridView1.Columns.Add("colAttendanceType", "Attendance Type");
                dataGridView1.Columns.Add("colLabType", "Lab Type");
            }

            // Display students in DataGridView
            foreach (var student in _university.Students)
            {
                int rowIndex = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                row.Cells["colStudentID"].Value = student.StudentID;
                row.Cells["colStudentName"].Value = student.StudentName;
                row.Cells["colAttendanceType"].Value = student.AttendanceType.GetAttendanceType();
                row.Cells["colLabType"].Value = student.LabType.GetLabType();
            }
            label1.Text = "Massey University";
        }

        private DataGridView dataGridView1;
        private Label label1;
        private Button button1;
    }
}
