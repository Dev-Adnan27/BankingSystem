using Banking_System.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Banking_System.Program;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Banking_System
{
    public partial class AddAcc : Form
    {
        SqlConnection connection;
        SqlCommand command;
        public AddAcc()
        {
            InitializeComponent();
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\adnan\\source\\repos\\Banking System\\Bank.mdf\";Integrated Security=True";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
            accName.Visible = false;
            accNameText.Visible = false;
            pin.Visible = false;
            PinText.Visible = false;
            cPin.Visible = false;
            cPinText.Visible = false;
            addBtn.Visible = false;
        }

        private void AccountSetup_Load(object sender, EventArgs e)
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
            Deposit deposit = new Deposit();
            deposit.Show();
            this.Hide();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (accName.Text != string.Empty && pin.Text != string.Empty && cPin.Text != string.Empty)
            {
                if (pin.Text.Trim().Length == 4)
                {
                    if (pin.Text.Trim() == cPin.Text.Trim())
                    {
                        try
                        {
                            connection.Open();
                            int PIN = Convert.ToInt32(pin.Text);
                            string AccountName = accName.Text.Trim();
                            string query = "INSERT INTO Account (Customer,AccountName,SecurityPin) VALUES (@Customer,@accName,@PIN)";
                            command.CommandText = query;

                            command.Parameters.AddWithValue("@Customer", GlobalVariables.Customer);
                            command.Parameters.AddWithValue("@accName", AccountName);
                            command.Parameters.AddWithValue("@PIN", PIN);
                            command.ExecuteNonQuery();

                            MessageBox.Show("Account added successfully.");

                            accName.Text = "";
                            pin.Text = "";
                            cPin.Text = "";
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
                        MessageBox.Show("Security PIN and Confirm PIN do not match.");
                    }
                }
                else
                {
                    MessageBox.Show("Security PIN must be 4 numbers.");
                }
            }
            else
            {
                MessageBox.Show("Every detail is mandatory for Account Opening.");
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string FirstName = firstname.Text.Trim();
            string Password = password.Text.Trim();
            try
            {
                connection.Open();
                string Searchquery = "SELECT Id FROM Customer WHERE FirstName = @Name AND Password = @Password";
                SqlCommand command = new SqlCommand(Searchquery, connection);
                command.Parameters.AddWithValue("@Name", FirstName);
                command.Parameters.AddWithValue("@Password", Password);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int customerId = Convert.ToInt32(reader["Id"]);
                    GlobalVariables.Customer = customerId;
                    accName.Visible = true;
                    accNameText.Visible = true;              
                    pin.Visible = true;
                    PinText.Visible = true;              
                    cPin.Visible = true;
                    cPinText.Visible = true;
                    addBtn.Visible = true;
                    passwordText.Visible = false;
                    password.Visible = false;
                    firstname.Visible = false;
                    firstnametext.Visible = false;
                    searchBtn.Visible = false;
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("No Account Found With The Given Credentials");
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
    }
}