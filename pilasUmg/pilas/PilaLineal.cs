
using pilasUmg.listasimple;
using System;
using System.Collections.Generic;
using System.Text;

namespace pilasUmg.pilas
{
    class PilaLineal
    {
        private static int LENGTH = 49;
        private int cima;
        private Object[] listaPila;
    

        public PilaLineal()
        {
            cima = -1;//condicion para la pila
            listaPila = new Object[LENGTH];
  
        }
        public bool pilaLlena() => cima == LENGTH - 1;

        //operaciones que modifican la pila

        public void insertar(Object elemento)
        {
            if (pilaLlena())
            {
                throw new Exception("Desbordamiento de la pila StackOverflow");
            }
            cima++;
            listaPila[cima] = elemento;
        }




        //extraer elemento de la pila
        public bool pilaVacia() => cima == -1;

        //Retorna un tipo char
        public object quitarChar()
        {
            char aux;
            if (pilaVacia())
            {
                throw new Exception("Pila vacia");
            }
            aux = (char)listaPila[cima];
            cima--;
            return aux;
        }

        public Object quitar()
        {
            int aux;
            if (pilaVacia())
            {
                throw new Exception("La pila esta vacia, no se puede sacar");
            }
            //cuardar elemento
            aux = (int)listaPila[cima];
            //decrementar el valor de cima y retornar elemento
            cima--;
            return aux;
        }
        public void LimpiarPila()
        {
            cima = -1;
        }
        //operaciones de acceso a la pila
        public Object cimaPila()
        {
            if (pilaVacia())
            {
                throw new Exception("Pila vacia");
            }
            return listaPila[cima];
        }
    }
}
