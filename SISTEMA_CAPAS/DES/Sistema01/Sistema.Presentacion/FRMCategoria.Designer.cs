
namespace Sistema.Presentacion
{
    partial class FRMCategoria
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
            this.TabGeneral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BTNEliminar = new System.Windows.Forms.Button();
            this.BTNDesactivar = new System.Windows.Forms.Button();
            this.BTNActivar = new System.Windows.Forms.Button();
            this.CHKSeleccionar = new System.Windows.Forms.CheckBox();
            this.BTNBuscar = new System.Windows.Forms.Button();
            this.TXTBuscar = new System.Windows.Forms.TextBox();
            this.LBLTotal = new System.Windows.Forms.Label();
            this.DGVListado = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BTNActualizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.BTNInsertar = new System.Windows.Forms.Button();
            this.TXTId = new System.Windows.Forms.TextBox();
            this.TXTDescripcion = new System.Windows.Forms.TextBox();
            this.TXTNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TabGeneral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.tabPage1);
            this.TabGeneral.Controls.Add(this.tabPage2);
            this.TabGeneral.Location = new System.Drawing.Point(-2, 1);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(1101, 600);
            this.TabGeneral.TabIndex = 0;
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
            this.tabPage1.Size = new System.Drawing.Size(1093, 574);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.Location = new System.Drawing.Point(416, 500);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(75, 23);
            this.BTNEliminar.TabIndex = 7;
            this.BTNEliminar.Text = "Eliminar";
            this.BTNEliminar.UseVisualStyleBackColor = true;
            this.BTNEliminar.Click += new System.EventHandler(this.BTNEliminar_Click);
            // 
            // BTNDesactivar
            // 
            this.BTNDesactivar.Location = new System.Drawing.Point(294, 500);
            this.BTNDesactivar.Name = "BTNDesactivar";
            this.BTNDesactivar.Size = new System.Drawing.Size(75, 23);
            this.BTNDesactivar.TabIndex = 6;
            this.BTNDesactivar.Text = "Desactivar";
            this.BTNDesactivar.UseVisualStyleBackColor = true;
            this.BTNDesactivar.Click += new System.EventHandler(this.BTNDesactivar_Click);
            // 
            // BTNActivar
            // 
            this.BTNActivar.Location = new System.Drawing.Point(171, 500);
            this.BTNActivar.Name = "BTNActivar";
            this.BTNActivar.Size = new System.Drawing.Size(75, 23);
            this.BTNActivar.TabIndex = 5;
            this.BTNActivar.Text = "Activar";
            this.BTNActivar.UseVisualStyleBackColor = true;
            this.BTNActivar.Click += new System.EventHandler(this.BTNActivar_Click);
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
            this.CHKSeleccionar.CheckedChanged += new System.EventHandler(this.CHKSeleccionar_CheckedChanged);
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
            this.DGVListado.Size = new System.Drawing.Size(1064, 402);
            this.DGVListado.TabIndex = 0;
            this.DGVListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListado_CellContentClick);
            this.DGVListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListado_CellDoubleClick);
            // 
            // tabPage2
            // 
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
            this.tabPage2.Size = new System.Drawing.Size(1093, 574);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BTNActualizar
            // 
            this.BTNActualizar.Location = new System.Drawing.Point(226, 294);
            this.BTNActualizar.Name = "BTNActualizar";
            this.BTNActualizar.Size = new System.Drawing.Size(121, 23);
            this.BTNActualizar.TabIndex = 8;
            this.BTNActualizar.Text = "Actualizar";
            this.BTNActualizar.UseVisualStyleBackColor = true;
            this.BTNActualizar.Click += new System.EventHandler(this.BTNActualizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "(*) Indica que el dato es obligatorio";
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Location = new System.Drawing.Point(396, 294);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(118, 23);
            this.BTNCancelar.TabIndex = 6;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.UseVisualStyleBackColor = true;
            this.BTNCancelar.Click += new System.EventHandler(this.BTNCancelar_Click);
            // 
            // BTNInsertar
            // 
            this.BTNInsertar.Location = new System.Drawing.Point(226, 294);
            this.BTNInsertar.Name = "BTNInsertar";
            this.BTNInsertar.Size = new System.Drawing.Size(121, 23);
            this.BTNInsertar.TabIndex = 5;
            this.BTNInsertar.Text = "Insertar";
            this.BTNInsertar.UseVisualStyleBackColor = true;
            this.BTNInsertar.Click += new System.EventHandler(this.BTNInsertar_Click);
            // 
            // TXTId
            // 
            this.TXTId.Location = new System.Drawing.Point(396, 39);
            this.TXTId.Name = "TXTId";
            this.TXTId.Size = new System.Drawing.Size(118, 20);
            this.TXTId.TabIndex = 4;
            this.TXTId.Visible = false;
            // 
            // TXTDescripcion
            // 
            this.TXTDescripcion.Location = new System.Drawing.Point(226, 133);
            this.TXTDescripcion.Multiline = true;
            this.TXTDescripcion.Name = "TXTDescripcion";
            this.TXTDescripcion.Size = new System.Drawing.Size(288, 88);
            this.TXTDescripcion.TabIndex = 3;
            // 
            // TXTNombre
            // 
            this.TXTNombre.Location = new System.Drawing.Point(226, 74);
            this.TXTNombre.Name = "TXTNombre";
            this.TXTNombre.Size = new System.Drawing.Size(288, 20);
            this.TXTNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre (*)";
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // FRMCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1099, 601);
            this.Controls.Add(this.TabGeneral);
            this.Name = "FRMCategoria";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.FRMCategoria_Load);
            this.TabGeneral.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DGVListado;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label LBLTotal;
        private System.Windows.Forms.Button BTNBuscar;
        private System.Windows.Forms.TextBox TXTBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTNCancelar;
        private System.Windows.Forms.Button BTNInsertar;
        private System.Windows.Forms.TextBox TXTId;
        private System.Windows.Forms.TextBox TXTDescripcion;
        private System.Windows.Forms.TextBox TXTNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.Button BTNActualizar;
        private System.Windows.Forms.Button BTNEliminar;
        private System.Windows.Forms.Button BTNDesactivar;
        private System.Windows.Forms.Button BTNActivar;
        private System.Windows.Forms.CheckBox CHKSeleccionar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
    }
}