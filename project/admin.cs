using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("entrer le mot de passe d un administrateur");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("entrer le mot de passe administrateur");
            }
            else if (textBox3.Text == "admin")
            {

                Gestion ag = new Gestion();
                ag.ShowDialog();
                this.Hide();

            }
            else
            {
                MessageBox.Show("error");
            }
        }
    }
}
