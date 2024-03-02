namespace Chessir.gui
{
    partial class FormGestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRepitePassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxEsAdmin = new System.Windows.Forms.CheckBox();
            this.buttonCrearUsuario = new System.Windows.Forms.Button();
            this.labelPasswordNoCoincide = new System.Windows.Forms.Label();
            this.labelUsernameCorto = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxUsuariosModificar = new System.Windows.Forms.ComboBox();
            this.labelUsernameCortoModificar = new System.Windows.Forms.Label();
            this.labelPasswordNoCoincideModificar = new System.Windows.Forms.Label();
            this.buttonModificarUsuario = new System.Windows.Forms.Button();
            this.checkBoxEsAdminModificar = new System.Windows.Forms.CheckBox();
            this.textBoxRepitePasswordModificar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxPasswordModificar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxUsernameModificar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxUsuariosEliminar = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonEliminarUsuario = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.checkBoxActivo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Code Pro Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(647, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Gestión de usuarios (Administrador)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(56, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(761, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Aquí puedes registrar nuevos usuarios en Chessir!™, modificar los ya existentes o" +
    " eliminarlos.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(53, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Crear nuevo usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(55, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Username";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(221, 223);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(293, 27);
            this.textBoxUsername.TabIndex = 11;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(220, 285);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(294, 27);
            this.textBoxPassword.TabIndex = 13;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(55, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Password";
            // 
            // textBoxRepitePassword
            // 
            this.textBoxRepitePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRepitePassword.Location = new System.Drawing.Point(221, 347);
            this.textBoxRepitePassword.Name = "textBoxRepitePassword";
            this.textBoxRepitePassword.PasswordChar = '*';
            this.textBoxRepitePassword.Size = new System.Drawing.Size(293, 27);
            this.textBoxRepitePassword.TabIndex = 15;
            this.textBoxRepitePassword.TextChanged += new System.EventHandler(this.textBoxRepitePassword_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(55, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Repite password";
            // 
            // checkBoxEsAdmin
            // 
            this.checkBoxEsAdmin.AutoSize = true;
            this.checkBoxEsAdmin.Font = new System.Drawing.Font("Arial", 10.8F);
            this.checkBoxEsAdmin.ForeColor = System.Drawing.Color.White;
            this.checkBoxEsAdmin.Location = new System.Drawing.Point(60, 409);
            this.checkBoxEsAdmin.Name = "checkBoxEsAdmin";
            this.checkBoxEsAdmin.Size = new System.Drawing.Size(187, 25);
            this.checkBoxEsAdmin.TabIndex = 16;
            this.checkBoxEsAdmin.Text = "¿Es Administrador?";
            this.checkBoxEsAdmin.UseVisualStyleBackColor = true;
            // 
            // buttonCrearUsuario
            // 
            this.buttonCrearUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.buttonCrearUsuario.Enabled = false;
            this.buttonCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrearUsuario.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrearUsuario.ForeColor = System.Drawing.Color.White;
            this.buttonCrearUsuario.Location = new System.Drawing.Point(60, 468);
            this.buttonCrearUsuario.Name = "buttonCrearUsuario";
            this.buttonCrearUsuario.Size = new System.Drawing.Size(195, 41);
            this.buttonCrearUsuario.TabIndex = 17;
            this.buttonCrearUsuario.Text = "Registrar";
            this.buttonCrearUsuario.UseVisualStyleBackColor = false;
            this.buttonCrearUsuario.Click += new System.EventHandler(this.buttonCrearUsuario_Click);
            // 
            // labelPasswordNoCoincide
            // 
            this.labelPasswordNoCoincide.AutoSize = true;
            this.labelPasswordNoCoincide.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordNoCoincide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.labelPasswordNoCoincide.Location = new System.Drawing.Point(217, 377);
            this.labelPasswordNoCoincide.Name = "labelPasswordNoCoincide";
            this.labelPasswordNoCoincide.Size = new System.Drawing.Size(175, 16);
            this.labelPasswordNoCoincide.TabIndex = 18;
            this.labelPasswordNoCoincide.Text = "La contraseña no coincide";
            this.labelPasswordNoCoincide.Visible = false;
            // 
            // labelUsernameCorto
            // 
            this.labelUsernameCorto.AutoSize = true;
            this.labelUsernameCorto.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsernameCorto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.labelUsernameCorto.Location = new System.Drawing.Point(218, 253);
            this.labelUsernameCorto.Name = "labelUsernameCorto";
            this.labelUsernameCorto.Size = new System.Drawing.Size(316, 16);
            this.labelUsernameCorto.TabIndex = 19;
            this.labelUsernameCorto.Text = "El usuario debe tener un mínimo de 5 caracteres";
            this.labelUsernameCorto.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(581, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(302, 31);
            this.label7.TabIndex = 20;
            this.label7.Text = "Modificar datos de usuario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(583, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 21);
            this.label8.TabIndex = 21;
            this.label8.Text = "Selecciona un usuario";
            // 
            // comboBoxUsuariosModificar
            // 
            this.comboBoxUsuariosModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUsuariosModificar.FormattingEnabled = true;
            this.comboBoxUsuariosModificar.Location = new System.Drawing.Point(786, 222);
            this.comboBoxUsuariosModificar.Name = "comboBoxUsuariosModificar";
            this.comboBoxUsuariosModificar.Size = new System.Drawing.Size(257, 28);
            this.comboBoxUsuariosModificar.TabIndex = 22;
            this.comboBoxUsuariosModificar.TextChanged += new System.EventHandler(this.comboBoxUsuariosModificar_TextChanged);
            // 
            // labelUsernameCortoModificar
            // 
            this.labelUsernameCortoModificar.AutoSize = true;
            this.labelUsernameCortoModificar.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsernameCortoModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.labelUsernameCortoModificar.Location = new System.Drawing.Point(746, 315);
            this.labelUsernameCortoModificar.Name = "labelUsernameCortoModificar";
            this.labelUsernameCortoModificar.Size = new System.Drawing.Size(316, 16);
            this.labelUsernameCortoModificar.TabIndex = 32;
            this.labelUsernameCortoModificar.Text = "El usuario debe tener un mínimo de 5 caracteres";
            this.labelUsernameCortoModificar.Visible = false;
            // 
            // labelPasswordNoCoincideModificar
            // 
            this.labelPasswordNoCoincideModificar.AutoSize = true;
            this.labelPasswordNoCoincideModificar.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordNoCoincideModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.labelPasswordNoCoincideModificar.Location = new System.Drawing.Point(744, 438);
            this.labelPasswordNoCoincideModificar.Name = "labelPasswordNoCoincideModificar";
            this.labelPasswordNoCoincideModificar.Size = new System.Drawing.Size(175, 16);
            this.labelPasswordNoCoincideModificar.TabIndex = 31;
            this.labelPasswordNoCoincideModificar.Text = "La contraseña no coincide";
            this.labelPasswordNoCoincideModificar.Visible = false;
            // 
            // buttonModificarUsuario
            // 
            this.buttonModificarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.buttonModificarUsuario.Enabled = false;
            this.buttonModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificarUsuario.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificarUsuario.ForeColor = System.Drawing.Color.White;
            this.buttonModificarUsuario.Location = new System.Drawing.Point(586, 535);
            this.buttonModificarUsuario.Name = "buttonModificarUsuario";
            this.buttonModificarUsuario.Size = new System.Drawing.Size(195, 41);
            this.buttonModificarUsuario.TabIndex = 30;
            this.buttonModificarUsuario.Text = "Modificar";
            this.buttonModificarUsuario.UseVisualStyleBackColor = false;
            this.buttonModificarUsuario.Click += new System.EventHandler(this.buttonModificarUsuario_Click);
            // 
            // checkBoxEsAdminModificar
            // 
            this.checkBoxEsAdminModificar.AutoSize = true;
            this.checkBoxEsAdminModificar.Enabled = false;
            this.checkBoxEsAdminModificar.Font = new System.Drawing.Font("Arial", 10.8F);
            this.checkBoxEsAdminModificar.ForeColor = System.Drawing.Color.White;
            this.checkBoxEsAdminModificar.Location = new System.Drawing.Point(586, 473);
            this.checkBoxEsAdminModificar.Name = "checkBoxEsAdminModificar";
            this.checkBoxEsAdminModificar.Size = new System.Drawing.Size(187, 25);
            this.checkBoxEsAdminModificar.TabIndex = 29;
            this.checkBoxEsAdminModificar.Text = "¿Es Administrador?";
            this.checkBoxEsAdminModificar.UseVisualStyleBackColor = true;
            // 
            // textBoxRepitePasswordModificar
            // 
            this.textBoxRepitePasswordModificar.Enabled = false;
            this.textBoxRepitePasswordModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRepitePasswordModificar.Location = new System.Drawing.Point(748, 408);
            this.textBoxRepitePasswordModificar.Name = "textBoxRepitePasswordModificar";
            this.textBoxRepitePasswordModificar.PasswordChar = '*';
            this.textBoxRepitePasswordModificar.Size = new System.Drawing.Size(295, 27);
            this.textBoxRepitePasswordModificar.TabIndex = 28;
            this.textBoxRepitePasswordModificar.TextChanged += new System.EventHandler(this.textBoxRepitePasswordModificar_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(582, 410);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 21);
            this.label11.TabIndex = 27;
            this.label11.Text = "Repite password";
            // 
            // textBoxPasswordModificar
            // 
            this.textBoxPasswordModificar.Enabled = false;
            this.textBoxPasswordModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordModificar.Location = new System.Drawing.Point(749, 347);
            this.textBoxPasswordModificar.Name = "textBoxPasswordModificar";
            this.textBoxPasswordModificar.PasswordChar = '*';
            this.textBoxPasswordModificar.Size = new System.Drawing.Size(294, 27);
            this.textBoxPasswordModificar.TabIndex = 26;
            this.textBoxPasswordModificar.TextChanged += new System.EventHandler(this.textBoxPasswordModificar_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(582, 349);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 21);
            this.label12.TabIndex = 25;
            this.label12.Text = "Password";
            // 
            // textBoxUsernameModificar
            // 
            this.textBoxUsernameModificar.Enabled = false;
            this.textBoxUsernameModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsernameModificar.Location = new System.Drawing.Point(749, 285);
            this.textBoxUsernameModificar.Name = "textBoxUsernameModificar";
            this.textBoxUsernameModificar.Size = new System.Drawing.Size(294, 27);
            this.textBoxUsernameModificar.TabIndex = 24;
            this.textBoxUsernameModificar.TextChanged += new System.EventHandler(this.textBoxUsernameModificar_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(583, 287);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 21);
            this.label13.TabIndex = 23;
            this.label13.Text = "Username";
            // 
            // comboBoxUsuariosEliminar
            // 
            this.comboBoxUsuariosEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUsuariosEliminar.FormattingEnabled = true;
            this.comboBoxUsuariosEliminar.Location = new System.Drawing.Point(1318, 223);
            this.comboBoxUsuariosEliminar.Name = "comboBoxUsuariosEliminar";
            this.comboBoxUsuariosEliminar.Size = new System.Drawing.Size(228, 28);
            this.comboBoxUsuariosEliminar.TabIndex = 35;
            this.comboBoxUsuariosEliminar.TextChanged += new System.EventHandler(this.comboBoxUsuariosEliminar_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1108, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 21);
            this.label9.TabIndex = 34;
            this.label9.Text = "Selecciona un usuario";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1106, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(319, 31);
            this.label10.TabIndex = 33;
            this.label10.Text = "Desactivar/Reactivar usuario";
            // 
            // buttonEliminarUsuario
            // 
            this.buttonEliminarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.buttonEliminarUsuario.Enabled = false;
            this.buttonEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarUsuario.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarUsuario.ForeColor = System.Drawing.Color.White;
            this.buttonEliminarUsuario.Location = new System.Drawing.Point(1112, 338);
            this.buttonEliminarUsuario.Name = "buttonEliminarUsuario";
            this.buttonEliminarUsuario.Size = new System.Drawing.Size(195, 41);
            this.buttonEliminarUsuario.TabIndex = 36;
            this.buttonEliminarUsuario.Text = "Aplicar cambios";
            this.buttonEliminarUsuario.UseVisualStyleBackColor = false;
            this.buttonEliminarUsuario.Click += new System.EventHandler(this.buttonEliminarUsuario_Click);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.label14.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(550, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(2, 500);
            this.label14.TabIndex = 37;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            this.label15.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(1080, 160);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(2, 500);
            this.label15.TabIndex = 38;
            // 
            // checkBoxActivo
            // 
            this.checkBoxActivo.AutoSize = true;
            this.checkBoxActivo.Enabled = false;
            this.checkBoxActivo.Font = new System.Drawing.Font("Arial", 10.8F);
            this.checkBoxActivo.ForeColor = System.Drawing.Color.White;
            this.checkBoxActivo.Location = new System.Drawing.Point(1112, 283);
            this.checkBoxActivo.Name = "checkBoxActivo";
            this.checkBoxActivo.Size = new System.Drawing.Size(141, 25);
            this.checkBoxActivo.TabIndex = 39;
            this.checkBoxActivo.Text = "¿Está activo?";
            this.checkBoxActivo.UseVisualStyleBackColor = true;
            // 
            // FormGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(106)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(1600, 915);
            this.Controls.Add(this.checkBoxActivo);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.buttonEliminarUsuario);
            this.Controls.Add(this.comboBoxUsuariosEliminar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelUsernameCortoModificar);
            this.Controls.Add(this.labelPasswordNoCoincideModificar);
            this.Controls.Add(this.buttonModificarUsuario);
            this.Controls.Add(this.checkBoxEsAdminModificar);
            this.Controls.Add(this.textBoxRepitePasswordModificar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxPasswordModificar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxUsernameModificar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBoxUsuariosModificar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelUsernameCorto);
            this.Controls.Add(this.labelPasswordNoCoincide);
            this.Controls.Add(this.buttonCrearUsuario);
            this.Controls.Add(this.checkBoxEsAdmin);
            this.Controls.Add(this.textBoxRepitePassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestion";
            this.Text = "FormGestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRepitePassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxEsAdmin;
        private System.Windows.Forms.Button buttonCrearUsuario;
        private System.Windows.Forms.Label labelPasswordNoCoincide;
        private System.Windows.Forms.Label labelUsernameCorto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxUsuariosModificar;
        private System.Windows.Forms.Label labelUsernameCortoModificar;
        private System.Windows.Forms.Label labelPasswordNoCoincideModificar;
        private System.Windows.Forms.Button buttonModificarUsuario;
        private System.Windows.Forms.CheckBox checkBoxEsAdminModificar;
        private System.Windows.Forms.TextBox textBoxRepitePasswordModificar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxPasswordModificar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxUsernameModificar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxUsuariosEliminar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonEliminarUsuario;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox checkBoxActivo;
    }
}