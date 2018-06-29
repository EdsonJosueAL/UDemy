using System;
using System.Data.Common;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public static class Gestion
    {
        public static void LlenarGrid(this DataGridView pvDataGridView, string pvStrQuery)
        {
            //Limpiamos el Grid
            pvDataGridView.Rows.Clear();
            //Creamos instancia de la clase de ConexionBD
            ConexionBD conexionBD = new ConexionBD();
            //Creamos la instancia de DBDataReader
            DbDataReader vDrOrigenDatos = null;

            //Si la consulta tiene valor
            if (pvStrQuery.Length > 0)
            {
                try
                {
                    //Llenamos el DBDataReader
                    vDrOrigenDatos = conexionBD.CrearDataReader(pvStrQuery);
                    //Si no es nulo
                    if (vDrOrigenDatos != null)
                    {
                        //Mientras tenga información
                        while (vDrOrigenDatos.Read())
                        {
                            //Agregamos una nueva fila y recuperamos su índice
                            int vIndiceFila = pvDataGridView.Rows.Add();
                            //Iteramos las columnas del grid
                            for (int indiceColumna = 0; indiceColumna < pvDataGridView.Columns.Count; ++indiceColumna)
                            {
                                //Si el la columna iterada es de tipo DataGridViewCheckBoxColumn continuamos
                                if (pvDataGridView.Columns[indiceColumna] is DataGridViewCheckBoxColumn)
                                    continue;

                                //Recuperamos el valor del DBDataReader en la posición del índice de la columna iterada
                                object vObjNuevoValorCelda = vDrOrigenDatos.GetValue(indiceColumna);
                                //Si el tipo del objeto recuperado es DBNull continuamos con la sig. columna
                                if (vObjNuevoValorCelda.GetType().Equals(typeof(System.DBNull)))
                                    continue;
                                //Si la columna iterada es de tipo DataGridViewTextBoxColumn
                                if (pvDataGridView.Columns[indiceColumna] is DataGridViewTextBoxColumn)
                                {
                                    //Asignamos el nuevo valor a la celda de la fila agregada en el índice correspondiente
                                    pvDataGridView.Rows[vIndiceFila].Cells[indiceColumna].Value = vObjNuevoValorCelda.ToString();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Existió un error al momento de cargar el Grid" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    //Quitamos la selección del grid
                    pvDataGridView.ClearSelection();
                }
            }
        }
    }
}
