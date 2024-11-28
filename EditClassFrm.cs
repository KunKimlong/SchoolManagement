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
using System.Xml.Linq;

namespace SchoolManagement
{
    public partial class EditClassFrm : Form
    {
        private int id;
        private string connectionString = ConnectToDB.connectionString;
        public EditClassFrm(int id, string name, DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            this.id = id;
            nameTxt.Text = name;
            /*startDate.Value = startDate;
            endDate.Value = endDate;*/
        }

        private void btnClassUpdate_Click(object sender, EventArgs e)
        {
            DateTime currentTimestamp = DateTime.Now;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "UPDATE classes SET name = @name, course_id = @course, room_id=@room,teacher_id=@teacher,start_date=@startdate,end_date=@enddate, updated_at=@updated_at WHERE id=@id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", nameTxt.Text);
                        cmd.Parameters.AddWithValue("@course", courseCbo.Text);
                        cmd.Parameters.AddWithValue("@room", roomIdCbo.Text);
                        cmd.Parameters.AddWithValue("@teacher", teacherIdCbo.Text);
                        cmd.Parameters.AddWithValue("@startdate", dateSart.Text);
                        cmd.Parameters.AddWithValue("@enddate", dateEnd.Text);

                        cmd.Parameters.AddWithValue("@updated_at", currentTimestamp);
                        cmd.Parameters.AddWithValue("@id", id);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Class update successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("An error class. No data update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            /*this.ClearText();*/
        }

        private void EditClassFrm_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM classes WHERE id = @id";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                nameTxt.Text = reader["name"].ToString();
                                   
                                courseCbo.Text = reader["course_id"].ToString();
                                roomIdCbo.Text = reader["room_id"].ToString();
                                teacherIdCbo.Text=reader["teacher_id"].ToString();
                                dateSart.Text=reader["start_date"].ToString();
                                dateEnd.Text=reader["end_date"].ToString() ;

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
    }
}
