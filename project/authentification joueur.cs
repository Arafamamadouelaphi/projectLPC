using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project
{
    public partial class authentification_joueur : Form
    {
        public authentification_joueur()
        {
            InitializeComponent();
        }
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-RCCFLSL;Initial Catalog=jeux;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            if ( textBox2.Text == "")
            {
                MessageBox.Show("enter your name");
            }
            else
            {
                SqlCommand c = new SqlCommand();
                c.Connection = cnx;
                c.CommandText = "select  nomdujoueur from joueur where nomdujoueur='"+textBox2.Text+"'";
                SqlDataReader dr;
                dr = c.ExecuteReader();
                bool exists;

                while (dr.Read())
                {

                    if (textBox2.Text == dr[0].ToString() )
                    {
                        exists = true;
                        MessageBox.Show("WELCOME");
                        Form1 t = new Form1();
                        t.ShowDialog();
                        this.Hide();
                        break;
                    }

                    else
                    {
                        exists = false;
                    }

                    if (exists == false)
                    {
                        MessageBox.Show("please double check your name...");
                    }

                }
                dr.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin o = new admin();
            o.ShowDialog();
            this.Hide();
            cnx.Close();
        }

        private void authentification_joueur_Load(object sender, EventArgs e)
        {
            cnx.Open();
        }
    }
    }

