using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class AddStudentFrm : Form
    {
        private string connectionString = ConnectToDB.connectionString;
            private void LoadComboBoxData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string classQuery = "SELECT id, name FROM classes";
                    using (MySqlDataAdapter classAdapter = new MySqlDataAdapter(classQuery, conn))
                    {
                        DataTable classTable = new DataTable();
                        classAdapter.Fill(classTable);

                        classCbo.DataSource = classTable;
                        classCbo.DisplayMember = "name";
                        classCbo.ValueMember = "id";
                        classCbo.SelectedIndex = -1;
                    }
                    string courseQuery = "SELECT id, name FROM courses";
                    using (MySqlDataAdapter courseAdapter = new MySqlDataAdapter(courseQuery, conn))
                    {
                        DataTable courseTable = new DataTable();
                        courseAdapter.Fill(courseTable);

                        courseCbo.DataSource = courseTable;
                        courseCbo.DisplayMember = "name";
                        courseCbo.ValueMember = "id";
                        courseCbo.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public AddStudentFrm()
        {
            InitializeComponent();
            LoadComboBoxData();
        }
        public int InsertStudent()
        {
            
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string insertStudentQuery = "INSERT INTO students (first_name, last_name, gender, class_id, phone_number, created_at, updated_at) " +
                                            "VALUES (@FirstName, @LastName, @Gender, @ClassId, @PhoneNumber, @CreatedAt, @UpdatedAt);";
                MySqlCommand cmd = new MySqlCommand(insertStudentQuery, conn);
                cmd.Parameters.AddWithValue("@FirstName", firstNameTxt.Text);
                cmd.Parameters.AddWithValue("@LastName", lastNameTxt.Text);
                cmd.Parameters.AddWithValue("@Gender", genderCbo.Text.ToString());
                cmd.Parameters.AddWithValue("@ClassId", classCbo.SelectedValue);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneTxt.Text);
                cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                cmd.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);
                cmd.ExecuteNonQuery();
                int studentId = (int)cmd.LastInsertedId;
                return studentId;
            }
        }
        public void InsertPayment(int studentId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string insertPaymentQuery = "INSERT INTO payments (course_id, student_id, type, money, remark, created_at, updated_at) " +
                                            "VALUES (@CourseId, @StudentId, @Type, @Money, @Remark, @CreatedAt, @UpdatedAt);";
                MySqlCommand cmd = new MySqlCommand(insertPaymentQuery, conn);
                cmd.Parameters.AddWithValue("@CourseId", courseCbo.SelectedValue);
                cmd.Parameters.AddWithValue("@StudentId", studentId);
                cmd.Parameters.AddWithValue("@Type", typeCbo.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Money", decimal.Parse(payTxt.Text));
                cmd.Parameters.AddWithValue("@Remark", remarkTxt.Text);
                cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                cmd.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);
                cmd.ExecuteNonQuery();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = InsertStudent();
                InsertPayment(studentId);
                MessageBox.Show("Student and payment records added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
