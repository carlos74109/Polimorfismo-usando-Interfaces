using OrientarObjetoC.Classe;
using OrientarObjetoC.Interface;
using OrientarObjetoC.Polimorfismo;
using OrientarObjetoC.Estatico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientarObjetoC
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Calculo cal = new Calculo();
            cal.somar(4, 5);
            cal.subtrair(5, 7);



        }
       
    }
}
