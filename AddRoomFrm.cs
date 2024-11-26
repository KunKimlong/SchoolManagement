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
    public partial class AddRoomFrm : Form
    {
        private string connectionString = ConnectToDB.connectionString;
        public AddRoomFrm()
        {
            InitializeComponent();
        }
        private void clearText()
        {
            txtRoomCode.Text = "";
            txtRoomFloor.Text = "";
        }
        private void btnRoomAdd_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO rooms (room_code, floor) VALUES (@roomCode, @roomFloor)";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@roomCode", txtRoomCode.Text);
                        command.Parameters.AddWithValue("@roomFloor", txtRoomFloor.Text);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Room added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.clearText();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnRoomClear_Click(object sender, EventArgs e)
        {
            this.clearText();
        }
    }
}
