using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class EditCourseFrm : Form
    {
        private int id;
        private string connectionString = ConnectToDB.connectionString;
        public EditCourseFrm(int id)
        {
            this.id = id;
            InitializeComponent();
        }
        private void ClearText()
        {
            txtCoursePrice.Text = "";
            txtCourseName.Text = "";
            txtCourseDiscount.Text = "";
        }

        private void EditCourseFrm_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM courses WHERE id = @id";
                    using (MySqlCommand command = new MySqlCommand(query, connection)) {
                        command.Parameters.AddWithValue("@id", id);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtCourseName.Text = reader["name"].ToString();
                                txtCoursePrice.Text = reader["price"].ToString();
                                txtCourseDiscount.Text = reader["discount"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Course not found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors by displaying the exception message
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnCourseUpdate_Click(object sender, EventArgs e)
        {
            DateTime currentTimestamp = DateTime.Now;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "UPDATE courses SET name = @name, price = @price, discount=@discount, updated_at=@updated_at WHERE id=@id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtCourseName.Text);
                        cmd.Parameters.AddWithValue("@price", txtCoursePrice.Text);
                        cmd.Parameters.AddWithValue("@discount", txtCourseDiscount.Text);
                        cmd.Parameters.AddWithValue("@updated_at", currentTimestamp);
                        cmd.Parameters.AddWithValue("@id", id);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Course update successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("An error occurred. No data update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.ClearText();
        }
    }
}
