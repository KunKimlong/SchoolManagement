using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class Home : Form
    {
        private string firstName;
        private string lastName;
        private string gender;

        public Home(string firstName, string lastName, string gender)
        {
            InitializeComponent();
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
        }

        private void btnGoTeacher_Click(object sender, EventArgs e)
        {
            TeacherFrm teacherFrm = new TeacherFrm();
            this.Hide();
            teacherFrm.ShowDialog();
            this.Show();
        }

        private void btnGoStudent_Click(object sender, EventArgs e)
        {
            StudentFrm studentFrm = new StudentFrm();
            this.Hide();
            studentFrm.ShowDialog();
            this.Show();
        }

        private void btnGoClass_Click(object sender, EventArgs e)
        {
            ClassFrm classFrm = new ClassFrm();
            this.Hide();
            classFrm.ShowDialog();
            this.Show();
        }

        private void btnGoCourses_Click(object sender, EventArgs e)
        {
            CourseManagementFrm courseManagementFrm = new CourseManagementFrm();
            this.Hide();
            courseManagementFrm.ShowDialog();
            this.Show();
        }

        private void btnGoManageRoom_Click(object sender, EventArgs e)
        {
            RoomManagement roomManagement = new RoomManagement();
            this.Hide();
            roomManagement.ShowDialog();
            this.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            string title = (gender.ToLower() == "male") ? "Mr." : "Ms.";
            WelcomeLabel1.Text = $"Welcome, {title} {firstName} {lastName}!";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }
    }
}
