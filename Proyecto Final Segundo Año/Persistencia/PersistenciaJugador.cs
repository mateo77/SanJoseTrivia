using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using EntidadesCompartidas;

namespace Persistencia
{
    internal class PersistenciaJugador : IPersistenciaJugador
    {
        //Singleton
        private static PersistenciaJugador _instancia = null; 

        private PersistenciaJugador() {} 

        public static PersistenciaJugador GetInstancia()  
        {
            if (_instancia == null) 
                _instancia = new PersistenciaJugador(); 
            return _instancia; 
        }


        //public void AltaJugador(Jugador unJugador)
        //{
        //    {
        //    SqlConnection _cnn = new SqlConnection(Conexion.MiConexion);
        //    SqlCommand _comando = new SqlCommand("", _cnn);
        //    _comando.CommandType = CommandType.StoredProcedure;

        //    SqlParameter oCedula = new SqlParameter("@", unJugador.Cedula);
        //    SqlParameter oContraseña = new SqlParameter("@", unJugador.Contraseña;
        //    SqlParameter oUsuarioLogueo = new SqlParameter("@", 
        //    SqlParameter oNombre = new SqlParameter("@", 
        //    SqlParameter oRetorno = new SqlParameter("@Retorno", SqlDbType.Int);
        //    oRetorno.Direction = ParameterDirection.ReturnValue;

        //    _comando.Parameters.Add();
        //    _comando.Parameters.Add();
        //    _comando.Parameters.Add();
        //    _comando.Parameters.Add();
        //    _comando.Parameters.Add(oRetorno);

        //    try
        //    {
        //        _cnn.Open();
        //        _comando.ExecuteNonQuery();
        //        int oAfectados = (int)_comando.Parameters["@Retorno"].Value;
        //        if (oAfectados == -1)
        //            throw new Exception("Error");
        //        else if (oAfectados == -2)
        //            throw new Exception("Error");
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        _cnn.Close();
        //    }
        //}
    }
}
