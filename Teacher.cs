using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class TeacherFrm : Form
    {
        private int id = 0;
        private string connectionString = ConnectToDB.connectionString;
        private void getData()
        {
            string query = "SELECT * FROM teachers";
            try
            {
                if (dataGridViewTeacher.Columns.Count == 0)
                {
                    dataGridViewTeacher.Columns.Add("id", "ID");
                    dataGridViewTeacher.Columns.Add("first_name", "First Name");
                    dataGridViewTeacher.Columns.Add("last_name", "Last Name");
                    dataGridViewTeacher.Columns.Add("phone_number", "Phone Number");
                    dataGridViewTeacher.Columns.Add("gender", "Gender");
                    dataGridViewTeacher.Columns.Add("status", "Status");
                    dataGridViewTeacher.Columns.Add("experiences", "Experiences");
                    dataGridViewTeacher.Columns.Add("email", "Email");
                    dataGridViewTeacher.Columns.Add("type", "Type");
                }
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            dataGridViewTeacher.Rows.Clear();
                            while (reader.Read())
                            {
                                int rowIndex = dataGridViewTeacher.Rows.Add();
                                DateTime defaultDate = DateTime.MinValue;
                                dataGridViewTeacher.Rows[rowIndex].Cells["id"].Value = reader["id"];
                                dataGridViewTeacher.Rows[rowIndex].Cells["first_name"].Value = reader["first_name"];
                                dataGridViewTeacher.Rows[rowIndex].Cells["last_name"].Value = reader["last_name"];
                                dataGridViewTeacher.Rows[rowIndex].Cells["phone_number"].Value = reader["phone_number"];
                                dataGridViewTeacher.Rows[rowIndex].Cells["gender"].Value = reader["gender"];
                                dataGridViewTeacher.Rows[rowIndex].Cells["status"].Value = reader["status"];
                                dataGridViewTeacher.Rows[rowIndex].Cells["experiences"].Value = reader["experiences"];
                                dataGridViewTeacher.Rows[rowIndex].Cells["email"].Value = reader["email"];
                                dataGridViewTeacher.Rows[rowIndex].Cells["type"].Value = reader["type"];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public TeacherFrm()
        {
            InitializeComponent();
            this.getData();
        }
           
        private void AddTeacherFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.getData();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AddTeacherFrm frm = new AddTeacherFrm();
            frm.FormClosed += AddTeacherFrm_FormClosed;
            frm.ShowDialog();
        }

        private void TeacherFrm_Load(object sender, EventArgs e)
        {
            this.getData();
        }
    }
}
