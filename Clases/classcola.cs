using System;
using System.Collections.Generic;
using Interfaces;

namespace Classcola
{//Actividad 1, ejercicio 4
    public class Cola: Coleccionable
    {
        private List<Comparable> elementos;

        public Cola()
        {
            this.elementos= new List<Comparable>();
        }

        public void encolar(Comparable c)
        {
            this.elementos.Add(c);
        }
        
        public void desencolar()
        {
            Comparable e= this.elementos[0];
            this.elementos.Remove(e);
        }

        public List<Comparable> Getelementos()
        {
            return elementos;
        }


        //Metodos de la interface
        public int cuantos()
        {
            return this.elementos.Count;
        }
        public Comparable minimo()
        {
            Comparable masChico = this.elementos[0];
            foreach (Comparable e in elementos)
            {
                if (e.sosMenor(masChico))
                {
                    masChico = e;
                }
            }return masChico;
        }
        public Comparable maximo()
        {
            Comparable masGrande = this.elementos[0];
            foreach (Comparable e in elementos)
            {
                if (e.SosMayor(masGrande))
                {
                    masGrande = e;
                }
            }return masGrande;

        }
        public void agregar(Comparable c)
        {
            this.encolar(c);
        }
        public bool contiene (Comparable c)
        {
            foreach(Comparable e in this.elementos){
                if(e.sosIgual(c)){
                    return true;
                }
            }
            return false;           
        }


    }

}