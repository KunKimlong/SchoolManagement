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
    public partial class RoomManagement : Form
    {
        private int id = 0;
        private string connectionString = ConnectToDB.connectionString;
        public RoomManagement()
        {
            InitializeComponent();
            btnUpdate.BackColor = SystemColors.AppWorkspace;
            btnDelete.BackColor = SystemColors.AppWorkspace;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void GetData()
        {
            string query = "SELECT * FROM rooms";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);
                            dataGridViewRoom.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void RoomManagement_Load(object sender, EventArgs e)
        {
            this.GetData();
        }

        private void btnRoomAdd_Click(object sender, EventArgs e)
        {
            AddRoomFrm addRoomFrm = new AddRoomFrm();
            addRoomFrm.FormClosed += AddRoomFrm_FormClosed;
            addRoomFrm.ShowDialog();
        }
        private void AddRoomFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.GetData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateRoomFrm updateRoomFrm = new UpdateRoomFrm(id);
            updateRoomFrm.FormClosed += UpdateRoomFrm_FormClosed;
            updateRoomFrm.ShowDialog();
            id = 0;
        }
        private void UpdateRoomFrm_FormClosed(Object sender, FormClosedEventArgs e)
        {
            this.GetData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this room?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM rooms WHERE id = @id";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id", id);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Room deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Room not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            this.GetData();
            id = 0;
        }

        private void dataGridViewRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.BackColor = Color.Yellow;
            btnDelete.BackColor = Color.Red;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            id = 0;
            string idcol = dataGridViewRoom.Rows[e.RowIndex].Cells[0].Value.ToString();
            id = int.Parse(idcol);
        }

        private void dataGridViewRoom_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewRoom.SelectedCells.Count == 0)
            {
                btnUpdate.BackColor = SystemColors.AppWorkspace;
                btnDelete.BackColor = SystemColors.AppWorkspace;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }
    }
}
