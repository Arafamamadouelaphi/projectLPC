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
    public partial class salle : Form
    {
        public salle()
        {
            InitializeComponent();
        }
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-RCCFLSL;Initial Catalog=jeux;Integrated Security=True");

        private void salle_Load(object sender, EventArgs e)
        {
           
            cnx.Open();
            SqlCommand c = new SqlCommand();
            c.Connection = cnx;
            c.CommandText = "select * from sallee ";
            SqlDataReader dr = c.ExecuteReader();
            DataTable dt = new DataTable();
            dataGrid.DataSource = dt;
            dt.Load(dr);
            aff();
        }
        public void aff()
        {


            SqlCommand c = new SqlCommand();
            c.Connection = cnx;
            c.CommandText = "select *from sallee";
            SqlDataReader dr = c.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGrid.DataSource = dt;

            dr.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            {
                
                if (textBox6.Text == "" )
                {
                    MessageBox.Show("completez les informations sulvouplait!!!");

                }
                else
                {
                    SqlCommand c = new SqlCommand();
                   c.Connection = cnx;
                    c.CommandText = "insert into sallee values ("+ int.Parse(textBox6.Text)+ " ,'" +DateTime.Parse( dateTimePicker1.Text)+"')";
                    
                   
                    c.ExecuteNonQuery();
                      MessageBox.Show("Ajout Reussi");

                    aff();
                }
            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            int numsalle = (int)dataGrid.CurrentRow.Cells[0].Value;
            SqlCommand c = new SqlCommand();
            c.Connection = cnx;
            c.CommandText = "update sallee set date='" + DateTime.Parse(dateTimePicker1.Text) + "' where numsalle=" + numsalle + " ";
            c.ExecuteNonQuery();
            MessageBox.Show("modification réussi");

            aff();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int numsalle = (int)dataGrid.CurrentRow.Cells[0].Value;
            SqlCommand c = new SqlCommand();
            c.Connection = cnx;
            c.CommandText = "delete from  sallee where numsalle=" + numsalle+ "";
            c.ExecuteNonQuery();
            MessageBox.Show("sup réussi");
            aff();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            aff();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Gestion v = new Gestion();
            v.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
