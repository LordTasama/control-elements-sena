using control_elements_sena.Controllers.Usuarios;
using control_elements_sena.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace control_elements_sena.Forms.Create
{
    public partial class EditarUsuario : Form
    {
        private Point lastLocation;
        private bool mouseDown;
        private string [] _data = new string[7];
        public EditarUsuario(string [] data)
        {
            InitializeComponent();
            _data = data;
        }

        // Controles de la ventana
        private void pControlBox_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void pControlBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                // Mueve el formulario a la nueva posición del ratón
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update(); // Actualiza la posición del formulario
            }
        }

        private void pControlBox_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                btnShowPassword.Visible = false;
            }
            else
            {
                btnShowPassword.Visible = true;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // Validar datos
           
            var user = new UsuarioModel
            {
                Identificacion = txtIdentificacion.Text,
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                Correo = txtCorreo.Text,
                Password = txtPassword.Text,
                PasswordRequired = txtPassword.Text == "" ? false : true,
            };

            var validator = new ValidacionesUsuario();
            var result = validator.Validate(user);

            if (!result.IsValid)
            {
                string errores = "";
                bool emptyFields = false;
                foreach (var error in result.Errors)
                {
                    errores += error.ErrorMessage + "\n";
                    if (!emptyFields)
                    {
                        emptyFields = error.ErrorCode == "empty" ? true : false;
                    }

                }
                if (emptyFields)
                {
                    MessageBox.Show("Verifica si hay campos vacíos", "Error de verificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(errores, "Error de verificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            // Enviar datos
            else
            {
                bool response = Usuarios.EditarUsuario(_data[0],txtNombres.Text, txtApellidos.Text, txtIdentificacion.Text, txtCorreo.Text, txtPassword.Text,Convert.ToByte(cmbRol.SelectedValue));

                if (response)
                {
                    MessageBox.Show("Usuario editado exitosamente", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                  
                }
                else
                {
                    MessageBox.Show(Usuarios.errorMessage, "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            var data = Usuarios.SeleccionarRoles();
            List<Rol> datosRol = new List<Rol>();
            if (data.Item2)
            {
                foreach (DataRow row in data.Item1.Rows)
                {
                    datosRol.Add(new Rol { id = Convert.ToByte(row["id"]), nombre = row["nombre"].ToString() });

                }
                cmbRol.DataSource = datosRol;
                cmbRol.DisplayMember = "nombre";
                cmbRol.ValueMember = "id";

            }
            else
            {
                MessageBox.Show("Error al traer los datos", "Datos roles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtIdentificacion.Text = _data[1];
            txtNombres.Text = _data[2];
            txtApellidos.Text = _data[3];
            txtCorreo.Text = _data[4];

            foreach (var item in cmbRol.Items)
            {
                if (item is Rol rol)
                {
                    if (rol.id == Convert.ToByte(_data[5]))
                    {
                        // Encuentra el índice del elemento que coincide
                        int index = cmbRol.Items.IndexOf(item);
                        // Establece el índice seleccionado
                        cmbRol.SelectedIndex = index;
                        break; // Sale del bucle una vez que se ha encontrado el elemento
                    }
                }
            }


        }

        private void cmbRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
