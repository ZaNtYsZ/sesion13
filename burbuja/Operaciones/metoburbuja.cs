using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burbuja.Operaciones
{
    internal class burbuja
    {
        public void ordenarBurbuja(int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                for (int j = i; j < arreglo.Length - 1; j++)
                {
                    if (arreglo[j] > arreglo[i])
                    {
                        int tempo = arreglo[j];
                        arreglo[j] = arreglo[i];
                        arreglo[i] = tempo;
                    }
                }
            }
        }
    }
}
