using System;
using System.Globalization;

namespace EscalaTemperatura;

public class Program
{

    static void Main(string[] args)
    {
        CultureInfo CI = CultureInfo.InvariantCulture;


        double C, F;
        char escala;

      
        Console.WriteLine("Você vai digitar a temperatura em qual escala ?");
        Console.WriteLine("Lembrando que C para Celsius, e F para Fahrenheit");
        Console.Write("Escala C/F = ");
        escala = char.Parse(Console.ReadLine());
        
       
        if(escala == 'F' || escala == 'f') 
        {
            Console.Write("Digite por favor a temperatura em Fahrenheit = ");
            F = double.Parse(Console.ReadLine());
            C = (F - 32) / 1.8;
            Console.WriteLine("Temperatura equivalente em Celsius = " + C.ToString("F2", CI));
            
            if (F < 20)
            {
                Console.WriteLine("Dia esta frio, leve uma blulsa");
            }
            else if (F > 20 && F < 23)
            {
                Console.WriteLine("Dia agradavel");
            }
            else
            {
                Console.WriteLine("Dia quente, muito quente, beba água");
            }
        }
        else if(escala == 'C' || escala == 'c')
        {
            Console.Write("Dgite por favor a temperatura em Celsius = ");
            C = double.Parse(Console.ReadLine());
            F = (9 * C + 160) / 5;
            Console.WriteLine("Temperatura equivalente em Fahrenheit = " + F.ToString("F2", CI));
            
            if (F < 68)
            {
                Console.WriteLine("Dia esta frio, leve uma blulsa");
            }
            else if (F > 68 && F < 73.4)
            {
                Console.WriteLine("Dia agradavel");
            }
            else
            {
                Console.WriteLine("Dia quente, muito quente, beba água");
            }


        }

        
    }
}