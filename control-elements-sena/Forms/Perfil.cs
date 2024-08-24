using control_elements_sena.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace control_elements_sena.Forms
{
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
        }

        private async void Perfil_Load(object sender, EventArgs e)
        {
            Session session = new Session();
            string[] data = await session.DescifrarTokenAsync();
            if (!session.validToken)
            {
                MessageBox.Show("Token no válido o ya expiró, por favor inicia sesión nuevamente", "Error al validar ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            lblRol.Text = data[3] == "1" ? "Administrador" : "Guardia";
            if (data[3] == "1") {
                lblRol.ForeColor = Color.FromArgb(57, 169, 0);
            }
            else
            {
                lblRol.ForeColor = Color.FromArgb(4, 50, 77);
            }
            lblIdentificacion.Text = data[1];
            lblNombres.Text = data[2];
            lblCorreo.Text = data[4];
        }
    }
}
