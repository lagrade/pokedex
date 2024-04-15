namespace conexionsql
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwpokemon = new System.Windows.Forms.DataGridView();
            this.pbxpokemon = new System.Windows.Forms.PictureBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btneliminarLogico = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.lblcampo = new System.Windows.Forms.Label();
            this.lblcritero = new System.Windows.Forms.Label();
            this.lblfiltroavanzado = new System.Windows.Forms.Label();
            this.cboxCampo = new System.Windows.Forms.ComboBox();
            this.cboxCriterio = new System.Windows.Forms.ComboBox();
            this.txtfiltroavanzado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwpokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxpokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwpokemon
            // 
            this.dgwpokemon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwpokemon.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwpokemon.Location = new System.Drawing.Point(4, 116);
            this.dgwpokemon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgwpokemon.Name = "dgwpokemon";
            this.dgwpokemon.RowHeadersWidth = 51;
            this.dgwpokemon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwpokemon.Size = new System.Drawing.Size(667, 319);
            this.dgwpokemon.TabIndex = 0;
            this.dgwpokemon.SelectionChanged += new System.EventHandler(this.dgwpokemon_SelectionChanged);
            // 
            // pbxpokemon
            // 
            this.pbxpokemon.Location = new System.Drawing.Point(679, 116);
            this.pbxpokemon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxpokemon.Name = "pbxpokemon";
            this.pbxpokemon.Size = new System.Drawing.Size(372, 316);
            this.pbxpokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxpokemon.TabIndex = 1;
            this.pbxpokemon.TabStop = false;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(9, 457);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(153, 36);
            this.btnagregar.TabIndex = 2;
            this.btnagregar.Text = "agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(171, 457);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(140, 36);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(319, 457);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 36);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar fisico";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btneliminarLogico
            // 
            this.btneliminarLogico.Location = new System.Drawing.Point(461, 457);
            this.btneliminarLogico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btneliminarLogico.Name = "btneliminarLogico";
            this.btneliminarLogico.Size = new System.Drawing.Size(152, 34);
            this.btneliminarLogico.TabIndex = 5;
            this.btneliminarLogico.Text = "eliminar logico";
            this.btneliminarLogico.UseVisualStyleBackColor = true;
            this.btneliminarLogico.Click += new System.EventHandler(this.btneliminarLogico_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filtro";
            // 
            // txtfiltro
            // 
            this.txtfiltro.Location = new System.Drawing.Point(81, 65);
            this.txtfiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(199, 22);
            this.txtfiltro.TabIndex = 7;
            this.txtfiltro.TextChanged += new System.EventHandler(this.txtfiltro_TextChanged);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(764, 543);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(117, 28);
            this.btnbuscar.TabIndex = 8;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // lblcampo
            // 
            this.lblcampo.AutoSize = true;
            this.lblcampo.Location = new System.Drawing.Point(25, 552);
            this.lblcampo.Name = "lblcampo";
            this.lblcampo.Size = new System.Drawing.Size(51, 16);
            this.lblcampo.TabIndex = 9;
            this.lblcampo.Text = "Campo";
            // 
            // lblcritero
            // 
            this.lblcritero.AutoSize = true;
            this.lblcritero.Location = new System.Drawing.Point(270, 555);
            this.lblcritero.Name = "lblcritero";
            this.lblcritero.Size = new System.Drawing.Size(49, 16);
            this.lblcritero.TabIndex = 11;
            this.lblcritero.Text = "Criterio";
            // 
            // lblfiltroavanzado
            // 
            this.lblfiltroavanzado.AutoSize = true;
            this.lblfiltroavanzado.Location = new System.Drawing.Point(491, 555);
            this.lblfiltroavanzado.Name = "lblfiltroavanzado";
            this.lblfiltroavanzado.Size = new System.Drawing.Size(96, 16);
            this.lblfiltroavanzado.TabIndex = 12;
            this.lblfiltroavanzado.Text = "Filto Avanzado";
            // 
            // cboxCampo
            // 
            this.cboxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCampo.FormattingEnabled = true;
            this.cboxCampo.Location = new System.Drawing.Point(96, 546);
            this.cboxCampo.Name = "cboxCampo";
            this.cboxCampo.Size = new System.Drawing.Size(138, 24);
            this.cboxCampo.TabIndex = 13;
            this.cboxCampo.SelectedIndexChanged += new System.EventHandler(this.cboxCampo_SelectedIndexChanged);
            // 
            // cboxCriterio
            // 
            this.cboxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCriterio.FormattingEnabled = true;
            this.cboxCriterio.Location = new System.Drawing.Point(334, 547);
            this.cboxCriterio.Name = "cboxCriterio";
            this.cboxCriterio.Size = new System.Drawing.Size(138, 24);
            this.cboxCriterio.TabIndex = 14;
            // 
            // txtfiltroavanzado
            // 
            this.txtfiltroavanzado.Location = new System.Drawing.Point(608, 548);
            this.txtfiltroavanzado.Name = "txtfiltroavanzado";
            this.txtfiltroavanzado.Size = new System.Drawing.Size(125, 22);
            this.txtfiltroavanzado.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 630);
            this.Controls.Add(this.txtfiltroavanzado);
            this.Controls.Add(this.cboxCriterio);
            this.Controls.Add(this.cboxCampo);
            this.Controls.Add(this.lblfiltroavanzado);
            this.Controls.Add(this.lblcritero);
            this.Controls.Add(this.lblcampo);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtfiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btneliminarLogico);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.pbxpokemon);
            this.Controls.Add(this.dgwpokemon);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwpokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxpokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwpokemon;
        private System.Windows.Forms.PictureBox pbxpokemon;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btneliminarLogico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label lblcampo;
        private System.Windows.Forms.Label lblcritero;
        private System.Windows.Forms.Label lblfiltroavanzado;
        private System.Windows.Forms.ComboBox cboxCampo;
        private System.Windows.Forms.ComboBox cboxCriterio;
        private System.Windows.Forms.TextBox txtfiltroavanzado;
    }
}

