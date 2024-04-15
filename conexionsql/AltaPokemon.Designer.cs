namespace conexionsql
{
    partial class AltaPokemon
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbltipo = new System.Windows.Forms.Label();
            this.lbldebilidad = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.cbxDebilidad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.pbxpokemon = new System.Windows.Forms.PictureBox();
            this.btnAgregarImg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxpokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(39, 11);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(55, 16);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Numero";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(39, 47);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(13, 79);
            this.lbldescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(79, 16);
            this.lbldescripcion.TabIndex = 2;
            this.lbldescripcion.Text = "Descripcion";
            this.lbldescripcion.Click += new System.EventHandler(this.lbldescripcion_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(105, 11);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(177, 22);
            this.txtNumero.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(105, 43);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(177, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(105, 79);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(177, 22);
            this.txtDescripcion.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(16, 212);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(125, 42);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(151, 212);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 42);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Location = new System.Drawing.Point(60, 145);
            this.lbltipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(35, 16);
            this.lbltipo.TabIndex = 8;
            this.lbltipo.Text = "Tipo";
            // 
            // lbldebilidad
            // 
            this.lbldebilidad.AutoSize = true;
            this.lbldebilidad.Location = new System.Drawing.Point(29, 182);
            this.lbldebilidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldebilidad.Name = "lbldebilidad";
            this.lbldebilidad.Size = new System.Drawing.Size(66, 16);
            this.lbldebilidad.TabIndex = 9;
            this.lbldebilidad.Text = "Debilidad";
            // 
            // cbxTipo
            // 
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(105, 145);
            this.cbxTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(177, 24);
            this.cbxTipo.TabIndex = 4;
            // 
            // cbxDebilidad
            // 
            this.cbxDebilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDebilidad.FormattingEnabled = true;
            this.cbxDebilidad.Location = new System.Drawing.Point(105, 178);
            this.cbxDebilidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxDebilidad.Name = "cbxDebilidad";
            this.cbxDebilidad.Size = new System.Drawing.Size(177, 24);
            this.cbxDebilidad.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Url Imagen";
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(105, 111);
            this.txtImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(177, 22);
            this.txtImagen.TabIndex = 3;
            this.txtImagen.Leave += new System.EventHandler(this.txtImagen_Leave);
            // 
            // pbxpokemon
            // 
            this.pbxpokemon.Location = new System.Drawing.Point(334, 11);
            this.pbxpokemon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxpokemon.Name = "pbxpokemon";
            this.pbxpokemon.Size = new System.Drawing.Size(264, 241);
            this.pbxpokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxpokemon.TabIndex = 13;
            this.pbxpokemon.TabStop = false;
            // 
            // btnAgregarImg
            // 
            this.btnAgregarImg.Location = new System.Drawing.Point(289, 109);
            this.btnAgregarImg.Name = "btnAgregarImg";
            this.btnAgregarImg.Size = new System.Drawing.Size(25, 26);
            this.btnAgregarImg.TabIndex = 14;
            this.btnAgregarImg.Text = "+";
            this.btnAgregarImg.UseVisualStyleBackColor = true;
            this.btnAgregarImg.Click += new System.EventHandler(this.btnAgregarImg_Click);
            // 
            // AltaPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 272);
            this.Controls.Add(this.btnAgregarImg);
            this.Controls.Add(this.pbxpokemon);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxDebilidad);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.lbldebilidad);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNumero);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AltaPokemon";
            this.Text = "AltaPokemon";
            this.Load += new System.EventHandler(this.AltaPokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxpokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Label lbldebilidad;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.ComboBox cbxDebilidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.PictureBox pbxpokemon;
        private System.Windows.Forms.Button btnAgregarImg;
    }
}