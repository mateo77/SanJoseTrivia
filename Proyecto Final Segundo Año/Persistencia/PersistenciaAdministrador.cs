using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using EntidadesCompartidas;

namespace Persistencia
{
    internal class PersistenciaAdministrador : IPersistenciaAdministrador
    {
        //Singleton
        private static PersistenciaAdministrador _instancia = null; 

        private PersistenciaAdministrador() {} 

        public static PersistenciaAdministrador GetInstancia()  
        {
            if (_instancia == null) 
                _instancia = new PersistenciaAdministrador(); 
            return _instancia; 
        }


    }
}
