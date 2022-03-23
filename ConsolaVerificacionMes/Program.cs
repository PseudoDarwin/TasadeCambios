using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace ConsolaVerificacionMes
{
    public class Program
    {
        static void Main(string[] args)
        {
         
        }

        //Esta aplicación verifica la existencia de datos correspondientes al siguiente mes ingresado
        public  bool VerificarMes(int mes, int año)
        {
            bool resultado = false;
            //Instancia del servicio SOAP
            bcn_ref.Tipo_Cambio_BCN bcn = new bcn_ref.Tipo_Cambio_BCN();

            //Busqueda por mes especifico
            var resultadoMes = bcn.RecuperaTC_Mes(año, mes).OuterXml;

            //OuterXml obtiene los resultados de la busqueda en formato XML guardando cada uno en una rama individual

            //Recorriendo el XML

            //xdoc crea un nuevo documento a parit de los resultados del anterior xml
            XDocument xdoc = XDocument.Parse(resultadoMes);
            IEnumerable<XElement> dvalor = xdoc.XPathSelectElements(".//Valor").ToArray();
            int cantidadverificada = dvalor.Count();
            if (cantidadverificada > 0)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            return resultado;
        }
    }
}
