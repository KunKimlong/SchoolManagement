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
        public Home()
        {
            InitializeComponent();
        }

        private void btnGoTeacher_Click(object sender, EventArgs e)
        {
            TeacherFrm teacherFrm = new TeacherFrm();
            this.Close();
            teacherFrm.ShowDialog();
        }

        private void btnGoStudent_Click(object sender, EventArgs e)
        {
            StudentFrm studentFrm = new StudentFrm();
            this.Close();
            studentFrm.ShowDialog();
        }

        private void btnGoClass_Click(object sender, EventArgs e)
        {
            ClassFrm classFrm = new ClassFrm();
            this.Close();
            classFrm.ShowDialog();
        }
    }
}
