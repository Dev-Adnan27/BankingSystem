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
    public partial class CloseAcc : Form
    {
        SqlConnection connection;
        SqlCommand command;
        public CloseAcc()
        {
            InitializeComponent();
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\adnan\\source\\repos\\Banking System\\Bank.mdf\";Integrated Security=True";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
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
                            string Squery = "SELECT Id FROM Account WHERE Customer = @Customer AND AccountName = @accName AND SecurityPin = @PIN";
                            command.CommandText = Squery;

                            command.Parameters.AddWithValue("@Customer", 1);
                            command.Parameters.AddWithValue("@accName", AccountName);
                            command.Parameters.AddWithValue("@PIN", PIN);
                            object result = command.ExecuteScalar();

                            if (result != null)
                            {
                                int accountId = Convert.ToInt32(result);
                                GlobalVariables.Account = accountId;
                                int ID = GlobalVariables.Account;
                                try
                                {
                                    connection.Open();
                                    string query = "DELETE FROM Account WHERE Id = @ID";
                                    SqlCommand command1 = new SqlCommand(query, connection);
                                    command1.Parameters.AddWithValue("@CustID", ID);
                                    command1.ExecuteNonQuery();
                                    MessageBox.Show("Account Deleted Successfully");
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

        private void CloseAcc_Load(object sender, EventArgs e)
        {

        }
    }
}
