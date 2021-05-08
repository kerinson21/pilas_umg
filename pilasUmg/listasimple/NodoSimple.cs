using System;
using System.Collections.Generic;
using System.Text;

namespace pilasUmg.listasimple
{
    class NodoSimple
    {
        private Object dato;
        private NodoSimple enlace = null;
        public NodoSimple()
        {

        }
        public NodoSimple(string dato, NodoSimple enlace)
        {
            this.dato = dato;
            this.enlace = enlace;
        }
        public Object getDato() => this.dato;
        public void setDato(Object dato) => this.dato = dato;
        public NodoSimple getEnlace() => this.enlace;
        public void setEnlace(NodoSimple enlace) => this.enlace = enlace;
    }
}
