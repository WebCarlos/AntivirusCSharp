using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntivirusForm
{
    public class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dataReader;
        SqlDataAdapter adaptador;
        List<Virus> _listaVirus;
        
        /// <summary>
        /// Open connection with bd
        /// </summary>
        public Conexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\VirusDatabase.mdf;Integrated Security=True");
                
                cn.Open();
                //MessageBox.Show("Conectado");

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Imposible conectar con la base de datos: " + ex.ToString());
            }
        }

        /// <summary>
        /// Closes the connection to the bd
        /// </summary>
        public void Cerrar(){
            try
            {
                cn.Close();
            }
            catch(SqlException ex)
            {

            }
        }

        /// <summary>
        /// Get virus hash from bd
        /// </summary>
        /// <returns></returns>
        public List<Virus> RecuperarDatos()
        {
            _listaVirus= new List<Virus>();
            cmd = new SqlCommand();
            adaptador = new SqlDataAdapter();
            
            adaptador.SelectCommand = cmd;
            cmd.Connection = cn;
            cmd.CommandText = "SELECT * FROM Virus;";
            dataReader = cmd.ExecuteReader();
            
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    _listaVirus.Add(new Virus { Nombre = (String)dataReader["nombreVirus"], Hash = (String)dataReader["hash"], Actualizado = (DateTime)dataReader["date"] });
                }
            }
            return _listaVirus;                
        }

    }
}
