using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace app_crud_db
{
    public partial class Form1 : Form
    {
        OleDbConnection con;
        public Form1()
        {
            InitializeComponent();
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\crud_exemplo\db.accdb;");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                OleDbCommand cmd = new OleDbCommand("INSERT INTO alunos (nome, numero, nota) VALUES (@nome, @num, @nota)", con);

                cmd.Parameters.AddWithValue("@nome", textBox2.Text);
                cmd.Parameters.AddWithValue("@num", textBox3.Text);
                cmd.Parameters.AddWithValue("@nota", textBox4.Text);

                cmd.ExecuteNonQuery();

                con.Close();
                carregar();
                limpatextboxs();

                MessageBox.Show("Inserido com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                OleDbDataAdapter da =
                    new OleDbDataAdapter("SELECT * FROM alunos", con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                OleDbCommand cmd = new OleDbCommand(
                    "DELETE FROM alunos WHERE ID=@id",
                    con);

                cmd.Parameters.AddWithValue("@id", textBox1.Text);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Apagado com sucesso");

                carregar();
                limpatextboxs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                OleDbCommand cmd = new OleDbCommand(
                    "UPDATE alunos SET nome=@nome, numero=@num, nota=@nota WHERE ID=@id",
                    con);

                cmd.Parameters.AddWithValue("@nome", textBox2.Text);
                cmd.Parameters.AddWithValue("@num", textBox3.Text);
                cmd.Parameters.AddWithValue("@nota", textBox4.Text);
                cmd.Parameters.AddWithValue("@id", textBox1.Text);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Atualizado com sucesso");

                carregar();
                limpatextboxs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void limpatextboxs()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
        void carregar()
        {
            try
            {
                con.Open();

                OleDbDataAdapter da =
                    new OleDbDataAdapter("SELECT * FROM alunos", con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carregar();
        }
    }
}
