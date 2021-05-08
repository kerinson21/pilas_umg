using System;
using System.Collections.Generic;
using System.Text;

namespace pilasUmg.listasimple
{
    class MyListaSimple
    {
        //ancla o encabezado de la lista
        private NodoSimple cabeza;
        private NodoSimple primero;
        private NodoSimple auxAnterior;

        private int tamanio;


        public MyListaSimple()
        {
            //instanciamos el ancla
            cabeza = new NodoSimple();
            //indicamoes que es vacia la lista
            cabeza.setEnlace(null);
            tamanio = 0;
        }
        public void Transversa()
        {
            primero = cabeza;
            //recorremos hasta encontrar el final
            while (primero.getEnlace() != null)
            {
                primero = primero.getEnlace();
                string dato =(string) primero.getDato();
                Console.WriteLine(dato);
                //this.tamanio = this.tamanio + 1;
                
            }
        }
        public void Adicionar(Object dato)
        {

            primero = cabeza;
            //recorro hasta encontrar el final para agregar un nodo nuevo
            while (primero.getEnlace() != null)
            {
                primero = primero.getEnlace();
            }

            //creo el nuevo nodol
            NodoSimple tempo = new NodoSimple();

            //inserto el dato 
            tempo.setDato(dato);

            //se finaliza 
            tempo.setEnlace(null);

            //ligamos el ultimo nodo con el recien creado
            primero.setEnlace(tempo);
            tamanio++;
        }


        

        public NodoSimple obtenerNodo(int posicion)
        {
            primero = cabeza;

            int i = 1;
            int index = 0;
            while (primero.getEnlace() != null && i <= posicion)
            {
                primero = primero.getEnlace();
                if (i == posicion) index = i;
                i++;
            }
            if (index == posicion)
            {
                return primero;
            }
            else
            {
                return null;
            }
        }

        public NodoSimple obtenerAnterior(NodoSimple dato)
        {
            auxAnterior = cabeza;
            //NodoSimple anterio;

            int i = 1;
           
            while (auxAnterior.getEnlace() != null && auxAnterior.getEnlace().getDato() != dato.getDato())
            {
                auxAnterior = auxAnterior.getEnlace();
            }
            return auxAnterior;
        }

        public void removerElemento(int posicion)
        {
            NodoSimple encontrado = obtenerNodo(posicion);
            NodoSimple anterior = obtenerAnterior(encontrado);

            anterior.setEnlace(encontrado.getEnlace());
            encontrado.setEnlace(null);

        }
        public void Vaciar()
        {
            cabeza.setEnlace(null);
        }
        public bool Vacio()
        {
            if (cabeza.getEnlace() == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public int listaLength() => tamanio;

        /*public string[] convertirArreglo()
        {
            Transversa();
            string[] datos = new string[this.tamanio];

            primero = cabeza;
            int i = 0;
            //recorremos hasta encontrar el final
            while (primero.getEnlace() != null)
            {
                primero = primero.getEnlace();
                string dato = (string)primero.getDato();
                datos[i] = dato;
                //Console.WriteLine(dato);
                //this.tamanio = this.tamanio + 1;
                i++;
            }
            return datos;
        }*/
    }
}
