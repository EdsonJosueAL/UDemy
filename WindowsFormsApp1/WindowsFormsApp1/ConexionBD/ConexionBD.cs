using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class ConexionBD
    {
        #region Constructor

        public ConexionBD()
        {

        }

        #endregion Constructor

        #region Métodos Públicos

        public bool EjecutarSQL(string vStrQuery)
        {
            MySqlConnection vMySqlConnection = new MySqlConnection();
            bool vBolEjecucionCorrecta = true;

            try
            {
                vMySqlConnection = InicializarConexion();
                EjecutarSQL(vMySqlConnection, vStrQuery);
            }
            catch
            {
                if (vMySqlConnection.State != ConnectionState.Closed)
                    vMySqlConnection.Close();

                vBolEjecucionCorrecta = false;
            }
            finally
            {
                if (vMySqlConnection.State != ConnectionState.Closed)
                    vMySqlConnection.Close();
            }

            return (vBolEjecucionCorrecta);
        }

        public DbDataReader CrearDataReader(string vStrQuery)
        {
            MySqlConnection mySqlConnection = new MySqlConnection();
            DbDataReader dbDataReader = null;

            try
            {
                mySqlConnection = InicializarConexion();
                dbDataReader = CrearDataReader(mySqlConnection, vStrQuery);
            }
            catch
            {
                if (mySqlConnection.State != ConnectionState.Closed)
                    mySqlConnection.Close();
            }

            return (dbDataReader);
        }

        public DataTable CrearDataTable(string vStrQuery)
        {
            MySqlConnection vMySqlConnection = new MySqlConnection();
            DataTable vDataTable = new DataTable();

            try
            {
                vMySqlConnection = InicializarConexion();
                vDataTable = CrearDataTable(vMySqlConnection, vStrQuery);
            }
            catch
            {
                if (vMySqlConnection.State != ConnectionState.Closed)
                    vMySqlConnection.Close();
            }
            finally
            {
                if (vMySqlConnection.State != ConnectionState.Closed)
                    vMySqlConnection.Close();
            }

            return (vDataTable);
        }

        #endregion Métodos Públicos

        #region Métodos Privados

        private MySqlConnection InicializarConexion()
        {
            MySqlConnection vMySqlConnection = new MySqlConnection();
            string vStrCadenaConexion = "Server = localhost; Database = Examen; Uid = root; Pwd = 5991";

            try
            {
                vMySqlConnection.ConnectionString = vStrCadenaConexion;
                vMySqlConnection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en conexión: " + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return (vMySqlConnection);
        }

        private DbCommand CrearDBCommand(MySqlConnection vMySqlConnection, string vStrQuery)
        {
            DbCommand dbCommand = vMySqlConnection.CreateCommand();
            dbCommand.CommandText = vStrQuery;
            dbCommand.CommandTimeout = 36000;

            return (dbCommand);
        }

        private DbDataAdapter CrearDBDataAdapter(DbCommand dbCommand)
        {
            DbDataAdapter dbDataAdapter = null;
            Type type = Type.GetType("MySql.Data.MySqlClient.MySqlDataAdapter,MySql.Data");
            dbDataAdapter = (DbDataAdapter)Activator.CreateInstance(type, dbCommand);

            return (dbDataAdapter);
        }

        private void EjecutarSQL(MySqlConnection vMySqlConnection, string vStrQuery)
        {
            DbCommand dbCommand = CrearDBCommand(vMySqlConnection, vStrQuery);
            dbCommand.ExecuteNonQuery();
        }

        private DbDataReader CrearDataReader(MySqlConnection mySqlConnection, string vStrQuery)
        {
            DbCommand dbCommand = CrearDBCommand(mySqlConnection, vStrQuery);
            return (dbCommand.ExecuteReader());
        }

        private DataTable CrearDataTable(MySqlConnection vMySqlConnection, string vStrQuery)
        {
            DbCommand dbCommand = CrearDBCommand(vMySqlConnection, vStrQuery);
            DbDataAdapter dbDataAdapter = CrearDBDataAdapter(dbCommand);

            DataTable dataTable = new DataTable();
            dbDataAdapter.Fill(dataTable);

            return (dataTable);
        }

        #endregion Métodos Privados
    }
}
