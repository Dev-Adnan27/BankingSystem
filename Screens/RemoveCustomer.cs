using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Banking_System.Program;

namespace Banking_System.Screens
{
    public partial class RemoveCustomer : Form
    {
        SqlConnection connection;
        SqlCommand command;
        public RemoveCustomer()
        {
            InitializeComponent();
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\adnan\\source\\repos\\Banking System\\Bank.mdf\";Integrated Security=True";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
        }
        private void RemoveCustomer_Load(object sender, EventArgs e)
        {

        }
        private void nextBtn_Click(object sender, EventArgs e)
        {
            AddCust addCust = new AddCust();
            addCust.Show();
            this.Hide();
        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Hide();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if(firstname.Text != string.Empty && emailaddress.Text != string.Empty && password.Text != string.Empty && cPassword.Text != string.Empty)
            {
                if(password.Text.Trim() == cPassword.Text.Trim())
                {
                    string FirstName = firstname.Text.Trim();
                    string Password = password.Text.Trim();
                    string Email = emailaddress.Text.Trim();
                    try
                    {
                        connection.Open();
                        string searchQuery = "SELECT Id FROM Customer WHERE FirstName = @Name AND Password = @Password AND EmailAddress = @Email";
                        SqlCommand command = new SqlCommand(searchQuery, connection);
                        command.Parameters.AddWithValue("@Name", FirstName);
                        command.Parameters.AddWithValue("@Password", Password);
                        command.Parameters.AddWithValue("@Email", Email);
                        object result = command.ExecuteScalar();

                        if (result != null) 
                        {
                            int customerId = Convert.ToInt32(result);
                            GlobalVariables.Customer = customerId;
                            int ID = GlobalVariables.Customer;
                            try
                            {
                                connection.Open();
                                string query = "DELETE FROM Customer WHERE Id = @ID";
                                SqlCommand command1 = new SqlCommand(query, connection);
                                command1.Parameters.AddWithValue("@CustID", ID);
                                command1.ExecuteNonQuery();
                                MessageBox.Show("Customer Deleted Successfully");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error: " + ex.Message);
                            }
                            finally
                            {
                                connection.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("No Customer Found With The Given Credentials");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Password and Confirm Password Doesn't Match");
                }
            }
            else
            {
                MessageBox.Show("Fill Out All Details To Remove a Customer.");
            }
        }
    }
}
