using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummaPrueba.App_Start.Interface
{
    internal interface IAgente
    {
        double getMedia(List<double> data);

        String getStaircase(int num);
    }
}
