using SummaPrueba.App_Start.Interface;
using SummaPrueba.App_Start.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SummaPrueba
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [System.Web.Services.WebMethod]
        public static double MediaAgenteA(string mediaText)
        {
            IAgente instancia = new A();
            List<double> lista = mediaText.Split(',')
                                      .Select(valor => double.Parse(valor))
                                      .ToList();
            return instancia.getMedia(lista);
        }

        [System.Web.Services.WebMethod]
        public static double MediaAgenteB(string mediaText)
        {
            IAgente instancia = new B();
            List<double> lista = mediaText.Split(',')
                                      .Select(valor => double.Parse(valor))
                                      .ToList();
            return instancia.getMedia(lista);
        }

        [System.Web.Services.WebMethod]
        public static double MediaAgenteC(string mediaText)
        {
            IAgente instancia = new C();
            List<double> lista = mediaText.Split(',')
                                      .Select(valor => double.Parse(valor))
                                      .ToList();
            return instancia.getMedia(lista);
        }

        [System.Web.Services.WebMethod]
        public static string EscaleraAgenteA(int numero)
        {
            IAgente agente = new A();
            return agente.getStaircase(numero);
        }

        [System.Web.Services.WebMethod]
        public static string EscaleraAgenteB(int numero)
        {
            IAgente agente = new B();
            return agente.getStaircase(numero);
        }

        [System.Web.Services.WebMethod]
        public static string EscaleraAgenteC(int numero)
        {
            IAgente agente = new C();
            return agente.getStaircase(numero);
        }
    }
    
}