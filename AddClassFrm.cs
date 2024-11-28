using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SchoolManagement
{
    public partial class AddClassFrm : Form
    {
        private string connectionString = ConnectToDB.connectionString;

        public AddClassFrm()
        {
            InitializeComponent();
        }
        public List<KeyValuePair<int, string>> FetchTeachers()
        {
            var teachers = new List<KeyValuePair<int, string>>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id, first_name, last_name, gender FROM teachers";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("id");
                        string firstName = reader.GetString("first_name");
                        string lastName = reader.GetString("last_name");
                        string gender = reader.GetString("gender");

                        // Prefix name with "Mr." or "Ms." based on gender
                        string prefix = gender == "Male" ? "Mr." : "Ms.";
                        string fullName = $"{prefix} {firstName} {lastName}";

                        // Add to the list as KeyValuePair
                        teachers.Add(new KeyValuePair<int, string>(id, fullName));
                    }
                }
            }
            return teachers;
        }

        public List<KeyValuePair<int, string>> FetchCourses(string tbName)
            {
                var courses = new List<KeyValuePair<int, string>>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT id, name FROM "+tbName; // Replace with your table and column names
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("id");
                        string name = reader.GetString("name");
                        courses.Add(new KeyValuePair<int, string>(id, name));
                    }
                }
            }
                return courses;
            }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            if (string.IsNullOrWhiteSpace(name) ||
                courseCbo.SelectedValue == null ||
                roomIdCbo.SelectedValue == null ||
                teacherIdCbo.SelectedValue == null)
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }

            int courseId = (int)courseCbo.SelectedValue;
            int roomId = (int)roomIdCbo.SelectedValue;
            int teacherId = (int)teacherIdCbo.SelectedValue;
            DateTime startDate = dateSart.Value;
            DateTime endDate = dateEnd.Value;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO classes (name, course_id, room_id, teacher_id, start_date, end_date) " +
                               "VALUES (@Name, @CourseID, @RoomID, @TeacherID, @StartDate, @EndDate)";

                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = name;
                command.Parameters.Add("@CourseID", MySqlDbType.Int32).Value = courseId;
                command.Parameters.Add("@RoomID", MySqlDbType.Int32).Value = roomId;
                command.Parameters.Add("@TeacherID", MySqlDbType.Int32).Value = teacherId;
                command.Parameters.Add("@StartDate", MySqlDbType.DateTime).Value = startDate;
                command.Parameters.Add("@EndDate", MySqlDbType.DateTime).Value = endDate;

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Class added successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void AddClassFrm_Load(object sender, EventArgs e)
        {
            var courses = FetchCourses("courses");

            courseCbo.DataSource = courses;
            courseCbo.DisplayMember = "Value"; 
            courseCbo.ValueMember = "Key";   

            var rooms = FetchCourses("rooms");

            roomIdCbo.DataSource = rooms;
            roomIdCbo.DisplayMember = "Value"; 
            roomIdCbo.ValueMember = "Key";  

            // Fetch the list of teachers
            var teachers = FetchTeachers();
            // Bind the data to the ComboBox
            teacherIdCbo.DataSource = teachers;
            teacherIdCbo.DisplayMember = "Value"; 
            teacherIdCbo.ValueMember = "Key";    
        }
        private void clearText()
        {
            nameTxt.Text = "";
            courseCbo.Text = "";
            roomIdCbo.Text = "";
            teacherIdCbo.Text= "";
            dateSart.Text= DateTime.Now.ToString();
            dateEnd.Text= DateTime.Now.ToString();

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.clearText();
        }
    }
}
