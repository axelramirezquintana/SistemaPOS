using LibreriaDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPOS
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Administrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM Usuarios WHERE id_usuario=" + Login.Codigo;
            DataSet Data = Biblioteca.Herramientas(consulta);

            lAdmin.Text = Data.Tables[0].Rows[0]["username"].ToString();
            lAdminUser.Text = Data.Tables[0].Rows[0]["account"].ToString();
            lAdminCodigo.Text = Data.Tables[0].Rows[0]["id_usuario"].ToString();

        }
    }
}
