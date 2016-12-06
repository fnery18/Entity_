using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exemplo02.Persistencia.Test
{
    class Calculadora
    {
        public int Fatorial(int numero)
        {
            if (numero == 0)
            {
                return 1;
            }

            int results = 1;
            for (int i = 1; i < numero; i++)
            {
                results = results * (i + 1);
            }
            return results;
        }
    }
}
