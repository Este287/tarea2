using System;

namespace repaso
{
    class Program
    {
        static void Main(string[] args)
        {
        
            
            Console.WriteLine("\n1.-Suma");
            Console.WriteLine("\n2.-Resta");
            Console.WriteLine("\n3.-Multiplicacion");
            Console.WriteLine("\n4.-Division");
            Console.WriteLine("\n5.-Modulo");
            Console.WriteLine("\n-Salir");
            Console.WriteLine("\n- Escoja una Opcion");
            string input = Console.ReadLine();
            switch (input)
            {
            case "1": 
                        
                Console.WriteLine("1.Suma");
                Console.WriteLine("Ingrese el Primer numero");
                float number1;
                number1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                float number2;
                number2 = float.Parse(Console.ReadLine());
                float Suma = number1 + number2;
                Console.WriteLine("El resultado es " + Suma);
                Console.ReadKey();
                break;
                 


            case "2": 
                        
                Console.WriteLine("1.Resta");
                Console.WriteLine("Ingrese el Primer numero");
                float number3;
                number3 = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                float number4;
                number4 = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                float Resta = number3 - number4;
                Console.WriteLine("El resultado es " + Resta);
                Console.ReadKey();
                break; 

            case "3": 
                        
                Console.WriteLine("1.Multiplicacion");
                Console.WriteLine("Ingrese el Primer numero");
                float number5;
                number5 = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                float number6;
                number6 = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                float Multiplicacion = number5 + number6;
                Console.WriteLine("El resultado es " + Multiplicacion);
                Console.ReadKey();
                break; 

            case "4": 
                        
                Console.WriteLine("5.Division");
                Console.WriteLine("Ingrese el Primer numero");
                float number7;
                number7 = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el primer numero");
                float number8;
                number8 = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                if(number7==number8)
                {
                    Console.WriteLine("Error, no se puede dividir entre 0");
                    Console.WriteLine("");
                    
                    }
                    else
                    {
                       float respuesta = number7/number8;

                        Console.WriteLine("El resultado de "+number7+"divido"+number8+" es: +respuesta");
                    }

                float Division = number7 + number8;
                Console.WriteLine("El resultado es " + Division);
                Console.ReadKey();
                break; 

            case "5": 
                        
                Console.WriteLine("5.Modulo");
                Console.WriteLine("Ingrese el Primer numero");
                float number9;
                number9 = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                float number10;
                number10 = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                float Modulo = number9 + number10;
                Console.WriteLine("El resultado es " + Modulo);
                Console.ReadKey();
                break; 

            

               
            }
                 
        }
    }
}
