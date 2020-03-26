using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trainingBoard
{
    public partial class main1 : Form
    {
        public main1()
        {
            InitializeComponent();
        }

        private void main1_Load(object sender, EventArgs e)
        {
            // Variables :
            string current_user = Environment.UserName;
            DateTime current_date = DateTime.Now;

            string user_and_date = ($" - {current_user} {current_date}");

            // Initialisation main1
            this.Text = "trainingBoard - Gestion des Formation" + user_and_date;
        }
    }
}
