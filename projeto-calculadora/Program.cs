using System;

namespace projeto_calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int num1, num2, resultado = 0;
            string operador;
           
            Console.WriteLine(">>>>>>>>CALCULADORA!<<<<<<<<<\n\n\n");

            Console.WriteLine("DIGITE O PRIMEIRO VALOR: ");
            num1 = int.Parse(Console.ReadLine());


            Console.WriteLine("DIGITE OPERADOR>>> ");
            operador = Console.ReadLine();


            Console.WriteLine("DIGITE O SEGUNDO VALOR: ");
            num2 = int.Parse(Console.ReadLine());


            switch(operador)
            {
                case "+":
             resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
            }
            Console.WriteLine("{0} {1} {2} = {3}", num1, operador, num2, resultado);

        }
    }
}
