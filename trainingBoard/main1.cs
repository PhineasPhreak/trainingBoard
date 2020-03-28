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
    public partial class Main1 : Form
    {
        public Main1()
        {
            InitializeComponent();

            // Center Main to center
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Main1_Load_1(object sender, EventArgs e)
        {
            // Variables
            string current_user = Environment.UserName;
            var current_date = DateTime.Now.ToString("dd/MM/yyyy");

            string user_and_date = ($" - {current_user} - {current_date}");

            // Initialisation main1
            this.Text = "trainingBoard - Gestion des Formations" + user_and_date;
            
        }

        private void aProposDeTrainingBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apropos frmApropos = new Apropos();
            frmApropos.StartPosition = FormStartPosition.CenterParent;
            frmApropos.ShowDialog(this);
            //frm.ShowDialog();
        }
    }
}
