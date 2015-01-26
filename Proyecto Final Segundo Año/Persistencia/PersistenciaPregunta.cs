using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using EntidadesCompartidas;

namespace Persistencia
{
    internal class PersistenciaPregunta : IPersistenciaPregunta
    {
        //Singleton
        private static PersistenciaPregunta _instancia = null; 

        private PersistenciaPregunta() {} 

        public static PersistenciaPregunta GetInstancia()  
        {
            if (_instancia == null) 
                _instancia = new PersistenciaPregunta(); 
            return _instancia; 
        }


    }
}
