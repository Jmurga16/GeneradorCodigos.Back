using Data;
using Entity;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class CodigoBusiness
    {
        private readonly CodigoData codigoData = new CodigoData();
        private readonly Logger logger = LogManager.GetCurrentClassLogger();


        public object BusinessCodigo(GeneralEntity genEnt)
        {
            try
            {

                return codigoData.DataCodigo(genEnt);

            }
            catch (Exception e)
            {
                logger.Error(e);
                throw;

            }
        }
    }
}
