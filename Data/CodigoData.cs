using Entity;
using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{

    public class CodigoData
    {
        private readonly Logger logger = LogManager.GetCurrentClassLogger();
        #region Conexion
        private readonly Conexion oCon;

        public CodigoData()
        {
            oCon = new Conexion(1);
        }
        #endregion

        private readonly List<RegistroEntity> listaRegistro = new List<RegistroEntity>();


        #region Codigos
        public object DataCodigo(GeneralEntity genEnt)
        {

            string msj = string.Empty;
            try
            {

                switch (genEnt.sOpcion)
                {

                    #region 01. Lista de Registros
                    case "01":

                        using (IDataReader dr = oCon.ejecutarDataReader("USP_MNT_Codigos", genEnt.sOpcion, genEnt.pParametro))
                        {

                            while (dr.Read())
                            {
                                RegistroEntity regEnt = new RegistroEntity();


                                regEnt.nIdRegistro = Int32.Parse(Convert.ToString(dr["nIdRegistro"]));
                                regEnt.sNombre = Convert.ToString(dr["sNombre"]);
                                regEnt.sEmail = Convert.ToString(dr["sEmail"]);
                                regEnt.sCodigo = Convert.ToString(dr["sCodigo"]);
                                regEnt.nEstado = Int32.Parse(Convert.ToString(dr["nEstado"]));
                                regEnt.sEstado = Convert.ToString(dr["sEstado"]);


                                listaRegistro.Add(regEnt);

                            }

                            return listaRegistro;

                        }
                    #endregion
                        
                    #region 02. Generar | 03. Canjear 
                    case "02":
                    case "03":                     

                        string sResultado = Convert.ToString(oCon.EjecutarEscalar("USP_MNT_Codigos", genEnt.sOpcion, genEnt.pParametro));
                        msj = sResultado;

                        return msj;
                    #endregion

                    default:
                        return null;
                }
            }
            catch (Exception exc4)
            {
                logger.Error(exc4);
                throw;
            }

        }
        #endregion



    }
}
