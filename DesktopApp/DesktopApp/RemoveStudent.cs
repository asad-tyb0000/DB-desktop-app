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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DesktopApp
{
    public partial class RemoveStudent : Form
    {
        private string connectionString = "Data Source=DESKTOP-IC90SRH\\SQLEXPRESS01;Initial Catalog=desktopApp;Integrated Security=True;";

        public RemoveStudent()
        {
            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //String connectionString = "Data Source=DESKTOP-IC90SRH\\SQLEXPRESS01;Initial Catalog=desktopApp;Integrated Security=True;";
            string registrationNumber = textBox1.Text;

            if (string.IsNullOrEmpty(registrationNumber))
            {
                MessageBox.Show("Please enter the student's registration number.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                try
                {
                    // Check if student exists before deletion
                    string checkStudentExists = "SELECT COUNT(*) FROM Student WHERE RegistrationNumber = @RegistrationNumber";
                    SqlCommand checkCmd = new SqlCommand(checkStudentExists, conn);
                    checkCmd.Parameters.AddWithValue("@RegistrationNumber", registrationNumber);

                    int studentCount = (int)checkCmd.ExecuteScalar();

                    if (studentCount > 0)
                    {
                        // Student exists, proceed with deletion
                        string deleteStudent = "DELETE FROM Student WHERE RegistrationNumber = @RegistrationNumber";
                        SqlCommand deleteCmd = new SqlCommand(deleteStudent, conn);
                        deleteCmd.Parameters.AddWithValue("@RegistrationNumber", registrationNumber);

                        int rowsDeleted = deleteCmd.ExecuteNonQuery();

                        MessageBox.Show($"Student with registration number '{registrationNumber}' deleted successfully.", "Student Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Student with registration number '{registrationNumber}' not found.", "Student Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }
    }
}
