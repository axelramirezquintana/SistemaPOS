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
using LibreriaDLL;


namespace SistemaPOS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static string Codigo = "";

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string validar = string.Format("Select * FROM Usuarios WHERE account='{0}'AND password ='{1}'", textUsuario.Text.Trim(), textPassword.Text.Trim());
                DataSet conectar = Biblioteca.Herramientas(validar);

                Codigo = conectar.Tables[0].Rows[0]["id_usuario"].ToString().Trim();
                string cuenta = conectar.Tables[0].Rows[0]["account"].ToString().Trim();
                string contrasena = conectar.Tables[0].Rows[0]["password"].ToString().Trim();

                if (cuenta == textUsuario.Text.Trim() && contrasena == textPassword.Text.Trim())
                {
                    if (Convert.ToBoolean(conectar.Tables[0].Rows[0]["validar_admin"].ToString().Trim()) == true)
                    {
                        Administrador Admin = new Administrador();
                        this.Hide();
                        Admin.Show();
                    }
                    else
                    {
                        Usuario User = new Usuario();
                        this.Hide();
                        User.Show();
                    }
                }
               
            }
            catch(Exception error)
            {
                MessageBox.Show("Usuario o contraseña incorrectos"+error);
            }
            }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
    }
