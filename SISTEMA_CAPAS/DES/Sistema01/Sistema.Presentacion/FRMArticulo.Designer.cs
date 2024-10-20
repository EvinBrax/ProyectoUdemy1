namespace Sistema.Presentacion
{
    partial class FRMArticulo
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
            this.components = new System.ComponentModel.Container();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.BTNActualizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.BTNInsertar = new System.Windows.Forms.Button();
            this.TXTId = new System.Windows.Forms.TextBox();
            this.TXTDescripcion = new System.Windows.Forms.TextBox();
            this.TXTNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BTNGuardarCodigo = new System.Windows.Forms.Button();
            this.BTNGenerarCodigo = new System.Windows.Forms.Button();
            this.TXTCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PCBImagen = new System.Windows.Forms.PictureBox();
            this.BTNCargarImagen = new System.Windows.Forms.Button();
            this.TXTImagen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBOCategoria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BTNEliminar = new System.Windows.Forms.Button();
            this.BTNDesactivar = new System.Windows.Forms.Button();
            this.BTNActivar = new System.Windows.Forms.Button();
            this.CHKSeleccionar = new System.Windows.Forms.CheckBox();
            this.BTNBuscar = new System.Windows.Forms.Button();
            this.TXTBuscar = new System.Windows.Forms.TextBox();
            this.LBLTotal = new System.Windows.Forms.Label();
            this.DGVListado = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TabGeneral = new System.Windows.Forms.TabControl();
            this.PNLCodigo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCBImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.TabGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // BTNActualizar
            // 
            this.BTNActualizar.Location = new System.Drawing.Point(16, 536);
            this.BTNActualizar.Name = "BTNActualizar";
            this.BTNActualizar.Size = new System.Drawing.Size(121, 23);
            this.BTNActualizar.TabIndex = 8;
            this.BTNActualizar.Text = "Actualizar";
            this.BTNActualizar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "(*) Indica que el dato es obligatorio";
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Location = new System.Drawing.Point(355, 536);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(118, 23);
            this.BTNCancelar.TabIndex = 6;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.UseVisualStyleBackColor = true;
            // 
            // BTNInsertar
            // 
            this.BTNInsertar.Location = new System.Drawing.Point(185, 536);
            this.BTNInsertar.Name = "BTNInsertar";
            this.BTNInsertar.Size = new System.Drawing.Size(121, 23);
            this.BTNInsertar.TabIndex = 5;
            this.BTNInsertar.Text = "Insertar";
            this.BTNInsertar.UseVisualStyleBackColor = true;
            // 
            // TXTId
            // 
            this.TXTId.Location = new System.Drawing.Point(355, 37);
            this.TXTId.Name = "TXTId";
            this.TXTId.Size = new System.Drawing.Size(118, 20);
            this.TXTId.TabIndex = 4;
            this.TXTId.Visible = false;
            // 
            // TXTDescripcion
            // 
            this.TXTDescripcion.Location = new System.Drawing.Point(188, 409);
            this.TXTDescripcion.Multiline = true;
            this.TXTDescripcion.Name = "TXTDescripcion";
            this.TXTDescripcion.Size = new System.Drawing.Size(288, 88);
            this.TXTDescripcion.TabIndex = 3;
            // 
            // TXTNombre
            // 
            this.TXTNombre.Location = new System.Drawing.Point(185, 131);
            this.TXTNombre.Name = "TXTNombre";
            this.TXTNombre.Size = new System.Drawing.Size(288, 20);
            this.TXTNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PNLCodigo);
            this.tabPage2.Controls.Add(this.BTNGuardarCodigo);
            this.tabPage2.Controls.Add(this.BTNGenerarCodigo);
            this.tabPage2.Controls.Add(this.TXTCodigo);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.PCBImagen);
            this.tabPage2.Controls.Add(this.BTNCargarImagen);
            this.tabPage2.Controls.Add(this.TXTImagen);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.CBOCategoria);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.BTNActualizar);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.BTNCancelar);
            this.tabPage2.Controls.Add(this.BTNInsertar);
            this.tabPage2.Controls.Add(this.TXTId);
            this.tabPage2.Controls.Add(this.TXTDescripcion);
            this.tabPage2.Controls.Add(this.TXTNombre);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1332, 574);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BTNGuardarCodigo
            // 
            this.BTNGuardarCodigo.Enabled = false;
            this.BTNGuardarCodigo.Location = new System.Drawing.Point(370, 204);
            this.BTNGuardarCodigo.Name = "BTNGuardarCodigo";
            this.BTNGuardarCodigo.Size = new System.Drawing.Size(103, 23);
            this.BTNGuardarCodigo.TabIndex = 18;
            this.BTNGuardarCodigo.Text = "Guardar Código";
            this.BTNGuardarCodigo.UseVisualStyleBackColor = true;
            this.BTNGuardarCodigo.Click += new System.EventHandler(this.BTNGuardarCodigo_Click);
            // 
            // BTNGenerarCodigo
            // 
            this.BTNGenerarCodigo.Location = new System.Drawing.Point(185, 204);
            this.BTNGenerarCodigo.Name = "BTNGenerarCodigo";
            this.BTNGenerarCodigo.Size = new System.Drawing.Size(106, 23);
            this.BTNGenerarCodigo.TabIndex = 17;
            this.BTNGenerarCodigo.Text = "Generar Código";
            this.BTNGenerarCodigo.UseVisualStyleBackColor = true;
            this.BTNGenerarCodigo.Click += new System.EventHandler(this.BTNGenerarCodigo_Click);
            // 
            // TXTCodigo
            // 
            this.TXTCodigo.Location = new System.Drawing.Point(185, 174);
            this.TXTCodigo.Name = "TXTCodigo";
            this.TXTCodigo.Size = new System.Drawing.Size(288, 20);
            this.TXTCodigo.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Código de barras";
            // 
            // PCBImagen
            // 
            this.PCBImagen.Location = new System.Drawing.Point(743, 131);
            this.PCBImagen.Name = "PCBImagen";
            this.PCBImagen.Size = new System.Drawing.Size(294, 247);
            this.PCBImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCBImagen.TabIndex = 14;
            this.PCBImagen.TabStop = false;
            // 
            // BTNCargarImagen
            // 
            this.BTNCargarImagen.Location = new System.Drawing.Point(988, 88);
            this.BTNCargarImagen.Name = "BTNCargarImagen";
            this.BTNCargarImagen.Size = new System.Drawing.Size(75, 23);
            this.BTNCargarImagen.TabIndex = 13;
            this.BTNCargarImagen.Text = "...";
            this.BTNCargarImagen.UseVisualStyleBackColor = true;
            this.BTNCargarImagen.Click += new System.EventHandler(this.BTNCargarImagen_Click);
            // 
            // TXTImagen
            // 
            this.TXTImagen.Enabled = false;
            this.TXTImagen.Location = new System.Drawing.Point(830, 90);
            this.TXTImagen.Name = "TXTImagen";
            this.TXTImagen.Size = new System.Drawing.Size(117, 20);
            this.TXTImagen.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(740, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Imagen";
            // 
            // CBOCategoria
            // 
            this.CBOCategoria.FormattingEnabled = true;
            this.CBOCategoria.Location = new System.Drawing.Point(185, 90);
            this.CBOCategoria.Name = "CBOCategoria";
            this.CBOCategoria.Size = new System.Drawing.Size(288, 21);
            this.CBOCategoria.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Categoria (*)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre (*)";
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.Location = new System.Drawing.Point(416, 500);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(75, 23);
            this.BTNEliminar.TabIndex = 7;
            this.BTNEliminar.Text = "Eliminar";
            this.BTNEliminar.UseVisualStyleBackColor = true;
            // 
            // BTNDesactivar
            // 
            this.BTNDesactivar.Location = new System.Drawing.Point(294, 500);
            this.BTNDesactivar.Name = "BTNDesactivar";
            this.BTNDesactivar.Size = new System.Drawing.Size(75, 23);
            this.BTNDesactivar.TabIndex = 6;
            this.BTNDesactivar.Text = "Desactivar";
            this.BTNDesactivar.UseVisualStyleBackColor = true;
            // 
            // BTNActivar
            // 
            this.BTNActivar.Location = new System.Drawing.Point(171, 500);
            this.BTNActivar.Name = "BTNActivar";
            this.BTNActivar.Size = new System.Drawing.Size(75, 23);
            this.BTNActivar.TabIndex = 5;
            this.BTNActivar.Text = "Activar";
            this.BTNActivar.UseVisualStyleBackColor = true;
            // 
            // CHKSeleccionar
            // 
            this.CHKSeleccionar.AutoSize = true;
            this.CHKSeleccionar.Location = new System.Drawing.Point(11, 500);
            this.CHKSeleccionar.Name = "CHKSeleccionar";
            this.CHKSeleccionar.Size = new System.Drawing.Size(82, 17);
            this.CHKSeleccionar.TabIndex = 4;
            this.CHKSeleccionar.Text = "Seleccionar";
            this.CHKSeleccionar.UseVisualStyleBackColor = true;
            // 
            // BTNBuscar
            // 
            this.BTNBuscar.Location = new System.Drawing.Point(545, 24);
            this.BTNBuscar.Name = "BTNBuscar";
            this.BTNBuscar.Size = new System.Drawing.Size(135, 23);
            this.BTNBuscar.TabIndex = 3;
            this.BTNBuscar.Text = "Buscar";
            this.BTNBuscar.UseVisualStyleBackColor = true;
            this.BTNBuscar.Click += new System.EventHandler(this.BTNBuscar_Click);
            // 
            // TXTBuscar
            // 
            this.TXTBuscar.Location = new System.Drawing.Point(11, 28);
            this.TXTBuscar.Name = "TXTBuscar";
            this.TXTBuscar.Size = new System.Drawing.Size(505, 20);
            this.TXTBuscar.TabIndex = 2;
            // 
            // LBLTotal
            // 
            this.LBLTotal.AutoSize = true;
            this.LBLTotal.Location = new System.Drawing.Point(972, 500);
            this.LBLTotal.Name = "LBLTotal";
            this.LBLTotal.Size = new System.Drawing.Size(34, 13);
            this.LBLTotal.TabIndex = 1;
            this.LBLTotal.Text = "Total:";
            // 
            // DGVListado
            // 
            this.DGVListado.AllowUserToAddRows = false;
            this.DGVListado.AllowUserToDeleteRows = false;
            this.DGVListado.AllowUserToOrderColumns = true;
            this.DGVListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DGVListado.Location = new System.Drawing.Point(11, 74);
            this.DGVListado.Name = "DGVListado";
            this.DGVListado.ReadOnly = true;
            this.DGVListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVListado.Size = new System.Drawing.Size(1302, 402);
            this.DGVListado.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BTNEliminar);
            this.tabPage1.Controls.Add(this.BTNDesactivar);
            this.tabPage1.Controls.Add(this.BTNActivar);
            this.tabPage1.Controls.Add(this.CHKSeleccionar);
            this.tabPage1.Controls.Add(this.BTNBuscar);
            this.tabPage1.Controls.Add(this.TXTBuscar);
            this.tabPage1.Controls.Add(this.LBLTotal);
            this.tabPage1.Controls.Add(this.DGVListado);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1332, 574);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.tabPage1);
            this.TabGeneral.Controls.Add(this.tabPage2);
            this.TabGeneral.Location = new System.Drawing.Point(0, 0);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(1340, 600);
            this.TabGeneral.TabIndex = 1;
            // 
            // PNLCodigo
            // 
            this.PNLCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PNLCodigo.Location = new System.Drawing.Point(188, 241);
            this.PNLCodigo.Name = "PNLCodigo";
            this.PNLCodigo.Size = new System.Drawing.Size(369, 137);
            this.PNLCodigo.TabIndex = 19;
            // 
            // FRMArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 690);
            this.Controls.Add(this.TabGeneral);
            this.Name = "FRMArticulo";
            this.Text = "Artículos";
            this.Load += new System.EventHandler(this.FRMArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCBImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.TabGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.TabControl TabGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BTNEliminar;
        private System.Windows.Forms.Button BTNDesactivar;
        private System.Windows.Forms.Button BTNActivar;
        private System.Windows.Forms.CheckBox CHKSeleccionar;
        private System.Windows.Forms.Button BTNBuscar;
        private System.Windows.Forms.TextBox TXTBuscar;
        private System.Windows.Forms.Label LBLTotal;
        private System.Windows.Forms.DataGridView DGVListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BTNActualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTNCancelar;
        private System.Windows.Forms.Button BTNInsertar;
        private System.Windows.Forms.TextBox TXTId;
        private System.Windows.Forms.TextBox TXTDescripcion;
        private System.Windows.Forms.TextBox TXTNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBOCategoria;
        private System.Windows.Forms.PictureBox PCBImagen;
        private System.Windows.Forms.Button BTNCargarImagen;
        private System.Windows.Forms.TextBox TXTImagen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTNGuardarCodigo;
        private System.Windows.Forms.Button BTNGenerarCodigo;
        private System.Windows.Forms.TextBox TXTCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel PNLCodigo;
    }
}