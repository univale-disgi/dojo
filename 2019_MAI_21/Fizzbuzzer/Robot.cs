using System;

namespace Fizzbuzzer
{
    /*
    
        Regras Fizzbuzz

        1. Se a posicao for multiplo de 3 fale: fizz
        2. Se a posicao for multiplo de 5 fale: buzz
        3. Se a posicao for multiplo de 3 e de 5 fale: fizzbuzz
        4. Para qualquer outra posicao fale o proprio número.

    
     */
    public class Robot
    {
        public string Fizzbuzz(int posicao)
        {
            if(MultiploDe3(posicao))
                return "Fizz";
            else
                return posicao.ToString();
        }

        public bool MultiploDe3(int numero)
        {
            var resultado = (numero - numero / 3 * 3 == 0);
            return resultado;
        }
    }
}