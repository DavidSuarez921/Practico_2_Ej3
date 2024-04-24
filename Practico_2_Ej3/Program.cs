using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_2_Ej3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (var indice = 0; indice < valores.Count - 1; indice++) // +1
            {
                if (valores[indice] > valores[indice + 1])             // +1  (if anidado) +1
                {
                    var valorTemporal = valores[indice];
                    valores[indice] = valores[indice + 1];
                    valores[indice + 1] = valorTemporal;                                            // 4 PUNTOS DE COMPLEJIDAD COGNITIVA
                    indice--;
                }
            }

            foreach (var valorOrdenado in valores)                     // +1
            {
                Console.WriteLine(valorOrdenado);
            }
            //---------------------------------------------------------------------------------------------------------
            Console.WriteLine(" ");

            //Con linQ:
            var valoresOrdenados = valores.OrderBy(valor => valor);

            foreach (var val in valoresOrdenados)
            { Console.WriteLine(val); }
        }
    }
}
