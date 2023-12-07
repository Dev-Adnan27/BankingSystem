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
using static Banking_System.Program;

namespace Banking_System.Screens
{
    public partial class Deposit : Form
    {
        SqlConnection connection;
        SqlCommand command;
        public Deposit()
        {
            InitializeComponent();
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\adnan\\source\\repos\\Banking System\\Bank.mdf\";Integrated Security=True";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
            depositMoney.Visible = false;
            depositText.Visible = false;
            addBtn.Visible = false;
        }

        private void verifyBtn_Click(object sender, EventArgs e)
        {
            int PIN = Convert.ToInt32(pin.Text.Trim());
            string AccName = accName.Text.Trim();
            try
            {
                connection.Open();
                string Searchquery = "SELECT Id,Customer FROM Account WHERE AccountName = @AccName AND SecurityPin = @PIN";
                SqlCommand command = new SqlCommand(Searchquery, connection);
                command.Parameters.AddWithValue("@AccName", AccName);
                command.Parameters.AddWithValue("@PIN", PIN);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int customerId = Convert.ToInt32(reader["Customer"]);
                    GlobalVariables.Customer = customerId;

                    int accountId = Convert.ToInt32(reader["Id"]);
                    GlobalVariables.Account = accountId;
                    depositMoney.Visible = true;
                    depositText.Visible = true;
                    addBtn.Visible = true;
                    pinText.Visible = false;
                    pin.Visible = false;
                    accName.Visible = false;
                    accNameText.Visible = false;
                    verifyBtn.Visible = false;
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

        private void nextBtn_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw();
            withdraw.Show();
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
            int Customer = GlobalVariables.Customer;
            int Account = GlobalVariables.Account;
            int Money = Convert.ToInt32(depositMoney.Text.Trim());
            DateTime date = DateTime.Now;

            try
            {
                connection.Open();
                string query = "INSERT INTO Transactions (Account,Customer,Money,TransactionType,DateOfTransaction) VALUES (@Account,@Customer,@Money,1,@DOT)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Money", Money);
                command.Parameters.AddWithValue("@Account", Account);
                command.Parameters.AddWithValue("@Customer", Customer);
                command.Parameters.AddWithValue("@DOT", date);
                command.ExecuteNonQuery();

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Transaction added successfully.");
                    string updateAccountsQuery = "UPDATE Account SET Money = Money + @Money WHERE Id = @Account";
                    SqlCommand updateAccountsCommand = new SqlCommand(updateAccountsQuery, connection);
                    updateAccountsCommand.Parameters.AddWithValue("@Money", Money);
                    updateAccountsCommand.Parameters.AddWithValue("@Account", Account);

                    int accountsRowsAffected = updateAccountsCommand.ExecuteNonQuery();

                    if (accountsRowsAffected > 0)
                    {
                        MessageBox.Show("Account balance updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update account balance.");
                    }
                }
                else
                {
                    MessageBox.Show("Transaction Failed");
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

        private void Deposit_Load(object sender, EventArgs e)
        {

        }
    }
}
