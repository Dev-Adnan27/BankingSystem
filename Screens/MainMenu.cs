using Banking_System.Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_System
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCustBtn_Click(object sender, EventArgs e)
        {
            AddCust addCust = new AddCust();
            addCust.Show();
            this.Hide();
        }

        private void AddAccBtn_Click(object sender, EventArgs e)
        {
            AddAcc addAcc = new AddAcc();
            addAcc.Show();
            this.Hide();
        }

        private void WithMoneyBtn_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw();
            withdraw.Show();
            this.Hide();
        }

        private void TransHistBtn_Click(object sender, EventArgs e)
        {
            TransHistory transHistory = new TransHistory();
            transHistory.Show();
            this.Hide();
        }

        private void RemoveCustBtn_Click(object sender, EventArgs e)
        {
            RemoveCustomer removeCustomer = new RemoveCustomer();
            removeCustomer.Show();
            this.Hide();
        }

        private void CloseAccBtn_Click(object sender, EventArgs e)
        {
            CloseAcc closeAcc = new CloseAcc();
            closeAcc.Show();
            this.Hide();
        }

        private void CustDetailsBtn_Click(object sender, EventArgs e)
        {
            CustDetails custDetails = new CustDetails();    
            custDetails.Show();
            this.Hide();
        }

        private void AccDetailsBtn_Click(object sender, EventArgs e)
        {
            AccDetails accDetails = new AccDetails();
            accDetails.Show();
            this.Hide();
        }

        private void DepMoneyBtn_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();
            deposit.Show();
            this.Hide();
        }
    }
}
