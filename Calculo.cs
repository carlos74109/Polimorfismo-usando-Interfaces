using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientarObjetoC.Interface
{
    class Calculo: IPadrao
    {
        public void somar(int n1, int n2)
        {
            Console.WriteLine(n1 + n2);
        }

        public void subtrair(int n1, int n2)
        {
            if (n1 - n2 < 0)
            {
                Console.WriteLine("Resultado é igual a " + 0);
            }else
            {
                Console.WriteLine(n1 - n2);
            }
        }
     

    }
}
