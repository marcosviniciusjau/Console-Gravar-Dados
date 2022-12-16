using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace GravarDados
{
    public partial class Form1 : Form
    {
        MySqlConnection Conexao;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "data_source= localhost; username= root; password= etecjau; database= db_agenda";

                Conexao = new MySqlConnection(data_source);

                string sql = "INSERT INTO CONTATO (nome, email, telefone) VALUES ('" + txtNome.Text + "' , '" + txt_Email.Text + "' , + txt_Telefone.Text ";
                    MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();

                comando.ExecuteReader();

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                Conexao.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string q = "'%" + txt_buscar.Text + "'%";
                Conexao = new MySqlConnection(data_source);

                string sql= "SELECT * " +
                    "FROM "
            }
        }
    }
}
