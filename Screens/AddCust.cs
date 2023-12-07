using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_System.Screens
{
    public partial class AddCust : Form
    {
        SqlConnection connection;
        SqlCommand command;
        public AddCust()
        {
            InitializeComponent();
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\adnan\\source\\repos\\Banking System\\Bank.mdf\";Integrated Security=True";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
        }

        private void AddCust_Load(object sender, EventArgs e)
        {
        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Hide();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            AddAcc addAcc = new AddAcc();
            addAcc.Show();
            this.Hide();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (firstname.Text != string.Empty && lastname.Text != string.Empty && age.Text != string.Empty && emailaddress.Text != string.Empty && password.Text != string.Empty)
            {
                if (cPassword.Text.Trim() == password.Text.Trim())
                {
                    try
                    {
                        connection.Open();
                        int Age = Convert.ToInt32(age.Text);
                        string FirstName = firstname.Text.Trim();
                        string LastName = lastname.Text.Trim();
                        string Email = emailaddress.Text.Trim();
                        string Password = password.Text.Trim();
                        string query = "INSERT INTO Customer (FirstName, LastName, Age, EmailAddress, Password) VALUES (@FirstName, @LastName, @Age, @Email, @Password)";
                        command.CommandText = query;
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@Age", Age);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Customer added successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        age.Text = "";
                        firstname.Text = "";
                        lastname.Text = "";
                        emailaddress.Text = "";
                        password.Text = "";
                        cPassword.Text = "";
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Password And Confirm Password Do Not Match.");
                }
            }
            else
            {
                MessageBox.Show("Every Detail is Mandatory For Registration");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void emailaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void age_TextChanged(object sender, EventArgs e)
        {

        }

        private void cPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
