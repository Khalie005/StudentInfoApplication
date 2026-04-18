using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace StudentInfoApplication
{
    public partial class FrmStudentInfo : Form
    {
        private int totalStudents = 0;
        public FrmStudentInfo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStudentID.Text.Trim() == "" || txtFirstName.Text.Trim() == "" || txtLastName.Text.Trim() == "")
                    throw new ArgumentException("All fields are required. Please fill in Student ID, First Name, and Last Name.");

                if (!Regex.IsMatch(txtStudentID.Text.Trim(), @"^\d+$"))
                    throw new FormatException("Student ID must contain numbers only.");

                if (txtStudentID.Text.Trim().Length != 11)
                    throw new ArgumentOutOfRangeException("Student ID must be exactly 11 digits.");

                if (!Regex.IsMatch(txtFirstName.Text.Trim(), @"^[a-zA-Z\s]+$") ||
                    !Regex.IsMatch(txtLastName.Text.Trim(), @"^[a-zA-Z\s]+$"))
                    throw new FormatException("First Name and Last Name must contain letters only.");


                var student = new Student(txtStudentID.Text.Trim(), txtFirstName.Text.Trim(), txtLastName.Text.Trim());

                lstStudentID.Items.Add(student.StudentID);
                lstFirstName.Items.Add(student.FirstName);
                lstLastName.Items.Add(student.LastName);

                totalStudents++;
                label7.Text = "Total Student: " + totalStudents;

                txtStudentID.Clear();
                txtFirstName.Clear();
                txtLastName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
