using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario2704
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1User_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button1Entrar_Click(object sender, EventArgs e)
        {
            String name = txtUser.Text;
            String Password = txtPassword.Text;
            if (name == "" || Password == "") {
                MessageBox.Show("Todos os campos devem estar preenchidos para poder logar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (name != "" && Password == "") {
                MessageBox.Show("Por favor digite sua senha para poder entrar!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
            } else if (txtPassword.Text.Trim().Length < 8){
                MessageBox.Show("A senha deve conter pelo menos 8 dígitos", "Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtPassword.Focus();
            }else {
                MessageBox.Show("Login efetuado com sucesso!", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
