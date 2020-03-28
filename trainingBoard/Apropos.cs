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
    public partial class Apropos : Form
    {
        public Apropos()
        {
            InitializeComponent();
        }

        private void linkLabelGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/PhineasPhreak/trainingBoard");
        }

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
