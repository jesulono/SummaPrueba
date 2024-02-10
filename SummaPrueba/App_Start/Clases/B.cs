using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SummaPrueba.App_Start.Clases
{
    public class B : Agente
    {
        public override double getMedia(List<double> data)
        {
            var count = data.Count();

            double sumaInversos = 0;
            foreach (double num in data)
            {
                sumaInversos += 1.0 / num;
            }

            // Calcular la media armónica
            double mediaArmonica = count / sumaInversos;


            return mediaArmonica;
        }

        public override string getStaircase(int num)
        {
            var cadena = "";
            for (int n = 0; n < num; n++)
            {
                for (int m = 0; m < num; m++)
                {
                    //concatena los "#" en las posiciones designadas
                    cadena += (m >= n ? "#" : " ");
                }
                cadena += "\n";
            }
            return cadena;
        }
    }
}