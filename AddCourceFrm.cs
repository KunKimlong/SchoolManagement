using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SchoolManagement
{
    public partial class AddCourceFrm : Form
    {
        private string connectionString = ConnectToDB.connectionString;
        public AddCourceFrm()
        {
            InitializeComponent();
        }
        private void ClearText()
        {
            txtCoursePrice.Text = "";
            txtCourseName.Text = "";
            txtCourseDiscount.Text = "";
        }

        private void btnCourseAdd_Click(object sender, EventArgs e)
        {
            DateTime currentTimestamp = DateTime.Now;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO courses (name, price, discount, created_at, updated_at) " +
                                   "VALUES (@name, @price, @discount, @created_at, @updated_at)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@name", txtCourseName.Text);
                        cmd.Parameters.AddWithValue("@price", txtCoursePrice.Text);
                        cmd.Parameters.AddWithValue("@discount", txtCourseDiscount.Text);
                        cmd.Parameters.AddWithValue("@created_at", currentTimestamp);
                        cmd.Parameters.AddWithValue("@updated_at", currentTimestamp);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Course inserted successfully.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("An error occurred. No data inserted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnCourseClear_Click(object sender, EventArgs e)
        {
            this.ClearText();
        }
    }
}
