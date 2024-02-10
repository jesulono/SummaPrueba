using SummaPrueba.App_Start.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SummaPrueba.App_Start.Clases
{
    public abstract class Agente : IAgente
    {
        public abstract double getMedia(List<double> data);

        public abstract String getStaircase(int num);
    }
}