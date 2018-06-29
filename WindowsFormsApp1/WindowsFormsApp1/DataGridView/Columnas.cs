using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Columnas
    {
        public Columnas()
        {

        }

        /// <summary>
        /// Método para agregar columnas de tipo TextBox a un DataGridView
        /// </summary>
        /// <param name="pvDataGridView">Instancia del Grid a afectar</param>
        /// <param name="pvStrNombreColumna">Nombre de la columna</param>
        /// <param name="pvStrEncabezado">Texto del encabezado de la columna</param>
        /// <param name="pvDouAncho">Ancho en porcentaje (0.01 - 0.99) de la columna</param>
        /// <param name="pvBolVisible">Indica si la columna deberá mostrarse</param>
        public static void AgregarColumnaTextBox(DataGridView pvDataGridView, string pvStrNombreColumna,
                                            string pvStrEncabezado, double pvDouAncho, bool pvBolVisible)
        {
            //Creamos una nueva columna de tipo TextBox
            DataGridViewTextBoxColumn dgvTextBoxColumn = new DataGridViewTextBoxColumn();

            //Se obtiene el ancho del Grid
            int vIntAnchoGridActual = pvDataGridView.Width;

            //Se asigna el nombre de la columna
            dgvTextBoxColumn.Name = pvStrNombreColumna;
            //Se asigna el nombre del encabezado de la columna
            dgvTextBoxColumn.HeaderText = pvStrEncabezado;
            //Se asigna el ancho de la columna
            dgvTextBoxColumn.Width = (int)(pvDouAncho * vIntAnchoGridActual);
            //Se asigna el tipo de valor contenido
            dgvTextBoxColumn.ValueType = typeof(string);
            //Se hace o no visible conforme al valor del parámetro
            dgvTextBoxColumn.Visible = pvBolVisible;

            //Agregamos la columna junto con las ya existentes en el Grid
            pvDataGridView.Columns.Add(dgvTextBoxColumn);
        }

        public static void AgregarColumnaCheckBox(DataGridView pvDataGridView, string pvStrNombreColumna,
                                            string pvStrEncabezado, double pvDouAncho, bool pvBolVisible)
        {
            //Creamos una nueva columna de tipo CheckBox
            DataGridViewCheckBoxColumn dgvCheckBoxColumn = new DataGridViewCheckBoxColumn();

            //Se obtiene el ancho del Grid
            int vIntAnchoGridActual = pvDataGridView.Width;

            //Se asigna el nombre de la columna
            dgvCheckBoxColumn.Name = pvStrNombreColumna;
            //Se asigna el nombre del encabezado de la columna
            dgvCheckBoxColumn.HeaderText = pvStrEncabezado;
            //Se asigna el ancho de la columna
            dgvCheckBoxColumn.Width = (int)(pvDouAncho * vIntAnchoGridActual);
            //Se asigna el tipo de valor contenido
            dgvCheckBoxColumn.ValueType = typeof(int);
            //Se hace o no visible conforme al valor del parámetro
            dgvCheckBoxColumn.Visible = pvBolVisible;

            dgvCheckBoxColumn.TrueValue = 0;
            dgvCheckBoxColumn.FalseValue = 1;
            dgvCheckBoxColumn.ThreeState = false;

            //Agregamos la columna junto con las ya existentes en el Grid
            pvDataGridView.Columns.Add(dgvCheckBoxColumn);
        }
    }
}
