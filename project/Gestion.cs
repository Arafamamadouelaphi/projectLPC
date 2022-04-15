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
    public partial class Gestion : Form
    {
        public Gestion()
        {
            InitializeComponent();
        }
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-RCCFLSL;Initial Catalog=jeux;Integrated Security=True");

        private void Gestion_Load(object sender, EventArgs e)
        {



            cnx.Open();
            comboBox1.Items.Add("MASCULIN");
            comboBox1.Items.Add("FEMININ");
            REMPLIRGRID();
            cnx.Close();

            ChargerCombo();

        }public void REMPLIRGRID()
        {
            SqlCommand c = new SqlCommand();
            c.Connection = cnx;
            c.CommandText = "select * from joueur ";
            SqlDataReader dr = c.ExecuteReader();
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            dt.Load(dr);
        }
        public void ChargerCombo()
        {
            cnx.Open();
            SqlCommand c = new SqlCommand();
            c.Connection = cnx;
            c.CommandText = "select numsalle from sallee";
            SqlDataReader dr = c.ExecuteReader();
            while (dr.Read())
            {
                comb.Items.Add(dr[0]);
            }
           dr.Close();
        }
        public void affii()
        {


            SqlCommand c = new SqlCommand();
            c.Connection = cnx;
            c.CommandText = "select *from joueur";
            SqlDataReader dr = c.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;

            dr.Close();
            
        }
               public void reii()
        {
            textBox6.Text = "";
            dateTimePicker1.Text = "";
            textBox7.Text = "";

            comboBox1.Text = "";
            comb.Text = "";


        }
        private void label7_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.ShowDialog();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (textBox6.Text == "" || dateTimePicker1.Text == "" || textBox7.Text == "" || comboBox1.SelectedIndex == -1 || comb.SelectedIndex == -1)
            {
                MessageBox.Show("complete the information please!!!");

            }
            
            else
            {


                SqlCommand c = new SqlCommand();
                c.Connection = cnx;
                c.CommandText = ("insert into joueur  values(@nomjoueur,@datedujeux,@telephone,@genre,@numsalle)");

                c.Parameters.AddWithValue("@nomjoueur", textBox6.Text);
                c.Parameters.AddWithValue("@datedujeux", dateTimePicker1.Value);
                c.Parameters.AddWithValue("@telephone", textBox7.Text);

                c.Parameters.AddWithValue("@genre", comboBox1.Text);
                c.Parameters.AddWithValue("@numsalle", comb.Text);

                c.ExecuteNonQuery();
                MessageBox.Show("Ajout Reussi");

                affii();
                reii();
                cnx.Close();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nom = (String)dataGridView1.CurrentRow.Cells[0].Value;
            SqlCommand c = new SqlCommand();
            c.Connection = cnx;
            c.CommandText = "update joueur set datedujeux='" + dateTimePicker1.Value.ToString() + "',telephone='" + textBox7.Text + "',genre='" + comboBox1.Text + "',numsalle='" + comb.Text + "' where nomdujoueur='" +nom + "' ";
            c.ExecuteNonQuery();
            MessageBox.Show("modification réussi");

            affii();
            reii();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           //int numed = (int)dataGridView1.CurrentRow.Cells[0].Value;

            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells["nomdujoueur"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells["datedujeux"].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells["telephone"].Value.ToString();
          //  textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells["genre"].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["genre"].Value.ToString();
            comb.Text = dataGridView1.Rows[e.RowIndex].Cells["numsalle"].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            reii();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            affii();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String nomj = (String)dataGridView1.CurrentRow.Cells[0].Value;
            SqlCommand c = new SqlCommand();
            c.Connection = cnx;
            c.CommandText = "delete from  joueur where nomdujoueur='" +nomj + "'";
            c.ExecuteNonQuery();
            MessageBox.Show("sup réussi");
            affii();
            reii();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            salle s = new salle();
            s.ShowDialog();
            
        }
    }
}
