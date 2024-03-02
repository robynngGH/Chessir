using Chessir.dao;
using Chessir.dto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Chessir.gui
{
    public partial class FormGestion : Form
    {
        private int id_usuario = 0;
        public FormGestion(int id_usuario)
        {
            InitializeComponent();
            this.id_usuario = id_usuario; //recibe el id del usuario activo desde FormInicial

            //inicializa la lista completa de usernames en los combo box para modificar y eliminar
            ArrayList lista = new ArrayList();
            DAOUsuario daoUsuario = new DAOUsuario();
            lista = daoUsuario.usernamesDesplegable();
            for (int i = 0; i < lista.Count; i++)
            {
                comboBoxUsuariosModificar.Items.Add(lista[i]);
                comboBoxUsuariosEliminar.Items.Add(lista[i]);
            }
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxUsername.Text) || String.IsNullOrEmpty(textBoxPassword.Text))
            {
                buttonCrearUsuario.Enabled = false; //comprobación básica que no permite registrar un usuario si sus campos están vacíos
            }
            else
            {
                if (textBoxPassword.Text != textBoxRepitePassword.Text) //tampoco se activa el botón si las contraseñas no coinciden
                {
                    buttonCrearUsuario.Enabled = false;
                    labelPasswordNoCoincide.Visible = true;
                }
                else
                {
                    buttonCrearUsuario.Enabled = true;
                    labelPasswordNoCoincide.Visible = false;
                }

                if (textBoxUsername.Text.Length < 5)
                {
                    buttonCrearUsuario.Enabled = false;
                    labelUsernameCorto.Visible = true;
                }
                else
                {
                    buttonCrearUsuario.Enabled = true;
                    labelUsernameCorto.Visible = false;
                }
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxUsername.Text) || String.IsNullOrEmpty(textBoxPassword.Text))
            {
                buttonCrearUsuario.Enabled = false; //comprobación básica que no permite registrar un usuario si sus campos están vacíos
            }
            else
            {
                if (textBoxPassword.Text != textBoxRepitePassword.Text) //tampoco se activa el botón si las contraseñas no coinciden
                {
                    buttonCrearUsuario.Enabled = false;
                    labelPasswordNoCoincide.Visible = true;
                }
                else
                {
                    buttonCrearUsuario.Enabled = true;
                    labelPasswordNoCoincide.Visible = false;
                }

                if (textBoxUsername.Text.Length < 5)
                {
                    buttonCrearUsuario.Enabled = false;
                    labelUsernameCorto.Visible = true;
                }
                else
                {
                    buttonCrearUsuario.Enabled = true;
                    labelUsernameCorto.Visible = false;
                }
            }
        }

        private void textBoxRepitePassword_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxUsername.Text) || String.IsNullOrEmpty(textBoxPassword.Text))
            {
                buttonCrearUsuario.Enabled = false; //comprobación básica que no permite registrar un usuario si sus campos están vacíos
            }
            else
            {
                if (textBoxPassword.Text != textBoxRepitePassword.Text) //tampoco se activa el botón si las contraseñas no coinciden
                {
                    buttonCrearUsuario.Enabled = false;
                    labelPasswordNoCoincide.Visible = true;
                }
                else
                {
                    buttonCrearUsuario.Enabled = true;
                    labelPasswordNoCoincide.Visible = false;
                }

                if (textBoxUsername.Text.Length < 5)
                {
                    buttonCrearUsuario.Enabled = false;
                    labelUsernameCorto.Visible = true;
                }
                else
                {
                    buttonCrearUsuario.Enabled = true;
                    labelUsernameCorto.Visible = false;
                }
            }
        }

        private void buttonCrearUsuario_Click(object sender, EventArgs e)
        {
            DTOUsuario dtoUsuario = new DTOUsuario(textBoxUsername.Text, textBoxPassword.Text, checkBoxEsAdmin.Checked, id_usuario, true);
            DAOUsuario daoUsuario = new DAOUsuario();

            //crea el usuario únicamente cuando el username no existe ya en la base de datos
            if (daoUsuario.existeUsuario(textBoxUsername.Text))
                MessageBox.Show("El usuario ya existe.", "Registro incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                daoUsuario.registrarUsuario(dtoUsuario);
        }

        private void comboBoxUsuariosModificar_TextChanged(object sender, EventArgs e)
        {
            DAOUsuario daoUsuario = new DAOUsuario();
            DTOUsuario dtoUsuario = new DTOUsuario();

            //consulta el usuario únicamente cuando el username existe en la base de datos
            if (daoUsuario.existeUsuario(comboBoxUsuariosModificar.Text))
            {
                textBoxUsernameModificar.Enabled = true; textBoxPasswordModificar.Enabled = true;
                textBoxRepitePasswordModificar.Enabled = true; checkBoxEsAdminModificar.Enabled = true;
                buttonModificarUsuario.Enabled = true;

                //recibe los datos del username seleccionado y los coloca en su correspondiente lugar
                dtoUsuario = daoUsuario.buscarUsername(comboBoxUsuariosModificar.Text);
                textBoxUsernameModificar.Text = dtoUsuario.Username;
                textBoxPasswordModificar.Text = dtoUsuario.Password;
                textBoxRepitePasswordModificar.Text = dtoUsuario.Password;
                checkBoxEsAdminModificar.Checked = dtoUsuario.Es_admin;
            }
            else
            {
                textBoxUsernameModificar.Enabled = false; textBoxPasswordModificar.Enabled = false;
                textBoxRepitePasswordModificar.Enabled = false; checkBoxEsAdminModificar.Enabled = false;
                buttonModificarUsuario.Enabled = false;
            }
                
        }

        private void textBoxUsernameModificar_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxUsernameModificar.Text) || String.IsNullOrEmpty(textBoxPasswordModificar.Text))
            {
                buttonModificarUsuario.Enabled = false; //comprobación básica que no permite modificar un usuario si sus campos están vacíos
            }
            else
            {
                if (textBoxPasswordModificar.Text != textBoxRepitePasswordModificar.Text) //tampoco se activa el botón si las contraseñas no coinciden
                {
                    buttonModificarUsuario.Enabled = false;
                    labelPasswordNoCoincideModificar.Visible = true;
                }
                else
                {
                    buttonModificarUsuario.Enabled = true;
                    labelPasswordNoCoincideModificar.Visible = false;
                }

                if (textBoxUsernameModificar.Text.Length < 5)
                {
                    buttonModificarUsuario.Enabled = false;
                    labelUsernameCortoModificar.Visible = true;
                }
                else
                {
                    buttonModificarUsuario.Enabled = true;
                    labelUsernameCortoModificar.Visible = false;
                }
            }
        }

        private void textBoxPasswordModificar_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxUsernameModificar.Text) || String.IsNullOrEmpty(textBoxPasswordModificar.Text))
            {
                buttonModificarUsuario.Enabled = false; //comprobación básica que no permite modificar un usuario si sus campos están vacíos
            }
            else
            {
                if (textBoxPasswordModificar.Text != textBoxRepitePasswordModificar.Text) //tampoco se activa el botón si las contraseñas no coinciden
                {
                    buttonModificarUsuario.Enabled = false;
                    labelPasswordNoCoincideModificar.Visible = true;
                }
                else
                {
                    buttonModificarUsuario.Enabled = true;
                    labelPasswordNoCoincideModificar.Visible = false;
                }

                if (textBoxUsernameModificar.Text.Length < 5)
                {
                    buttonModificarUsuario.Enabled = false;
                    labelUsernameCortoModificar.Visible = true;
                }
                else
                {
                    buttonModificarUsuario.Enabled = true;
                    labelUsernameCortoModificar.Visible = false;
                }
            }
        }

        private void textBoxRepitePasswordModificar_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxUsernameModificar.Text) || String.IsNullOrEmpty(textBoxPasswordModificar.Text))
            {
                buttonModificarUsuario.Enabled = false; //comprobación básica que no permite modificar un usuario si sus campos están vacíos
            }
            else
            {
                if (textBoxPasswordModificar.Text != textBoxRepitePasswordModificar.Text) //tampoco se activa el botón si las contraseñas no coinciden
                {
                    buttonModificarUsuario.Enabled = false;
                    labelPasswordNoCoincideModificar.Visible = true;
                }
                else
                {
                    buttonModificarUsuario.Enabled = true;
                    labelPasswordNoCoincideModificar.Visible = false;
                }

                if (textBoxUsernameModificar.Text.Length < 5)
                {
                    buttonModificarUsuario.Enabled = false;
                    labelUsernameCortoModificar.Visible = true;
                }
                else
                {
                    buttonModificarUsuario.Enabled = true;
                    labelUsernameCortoModificar.Visible = false;
                }
            }
        }

        private void buttonModificarUsuario_Click(object sender, EventArgs e)
        {
            DTOUsuario dtoUsuario = new DTOUsuario(id_usuario, textBoxUsernameModificar.Text, textBoxPasswordModificar.Text, checkBoxEsAdminModificar.Checked);
            DAOUsuario daoUsuario = new DAOUsuario();

            daoUsuario.modificarUsuario(dtoUsuario, comboBoxUsuariosModificar.Text);
        }

        private void comboBoxUsuariosEliminar_TextChanged(object sender, EventArgs e)
        {
            DAOUsuario daoUsuario = new DAOUsuario();

            //activa el botón de eliminar únicamente cuando el usuario en el combo box existe
            if (daoUsuario.existeUsuario(comboBoxUsuariosEliminar.Text))
            {
                buttonEliminarUsuario.Enabled = true;
                checkBoxActivo.Enabled = true;
                checkBoxActivo.Checked = daoUsuario.buscarActividadUsuario(comboBoxUsuariosEliminar.Text);
            }
            else
            {
                buttonEliminarUsuario.Enabled = false;
                checkBoxActivo.Enabled = false;
            }
        }

        private void buttonEliminarUsuario_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea aplicar los cambios?",
                "Desactivar / Activar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                DAOUsuario daoUsuario = new DAOUsuario();
                daoUsuario.cambiarActividadUsuario(comboBoxUsuariosEliminar.Text, checkBoxActivo.Checked, id_usuario);
            }
        }
    }
}
