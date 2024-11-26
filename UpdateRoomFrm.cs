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

namespace SchoolManagement
{
    public partial class UpdateRoomFrm : Form
    {
        private int id;
        private string connectionString = ConnectToDB.connectionString;
        public UpdateRoomFrm(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnRoomUpdate_Click(object sender, EventArgs e)
        {
            string query = "UPDATE rooms SET room_code = @roomCode, floor = @roomFloor WHERE id = @roomId";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@roomCode", txtRoomCode.Text);
                        command.Parameters.AddWithValue("@roomFloor", txtRoomFloor.Text);
                        command.Parameters.AddWithValue("@roomId", id);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Room updated successfully.","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to update room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void UpdateRoomFrm_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM rooms WHERE id = @roomId";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@roomId", id);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtRoomCode.Text = reader["room_code"].ToString();
                                txtRoomFloor.Text = reader["floor"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Room not found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
