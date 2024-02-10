using SummaPrueba.App_Start.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SummaPrueba.App_Start.Clases
{
    public class C : Agente
    {
        public override double getMedia(List<double> data)
        {
            var count = data.Count();
            List<double> orderData = data.OrderBy(x => x).ToList();
            var median = (count % 2 == 0 ? (orderData[count / 2] + orderData[(count / 2) - 1]) / 2 : orderData[count / 2]);

            return median;
        }

        public override string getStaircase(int num)
        {
            var cadena = "";
            for (int n = 0; n < num * 2 - 1; n++)
            {
                for (int m = 0; m < num * 2 + (num - 2); m++)
                {
                    //concatena la cadena para hacer la parte superior del grafico
                    if (n < num)
                        cadena += (n + m >= num - 1 && n + m <= num + (num - 2 + (n * 2)) ? "#" : " ");
                    //concatena la cadena para hacer la parte inferior del grafico
                    else
                        cadena += (n + m >= num - ((num * 2) - 1 - (n * 2)) && m - n <= n + (num - 4) + ((num - n) * 3) ? "#" : " ");
                }
                cadena += "\n";
            }
            return cadena;
        }
    }
}