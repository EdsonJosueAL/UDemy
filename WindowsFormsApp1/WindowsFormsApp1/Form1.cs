using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmExamen : Form
    {
        #region Atributos

        private ConexionBDSQL cConexionBD;
        private static string CONSULTA_PRODUCTOS = "SELECT * FROM PRODUCTOS";

        #endregion Atributos

        #region Propiedades

        private ESTADO ESTADO_ACTUAL
        {
            get;
            set;
        }

        private enum ESTADO
        {
            INICIAL,
            REGISTRO_CLIENTE,
            VENTA
        }

        #endregion Propiedades

        #region Constructor

        public frmExamen()
        {
            InitializeComponent();
            InicializarGrid();
            EventosButton();
            EventosGrid();
            cConexionBD = new ConexionBDSQL();
        }

        private void EventosGrid()
        {
            this.dgvProductos.CellContentClick += new DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
        }

        #endregion Constructor

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarGrid();
            ESTADO_ACTUAL = ESTADO.INICIAL;
            EstablecerComportamiento();
        }

        private void CargarGrid()
        {
            dgvProductos.LlenarGrid(CONSULTA_PRODUCTOS);
        }

        private void InicializarGrid()
        {
            Columnas.AgregarColumnaTextBox(dgvProductos, "ID_PRODUCTO", "ID_PRODUCTO", 0, false);
            Columnas.AgregarColumnaTextBox(dgvProductos, "NOMBRE_PRODUCTO", "NOMBRE", .40, true);
            Columnas.AgregarColumnaTextBox(dgvProductos, "PRECIO_PRODUCTO", "PRECIO", .25, true);
            Columnas.AgregarColumnaTextBox(dgvProductos, "APLICA_IVA", "APLICA IVA", .15, true);
            Columnas.AgregarColumnaCheckBox(dgvProductos, "VENDER", "VENDER", .10, true);
        }

        private void EstablecerComportamiento()
        {
            switch (ESTADO_ACTUAL)
            {
                case ESTADO.INICIAL:
                    {
                        CargarEstadoInicial();
                        break;
                    }
                case ESTADO.REGISTRO_CLIENTE:
                    {
                        CargarEstadoRegistroCliente();
                        break;
                    }
                case ESTADO.VENTA:
                    {
                        CargarEstadoVenta();
                        break;
                    }
            }
        }

        private void CargarEstadoVenta()
        {
            txbNombrePersona.Text = "";
            CargarEstadoInicial();
            CargarGrid();
        }

        private void CargarEstadoRegistroCliente()
        {
            dgvProductos.Enabled = true;
            btnVenta.Visible = true;
        }

        private void CargarEstadoInicial()
        {
            dgvProductos.Enabled = false;
            btnVenta.Visible = false;
        }

        private void EventosButton()
        {
            btnRegistrarPersona.Click += new EventHandler(btnRegistrarPersona_Click);
            btnVenta.Click += new EventHandler(btnVenta_Click);
        }

        private void btnRegistrarPersona_Click(object sender, EventArgs e)
        {
            string vStrNombrePersona = txbNombrePersona.Text;

            if (ValidarNombrePersona(vStrNombrePersona))
            {
                if (!ExistePersonaRegistrada(vStrNombrePersona))
                {
                    bool vBolRegistroCorrecto = true;
                    RegistrarPersona(vStrNombrePersona, ref vBolRegistroCorrecto);
                    MostrarMensajeRegistroPersona(vBolRegistroCorrecto);
                }
                else
                    MostrarMensajeExistePersona();

                ESTADO_ACTUAL = ESTADO.REGISTRO_CLIENTE;
                EstablecerComportamiento();
            }
        }

        private void MostrarMensajeExistePersona()
        {
            MessageBox.Show("Persona ya registrada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MostrarMensajeRegistroPersona(bool vBolRegistroCorrecto)
        {
            string vStrMensaje = 
                vBolRegistroCorrecto ? 
                "La persona fue ingresada correctamente" :
                "Existió un error al registrar a la persona";

            string vStrCaption = 
                vBolRegistroCorrecto ? 
                "Alerta" : 
                "Error";

            MessageBoxIcon vMessageBoxIcon = 
                vBolRegistroCorrecto ? 
                MessageBoxIcon.Information :
                MessageBoxIcon.Error;

            MessageBox.Show(vStrMensaje, vStrCaption, MessageBoxButtons.OK, vMessageBoxIcon);
        }

        private void RegistrarPersona(string vStrNombrePersona, ref bool pvBolRegistroCorrecto)
        {
            StringBuilder vStringBuilder = new StringBuilder();

            vStringBuilder.AppendLine("INSERT INTO PERSONAS(NOMBRE_PERSONA) ")
                            .Append("VALUES('").Append(vStrNombrePersona).AppendLine("')");

            pvBolRegistroCorrecto = cConexionBD.EjecutarSQL(vStringBuilder.ToString());
        }

        private bool ExistePersonaRegistrada(string pvStrNombrePersona)
        {
            bool vBolExistePersonaRegistrada = false;

            DataTable vDtPersona = new DataTable();
            vDtPersona = cConexionBD.CrearDataTable("SELECT NOMBRE_PERSONA FROM PERSONAS WHERE NOMBRE_PERSONA = '" + pvStrNombrePersona + "'");

            if (vDtPersona != null && vDtPersona.Rows.Count > 0)
            {
                object vObjPersona = vDtPersona.Rows[0]["NOMBRE_PERSONA"];

                if (vObjPersona!= null && vObjPersona != DBNull.Value && !vObjPersona.Equals(string.Empty))
                {
                    vBolExistePersonaRegistrada = vObjPersona.ToString().Length > 0;
                }
            }

            return (vBolExistePersonaRegistrada);
        }

        private bool ValidarNombrePersona(string pvStrNombrePersona)
        {
            bool vBolValido = true;

            if (pvStrNombrePersona.Length == 0 || pvStrNombrePersona.ToString().Equals(string.Empty))
            {
                vBolValido = false;
                MessageBox.Show("Debe ingresar el nombre de una persona", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return (vBolValido);
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvRow in dgvProductos.Rows)
            {
                if (dgvRow.Cells["VENDER"].Value is bool)
                {
                    bool vBolValorCelda = false;
                    ObtenerValorBooleanoCelda(dgvRow.Cells["VENDER"], out vBolValorCelda);

                    if (vBolValorCelda)
                        RegistrarVenta(dgvRow);
                }
            }

            MessageBox.Show("Venta correcta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ESTADO_ACTUAL = ESTADO.VENTA;
            EstablecerComportamiento();
        }

        private void RegistrarVenta(DataGridViewRow dgvRow)
        {
            int vIntIDProducto = 0;
            int.TryParse(dgvRow.Cells["ID_PRODUCTO"].Value.ToString(), out vIntIDProducto);
            int vIntIDPersona = ObtenerIDPersona(txbNombrePersona.Text);
            int vIntCantidad = 1;
            string vStrPrecio = dgvRow.Cells["PRECIO_PRODUCTO"].Value.ToString().Replace(",", ".");

            RegistrarVenta(vIntIDPersona, vIntIDProducto, vIntCantidad, vStrPrecio);
        }

        private bool RegistrarVenta(int vIntIDPersona, int vIntIDProducto, int vIntCantidad, string vStrPrecio)
        {
            bool pvBolRegistroCorrecto = false;
            StringBuilder vStringBuilder = new StringBuilder();

            vStringBuilder.AppendLine("INSERT INTO VENTA_PRODUCTOS(ID_PERSONA, ID_PRODUCTO, CANTIDAD, TOTAL_VENTA) ")
                            .Append("VALUES(").Append(vIntIDPersona).Append(",").Append(vIntIDProducto).Append(",")
                            .Append(vIntCantidad).Append(",").Append(vStrPrecio).AppendLine(")");

            pvBolRegistroCorrecto = cConexionBD.EjecutarSQL(vStringBuilder.ToString());
            return (pvBolRegistroCorrecto);
        }

        private int ObtenerIDPersona(string pvStrNombrePersona)
        {
            int vBolIntIDPersona = 0;

            DataTable vDtIDPersona = new DataTable();
            vDtIDPersona = cConexionBD.CrearDataTable("SELECT ID_PERSONA FROM PERSONAS WHERE NOMBRE_PERSONA = '" + pvStrNombrePersona + "'");

            if (vDtIDPersona != null && vDtIDPersona.Rows.Count > 0)
            {
                object vObjPersona = vDtIDPersona.Rows[0]["ID_PERSONA"];

                if (vObjPersona != null && vObjPersona != DBNull.Value && !vObjPersona.Equals(string.Empty))
                {
                    int.TryParse(vObjPersona.ToString(),out vBolIntIDPersona);
                }
            }

            return (vBolIntIDPersona);
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                if (dgvProductos.Rows[e.RowIndex].Cells["VENDER"] is DataGridViewCheckBoxCell)
                {
                    bool vBolValorCelda = false;
                    ObtenerValorBooleanoCelda(dgvProductos.Rows[e.RowIndex].Cells["VENDER"], out vBolValorCelda);

                    if (vBolValorCelda)
                        dgvProductos.Rows[e.RowIndex].Cells["VENDER"].Value = false;
                    else
                        dgvProductos.Rows[e.RowIndex].Cells["VENDER"].Value = true;
                }
            }
        }

        private void ObtenerValorBooleanoCelda(DataGridViewCell dataGridViewCell, out bool vBolValorCelda)
        {
            string vStrCelda = 
                dataGridViewCell.Value != null ?
                (dataGridViewCell.Value).ToString() : 
                "false";

            bool.TryParse(vStrCelda, out vBolValorCelda);
        }
    }
}
