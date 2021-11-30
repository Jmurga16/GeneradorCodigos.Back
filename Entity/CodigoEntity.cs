using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CodigoEntity
    {
        public string sNombre { get; set; }
        public string sEmail { get; set; }
        public string sCodigo { get; set; }
        public int nEstado { get; set; }

    }

    public class RegistroEntity
    {
        public int nIdRegistro { get; set; }
        public string sNombre { get; set; }
        public string sEmail { get; set; }
        public string sCodigo { get; set; }
        public int nEstado { get; set; }
        public string sEstado { get; set; }
    }
    public class GeneralEntity
    {
        public string sOpcion { get; set; }
        public string pParametro { get; set; }

    }

}
