namespace WindowsForms
{
    partial class FormRegistrosTablaEntidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrosTablaEntidades));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txtNumDocumento = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtIdTipoEntidad = new System.Windows.Forms.TextBox();
            this.txtIdGrupoEntidad = new System.Windows.Forms.TextBox();
            this.txtLimitesCreditos = new System.Windows.Forms.TextBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.txtURLTwitter = new System.Windows.Forms.TextBox();
            this.txtURLTiktok = new System.Windows.Forms.TextBox();
            this.txtURLPaginaWeb = new System.Windows.Forms.TextBox();
            this.txtURLFacebook = new System.Windows.Forms.TextBox();
            this.txtURLInstagram = new System.Windows.Forms.TextBox();
            this.cbxTipoEntidad = new System.Windows.Forms.ComboBox();
            this.cbxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.cbxRolEntidad = new System.Windows.Forms.ComboBox();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.cbxNoEliminable = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1150, 617);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(105, 107);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(110, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(285, 107);
            this.txtClave.Multiline = true;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(109, 20);
            this.txtClave.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(105, 133);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(110, 22);
            this.txtDescripcion.TabIndex = 3;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(285, 133);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(109, 22);
            this.txtTelefono.TabIndex = 4;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(105, 170);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(110, 20);
            this.txtLocalidad.TabIndex = 5;
            // 
            // txtNumDocumento
            // 
            this.txtNumDocumento.Location = new System.Drawing.Point(307, 298);
            this.txtNumDocumento.Multiline = true;
            this.txtNumDocumento.Name = "txtNumDocumento";
            this.txtNumDocumento.Size = new System.Drawing.Size(97, 18);
            this.txtNumDocumento.TabIndex = 6;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(285, 170);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(109, 20);
            this.txtDireccion.TabIndex = 7;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(611, 495);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(132, 45);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(794, 495);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(149, 45);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(434, 495);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(146, 47);
            this.btnInsertar.TabIndex = 10;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(986, 497);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(139, 45);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(348, -2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(68, 27);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(422, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(728, 402);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(330, 60);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(42, 17);
            this.txtId.TabIndex = 14;
            // 
            // txtIdTipoEntidad
            // 
            this.txtIdTipoEntidad.Location = new System.Drawing.Point(94, 372);
            this.txtIdTipoEntidad.Multiline = true;
            this.txtIdTipoEntidad.Name = "txtIdTipoEntidad";
            this.txtIdTipoEntidad.Size = new System.Drawing.Size(121, 21);
            this.txtIdTipoEntidad.TabIndex = 17;
            // 
            // txtIdGrupoEntidad
            // 
            this.txtIdGrupoEntidad.Location = new System.Drawing.Point(98, 411);
            this.txtIdGrupoEntidad.Multiline = true;
            this.txtIdGrupoEntidad.Name = "txtIdGrupoEntidad";
            this.txtIdGrupoEntidad.Size = new System.Drawing.Size(117, 18);
            this.txtIdGrupoEntidad.TabIndex = 18;
            // 
            // txtLimitesCreditos
            // 
            this.txtLimitesCreditos.Location = new System.Drawing.Point(105, 455);
            this.txtLimitesCreditos.Multiline = true;
            this.txtLimitesCreditos.Name = "txtLimitesCreditos";
            this.txtLimitesCreditos.Size = new System.Drawing.Size(110, 18);
            this.txtLimitesCreditos.TabIndex = 19;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(94, 555);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(121, 18);
            this.txtComentario.TabIndex = 22;
            // 
            // txtURLTwitter
            // 
            this.txtURLTwitter.Location = new System.Drawing.Point(298, 378);
            this.txtURLTwitter.Multiline = true;
            this.txtURLTwitter.Name = "txtURLTwitter";
            this.txtURLTwitter.Size = new System.Drawing.Size(106, 20);
            this.txtURLTwitter.TabIndex = 25;
            // 
            // txtURLTiktok
            // 
            this.txtURLTiktok.Location = new System.Drawing.Point(298, 406);
            this.txtURLTiktok.Multiline = true;
            this.txtURLTiktok.Name = "txtURLTiktok";
            this.txtURLTiktok.Size = new System.Drawing.Size(106, 21);
            this.txtURLTiktok.TabIndex = 26;
            // 
            // txtURLPaginaWeb
            // 
            this.txtURLPaginaWeb.Location = new System.Drawing.Point(307, 444);
            this.txtURLPaginaWeb.Multiline = true;
            this.txtURLPaginaWeb.Name = "txtURLPaginaWeb";
            this.txtURLPaginaWeb.Size = new System.Drawing.Size(97, 21);
            this.txtURLPaginaWeb.TabIndex = 27;
            // 
            // txtURLFacebook
            // 
            this.txtURLFacebook.Location = new System.Drawing.Point(307, 484);
            this.txtURLFacebook.Multiline = true;
            this.txtURLFacebook.Name = "txtURLFacebook";
            this.txtURLFacebook.Size = new System.Drawing.Size(97, 20);
            this.txtURLFacebook.TabIndex = 28;
            // 
            // txtURLInstagram
            // 
            this.txtURLInstagram.Location = new System.Drawing.Point(307, 521);
            this.txtURLInstagram.Multiline = true;
            this.txtURLInstagram.Name = "txtURLInstagram";
            this.txtURLInstagram.Size = new System.Drawing.Size(97, 21);
            this.txtURLInstagram.TabIndex = 29;
            // 
            // cbxTipoEntidad
            // 
            this.cbxTipoEntidad.FormattingEnabled = true;
            this.cbxTipoEntidad.Items.AddRange(new object[] {
            "Fisica",
            "Juridica"});
            this.cbxTipoEntidad.Location = new System.Drawing.Point(94, 293);
            this.cbxTipoEntidad.Name = "cbxTipoEntidad";
            this.cbxTipoEntidad.Size = new System.Drawing.Size(107, 21);
            this.cbxTipoEntidad.TabIndex = 30;
            // 
            // cbxTipoDocumento
            // 
            this.cbxTipoDocumento.FormattingEnabled = true;
            this.cbxTipoDocumento.Items.AddRange(new object[] {
            "RNC",
            "Cédula",
            "Pasaporte"});
            this.cbxTipoDocumento.Location = new System.Drawing.Point(307, 332);
            this.cbxTipoDocumento.Name = "cbxTipoDocumento";
            this.cbxTipoDocumento.Size = new System.Drawing.Size(97, 21);
            this.cbxTipoDocumento.TabIndex = 31;
            // 
            // cbxRolEntidad
            // 
            this.cbxRolEntidad.FormattingEnabled = true;
            this.cbxRolEntidad.Items.AddRange(new object[] {
            "Admin",
            "Supervisor",
            "User"});
            this.cbxRolEntidad.Location = new System.Drawing.Point(94, 339);
            this.cbxRolEntidad.Name = "cbxRolEntidad";
            this.cbxRolEntidad.Size = new System.Drawing.Size(121, 21);
            this.cbxRolEntidad.TabIndex = 32;
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Activa",
            "Inactiva"});
            this.cbxStatus.Location = new System.Drawing.Point(80, 484);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(121, 21);
            this.cbxStatus.TabIndex = 33;
            // 
            // cbxNoEliminable
            // 
            this.cbxNoEliminable.FormattingEnabled = true;
            this.cbxNoEliminable.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cbxNoEliminable.Location = new System.Drawing.Point(94, 521);
            this.cbxNoEliminable.Name = "cbxNoEliminable";
            this.cbxNoEliminable.Size = new System.Drawing.Size(117, 21);
            this.cbxNoEliminable.TabIndex = 34;
            // 
            // FormRegistrosTablaEntidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 610);
            this.Controls.Add(this.cbxNoEliminable);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.cbxRolEntidad);
            this.Controls.Add(this.cbxTipoDocumento);
            this.Controls.Add(this.cbxTipoEntidad);
            this.Controls.Add(this.txtURLInstagram);
            this.Controls.Add(this.txtURLFacebook);
            this.Controls.Add(this.txtURLPaginaWeb);
            this.Controls.Add(this.txtURLTiktok);
            this.Controls.Add(this.txtURLTwitter);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.txtLimitesCreditos);
            this.Controls.Add(this.txtIdGrupoEntidad);
            this.Controls.Add(this.txtIdTipoEntidad);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNumDocumento);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormRegistrosTablaEntidades";
            this.Text = "Registro - Tabla Entidades";
            this.Load += new System.EventHandler(this.FormRegistrosTablaEntidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.TextBox txtNumDocumento;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtIdTipoEntidad;
        private System.Windows.Forms.TextBox txtIdGrupoEntidad;
        private System.Windows.Forms.TextBox txtLimitesCreditos;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.TextBox txtURLTwitter;
        private System.Windows.Forms.TextBox txtURLTiktok;
        private System.Windows.Forms.TextBox txtURLPaginaWeb;
        private System.Windows.Forms.TextBox txtURLFacebook;
        private System.Windows.Forms.TextBox txtURLInstagram;
        private System.Windows.Forms.ComboBox cbxTipoEntidad;
        private System.Windows.Forms.ComboBox cbxTipoDocumento;
        private System.Windows.Forms.ComboBox cbxRolEntidad;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.ComboBox cbxNoEliminable;
    }
}