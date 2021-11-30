using Business;
using Entity;
using Microsoft.AspNetCore.Mvc;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PagoEfectivo_Back.Controllers
{
    [Route("CodigoService")]
    [ApiController]
    public class CodigoController : Controller
    {
        private readonly CodigoBusiness objCod = new CodigoBusiness();
        private readonly Logger logger = LogManager.GetCurrentClassLogger();
        
        #region CRUD Codigo

        [HttpPost]
        public IActionResult CrudCodigo(GeneralEntity genEnt) 
        {

            if (genEnt.sOpcion == "01"  )
            {
                try
                {
                    var vRes = objCod.BusinessCodigo(genEnt);

                    return Ok(vRes);
                }
                catch (Exception e)
                {

                    logger.Error(e);
                    throw;

                }
            }

            else if (genEnt.sOpcion == "02" || genEnt.sOpcion == "03" )
            {
                try
                {
                    string[] listaRes;

                    string sResultado = Convert.ToString(objCod.BusinessCodigo(genEnt));
                    listaRes = sResultado.Split('|');

                    return Ok(new { cod = listaRes[0], mensaje = listaRes[1] });
                }
                catch (Exception e)
                {

                    logger.Error(e);
                    throw;

                }
            }

            else
            {
                return null;
            }

        }

        #endregion
    }
}
