using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_System.Screens
{
    public partial class TransHistory : Form
    {
        public TransHistory()
        {
            InitializeComponent();
        }

        private void TransHistory_Load(object sender, EventArgs e)
        {
            this.transactionsTableAdapter1.Fill(this.bankDataSet11.Transactions);
        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
          MainMenu mainMenu = new MainMenu();
          mainMenu.Show();
          this.Hide();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw();
            withdraw.Show();
            this.Hide();
        }
    }
}
