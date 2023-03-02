//Revisado por Rene Alexander Fecha 26/02/2023
//Revisado por Ester Lopez Primer Parcial 02/03/2023
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Libreria--------
using System.Data.Odbc;

namespace NavegadorModelo
{
    class Conexion
    {
        //Clase de conexion --------------
        public OdbcConnection conexion()
        {
            //creacion de la conexion via ODBC
            //Se cambiaron las variables para que fueran más claras y precisas Ester Lopez
            OdbcConnection conexionODBC = new OdbcConnection("Dsn=colchoneria");
            try
            {
                conexionODBC.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("Sin conexión");
            }
            return conexionODBC;
        }

        //metodo para cerrar la conexion
        public void cerrar_conexion(OdbcConnection conexionODBC)
        {
            try
            {
                conexionODBC.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("conexion cerrada");
            }
        }
    }
}
