using Sistema.Negocio;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.Drawing.Imaging;

namespace Sistema.Presentacion
{
    public partial class FRMArticulo : Form
    {
        //Guarda ruta absoluta de la imagen que se esta seleccinando
        private string RutaOrigen;
        //Dierectorio de proyecto donde se cargará la imagen
        private string RutaDestino;
        //Se establece un directorio - Donde se almacenaran las imagenes
        //private string Directorio = "C:\\PROYECTS\\SISTEMA_CAPAS\\DES\\DirectorioIMG\\";
        private string Directorio = ConfigurationManager.AppSettings["DirectorioIMG"].ToString();


        public FRMArticulo()
        {
            InitializeComponent();
        }

        #region METODOS DE LOGICA DE PRESENTACION
        private void Listar()
        {
            try
            {
                DGVListado.DataSource = NGArticulo.Listar();
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
            DGVListado.Columns[2].Visible = false;
            DGVListado.Columns[0].Width = 100;
            DGVListado.Columns[1].Width = 50;
            DGVListado.Columns[3].Width = 100;
            DGVListado.Columns[3].HeaderText = "Categoría";
            DGVListado.Columns[4].Width = 100;
            DGVListado.Columns[4].HeaderText = "Código";
            DGVListado.Columns[5].Width = 150;
            DGVListado.Columns[6].Width = 100;
            DGVListado.Columns[6].HeaderText = "Precio Venta";
            DGVListado.Columns[7].Width = 60;
            DGVListado.Columns[8].Width = 200;
            DGVListado.Columns[8].HeaderText = "Descripción";
            DGVListado.Columns[9].Width = 100;
            DGVListado.Columns[10].Width = 100;
        }

        private void Buscar()
        {
            try
            {
                DGVListado.DataSource = NGArticulo.Buscar(TXTBuscar.Text);
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

        private void CargarCategoria()
        {
            try
            {
                //Se indica la fuente de datos
                CBOCategoria.DataSource = NGCategoria.Seleccionar();
                //Asigna de donde obtiene el valor de los items
                CBOCategoria.ValueMember = "idcategoria";
                //Texto a mostrar de cada item
                CBOCategoria.DisplayMember = "nombre";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + Ex.StackTrace);
                throw;
            }
        }

        #endregion

        #region EVENTOS DE PAGINA
        private void FRMArticulo_Load(object sender, EventArgs e)
        {
            this.Listar();
            //Se indica el cargue de las categorias disponibles sobre el ComboBox del formulario
            this.CargarCategoria();
        }

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void BTNCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog File = new OpenFileDialog();
            //Se indica que en la ventana de dialogo solo muestre imagenes
            File.Filter = "Images Files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            //Se valida si despues de mostrar la ventana para seleccionar los archivos , el resultado es OK, entonces -->
            if (File.ShowDialog() == DialogResult.OK)
            {
                //Se cargara la imagen seleccionada en el objeto
                PCBImagen.Image = Image.FromFile(File.FileName);
                //Se indica a la caja de texto solo el nombre de la imagen - SE INDICA QUE SOLO MAPEE EL NOMBRE YA QUE LO POSTERIOR TOMA TODA LA RUTA
                TXTImagen.Text = File.FileName.Substring(File.FileName.LastIndexOf("\\") + 1);
                this.RutaOrigen = File.FileName;
            }
        }

        private void BTNGenerarCodigo_Click(object sender, EventArgs e)
        {
            //Se crea objeto que utiliza libreria "BarcodeLib" la cual permite generar Codigo de barras
            BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
            //Se indica que incluya el texto inferior de los codigos de barras comunes - EJM(9898989898)
            Codigo.IncludeLabel = true;

            if (string.IsNullOrEmpty(TXTCodigo.Text))
            {
                MensajeError("No ha ingresado ningun codigo, valide la entrada y vuelva a intertarlo");
                return;
            }

            //Se asigna imagen de fondo al panel - 1)Indica el tipo de codigo de barras - 2)Texto que sera codificado - 3)Indica color de las barras - 4)Color de fondo de codigo de barras - 5)Ancho - 6)Alto
            PNLCodigo.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128, TXTCodigo.Text, Color.Black, Color.White, 290, 120);
            BTNGuardarCodigo.Enabled = true;
        }


        #endregion

        private void BTNGuardarCodigo_Click(object sender, EventArgs e)
        {
            Image imgFinal = (Image)PNLCodigo.BackgroundImage.Clone();

            SaveFileDialog DialogoGuardar = new SaveFileDialog
            {
                AddExtension = true,
                Filter = "Image PNG (*.png)|*.png"
            };
            DialogoGuardar.ShowDialog();

            if (!string.IsNullOrEmpty(DialogoGuardar.FileName))
            {
                imgFinal.Save(DialogoGuardar.FileName, ImageFormat.Png);
            }
            imgFinal.Dispose();
        }
    }
}
