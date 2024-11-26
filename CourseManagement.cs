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
    public partial class CourseManagementFrm : Form
    {
        private int id;
        private string connectionString = ConnectToDB.connectionString;
        public CourseManagementFrm()
        {
            InitializeComponent();
        }

        private void GetData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM courses"; 
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridViewCourses.DataSource = dataTable;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void CourseManagement_Load(object sender, EventArgs e)
        {
            this.GetData();
            btnUpdate.BackColor = SystemColors.AppWorkspace;
            btnDelete.BackColor = SystemColors.AppWorkspace;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnCourseAdd_Click(object sender, EventArgs e)
        {
            AddCourceFrm addCourceFrm = new AddCourceFrm();
            addCourceFrm.FormClosed += AddCourceFrm_FormClosed;
            addCourceFrm.ShowDialog();
        }

        private void AddCourceFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.GetData();
        }

        private void dataGridViewCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.BackColor = Color.Yellow;
            btnDelete.BackColor = Color.Red;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            id = 0;
            string idcol = dataGridViewCourses.Rows[e.RowIndex].Cells[0].Value.ToString();
            id = int.Parse(idcol);

        }
        private void EditCourseFrm_FormClosed(Object sender, FormClosedEventArgs e)
        {
            this.GetData();
        }

        private void dataGridViewCourses_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dataGridViewCourses.SelectedCells.Count == 0)
            {
                btnUpdate.BackColor = SystemColors.AppWorkspace;
                btnDelete.BackColor = SystemColors.AppWorkspace;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;            
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EditCourseFrm editCourseFrm = new EditCourseFrm(id);
            editCourseFrm.FormClosed += EditCourseFrm_FormClosed;
            editCourseFrm.ShowDialog();
            id= 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this course?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM courses WHERE id = @id";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id", id);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Course deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Course not found.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            id= 0;
        }
    }
}
