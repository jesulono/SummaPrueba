using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SummaPrueba.App_Start.Clases
{
    public class A : Agente
    {

        public override double getMedia(List<double> data)
        {
            //calcula Promedio
            var average = data.Average();
            return average;
        }

        public override string getStaircase(int num)
        {
            var cadena = "";
            for (int n = 0; n < num; n++)
            {
                for (int m = 0; m < num; m++)
                {
                    //concatena los "#" en las posiciones designadas
                    cadena += (n + m >= num - 1 ? "#" : " ");
                }
                cadena += "\n";
            }
            return cadena;
        }
    }
}