using pilasUmg.pilas;
using System;
using System.Collections.Generic;
using System.Text;

namespace pilasUmg.expresiones
{
    class Evaluando
    {
        public double evaluar(String infija)
        {
            String posfija = convertir(infija);
            return evaluarPosfija(posfija);
        }

        private double evaluarPosfija(string posfija)
        {
            PilaLista pila = new PilaLista();
            for (int i = 0; i < posfija.Length; i++)
            {
                char caracter = posfija[i];
                if (!operador(caracter))
                {
                    double num = double.Parse(caracter.ToString());
                    pila.insertar(num);
                }
                else
                {
                    double desapilar1 = (double)pila.quitar();
                    double desapilar2 = (double)pila.quitar();
                    double desapilar3 = operar(caracter,desapilar1,desapilar2);
                    pila.insertar(desapilar3);
                }
            }
            return (double)pila.cimaPila();
        }

        private double operar(char caracter, double desapilar1, double desapilar2)
        {
            if (caracter == '*') return desapilar1 * desapilar2;
            if (caracter == '/') return desapilar1 / desapilar2;
            if (caracter == '+') return desapilar1 + desapilar2;
            if (caracter == '^') return Math.Pow(desapilar1, desapilar2);
            return 0;
        }

        private string convertir(string infija)
        {
            String posfija = "";
            PilaLista pila = new PilaLista();

            for(int i = 0; i < infija.Length; i++)
            {

                //obtengo el caracter
                char caracter = infija[i];
                if (operador(caracter))
                {
                    if (pila.pilaVacia())
                    {
                        pila.insertar(caracter);
                    }
                    else
                    {
                        //evuluamos la prioridad
                        if(prieoridadExpresion(caracter) > prieoridadPila((char)pila.cimaPila()))
                        {
                            pila.insertar(caracter);
                        }
                        else
                        {
                            //desapilar
                            posfija += pila.quitar();
                            //apilamos el nuevo operador
                            pila.insertar(caracter);
                        }
                    }
                }
                else
                {
                    posfija += caracter;
                }
            }
            //sacamos todo lo de la pila
            while (!pila.pilaVacia())
            {
                //desapilamos y guardamos todos los datos de la pila en la posfija
                posfija += pila.quitar();
            }
            return posfija;
        }

        private bool operador(char caracter)
        {
           
           if(caracter == '+' || caracter == '-' || caracter =='/' || caracter == '*' ||
                caracter == '^' || caracter == '(' || caracter == ')')
            {
                return true;
            }
            return false;
        }
        private int prieoridadExpresion(char caracter)
        {
            if (caracter == '^') return 4;
            if (caracter == '/' || caracter == '*') return 2;
            if (caracter == '+' || caracter == '-') return 1;
            if (caracter == '(' || caracter == ')') return 5;
            return 0;
        }
        private int prieoridadPila(char caracter)
        {
            if (caracter == '^') return 3;
            if (caracter == '/' || caracter == '*') return 2;
            if (caracter == '+' || caracter == '-') return 1;
            if (caracter == '(' || caracter == ')') return 0;
            return 0;
        }
    }
}
