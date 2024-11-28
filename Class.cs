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
    public partial class ClassFrm : Form
    {
        int id;
        private string connectionString = ConnectToDB.connectionString;

        public ClassFrm()
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
                    string query = "SELECT id, name, IFNULL(start_date, '1900-01-01') AS start_date, IFNULL(end_date, '1900-01-01') AS end_date FROM classes";
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridViewClass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridViewClass.DataSource = dataTable;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void btnClassAdd_Click(object sender, EventArgs e)
        {
            AddClassFrm addCourceFrm = new AddClassFrm();
            addCourceFrm.FormClosed += AddClassFrm_FormClosed;
            addCourceFrm.ShowDialog();
        }
        private void AddClassFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.GetData();
        }
        private void ClassFrm_Load(object sender, EventArgs e)
        {
            this.GetData();
            btnUpdate.BackColor = SystemColors.AppWorkspace;
            btnDelete.BackColor = SystemColors.AppWorkspace;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void dataGridViewClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.BackColor = Color.Yellow;
            btnDelete.BackColor = Color.Red;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            id = 0;
            string idcol = dataGridViewClass.Rows[e.RowIndex].Cells[0].Value.ToString();
            id = int.Parse(idcol);
        }
        private void EditClassFrm_FormClosed(Object sender, FormClosedEventArgs e)
        {
            this.GetData();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            /*EditClassFrm editClassFrm = new EditClassFrm(id);
            editClassFrm.FormClosed += EditClassFrm_FormClosed;
            editClassFrm.ShowDialog();
            id= 0;*/
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
