
using pilasUmg.expresiones;
using pilasUmg.listasimple;
using pilasUmg.pilas;
using pilasUmg.polindromo;
using System;
using System.Collections.Generic;
using System.Linq;

namespace pilasUmg
{
    class Program
    {
        static void ejemploPilaLineal()
        {
            PilaLineal pila;
            int x;
            int clave = -1;

            Console.WriteLine("Ingrese numeros, y para terminar -1");
            try
            {
                pila = new PilaLineal();
                do
                {
                    x = Convert.ToInt32(Console.ReadLine());
                    if(x != -1)
                    {
                        pila.insertar(x);
                    }
                } while (x != clave);
                

            }
            catch (Exception error)
            {
                Console.WriteLine("Error = " + error.Message);
            }
            
        }

        static void polindromo()
        {
            PilaLineal pilaChar;
            bool esPalindromo;
            String pal;

            try
            {
                pilaChar = new PilaLineal();
                Console.WriteLine("Teclee una palabra");
                pal = Console.ReadLine();
                //creamos la pila con los char
                foreach (var letra in pal)
                {
                    Char c;
                    c = letra;
                    pilaChar.insertar(c);
                }

                //comprueba si es palindromo
                esPalindromo = true;
                for(int i = 0; esPalindromo && !pilaChar.pilaVacia();)
                {
                    Char c;
                    c = (Char)pilaChar.quitarChar();
                    esPalindromo = pal[i++] == c; // evalua si la sigueinte letra es igual
                }
                pilaChar.LimpiarPila();
                if (esPalindromo)
                {
                    Console.WriteLine($"La palabra es palindromo");
                }
                else
                {
                    Console.WriteLine($"La palabra no es un palindromo");
                }

            }catch(Exception error)
            {
                Console.WriteLine($"ups error {error.Message}");
            }
        }
        static void Main(string[] args)
        {
            Polindromo polindromos = new Polindromo();
            polindromos.polindromoArray();
            polindromos.polindromoLista();
            polindromos.polindromoListaEnlazada();

            Evaluando evualador = new Evaluando();
            Console.Write("Digite un expresion matemática ");
            String expresion = Console.ReadLine();

            Console.WriteLine(evualador.evaluar(expresion));
           
           
        }
    }
}
