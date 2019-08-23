using System;
using System.Windows.Forms;

namespace ACTIVIDAD2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string usu = usuario.Text;
            string con = contraseña.Text;
            if (usu == "juancho" && con == "123tamarindo")
            {
                MessageBox.Show("Ingresaste con Exito!");
            }
            else
            {
                MessageBox.Show("su usuario o su contraseña son incorrectos");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
