using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class StudentFrm : Form
    {
        private string connectionString = ConnectToDB.connectionString;
        public StudentFrm()
        {
            InitializeComponent();
        }
        private void GetData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "SELECT first_name, last_name, gender, class_id, phone_number FROM students";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewStudent.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void StudentFrm_Load(object sender, EventArgs e)
        {
            this.GetData();
        }

        private void btnStudentAdd_Click(object sender, EventArgs e)
        {
            AddStudentFrm addStudentFrm = new AddStudentFrm();
            addStudentFrm.FormClosed += AddStudentFrm_FormClosed;
            addStudentFrm.ShowDialog();
        }
        

        private void AddStudentFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.GetData();
        }   
    }
}
