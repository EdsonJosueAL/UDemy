using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class ConexionBDSQL
    {
        #region Constructor

        public ConexionBDSQL()
        {

        }

        #endregion Constructor

        #region Métodos Públicos

        public bool EjecutarSQL(string vStrQuery)
        {
            SqlConnection vSqlConnection = new SqlConnection();
            bool vBolEjecucionCorrecta = true;

            try
            {
                vSqlConnection = InicializarConexion();
                EjecutarSQL(vSqlConnection, vStrQuery);
            }
            catch
            {
                if (vSqlConnection.State != ConnectionState.Closed)
                    vSqlConnection.Close();

                vBolEjecucionCorrecta = false;
            }
            finally
            {
                if (vSqlConnection.State != ConnectionState.Closed)
                    vSqlConnection.Close();
            }

            return (vBolEjecucionCorrecta);
        }

        public DbDataReader CrearDataReader(string vStrQuery)
        {
            SqlConnection SqlConnection = new SqlConnection();
            DbDataReader dbDataReader = null;

            try
            {
                SqlConnection = InicializarConexion();
                dbDataReader = CrearDataReader(SqlConnection, vStrQuery);
            }
            catch
            {
                if (SqlConnection.State != ConnectionState.Closed)
                    SqlConnection.Close();
            }

            return (dbDataReader);
        }

        public DataTable CrearDataTable(string vStrQuery)
        {
            SqlConnection vSqlConnection = new SqlConnection();
            DataTable vDataTable = new DataTable();

            try
            {
                vSqlConnection = InicializarConexion();
                vDataTable = CrearDataTable(vSqlConnection, vStrQuery);
            }
            catch
            {
                if (vSqlConnection.State != ConnectionState.Closed)
                    vSqlConnection.Close();
            }
            finally
            {
                if (vSqlConnection.State != ConnectionState.Closed)
                    vSqlConnection.Close();
            }

            return (vDataTable);
        }

        #endregion Métodos Públicos

        #region Métodos Privados

        private SqlConnection InicializarConexion()
        {
            SqlConnection vSqlConnection = new SqlConnection();
            string vStrCadenaConexion = "server=DESKTOP-CLI2T24\\SQLEXPRESS01; database=Examen; integrated security = true";
            //"Persist Security Info=False;Integrated Security=true;  
            //Initial Catalog = AdventureWorks; Server = MSSQL1"  
            //"Persist Security Info=False;Integrated Security=SSPI;  
            //database = AdventureWorks; server = (local)"  
            //"Persist Security Info=False;Trusted_Connection=True;  
            //database = AdventureWorks; server = (local)" 
            //"Persist Security Info=False;User ID=*****;Password=*****;Initial Catalog=AdventureWorks;Server=MySqlServer"
            //"TrustServerCertificate=true;"

            try
            {
                vSqlConnection.ConnectionString = vStrCadenaConexion;
                vSqlConnection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en conexión: " + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return (vSqlConnection);
        }

        private DbCommand CrearDBCommand(SqlConnection vSqlConnection, string vStrQuery)
        {
            DbCommand dbCommand = vSqlConnection.CreateCommand();
            dbCommand.CommandText = vStrQuery;
            dbCommand.CommandTimeout = 36000;

            return (dbCommand);
        }

        private SqlDataAdapter CrearSqlDataAdapter(SqlConnection vSqlConnection, string vStrQuery)
        {
            SqlDataAdapter SqlDataAdapter = new SqlDataAdapter();

            SqlDataAdapter.SelectCommand = new SqlCommand(vStrQuery, vSqlConnection);

            return (SqlDataAdapter);
        }

        private void EjecutarSQL(SqlConnection vSqlConnection, string vStrQuery)
        {
            DbCommand dbCommand = CrearDBCommand(vSqlConnection, vStrQuery);
            dbCommand.ExecuteNonQuery();
        }

        private DbDataReader CrearDataReader(SqlConnection SqlConnection, string vStrQuery)
        {
            DbCommand dbCommand = CrearDBCommand(SqlConnection, vStrQuery);
            return (dbCommand.ExecuteReader());
        }

        private DataTable CrearDataTable(SqlConnection vSqlConnection, string vStrQuery)
        {
            SqlDataAdapter SqlDataAdapter = CrearSqlDataAdapter(vSqlConnection, vStrQuery);

            DataTable dataTable = new DataTable();
            SqlDataAdapter.Fill(dataTable);

            return (dataTable);
        }

        #endregion Métodos Privados
    }
}
