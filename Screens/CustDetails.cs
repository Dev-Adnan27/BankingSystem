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

namespace Banking_System.Screens
{
    public partial class CustDetails : Form
    {
        public CustDetails()
        {
            InitializeComponent();
        }

        private void CustDetails_Load(object sender, EventArgs e)
        {
           this.customerTableAdapter1.Fill(this.bankDataSet11.Customer);
        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Hide();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            AccDetails accDetails = new AccDetails();
            accDetails.Show();
            this.Hide();
        }
    }
}
