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
    public partial class MutualFormationID : Form
    {
        public MutualFormationID()
        {
            InitializeComponent();
        }

        private void MutualFormationID_Load(object sender, EventArgs e)
        {
            //
            // Initialisation MutualFormationID
            //
            this.Text = "Mutuelle Formation - Identification";
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonValidation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxIdentifiant.Text) | string.IsNullOrEmpty(textBoxMotDePasse.Text))
            {
                MessageBox.Show("Avertissement," + (Char)13 + 
                    "Identifiant ou Mot de Passe Vide", "Avertissement saisie incorrecte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
