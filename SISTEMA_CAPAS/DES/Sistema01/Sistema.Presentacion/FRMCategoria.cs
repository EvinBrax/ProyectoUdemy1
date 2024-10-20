using Sistema.Negocio;
using System;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class FRMCategoria : Form
    {
        private string NombreAnt;

        public FRMCategoria()
        {
            InitializeComponent();
        }

        #region METODOS DE LOGICA DE PRESENTACION
        private void Listar()
        {
            try
            {
                DGVListado.DataSource = NGCategoria.Listar();
                this.Formato();
                this.Limpiar();
                LBLTotal.Text = "Total Registros: " + Convert.ToString(DGVListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Formato()
        {
            DGVListado.Columns[0].Visible = false;
            DGVListado.Columns[1].Visible = false;
            DGVListado.Columns[2].Width = 150;
            DGVListado.Columns[3].Width = 400;
            DGVListado.Columns[3].HeaderText = "Descripción";
            DGVListado.Columns[4].Width = 100;
        }

        private void Buscar()
        {
            try
            {
                DGVListado.DataSource = NGCategoria.Buscar(TXTBuscar.Text);
                this.Formato();
                LBLTotal.Text = "Total Registros: " + Convert.ToString(DGVListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Limpiar(bool activaOpcionActualizar = false)
        {
            TXTId.Clear();
            TXTBuscar.Clear();
            TXTNombre.Clear();
            TXTDescripcion.Clear();
            ErrorIcono.Clear();

            if (!activaOpcionActualizar)
            {
                BTNInsertar.Visible = true;
                BTNActualizar.Visible = false;
            }
            else
            {
                BTNInsertar.Visible = false;
                BTNActualizar.Visible = true;
            }

            DGVListado.Columns[0].Visible = false;
            BTNActivar.Visible = false;
            BTNDesactivar.Visible = false;
            BTNEliminar.Visible = false;
            CHKSeleccionar.Checked = false;
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion


        #region EVENTOS DE PAGINA
        private void FRMCategoria_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void BTNInsertar_Click(object sender, EventArgs e)
        {
            string Respuesta = string.Empty;
            try
            {
                if (string.IsNullOrEmpty(TXTNombre.Text))
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados en el formulario.");
                    ErrorIcono.SetError(TXTNombre, "Ingrese un nombre.");
                }
                else
                {
                    Respuesta = NGCategoria.Insertar(TXTNombre.Text.Trim(), TXTDescripcion.Text.Trim());

                    if (Respuesta.Equals("OK"))
                    {
                        this.MensajeOK("Se insertó de forma correcta el registro!.");
                        this.Limpiar();
                        this.Listar();
                    }
                    else
                        this.MensajeError(Respuesta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            TabGeneral.SelectedIndex = 0;
        }

        private void DGVListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar(true);
                this.NombreAnt = Convert.ToString(DGVListado.CurrentRow.Cells["Nombre"].Value);
                TXTId.Text = Convert.ToString(DGVListado.CurrentRow.Cells["ID"].Value);
                TXTNombre.Text = Convert.ToString(DGVListado.CurrentRow.Cells["Nombre"].Value);
                TXTDescripcion.Text = Convert.ToString(DGVListado.CurrentRow.Cells["Descripcion"].Value);
                TabGeneral.SelectedIndex = 1;
            }
            catch (Exception)
            {
                MessageBox.Show("Para editar un registro seleccione desde la selda 'Nombre'.");
            }
        }

        private void BTNActualizar_Click(object sender, EventArgs e)
        {
            string Respuesta = string.Empty;
            try
            {
                if (string.IsNullOrEmpty(TXTNombre.Text) || string.IsNullOrEmpty(TXTId.Text))
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados en el formulario.");
                    ErrorIcono.SetError(TXTNombre, "Ingrese un nombre.");
                }
                else
                {
                    int idActualizar = Convert.ToInt32(TXTId.Text);
                    Respuesta = NGCategoria.Actualizar(idActualizar, this.NombreAnt, TXTNombre.Text.Trim(), TXTDescripcion.Text.Trim());

                    if (Respuesta.Equals("OK"))
                    {
                        this.MensajeOK("Se actualizó de forma correcta el registro!.");
                        this.Limpiar();
                        this.Listar();
                    }
                    else
                        this.MensajeError(Respuesta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void CHKSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKSeleccionar.Checked)
            {
                DGVListado.Columns[0].Visible = true;
                BTNActivar.Visible = true;
                BTNDesactivar.Visible = true;
                BTNEliminar.Visible = true;
            }
            else
            {
                DGVListado.Columns[0].Visible = false;
                BTNActivar.Visible = false;
                BTNDesactivar.Visible = false;
                BTNEliminar.Visible = false;
            }
        }

        private void DGVListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.Equals(DGVListado.Columns["Seleccionar"].Index))
            {
                //Validación que determina si la celada debe estar marcada o no - Validación siguiendo la DOC de DataGriedView Para poder marcar y desmarcar un objeto.
                //Validación cambia el valor de selección segun el estado actual (EJM: Si es TRUE se asigna FALSE, Si es NULL se asigna FALSE)
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)DGVListado.Rows[e.RowIndex].Cells["Seleccionar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente desea eliminar el(los) registro(s)?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion.Equals(DialogResult.OK))
                {
                    int Codigo = 0;
                    string Respuesta = string.Empty;

                    foreach (DataGridViewRow Row in DGVListado.Rows)
                    {
                        //Se valida si la celda de la columna "0" Esta marcada
                        bool RowSelected = Convert.ToBoolean(Row.Cells[0].Value);
                        if (RowSelected)
                        {
                            //Se obtiene el ID del registro
                            Codigo = Convert.ToInt32(Row.Cells[1].Value);
                            Respuesta = NGCategoria.Eliminar(Codigo);

                            if (Respuesta.Equals("OK"))
                            {
                                //Se expone el nombre del registro eliminado
                                this.MensajeOK("Se eliminó el registro " + Convert.ToString(Row.Cells[2].Value));
                            }
                            else
                            {
                                this.MensajeError(Respuesta);
                            }
                        }
                    }
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BTNActivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente desea activar el(los) registro(s)?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion.Equals(DialogResult.OK))
                {
                    int Codigo = 0;
                    string Respuesta = string.Empty;

                    foreach (DataGridViewRow Row in DGVListado.Rows)
                    {
                        //Se valida si la celda de la columna "0" Esta marcada
                        bool RowSelected = Convert.ToBoolean(Row.Cells[0].Value);
                        if (RowSelected)
                        {
                            //Se agrega validación que indica si ya esta activo el registro seleccionado
                            bool RowActualState = Convert.ToBoolean(Row.Cells[4].Value);
                            if (RowActualState)
                            {
                                this.MensajeError("Ya se encuentra activo el registro " + Convert.ToString(Row.Cells[2].Value));
                            }
                            else
                            {
                                //Se obtiene el ID del registro
                                Codigo = Convert.ToInt32(Row.Cells[1].Value);
                                Respuesta = NGCategoria.Activar(Codigo);

                                if (Respuesta.Equals("OK"))
                                {
                                    //Se expone el nombre del registro eliminado
                                    this.MensajeOK("Se activó el registro " + Convert.ToString(Row.Cells[2].Value));
                                }
                                else
                                {
                                    this.MensajeError(Respuesta);
                                }
                            }
                        }
                    }
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BTNDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente desea desactivar el(los) registro(s)?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion.Equals(DialogResult.OK))
                {
                    int Codigo = 0;
                    string Respuesta = string.Empty;

                    foreach (DataGridViewRow Row in DGVListado.Rows)
                    {
                        //Se valida si la celda de la columna "0" Esta marcada
                        bool RowSelected = Convert.ToBoolean(Row.Cells[0].Value);
                        if (RowSelected)
                        {
                            //Se agrega validación que indica si ya esta activo el registro seleccionado
                            bool RowActualState = Convert.ToBoolean(Row.Cells[4].Value);
                            if (!RowActualState)
                            {
                                this.MensajeError("Ya se encuentra desactivado el registro " + Convert.ToString(Row.Cells[2].Value));
                            }
                            else
                            {
                                //Se obtiene el ID del registro
                                Codigo = Convert.ToInt32(Row.Cells[1].Value);
                                Respuesta = NGCategoria.Desactivar(Codigo);

                                if (Respuesta.Equals("OK"))
                                {
                                    //Se expone el nombre del registro eliminado
                                    this.MensajeOK("Se desactivó el registro " + Convert.ToString(Row.Cells[2].Value));
                                }
                                else
                                {
                                    this.MensajeError(Respuesta);
                                }
                            }
                        }
                    }
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        #endregion
    }
}
