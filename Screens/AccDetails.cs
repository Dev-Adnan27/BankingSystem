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
    public partial class AccDetails : Form
    {
        public AccDetails()
        {
            InitializeComponent();
        }

        private void AccDetails_Load(object sender, EventArgs e)
        {
         this.accountTableAdapter1.Fill(this.bankDataSet11.Account);
        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();
            this.Hide();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            TransHistory transHistory = new TransHistory();
            transHistory.Show();
            this.Hide();
        }
    }
}
