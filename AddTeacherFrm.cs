using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class AddTeacherFrm : Form
    {
        private string connectionString = ConnectToDB.connectionString;
        public AddTeacherFrm()
        {
            InitializeComponent();
        }
        private void AddTeacher()
        {
            // Get values from the form
            string firstName = firstnameTxt.Text;
            string lastName = lastnameTxt.Text;
            string phoneNumber = phoneTxt.Text;
            string gender = genderCbo.SelectedItem.ToString();
            string status = statusCbo.SelectedItem.ToString();
            string experiences = experiencesText.Text;
            string email = emailTxt.Text;
            string password = passwordTxt.Text;
            string address = txtAddress.Text;
            DateTime birthDate = birthdateDate.Value;
            DateTime joinDate = joinDateDate.Value;
            DateTime currentTime = DateTime.Now;
            byte[] profilePic = null;
            if (profilePicBox.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    profilePicBox.Image.Save(ms, profilePicBox.Image.RawFormat);
                    profilePic = ms.ToArray();
                }
            }
            string query = "INSERT INTO teachers (first_name, last_name, phone_number, gender, status, experiences, email, password, birth_date,address, type, joined_date, profile,created_at,updated_at) " +
                           "VALUES (@firstName, @lastName, @phoneNumber, @gender, @status, @experiences, @email, @password, @birthDate,@address, @type, @joinDate, @profile,@created_at,@updated_at)";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@firstName", firstName);
                        command.Parameters.AddWithValue("@lastName", lastName);
                        command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                        command.Parameters.AddWithValue("@gender", gender);
                        command.Parameters.AddWithValue("@status", status);
                        command.Parameters.AddWithValue("@experiences", experiences);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@birthDate", birthDate);
                        command.Parameters.AddWithValue("@address", address);
                        command.Parameters.AddWithValue("@type", "normal");
                        command.Parameters.AddWithValue("@joinDate", joinDate);
                        command.Parameters.AddWithValue("@profile", profilePic ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@created_at",currentTime);
                        command.Parameters.AddWithValue("@updated_at", currentTime);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Teacher added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("An error occurred while adding the teacher.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddTeacherFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddTeacher();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                profilePicBox.Image = new Bitmap(openFileDialog.FileName);
            }
        }
    }
}
